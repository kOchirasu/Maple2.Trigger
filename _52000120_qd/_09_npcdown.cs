namespace Maple2.Trigger._52000120_qd {
    public static class _09_npcdown {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001166}, arg2: 2);
                context.DestroyMonster(arg1: new[] {235});
                context.SetUserValue(key: "NpcDown", value: 0);
                context.SetUserValue(key: "BattleEnd", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NpcDown") == 1) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "NpcDown", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 27000)) {
                    return new StateNpcDown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDown : TriggerState {
            internal StateNpcDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {225});
                context.SetInteractObject(arg1: new[] {10001166}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleEnd") == 1) {
                    return new StateQuit(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001166}, arg2: 0)) {
                    return new StateNpcWakeUp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcWakeUp : TriggerState {
            internal StateNpcWakeUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001166}, arg2: 2);
                context.CreateMonster(arg1: new[] {235}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleEnd") == 1) {
                    return new StateQuit(context);
                }

                if (context.NpcDetected(arg1: 9900, arg2: new[] {225})) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001166}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 50000)) {
                    return new StateNpcDown02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDown02 : TriggerState {
            internal StateNpcDown02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {225});
                context.SetInteractObject(arg1: new[] {10001166}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleEnd") == 1) {
                    return new StateQuit(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001166}, arg2: 0)) {
                    return new StateNpcWakeUp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {225, 235});
                context.SetInteractObject(arg1: new[] {10001166}, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
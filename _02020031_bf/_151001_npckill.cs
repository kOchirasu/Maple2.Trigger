namespace Maple2.Trigger._02020031_bf {
    public static class _151001_npckill {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "NPCKill") == 1) {
                    return new StateNPCKillWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCKillWait : TriggerState {
            internal StateNPCKillWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    return new StateNPCKill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCKill : TriggerState {
            internal StateNPCKill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {15401, 15402, 15501, 15502});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateKillEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKillEnd : TriggerState {
            internal StateKillEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 151001, key: "NPCKill", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
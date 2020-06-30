using System;

namespace Maple2.Trigger._52000120_qd {
    public static class _09_npcdown {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001166}, arg2: 2);
                context.DestroyMonster(arg1: new int[] {235});
                context.SetUserValue(key: "NpcDown", value: 0);
                context.SetUserValue(key: "BattleEnd", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "NpcDown", value: 1)) {
                    context.State = new StateDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "NpcDown", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 27000)) {
                    context.State = new StateNpcDown(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcDown : TriggerState {
            internal StateNpcDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {225});
                context.SetInteractObject(arg1: new int[] {10001166}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleEnd", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001166}, arg2: 0)) {
                    context.State = new StateNpcWakeUp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcWakeUp : TriggerState {
            internal StateNpcWakeUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001166}, arg2: 2);
                context.CreateMonster(arg1: new int[] {235}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleEnd", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.NpcDetected(arg1: 9900, arg2: new int[] {225})) {
                    context.State = new StateDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001166}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 50000)) {
                    context.State = new StateNpcDown02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcDown02 : TriggerState {
            internal StateNpcDown02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {225});
                context.SetInteractObject(arg1: new int[] {10001166}, arg2: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "BattleEnd", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001166}, arg2: 0)) {
                    context.State = new StateNpcWakeUp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {225, 235});
                context.SetInteractObject(arg1: new int[] {10001166}, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
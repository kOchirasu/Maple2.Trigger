using System;

namespace Maple2.Trigger._02020031_bf {
    public static class _151001_npckill {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "NPCKill", value: 1)) {
                    context.State = new StateNPCKillWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCKillWait : TriggerState {
            internal StateNPCKillWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.State = new StateNPCKill(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCKill : TriggerState {
            internal StateNPCKill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {15401, 15402, 15501, 15502});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateKillEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKillEnd : TriggerState {
            internal StateKillEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 151001, key: "NPCKill", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
using System;

namespace Maple2.Trigger._02000315_bf {
    public static class _wounded_107 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "BridgeOpen", value: 0);
                context.SetInteractObject(arg1: new int[] {10001042}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001042}, arg2: 0)) {
                    context.State = new StateWakeUp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWakeUp : TriggerState {
            internal StateWakeUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001042}, arg2: 2);
                context.CreateMonster(arg1: new int[] {107}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "BridgeOpen", value: 3)) {
                    context.State = new StatePatrol03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol03 : TriggerState {
            internal StatePatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_1071");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
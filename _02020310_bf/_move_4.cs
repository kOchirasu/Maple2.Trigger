using System;
using System.Numerics;

namespace Maple2.Trigger._02020310_bf {
    public static class _move_4 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Archeon4", value: 1)) {
                    context.SetUserValue(triggerID: 900010, key: "Archeon4", value: 0);
                    context.State = new StateArcheon_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Ready : TriggerState {
            internal StateArcheon_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckAnyUserAdditionalEffect(triggerBoxID: 10001, additionalEffectID: 73000008,
                    level: true)) {
                    context.MoveUserToPos(pos: new Vector3(8700f, -4800f, 2750f), rot: new Vector3(0f, 0f, 0f));
                    context.State = new StateArcheon_On(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_On : TriggerState {
            internal StateArcheon_On(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
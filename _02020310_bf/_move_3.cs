using System.Numerics;

namespace Maple2.Trigger._02020310_bf {
    public static class _move_3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Archeon3") == 1) {
                    context.SetUserValue(triggerId: 900009, key: "Archeon3", value: 0);
                    return new StateArcheon_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Ready : TriggerState {
            internal StateArcheon_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 10001, additionalEffectId: 73000007, level: true)) {
                    context.MoveUserToPos(pos: new Vector3(8700f, -4800f, 2750f), rot: new Vector3(0f, 0f, 0f));
                    return new StateArcheon_On(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_On : TriggerState {
            internal StateArcheon_On(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
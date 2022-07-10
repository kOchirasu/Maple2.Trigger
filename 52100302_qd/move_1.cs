using System.Numerics;

namespace Maple2.Trigger._52100302_qd {
    public static class _move_1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Archeon1") == 1) {
                    context.SetUserValue(triggerId: 900007, key: "Archeon1", value: 0);
                    return new StateArcheon_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Ready : TriggerState {
            internal StateArcheon_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckAnyUserAdditionalEffect(boxId: 10001, additionalEffectId: 73000005, level: 1)) {
                    context.MoveUserToPos(position: new Vector3(8700f, -4800f, 2750f));
                    return new StateArcheon_On(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_On : TriggerState {
            internal StateArcheon_On(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

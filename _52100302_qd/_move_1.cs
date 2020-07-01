using System.Numerics;

namespace Maple2.Trigger._52100302_qd {
    public static class _move_1 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Archeon1") == 1) {
                    context.SetUserValue(triggerId: 900007, key: "Archeon1", value: 0);
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
                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 10001, additionalEffectId: 73000005,
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
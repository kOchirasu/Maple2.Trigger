namespace Maple2.Trigger._02000499_bf {
    public static class _event_a {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104}, arg2: false);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3008");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3009");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3010");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3011");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104})) {
                    return new StateCompleteEffect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCompleteEffect : TriggerState {
            internal StateCompleteEffect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
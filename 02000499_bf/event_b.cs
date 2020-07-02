namespace Maple2.Trigger._02000499_bf {
    public static class _event_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105, 106, 107, 108}, arg2: false);
                context.SetEffect(arg1: new[] {5005, 5006, 5007, 5008}, arg2: false);
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
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_3012");
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_3013");
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_3014");
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData_3015");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {105, 106, 107, 108})) {
                    return new StateCompleteEffect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCompleteEffect : TriggerState {
            internal StateCompleteEffect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5005, 5006, 5007, 5008}, arg2: true);
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
namespace Maple2.Trigger._02000317_bf {
    public static class _eagle_02 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State독수리비행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독수리비행 : TriggerState {
            internal State독수리비행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.MoveNpc(arg1: 98, arg2: "MS2PatrolData_98");
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // return new State종료2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
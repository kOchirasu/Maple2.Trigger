namespace Maple2.Trigger._02000079_bf {
    public static class _eagle {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State독수리비행 : TriggerState {
            internal State독수리비행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.MoveNpc(spawnId: 99, patrolName: "MS2PatrolData_99");
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1800000", seconds: 1800000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1800000")) {
                    // return new StateEnd2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

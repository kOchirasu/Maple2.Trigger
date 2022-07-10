namespace Maple2.Trigger._61000009_me {
    public static class _timer {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 100, textId: 40012);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReady(context);
                }

                if (context.GetUserValue(key: "timer") == 1) {
                    return new StateReady_Idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle : TriggerState {
            internal StateReady_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 100);
                context.SetTimer(timerId: "1200", seconds: 1200, clearAtZero: false, display: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1200")) {
                    return new StateEndGame(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndGame : TriggerState {
            internal StateEndGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, script: "$61000004_ME__TRIGGER_01__2$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUser(mapId: 0, portalId: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

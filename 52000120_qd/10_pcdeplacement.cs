namespace Maple2.Trigger._52000120_qd {
    public static class _10_pcdeplacement {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DefencePhase", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DefencePhase") == 1) {
                    return new StateDefencePhase01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefencePhase01 : TriggerState {
            internal StateDefencePhase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    return new StateMoveToTheWall(context);
                }

                if (context.GetUserValue(key: "DefencePhase") == 2) {
                    return new StateDefencePhase02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToTheWall : TriggerState {
            internal StateMoveToTheWall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000120, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefencePhase01(context);
                }

                if (context.GetUserValue(key: "DefencePhase") == 2) {
                    return new StateDefencePhase02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefencePhase02 : TriggerState {
            internal StateDefencePhase02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    return new StateOutsideOfTheWall(context);
                }

                if (context.GetUserValue(key: "DefencePhase") == 3) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOutsideOfTheWall : TriggerState {
            internal StateOutsideOfTheWall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000120, portalId: 40);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefencePhase02(context);
                }

                if (context.GetUserValue(key: "DefencePhase") == 3) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

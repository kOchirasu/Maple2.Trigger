namespace Maple2.Trigger._52000120_qd {
    public static class _10_pcdeplacement {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DefencePhase", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "DefencePhase") == 1) {
                    context.State = new StateDefencePhase01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDefencePhase01 : TriggerState {
            internal StateDefencePhase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    context.State = new StateMoveToTheWall(context);
                    return;
                }

                if (context.GetUserValue(key: "DefencePhase") == 2) {
                    context.State = new StateDefencePhase02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToTheWall : TriggerState {
            internal StateMoveToTheWall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000120, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefencePhase01(context);
                    return;
                }

                if (context.GetUserValue(key: "DefencePhase") == 2) {
                    context.State = new StateDefencePhase02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDefencePhase02 : TriggerState {
            internal StateDefencePhase02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    context.State = new StateOutsideOfTheWall(context);
                    return;
                }

                if (context.GetUserValue(key: "DefencePhase") == 3) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOutsideOfTheWall : TriggerState {
            internal StateOutsideOfTheWall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000120, arg2: 40);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefencePhase02(context);
                    return;
                }

                if (context.GetUserValue(key: "DefencePhase") == 3) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
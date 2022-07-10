namespace Maple2.Trigger._99999896 {
    public static class _02_coin {
        public class State동전Creation01 : TriggerState {
            internal State동전Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    context.SetTimer(timerId: "1", seconds: 2);
                    context.CreateItem(spawnIds: new []{4, 5, 6, 7, 8, 9, 10, 11, 12});
                    context.SetEventUI(arg1: 1, script: "$99999896__02_COIN__0$", duration: 2000);
                    return new State동전Creation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동전Creation02 : TriggerState {
            internal State동전Creation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    context.CreateItem(spawnIds: new []{13, 14, 15, 16, 17, 18, 19, 20, 21});
                    context.SetEventUI(arg1: 1, script: "$99999896__02_COIN__1$", duration: 2000);
                    return new State동전Creation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동전Creation03 : TriggerState {
            internal State동전Creation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    context.SetEventUI(arg1: 1, script: "$99999896__02_COIN__2$", duration: 2000);
                    context.CreateItem(spawnIds: new []{22, 23, 24, 25, 26, 27, 28, 29, 30});
                    context.SetEventUI(arg1: 3, script: "$99999896__02_COIN__3$", duration: 2000);
                    context.CreateItem(spawnIds: new []{31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48});
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

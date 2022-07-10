namespace Maple2.Trigger._52000014_qd {
    public static class _steam_5800 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State발사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발사01 : TriggerState {
            internal State발사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 1);
                context.CreateMonster(spawnIds: new []{580}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State발사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발사02 : TriggerState {
            internal State발사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.CreateMonster(spawnIds: new []{581}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 1);
                context.DestroyMonster(spawnIds: new []{580});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State발사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발사03 : TriggerState {
            internal State발사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 2);
                context.CreateMonster(spawnIds: new []{581}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{581});
            }

            public override TriggerState? Execute() {
                return new StateDelay01(context);
            }

            public override void OnExit() { }
        }
    }
}

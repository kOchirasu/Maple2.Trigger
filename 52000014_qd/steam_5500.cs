namespace Maple2.Trigger._52000014_qd {
    public static class _steam_5500 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State발사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발사01 : TriggerState {
            internal State발사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
                context.CreateMonster(spawnIds: new []{550}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{550});
            }

            public override TriggerState? Execute() {
                return new State발사01(context);
            }

            public override void OnExit() { }
        }
    }
}

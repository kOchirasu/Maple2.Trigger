namespace Maple2.Trigger._99999922 {
    public static class _event7 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2003});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999910})) {
                    return new State진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행1 : TriggerState {
            internal State진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "300", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2003})) {
                    return new State진행2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행2 : TriggerState {
            internal State진행2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{999910}, skillId: 49179111, level: 1, arg5: true);
                context.SetTimer(timerId: "300", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "300")) {
                    return new StateStart10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart10 : TriggerState {
            internal StateStart10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "400", seconds: 60);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

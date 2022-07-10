namespace Maple2.Trigger._52010015_qd {
    public static class _act01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002824}, questStates: new byte[]{2})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "100", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100")) {
                    return new State미카교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카교체01 : TriggerState {
            internal State미카교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.DestroyMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State미카이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카이동01 : TriggerState {
            internal State미카이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_2020");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 8000, spawnIds: new []{202})) {
                    return new State미카소멸01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카소멸01 : TriggerState {
            internal State미카소멸01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{202});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

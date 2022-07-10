namespace Maple2.Trigger._02000213_bf {
    public static class _regenmob28 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State소환몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환몹Spawn : TriggerState {
            internal State소환몹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000261}, arg2: 1)) {
                    context.CreateMonster(spawnIds: new []{1028}, arg2: false);
                    return new StateDeadCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadCheck : TriggerState {
            internal StateDeadCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000261}, arg2: 0)) {
                    return new State소멸(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000261}, arg2: 2)) {
                    return new State소멸(context);
                }

                if (context.MonsterDead(spawnIds: new []{1028})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State소환몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1028});
                context.SetTimer(timerId: "1", seconds: 1200);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }
    }
}

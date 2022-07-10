namespace Maple2.Trigger._52000014_qd {
    public static class _actor_8000 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8100}, visible: false);
                context.DestroyMonster(spawnIds: new []{800, 801});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State약화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State약화01 : TriggerState {
            internal State약화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{800}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new State교체01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State교체01 : TriggerState {
            internal State교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.DestroyMonster(spawnIds: new []{800});
                context.CreateMonster(spawnIds: new []{801}, arg2: false);
                context.MoveNpc(spawnId: 801, patrolName: "MS2PatrolData_801");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State일어남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일어남01 : TriggerState {
            internal State일어남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State포효01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포효01 : TriggerState {
            internal State포효01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 5);
                context.SetEffect(triggerIds: new []{8100}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd01 : TriggerState {
            internal StateEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8100}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

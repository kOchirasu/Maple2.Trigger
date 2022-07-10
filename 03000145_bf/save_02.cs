namespace Maple2.Trigger._03000145_bf {
    public static class _save_02 {
        public class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 1);
                context.SetMesh(triggerIds: new []{2001}, visible: false, arg5: 1f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000468}, state: 1);
                context.CreateMonster(spawnIds: new []{201, 202, 203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000468}, arg2: 0)) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetMesh(triggerIds: new []{2001}, visible: true, arg5: 1f);
                context.DestroyMonster(spawnIds: new []{201, 202, 203});
                context.CreateMonster(spawnIds: new []{211, 212, 213}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State도망갈Prepare1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망갈Prepare1 : TriggerState {
            internal State도망갈Prepare1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetConversation(type: 1, spawnId: 211, script: "$03000145_BF__SAVE_02__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State도망갈Prepare2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망갈Prepare2 : TriggerState {
            internal State도망갈Prepare2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetConversation(type: 1, spawnId: 212, script: "$03000145_BF__SAVE_02__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State도망갈Prepare3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망갈Prepare3 : TriggerState {
            internal State도망갈Prepare3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 1);
                context.SetConversation(type: 1, spawnId: 213, script: "$03000145_BF__SAVE_02__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State도망시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망시작 : TriggerState {
            internal State도망시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 211, patrolName: "MS2PatrolData_211");
                context.MoveNpc(spawnId: 212, patrolName: "MS2PatrolData_212");
                context.MoveNpc(spawnId: 213, patrolName: "MS2PatrolData_213");
            }

            public override TriggerState? Execute() {
                return new State도망중(context);
            }

            public override void OnExit() { }
        }

        private class State도망중 : TriggerState {
            internal State도망중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 4);
                context.SetConversation(type: 1, spawnId: 212, script: "$03000145_BF__SAVE_02__3$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 211, script: "$03000145_BF__SAVE_02__4$", arg4: 2, arg5: 1);
                context.SetConversation(type: 1, spawnId: 213, script: "$03000145_BF__SAVE_02__5$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new State도망끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망끝 : TriggerState {
            internal State도망끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "7", seconds: 10);
                context.DestroyMonster(spawnIds: new []{211, 212, 213});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "7")) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._03000145_bf {
    public static class _save_03 {
        public class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 1);
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg5: 1f);
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
                context.SetInteractObject(interactIds: new []{10000469}, state: 1);
                context.CreateMonster(spawnIds: new []{301, 302}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000469}, arg2: 0)) {
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
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg5: 1f);
                context.DestroyMonster(spawnIds: new []{301, 302});
                context.CreateMonster(spawnIds: new []{311, 312}, arg2: false);
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
                context.SetConversation(type: 1, spawnId: 311, script: "$03000145_BF__SAVE_03__0$", arg4: 2, arg5: 0);
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
                context.SetConversation(type: 1, spawnId: 312, script: "$03000145_BF__SAVE_03__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State도망시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망시작 : TriggerState {
            internal State도망시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 311, patrolName: "MS2PatrolData_311");
                context.MoveNpc(spawnId: 312, patrolName: "MS2PatrolData_312");
            }

            public override TriggerState? Execute() {
                return new State도망중(context);
            }

            public override void OnExit() { }
        }

        private class State도망중 : TriggerState {
            internal State도망중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 3);
                context.SetConversation(type: 1, spawnId: 311, script: "$03000145_BF__SAVE_03__2$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 312, script: "$03000145_BF__SAVE_03__3$", arg4: 2, arg5: 1);
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
                context.DestroyMonster(spawnIds: new []{311, 312});
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

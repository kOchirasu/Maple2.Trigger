namespace Maple2.Trigger._52000022_qd {
    public static class _patrol01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.CreateMonster(spawnIds: new []{111, 211}, arg2: false);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60001041}, questStates: new byte[]{1})) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.DestroyMonster(spawnIds: new []{111, 211});
                context.CreateMonster(spawnIds: new []{101, 201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State말풍선Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Cinematic01 : TriggerState {
            internal State말풍선Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000022_QD__PATROL01__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State말풍선Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Cinematic02 : TriggerState {
            internal State말풍선Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetConversation(type: 1, spawnId: 201, script: "$52000022_QD__PATROL01__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State말풍선Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Cinematic03 : TriggerState {
            internal State말풍선Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000022_QD__PATROL01__2$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateIshura이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura이동 : TriggerState {
            internal StateIshura이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State추격대원이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추격대원이동 : TriggerState {
            internal State추격대원이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetConversation(type: 1, spawnId: 201, script: "$52000022_QD__PATROL01__3$", arg4: 3, arg5: 0);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State말풍선Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Cinematic04 : TriggerState {
            internal State말풍선Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000022_QD__PATROL01__4$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State말풍선Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Cinematic05 : TriggerState {
            internal State말풍선Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000022_QD__PATROL01__5$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101_B");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State말풍선Cinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Cinematic06 : TriggerState {
            internal State말풍선Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000022_QD__PATROL01__6$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State감옥이펙트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감옥이펙트 : TriggerState {
            internal State감옥이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State말풍선Cinematic07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Cinematic07 : TriggerState {
            internal State말풍선Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetConversation(type: 1, spawnId: 201, script: "$52000022_QD__PATROL01__7$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201_B");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State말풍선Cinematic08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Cinematic08 : TriggerState {
            internal State말풍선Cinematic08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000022_QD__PATROL01__8$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State몹소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹소환 : TriggerState {
            internal State몹소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52000022_QD__PATROL01__9$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$52000022_QD__PATROL01__10$", arg4: 3, arg5: 0);
                context.CreateMonster(spawnIds: new []{1001}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1001})) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetEffect(triggerIds: new []{601}, visible: false);
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{111, 211}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

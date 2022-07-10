namespace Maple2.Trigger._52000012_qd {
    public static class _main {
        public class State초기상태 : TriggerState {
            internal State초기상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013}, visible: true);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(triggerId: 5001, visible: false, initialSequence: "DownIdle_B");
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.SetActor(triggerId: 10001, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 10002, visible: true, initialSequence: "Closed");
                context.CreateMonster(spawnIds: new []{101, 102, 103, 5000}, arg2: false);
                context.SetAgent(triggerIds: new []{7000, 7001, 7002, 7003, 7004, 8000, 8001, 8002, 8003, 8004, 8006, 8007, 8008, 8009, 8010}, visible: true);
                context.SetMesh(triggerIds: new []{10011, 10012}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{10002610}, questStates: new byte[]{1})) {
                    return new State레논Cinematic1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Cinematic1 : TriggerState {
            internal State레논Cinematic1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "9", seconds: 2);
                context.CreateMonster(spawnIds: new []{1000}, arg2: false);
                context.SetAgent(triggerIds: new []{7000, 7001, 7002, 7003, 7004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new State레논Cinematic2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논Cinematic2 : TriggerState {
            internal State레논Cinematic2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000012_QD__MAIN__0$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State전투1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투1 : TriggerState {
            internal State전투1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103})) {
                    return new State벨라StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라StartCinematic : TriggerState {
            internal State벨라StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "8", seconds: 3);
                context.CameraSelectPath(pathIds: new []{901, 902}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "8")) {
                    return new State벨라Cinematic중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Cinematic중 : TriggerState {
            internal State벨라Cinematic중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 7);
                context.SetConversation(type: 2, spawnId: 11000844, script: "$52000012_QD__MAIN__1$", arg4: 2);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000012_QD__MAIN__2$", arg4: 2);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000012_QD__MAIN__3$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new State벨라StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라StopCinematic : TriggerState {
            internal State벨라StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "14", seconds: 1);
                context.CameraSelectPath(pathIds: new []{906}, returnView: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "14")) {
                    return new State문열림1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림1 : TriggerState {
            internal State문열림1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "19", seconds: 1);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004}, visible: false);
                context.CreateMonster(spawnIds: new []{201, 202, 203}, arg2: false);
                context.SetActor(triggerId: 10001, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{10011}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "19")) {
                    return new State전투2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투2 : TriggerState {
            internal State전투2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1000, patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203})) {
                    return new State문열림2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림2 : TriggerState {
            internal State문열림2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 2);
                context.SetAgent(triggerIds: new []{8006, 8007, 8008, 8009, 8010}, visible: false);
                context.SetActor(triggerId: 10002, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{10012}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new State악령StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State악령StartCinematic : TriggerState {
            internal State악령StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "13", seconds: 6);
                context.CameraSelectPath(pathIds: new []{904, 905}, returnView: false);
                context.CreateMonster(spawnIds: new []{301}, arg2: false);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_301");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "13")) {
                    return new State화면끄기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면끄기 : TriggerState {
            internal State화면끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "22")) {
                    return new State영혼Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영혼Cinematic : TriggerState {
            internal State영혼Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "23", seconds: 2);
                context.DestroyMonster(spawnIds: new []{301, 5000, 301, 5000});
                context.SetActor(triggerId: 5001, visible: true, initialSequence: "DownIdle_B");
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "23")) {
                    return new State화면켜기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면켜기 : TriggerState {
            internal State화면켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "14", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "14")) {
                    return new State영혼Cinematic중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영혼Cinematic중 : TriggerState {
            internal State영혼Cinematic중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "15", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11000064, script: "$52000012_QD__MAIN__4$", arg4: 3);
                context.CameraSelectPath(pathIds: new []{905, 903}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State영혼StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영혼StopCinematic : TriggerState {
            internal State영혼StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1000, patrolName: "MS2PatrolData_1002");
                context.CameraSelect(triggerId: 903, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new State전투3(context);
            }

            public override void OnExit() { }
        }

        private class State전투3 : TriggerState {
            internal State전투3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 5001, visible: false, initialSequence: "DownIdle_B");
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.CreateMonster(spawnIds: new []{302}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{302})) {
                    return new State레논교체(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레논교체 : TriggerState {
            internal State레논교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1000});
                context.CreateMonster(spawnIds: new []{2000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{10002611}, questStates: new byte[]{2})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9001})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1000, 2000, 101, 102, 103, 201, 202, 203, 301, 302});
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}

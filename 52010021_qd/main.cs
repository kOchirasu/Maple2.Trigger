namespace Maple2.Trigger._52010021_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.CreateMonster(spawnIds: new []{101, 102, 103});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002540}, questStates: new byte[]{3})) {
                    return new StateEvent_01_Idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_Idle : TriggerState {
            internal StateEvent_01_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010021, portalId: 3, boxId: 701);
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{104});
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2004");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2003");
                context.CameraSelect(triggerId: 8001, enable: true);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 8001, enable: true);
            }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010021_QD__MAIN__0$", arg4: 4);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding : TriggerState {
            internal StateEnding(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2012");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2014");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2013");
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateOut(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 4);
            }
        }

        private class StateOut : TriggerState {
            internal StateOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 9, script: "$52010021_QD__MAIN__1$", arg3: true);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateReal_end2(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 9, script: "$52010021_QD__MAIN__2$", arg3: true);
                context.PlaySystemSoundInBox(sound: "System_Laugh_01");
            }
        }

        private class StateReal_end2 : TriggerState {
            internal StateReal_end2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateReal_end3(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 9, script: "$52010021_QD__MAIN__3$", arg3: true);
            }
        }

        private class StateReal_end3 : TriggerState {
            internal StateReal_end3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateReal_end4(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_Burp_01");
            }
        }

        private class StateReal_end4 : TriggerState {
            internal StateReal_end4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateReal_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReal_end : TriggerState {
            internal StateReal_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "mikaEpilogueEnd");
                context.MoveUser(mapId: 02010002, portalId: 1, boxId: 701);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

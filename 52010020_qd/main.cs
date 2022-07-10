namespace Maple2.Trigger._52010020_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 4);
                context.CreateMonster(spawnIds: new []{101, 102});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateEvent_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_Ready : TriggerState {
            internal StateEvent_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2001");
                context.SetConversation(type: 1, spawnId: 102, script: "$52010020_QD__MAIN__0$", arg4: 5);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2002");
                context.SetConversation(type: 1, spawnId: 101, script: "$52010020_QD__MAIN__1$", arg4: 5);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2004");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2001");
                context.MoveUser(mapId: 52010020, portalId: 1, boxId: 701);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{103});
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2003");
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: false);
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001502, script: "$52010020_QD__MAIN__2$", arg4: 4);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2001");
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 4);
            }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

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
                context.SetAchievement(triggerId: 701, type: "trigger", code: "luanDialogue");
                context.CameraSelect(triggerId: 8001, enable: false);
                context.MoveUser(mapId: 52010019, portalId: 2, boxId: 701);
            }
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

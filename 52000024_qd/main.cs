namespace Maple2.Trigger._52000024_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{20002233}, questStates: new byte[]{1})) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{20002233}, questStates: new byte[]{2})) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{20002233}, questStates: new byte[]{3})) {
                    return new StateStart_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_B : TriggerState {
            internal StateStart_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{106, 101}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.MoveUserPath(patrolName: "MS2PatrolData_2101");
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
                context.CameraSelectPath(pathIds: new []{8001, 8002, 8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7006}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001564, script: "$52000024_QD__MAIN__0$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{103});
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
            }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(triggerId: 8004, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartB_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStartB_01 : TriggerState {
            internal StateStartB_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 8005, enable: true);
                context.MoveUser(mapId: 52000024, portalId: 99);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartB_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_02 : TriggerState {
            internal StateStartB_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateStartB_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_04 : TriggerState {
            internal StateStartB_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005, 8006}, returnView: false);
                context.SetEffect(triggerIds: new []{7003}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000024_QD__MAIN__1$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStartB_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_07 : TriggerState {
            internal StateStartB_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001570, script: "$52000024_QD__MAIN__2$", arg4: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartB_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_08 : TriggerState {
            internal StateStartB_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007, 8008}, returnView: false);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2005");
                context.MoveUserPath(patrolName: "MS2PatrolData_2102");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStartB_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_09 : TriggerState {
            internal StateStartB_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2008");
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000024_QD__MAIN__3$", arg4: 5);
                context.SetEffect(triggerIds: new []{7004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStartB_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_10 : TriggerState {
            internal StateStartB_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001570, script: "$52000024_QD__MAIN__4$", arg4: 2);
                context.SetEffect(triggerIds: new []{7002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartB_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_11 : TriggerState {
            internal StateStartB_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartB_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartB_12 : TriggerState {
            internal StateStartB_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{105});
                context.CameraSelect(triggerId: 8005, enable: false);
                context.SetAchievement(triggerId: 701, type: "trigger", code: "PirateRiddenSea");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{20002233}, questStates: new byte[]{3})) {
                    return new StateStartC_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartC_01 : TriggerState {
            internal StateStartC_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 104, script: "$52000024_QD__MAIN__5$", arg4: 3, arg5: 0);
                context.SetEffect(triggerIds: new []{7005}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStartC_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartC_02 : TriggerState {
            internal StateStartC_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2002");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2007");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStartC_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartC_03 : TriggerState {
            internal StateStartC_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{104});
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new StateStartD_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartD_01 : TriggerState {
            internal StateStartD_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._52000050_qd {
    public static class _main_01 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7011}, visible: false);
                context.SetBreakable(triggerIds: new []{9001, 9002, 9003, 9004, 9005}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{9001, 9002, 9003, 9004, 9005}, visible: false);
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003056}, questStates: new byte[]{3})) {
                    return new StateQuest_end(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003056}, questStates: new byte[]{2})) {
                    return new StateQuest_end(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003055}, questStates: new byte[]{3})) {
                    return new StateStart_02_resume(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003055}, questStates: new byte[]{2})) {
                    return new StateStart_02_j_resume(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003055}, questStates: new byte[]{1})) {
                    return new StateStart_02_resume(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003054}, questStates: new byte[]{3})) {
                    return new StateStart_02_Ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003054}, questStates: new byte[]{2})) {
                    return new StateStart_02_Ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003054}, questStates: new byte[]{1})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.CreateMonster(spawnIds: new []{111, 112}, arg2: false);
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData_1201");
                context.SetConversation(type: 1, spawnId: 112, script: "$52000050_QD__MAIN_01__8$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 112, script: "$52000050_QD__MAIN_01__0$", arg4: 2, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetAchievement(triggerId: 701, type: "trigger", code: "MovetoNewHouse");
                    return new StateReady_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{112});
                context.CreateMonster(spawnIds: new []{122}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003055}, questStates: new byte[]{1})) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_Ready : TriggerState {
            internal StateStart_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.CreateMonster(spawnIds: new []{111, 122}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003055}, questStates: new byte[]{1})) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_1101");
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000050_QD__MAIN_01__1$", arg4: 4);
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_1205");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUserPath(patrolName: "MS2PatrolData_9901");
                    return new StateStart_02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_resume : TriggerState {
            internal StateStart_02_resume(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.CreateMonster(spawnIds: new []{111, 122}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_1101");
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000050_QD__MAIN_01__2$", arg4: 4);
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_1205");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUserPath(patrolName: "MS2PatrolData_9901");
                    return new StateStart_02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_b : TriggerState {
            internal StateStart_02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Talk_A", duration: 3000f);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000050_QD__MAIN_01__3$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_02_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_c : TriggerState {
            internal StateStart_02_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000050_QD__MAIN_01__4$", arg4: 3);
                context.SetNpcEmotionLoop(spawnId: 122, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_02_d(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_d : TriggerState {
            internal StateStart_02_d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_1202");
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000050_QD__MAIN_01__5$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_02_e(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_e : TriggerState {
            internal StateStart_02_e(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetBreakable(triggerIds: new []{9001, 9002, 9003, 9004, 9005}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{9001, 9002, 9003, 9004, 9005}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005}, visible: true);
                    context.SetMeshAnimation(triggerIds: new []{6001, 6002, 6003, 6004, 6005}, visible: true, arg3: 0, arg4: 0);
                    return new StateStart_02_f(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_f : TriggerState {
            internal StateStart_02_f(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEffect(triggerIds: new []{7011}, visible: true);
                    return new StateStart_02_g(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_g : TriggerState {
            internal StateStart_02_g(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003, 8004}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 122, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetBreakable(triggerIds: new []{9001, 9002, 9003, 9004, 9005}, enabled: false);
                    context.SetVisibleBreakableObject(triggerIds: new []{9001, 9002, 9003, 9004, 9005}, visible: false);
                    context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_1203");
                    return new StateStart_02_h(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_h : TriggerState {
            internal StateStart_02_h(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000050_QD__MAIN_01__6$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_02_i(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_i : TriggerState {
            internal StateStart_02_i(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 122, sequenceName: "Talk_A", duration: 3000f);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000050_QD__MAIN_01__7$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetAchievement(triggerId: 701, type: "trigger", code: "SingingOfBirds");
                    return new StateStart_02_j(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_j : TriggerState {
            internal StateStart_02_j(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: true);
                context.DestroyMonster(spawnIds: new []{111});
                context.CreateMonster(spawnIds: new []{121}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003056}, questStates: new byte[]{2})) {
                    return new StateStart_02_k(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_j_resume : TriggerState {
            internal StateStart_02_j_resume(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 111});
                context.CreateMonster(spawnIds: new []{121, 122}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005}, visible: true);
                context.SetEffect(triggerIds: new []{7011}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003056}, questStates: new byte[]{2})) {
                    return new StateStart_02_k(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_k : TriggerState {
            internal StateStart_02_k(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 121, patrolName: "MS2PatrolData_1204");
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_1204");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest_end : TriggerState {
            internal StateQuest_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

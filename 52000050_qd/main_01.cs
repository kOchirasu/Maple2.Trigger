namespace Maple2.Trigger._52000050_qd {
    public static class _main_01 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7011}, arg2: false);
                context.SetBreakable(arg1: new[] {9001, 9002, 9003, 9004, 9005}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {9001, 9002, 9003, 9004, 9005}, arg2: false);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003056}, arg3: new byte[] {3})) {
                    return new StateQuest_end(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003056}, arg3: new byte[] {2})) {
                    return new StateQuest_end(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003055}, arg3: new byte[] {3})) {
                    return new StateStart_02_resume(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003055}, arg3: new byte[] {2})) {
                    return new StateStart_02_j_resume(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003055}, arg3: new byte[] {1})) {
                    return new StateStart_02_resume(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003054}, arg3: new byte[] {3})) {
                    return new StateStart_02_Ready(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003054}, arg3: new byte[] {2})) {
                    return new StateStart_02_Ready(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003054}, arg3: new byte[] {1})) {
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
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {111, 112}, arg2: false);
                context.MoveNpc(arg1: 112, arg2: "MS2PatrolData_1201");
                context.SetConversation(arg1: 1, arg2: 112, script: "$52000050_QD__MAIN_01__8$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 112, script: "$52000050_QD__MAIN_01__0$", arg4: 2, arg5: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "MovetoNewHouse");
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
                context.DestroyMonster(arg1: new[] {112});
                context.CreateMonster(arg1: new[] {122}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003055}, arg3: new byte[] {1})) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_Ready : TriggerState {
            internal StateStart_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {111, 122}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003055}, arg3: new byte[] {1})) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_1101");
                context.CameraSelectPath(pathIds: new[] {8005}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001557, script: "$52000050_QD__MAIN_01__1$", arg4: 4);
                context.MoveNpc(arg1: 122, arg2: "MS2PatrolData_1205");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_9901");
                    return new StateStart_02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_resume : TriggerState {
            internal StateStart_02_resume(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {111, 122}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(arg1: 111, arg2: "MS2PatrolData_1101");
                context.CameraSelectPath(pathIds: new[] {8005}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001557, script: "$52000050_QD__MAIN_01__2$", arg4: 4);
                context.MoveNpc(arg1: 122, arg2: "MS2PatrolData_1205");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_9901");
                    return new StateStart_02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_b : TriggerState {
            internal StateStart_02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11001557, script: "$52000050_QD__MAIN_01__3$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11001708, script: "$52000050_QD__MAIN_01__4$", arg4: 3);
                context.SetNpcEmotionLoop(arg1: 122, arg2: "Talk_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 122, arg2: "MS2PatrolData_1202");
                context.SetConversation(arg1: 2, arg2: 11001708, script: "$52000050_QD__MAIN_01__5$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(pathIds: new[] {8001}, arg2: false);
                context.SetBreakable(arg1: new[] {9001, 9002, 9003, 9004, 9005}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {9001, 9002, 9003, 9004, 9005}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005}, arg2: true);
                    context.SetMeshAnimation(arg1: new[] {6001, 6002, 6003, 6004, 6005}, arg2: true, arg3: 0, arg4: 0);
                    return new StateStart_02_f(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_f : TriggerState {
            internal StateStart_02_f(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEffect(arg1: new[] {7011}, arg2: true);
                    return new StateStart_02_g(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_g : TriggerState {
            internal StateStart_02_g(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8003, 8004}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 122, arg2: "Talk_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetBreakable(arg1: new[] {9001, 9002, 9003, 9004, 9005}, arg2: false);
                    context.SetVisibleBreakableObject(arg1: new[] {9001, 9002, 9003, 9004, 9005}, arg2: false);
                    context.MoveNpc(arg1: 122, arg2: "MS2PatrolData_1203");
                    return new StateStart_02_h(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_h : TriggerState {
            internal StateStart_02_h(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, script: "$52000050_QD__MAIN_01__6$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.SetNpcEmotionLoop(arg1: 122, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11001708, script: "$52000050_QD__MAIN_01__7$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "SingingOfBirds");
                    return new StateStart_02_j(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_j : TriggerState {
            internal StateStart_02_j(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8002}, arg2: true);
                context.DestroyMonster(arg1: new[] {111});
                context.CreateMonster(arg1: new[] {121}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003056}, arg3: new byte[] {2})) {
                    return new StateStart_02_k(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_j_resume : TriggerState {
            internal StateStart_02_j_resume(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 111});
                context.CreateMonster(arg1: new[] {121, 122}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005}, arg2: true);
                context.SetEffect(arg1: new[] {7011}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003056}, arg3: new byte[] {2})) {
                    return new StateStart_02_k(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_k : TriggerState {
            internal StateStart_02_k(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 121, arg2: "MS2PatrolData_1204");
                context.MoveNpc(arg1: 122, arg2: "MS2PatrolData_1204");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest_end : TriggerState {
            internal StateQuest_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
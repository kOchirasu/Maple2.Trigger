namespace Maple2.Trigger._52000025_qd {
    public static class _main_etc {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002942}, arg3: new byte[] {1}, arg4: 30)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002942}, arg3: new byte[] {2}, arg4: 30)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002942}, arg3: new byte[] {3}, arg4: 30)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002951}, arg3: new byte[] {1}, arg4: 40)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002951}, arg3: new byte[] {2}, arg4: 40)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002951}, arg3: new byte[] {3}, arg4: 40)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002961}, arg3: new byte[] {1}, arg4: 20)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002961}, arg3: new byte[] {2}, arg4: 20)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002961}, arg3: new byte[] {3}, arg4: 20)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002971}, arg3: new byte[] {1}, arg4: 50)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002971}, arg3: new byte[] {2}, arg4: 50)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002971}, arg3: new byte[] {3}, arg4: 50)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002981}, arg3: new byte[] {1}, arg4: 10)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002981}, arg3: new byte[] {2}, arg4: 10)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002981}, arg3: new byte[] {3}, arg4: 10)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002981}, arg3: new byte[] {1}, arg4: 01)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002981}, arg3: new byte[] {2}, arg4: 01)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002981}, arg3: new byte[] {3}, arg4: 01)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002991}, arg3: new byte[] {1}, arg4: 60)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002991}, arg3: new byte[] {2}, arg4: 60)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002991}, arg3: new byte[] {3}, arg4: 60)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003001}, arg3: new byte[] {1}, arg4: 70)) {
                    return new StateStart(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003001}, arg3: new byte[] {2}, arg4: 70)) {
                    return new StateStart_B(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10003001}, arg3: new byte[] {3}, arg4: 70)) {
                    return new StateStart_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_B : TriggerState {
            internal StateStart_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202, 299}, arg2: false);
                context.DestroyMonster(arg1: new[] {203, 204, 205});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 203, 204, 101, 102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102})) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetConversation(arg1: 1, arg2: 201, script: "$52000025_QD__MAIN_ETC__0$", arg4: 2, arg5: 1);
            }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111, 112, 113, 114, 115, 116}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 201, script: "$52000025_QD__MAIN_ETC__1$", arg4: 2, arg5: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {111, 112, 113, 114, 115, 116})) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000025_QD__MAIN_ETC__2$", arg4: 4);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2000");
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000025_QD__MAIN_ETC__3$", arg4: 3);
                context.SetEffect(arg1: new[] {7003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 4);
            }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {203, 204, 205});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.MoveUser(arg1: 52000025, arg2: 99);
            }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2001");
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.CameraSelectPath(pathIds: new[] {8001, 8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001575, script: "$52000025_QD__MAIN_ETC__4$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001244, script: "$52000025_QD__MAIN_ETC__5$", arg4: 5);
                context.SetEffect(arg1: new[] {7002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001575, script: "$52000025_QD__MAIN_ETC__6$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_10 : TriggerState {
            internal StateStart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001575, script: "$52000025_QD__MAIN_ETC__7$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_11(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 8001, arg2: false);
            }
        }

        private class StateStart_11 : TriggerState {
            internal StateStart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {299}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "SweepthePriates");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
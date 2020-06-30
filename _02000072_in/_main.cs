using System;

namespace Maple2.Trigger._02000072_in {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트조건체크 : TriggerState {
            internal State퀘스트조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001566},
                    arg3: new byte[] {3})) {
                    context.State = new State환자홀로있는집(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001566},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001566},
                    arg3: new byte[] {1})) {
                    context.State = new State아르마노가출후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001565},
                    arg3: new byte[] {3})) {
                    context.State = new State아르마노가출후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001565},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001565},
                    arg3: new byte[] {1})) {
                    context.State = new State아르마노가출후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001564},
                    arg3: new byte[] {3})) {
                    context.State = new State아르마노가출후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001564},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001564},
                    arg3: new byte[] {1})) {
                    context.State = new State아르마노가출전(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001563},
                    arg3: new byte[] {3})) {
                    context.State = new State아르마노가출전(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001563},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출전(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001563},
                    arg3: new byte[] {1})) {
                    context.State = new State빈집(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001562},
                    arg3: new byte[] {3})) {
                    context.State = new State빈집(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001562},
                    arg3: new byte[] {2})) {
                    context.State = new State빈집(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001562},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001561},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001561},
                    arg3: new byte[] {2})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001561},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001560},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001560},
                    arg3: new byte[] {2})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001560},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001559},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001559},
                    arg3: new byte[] {2})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001559},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001558},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001558},
                    arg3: new byte[] {2})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001558},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001557},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001557},
                    arg3: new byte[] {2})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001557},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001556},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001556},
                    arg3: new byte[] {2})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001556},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001555},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001555},
                    arg3: new byte[] {2})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001555},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001554},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001554},
                    arg3: new byte[] {2})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001554},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001553},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001553},
                    arg3: new byte[] {2})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001553},
                    arg3: new byte[] {1})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {3})) {
                    context.State = new State마노비치혼자(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {2})) {
                    context.State = new State오스칼퇴장대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {1})) {
                    context.State = new State침공직후상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001551},
                    arg3: new byte[] {3})) {
                    context.State = new State침공직후상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001551},
                    arg3: new byte[] {2})) {
                    context.State = new State침공직후상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001551},
                    arg3: new byte[] {1})) {
                    context.State = new State빈집(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빈집 : TriggerState {
            internal State빈집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102, 103, 104, 105, 106, 107});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State침공직후상태 : TriggerState {
            internal State침공직후상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {2})) {
                    context.State = new State오스칼퇴장연출(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {1})) {
                    context.State = new State침공직후상태01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001551},
                    arg3: new byte[] {3})) {
                    context.State = new State침공직후상태01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001551},
                    arg3: new byte[] {2})) {
                    context.State = new State침공직후상태01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State침공직후상태01 : TriggerState {
            internal State침공직후상태01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {2})) {
                    context.State = new State오스칼퇴장연출(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {2})) {
                    context.State = new State침공직후상태02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State침공직후상태02 : TriggerState {
            internal State침공직후상태02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {2})) {
                    context.State = new State오스칼퇴장연출(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {2})) {
                    context.State = new State침공직후상태01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼퇴장대기 : TriggerState {
            internal State오스칼퇴장대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {2})) {
                    context.State = new State오스칼퇴장연출(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트조건체크(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼퇴장연출 : TriggerState {
            internal State오스칼퇴장연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Wayout_102_O");
                context.AddBalloonTalk(spawnPointID: 102, msg: "$02000072_IN__MAIN__0$", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State오스칼퇴장연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼퇴장연출종료 : TriggerState {
            internal State오스칼퇴장연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.DestroyMonster(arg1: new int[] {102});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001552},
                    arg3: new byte[] {2})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마노비치혼자 : TriggerState {
            internal State마노비치혼자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노가출전 : TriggerState {
            internal State아르마노가출전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103, 104, 105, 106}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001564},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출연출(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001564},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출전01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노가출전01 : TriggerState {
            internal State아르마노가출전01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001564},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출연출(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001564},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출전02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노가출전02 : TriggerState {
            internal State아르마노가출전02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001564},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출연출(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001564},
                    arg3: new byte[] {2})) {
                    context.State = new State아르마노가출전01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노가출대기 : TriggerState {
            internal State아르마노가출대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103, 104, 105, 106}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State아르마노가출연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노가출연출 : TriggerState {
            internal State아르마노가출연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8010}, arg2: 0);
                context.MoveUser(arg1: 02000072, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State아르마노대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노대사01 : TriggerState {
            internal State아르마노대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8011}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__1$", arg4: 4, arg5: 0);
                context.SetSceneSkip(arg1: "아르마노가출_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State아르마노대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노대사02 : TriggerState {
            internal State아르마노대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__2$", arg4: 5, arg5: 0);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State오스칼대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼대사01 : TriggerState {
            internal State오스칼대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8013}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003245, arg3: "$02000072_IN__MAIN__3$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State아르마노대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노대사03 : TriggerState {
            internal State아르마노대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8014}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__4$", arg4: 5, arg5: 0);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State오스칼대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼대사02 : TriggerState {
            internal State오스칼대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8013}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003245, arg3: "$02000072_IN__MAIN__5$", arg4: 8, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 8000f);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.State = new State오스칼대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼대사03 : TriggerState {
            internal State오스칼대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8013}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003245, arg3: "$02000072_IN__MAIN__6$", arg4: 8, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 8000f);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State오스칼대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오스칼대사04 : TriggerState {
            internal State오스칼대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003245, arg3: "$02000072_IN__MAIN__7$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 8000f);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State아르마노대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노대사04 : TriggerState {
            internal State아르마노대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8014}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__8$", arg4: 6, arg5: 0);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State아르마노대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노대사05 : TriggerState {
            internal State아르마노대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__9$", arg4: 8, arg5: 0);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State프레이대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이대사01 : TriggerState {
            internal State프레이대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8012}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003246, arg3: "$02000072_IN__MAIN__10$", arg4: 7, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 106, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State아르마노대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노대사06 : TriggerState {
            internal State아르마노대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8014}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__11$", arg4: 8, arg5: 0);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State프레이대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프레이대사02 : TriggerState {
            internal State프레이대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8012}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003246, arg3: "$02000072_IN__MAIN__12$", arg4: 9, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 106, arg2: "Talk_A", arg3: 9000f);
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State아르마노대사07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노대사07 : TriggerState {
            internal State아르마노대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8014, 8015}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__13$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new int[] {107});
                context.SetSkip(arg1: "아르마노가출_스킵완료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아르마노대사08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노대사08 : TriggerState {
            internal State아르마노대사08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8015}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__14$", arg4: 6, arg5: 0);
                context.SetSkip(arg1: "아르마노가출_스킵완료_조디제외");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State아르마노탈주(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노탈주 : TriggerState {
            internal State아르마노탈주(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_Wayout_104_A");
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_Walkin_107_J");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC멈칫(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC멈칫 : TriggerState {
            internal StatePC멈칫(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {104});
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Follow");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000072_IN__MAIN__15$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State조디등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조디등장 : TriggerState {
            internal State조디등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8016}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State조디대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조디대사01 : TriggerState {
            internal State조디대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8017}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11003247, arg3: "$02000072_IN__MAIN__16$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 107, arg2: "Talk_A", arg3: 3000f);
                context.SetSkip(arg1: "아르마노가출_스킵완료_조디제외");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State조디대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조디대사02 : TriggerState {
            internal State조디대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003247, arg3: "$02000072_IN__MAIN__17$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 107, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "아르마노가출_스킵완료_조디제외");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePC안녕(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC안녕 : TriggerState {
            internal StatePC안녕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Hello_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State조디대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조디대사03 : TriggerState {
            internal State조디대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003247, arg3: "$02000072_IN__MAIN__18$", arg4: 3, arg5: 0);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아르마노가출연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노가출_스킵완료 : TriggerState {
            internal State아르마노가출_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new int[] {107, 108});
                context.DestroyMonster(arg1: new int[] {104});
                context.CreateMonster(arg1: new int[] {108});
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Follow");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아르마노가출연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노가출연출종료 : TriggerState {
            internal State아르마노가출연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아르마노가출후 : TriggerState {
            internal State아르마노가출후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103, 105, 106, 108}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001566},
                    arg3: new byte[] {3})) {
                    context.State = new State환자홀로있는집(context);
                    return;
                }

                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State환자홀로있는집 : TriggerState {
            internal State환자홀로있는집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
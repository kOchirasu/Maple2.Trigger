namespace Maple2.Trigger._02000072_in {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001566}, arg3: new byte[] {3})) {
                    return new State환자홀로있는집(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001566}, arg3: new byte[] {2})) {
                    return new State아르마노가출후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001566}, arg3: new byte[] {1})) {
                    return new State아르마노가출후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001565}, arg3: new byte[] {3})) {
                    return new State아르마노가출후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001565}, arg3: new byte[] {2})) {
                    return new State아르마노가출후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001565}, arg3: new byte[] {1})) {
                    return new State아르마노가출후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001564}, arg3: new byte[] {3})) {
                    return new State아르마노가출후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001564}, arg3: new byte[] {2})) {
                    return new State아르마노가출Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001564}, arg3: new byte[] {1})) {
                    return new State아르마노가출전(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001563}, arg3: new byte[] {3})) {
                    return new State아르마노가출전(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001563}, arg3: new byte[] {2})) {
                    return new State아르마노가출전(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001563}, arg3: new byte[] {1})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001562}, arg3: new byte[] {3})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001562}, arg3: new byte[] {2})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001562}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001561}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001561}, arg3: new byte[] {2})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001561}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001560}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001560}, arg3: new byte[] {2})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001560}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001559}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001559}, arg3: new byte[] {2})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001559}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001558}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001558}, arg3: new byte[] {2})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001558}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001557}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001557}, arg3: new byte[] {2})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001557}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001556}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001556}, arg3: new byte[] {2})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001556}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001555}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001555}, arg3: new byte[] {2})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001555}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001554}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001554}, arg3: new byte[] {2})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001554}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001553}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001553}, arg3: new byte[] {2})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001553}, arg3: new byte[] {1})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {3})) {
                    return new State마노비치혼자(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {2})) {
                    return new State오스칼ExitWait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {1})) {
                    return new State침공직후상태(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001551}, arg3: new byte[] {3})) {
                    return new State침공직후상태(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001551}, arg3: new byte[] {2})) {
                    return new State침공직후상태(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001551}, arg3: new byte[] {1})) {
                    return new State빈집(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈집 : TriggerState {
            internal State빈집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침공직후상태 : TriggerState {
            internal State침공직후상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {2})) {
                    return new State오스칼ExitCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {1})) {
                    return new State침공직후상태01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001551}, arg3: new byte[] {3})) {
                    return new State침공직후상태01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001551}, arg3: new byte[] {2})) {
                    return new State침공직후상태01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침공직후상태01 : TriggerState {
            internal State침공직후상태01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {2})) {
                    return new State오스칼ExitCinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {2})) {
                    return new State침공직후상태02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침공직후상태02 : TriggerState {
            internal State침공직후상태02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {2})) {
                    return new State오스칼ExitCinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {2})) {
                    return new State침공직후상태01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼ExitWait : TriggerState {
            internal State오스칼ExitWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {2})) {
                    return new State오스칼ExitCinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {2})) {
                    return new StateQuestConditionCheck(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼ExitCinematic : TriggerState {
            internal State오스칼ExitCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_Wayout_102_O");
                context.AddBalloonTalk(spawnPointId: 102, msg: "$02000072_IN__MAIN__0$", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오스칼ExitStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼ExitStopCinematic : TriggerState {
            internal State오스칼ExitStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.DestroyMonster(arg1: new[] {102});
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001552}, arg3: new byte[] {2})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마노비치혼자 : TriggerState {
            internal State마노비치혼자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노가출전 : TriggerState {
            internal State아르마노가출전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103, 104, 105, 106}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001564}, arg3: new byte[] {2})) {
                    return new State아르마노가출Cinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001564}, arg3: new byte[] {2})) {
                    return new State아르마노가출전01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노가출전01 : TriggerState {
            internal State아르마노가출전01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001564}, arg3: new byte[] {2})) {
                    return new State아르마노가출Cinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001564}, arg3: new byte[] {2})) {
                    return new State아르마노가출전02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노가출전02 : TriggerState {
            internal State아르마노가출전02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001564}, arg3: new byte[] {2})) {
                    return new State아르마노가출Cinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001564}, arg3: new byte[] {2})) {
                    return new State아르마노가출전01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노가출Wait : TriggerState {
            internal State아르마노가출Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103, 104, 105, 106}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State아르마노가출Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노가출Cinematic : TriggerState {
            internal State아르마노가출Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.MoveUser(arg1: 02000072, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State아르마노Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script01 : TriggerState {
            internal State아르마노Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8011}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__1$", arg4: 4, arg5: 0);
                context.SetSceneSkip(arg1: "아르마노가출_스킵완료", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아르마노Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script02 : TriggerState {
            internal State아르마노Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__2$", arg4: 5, arg5: 0);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State오스칼Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script01 : TriggerState {
            internal State오스칼Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8013}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003245, arg3: "$02000072_IN__MAIN__3$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State아르마노Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script03 : TriggerState {
            internal State아르마노Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8014}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__4$", arg4: 5, arg5: 0);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State오스칼Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script02 : TriggerState {
            internal State오스칼Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8013}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003245, arg3: "$02000072_IN__MAIN__5$", arg4: 8, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 8000f);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    return new State오스칼Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script03 : TriggerState {
            internal State오스칼Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8013}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003245, arg3: "$02000072_IN__MAIN__6$", arg4: 8, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 8000f);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State오스칼Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Script04 : TriggerState {
            internal State오스칼Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003245, arg3: "$02000072_IN__MAIN__7$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Talk_A", arg3: 8000f);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State아르마노Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script04 : TriggerState {
            internal State아르마노Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8014}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__8$", arg4: 6, arg5: 0);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State아르마노Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script05 : TriggerState {
            internal State아르마노Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__9$", arg4: 8, arg5: 0);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State프레이Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이Script01 : TriggerState {
            internal State프레이Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8012}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003246, arg3: "$02000072_IN__MAIN__10$", arg4: 7, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 106, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State아르마노Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script06 : TriggerState {
            internal State아르마노Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8014}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__11$", arg4: 8, arg5: 0);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State프레이Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프레이Script02 : TriggerState {
            internal State프레이Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8012}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003246, arg3: "$02000072_IN__MAIN__12$", arg4: 9, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 106, arg2: "Talk_A", arg3: 9000f);
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State아르마노Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script07 : TriggerState {
            internal State아르마노Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8014, 8015}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__13$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new[] {107});
                context.SetSkip(state: new State아르마노가출_스킵완료(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아르마노Script08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노Script08 : TriggerState {
            internal State아르마노Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8015}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003244, arg3: "$02000072_IN__MAIN__14$", arg4: 6, arg5: 0);
                context.SetSkip(state: new State아르마노탈주(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State아르마노탈주(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노탈주 : TriggerState {
            internal State아르마노탈주(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_Wayout_104_A");
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_Walkin_107_J");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC멈칫(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC멈칫 : TriggerState {
            internal StatePC멈칫(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Follow");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000072_IN__MAIN__15$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State조디Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조디Appear : TriggerState {
            internal State조디Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8016}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State조디Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조디Script01 : TriggerState {
            internal State조디Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8017}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003247, arg3: "$02000072_IN__MAIN__16$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 107, arg2: "Talk_A", arg3: 3000f);
                context.SetSkip(state: new State조디Script02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State조디Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조디Script02 : TriggerState {
            internal State조디Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003247, arg3: "$02000072_IN__MAIN__17$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 107, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(state: new StatePC안녕(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePC안녕(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC안녕 : TriggerState {
            internal StatePC안녕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Hello_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State조디Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조디Script03 : TriggerState {
            internal State조디Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003247, arg3: "$02000072_IN__MAIN__18$", arg4: 3, arg5: 0);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아르마노가출StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노가출_스킵완료 : TriggerState {
            internal State아르마노가출_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {107, 108, 104});
                context.CreateMonster(arg1: new[] {108});
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Follow");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아르마노가출StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노가출StopCinematic : TriggerState {
            internal State아르마노가출StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노가출후 : TriggerState {
            internal State아르마노가출후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103, 105, 106, 108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001566}, arg3: new byte[] {3})) {
                    return new State환자홀로있는집(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State환자홀로있는집 : TriggerState {
            internal State환자홀로있는집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
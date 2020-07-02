namespace Maple2.Trigger._02000035_in {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuest조건체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest조건체크 : TriggerState {
            internal StateQuest조건체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {3})) {
                    return new State기본(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {2})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {1})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {3})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {2})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    return new StateNpc스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {3})) {
                    return new StateNpc스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {2})) {
                    return new StateNpc스폰(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {1})) {
                    return new State기본(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기본 : TriggerState {
            internal State기본(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc스폰 : TriggerState {
            internal StateNpc스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    return new StateSetupCinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    return new StateNPC스폰조건01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC스폰조건01 : TriggerState {
            internal StateNPC스폰조건01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {2})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    return new StateSetupCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {3})) {
                    return new StateNPC스폰조건02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {2})) {
                    return new StateNPC스폰조건02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {1})) {
                    return new State기본(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC스폰조건02 : TriggerState {
            internal StateNPC스폰조건02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {2})) {
                    return new State탈주이후(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    return new StateSetupCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {3})) {
                    return new StateNPC스폰조건01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {2})) {
                    return new StateNPC스폰조건01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {1})) {
                    return new State기본(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈주이후 : TriggerState {
            internal State탈주이후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102, 103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic00 : TriggerState {
            internal StateSetupCinematic00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000035, arg2: 10);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "케이틀린슬픔_스킵완료", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State언쟁시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State언쟁시작 : TriggerState {
            internal State언쟁시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003264, arg3: "$02000035_IN__MAIN__0$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8150)) {
                    return new State케이틀린대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사01 : TriggerState {
            internal State케이틀린대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003262, arg3: "$02000035_IN__MAIN__1$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
                context.SetSkip(arg1: "케이틀린대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6400)) {
                    return new State앤대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사01_skip : TriggerState {
            internal State케이틀린대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State앤대사01(context);
            }

            public override void OnExit() { }
        }

        private class State앤대사01 : TriggerState {
            internal State앤대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003264, arg3: "$02000035_IN__MAIN__2$", arg4: 5, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "앤대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5328)) {
                    return new State케이틀린대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤대사01_skip : TriggerState {
            internal State앤대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State케이틀린대사02(context);
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사02 : TriggerState {
            internal State케이틀린대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003262, arg3: "$02000035_IN__MAIN__3$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
                context.SetSkip(arg1: "케이틀린대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9404)) {
                    return new State호르헤대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사02_skip : TriggerState {
            internal State케이틀린대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State호르헤대사01(context);
            }

            public override void OnExit() { }
        }

        private class State호르헤대사01 : TriggerState {
            internal State호르헤대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003263, arg3: "$02000035_IN__MAIN__4$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
                context.SetSkip(arg1: "호르헤대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State케이틀린대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State호르헤대사01_skip : TriggerState {
            internal State호르헤대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State케이틀린대사03(context);
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사03 : TriggerState {
            internal State케이틀린대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003262, arg3: "$02000035_IN__MAIN__5$", arg4: 5, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "케이틀린대사03_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9404)) {
                    return new State앤대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사03_skip : TriggerState {
            internal State케이틀린대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State앤대사02(context);
            }

            public override void OnExit() { }
        }

        private class State앤대사02 : TriggerState {
            internal State앤대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003264, arg3: "$02000035_IN__MAIN__9$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "ChatUp_A", arg3: 2000f);
                context.SetSkip(arg1: "앤대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State호르헤대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤대사02_skip : TriggerState {
            internal State앤대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State호르헤대사02(context);
            }

            public override void OnExit() { }
        }

        private class State호르헤대사02 : TriggerState {
            internal State호르헤대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003263, arg3: "$02000035_IN__MAIN__10$", arg4: 2, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "ChatUp_A", arg3: 2000f);
                context.SetSkip(arg1: "호르헤대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State케이틀린대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State호르헤대사02_skip : TriggerState {
            internal State호르헤대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State케이틀린대사04(context);
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사04 : TriggerState {
            internal State케이틀린대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003262, arg3: "$02000035_IN__MAIN__6$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "케이틀린대사04_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4780)) {
                    return new State케이틀린탈주01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사04_skip : TriggerState {
            internal State케이틀린대사04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State케이틀린탈주01(context);
            }

            public override void OnExit() { }
        }

        private class State케이틀린탈주01 : TriggerState {
            internal State케이틀린탈주01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_100_wayout");
                context.MoveUserPath(arg1: "MS2PatrolData_PC01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State케이틀린탈주02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린탈주02 : TriggerState {
            internal State케이틀린탈주02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003262, arg3: "$02000035_IN__MAIN__7$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State케이틀린탈주03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린탈주03 : TriggerState {
            internal State케이틀린탈주03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101_wayout");
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
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000035_IN__MAIN__11$", arg4: 2, arg5: 0);
                context.DestroyMonster(arg1: new[] {101});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State앤대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤대사03 : TriggerState {
            internal State앤대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003264, arg3: "$02000035_IN__MAIN__8$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "ChatUp_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4022)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린슬픔_스킵완료 : TriggerState {
            internal State케이틀린슬픔_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {101});
                context.MoveUserPath(arg1: "MS2PatrolData_PC01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "KatelyninGrief");
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
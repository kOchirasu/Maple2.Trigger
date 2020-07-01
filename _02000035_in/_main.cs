namespace Maple2.Trigger._02000035_in {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
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
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {3})) {
                    context.State = new State기본(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {2})) {
                    context.State = new State탈주이후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001606}, arg3: new byte[] {1})) {
                    context.State = new State탈주이후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {3})) {
                    context.State = new State탈주이후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {2})) {
                    context.State = new State탈주이후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    context.State = new Statenpc스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {3})) {
                    context.State = new Statenpc스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {2})) {
                    context.State = new Statenpc스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {1})) {
                    context.State = new State기본(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본 : TriggerState {
            internal State기본(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statenpc스폰 : TriggerState {
            internal Statenpc스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    context.State = new State연출준비(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    context.State = new StateNPC스폰조건01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC스폰조건01 : TriggerState {
            internal StateNPC스폰조건01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {2})) {
                    context.State = new State탈주이후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    context.State = new State연출준비(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {3})) {
                    context.State = new StateNPC스폰조건02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {2})) {
                    context.State = new StateNPC스폰조건02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {1})) {
                    context.State = new State기본(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC스폰조건02 : TriggerState {
            internal StateNPC스폰조건02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {2})) {
                    context.State = new State탈주이후(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001605}, arg3: new byte[] {1})) {
                    context.State = new State연출준비(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {3})) {
                    context.State = new StateNPC스폰조건01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {2})) {
                    context.State = new StateNPC스폰조건01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001604}, arg3: new byte[] {1})) {
                    context.State = new State기본(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈주이후 : TriggerState {
            internal State탈주이후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102, 103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비00 : TriggerState {
            internal State연출준비00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비 : TriggerState {
            internal State연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000035, arg2: 10);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "케이틀린슬픔_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State언쟁시작(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 8150)) {
                    context.State = new State케이틀린대사01(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 6400)) {
                    context.State = new State앤대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사01_skip : TriggerState {
            internal State케이틀린대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State앤대사01(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 5328)) {
                    context.State = new State케이틀린대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State앤대사01_skip : TriggerState {
            internal State앤대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State케이틀린대사02(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 9404)) {
                    context.State = new State호르헤대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사02_skip : TriggerState {
            internal State케이틀린대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State호르헤대사01(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State케이틀린대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State호르헤대사01_skip : TriggerState {
            internal State호르헤대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State케이틀린대사03(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 9404)) {
                    context.State = new State앤대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사03_skip : TriggerState {
            internal State케이틀린대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State앤대사02(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State호르헤대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State앤대사02_skip : TriggerState {
            internal State앤대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State호르헤대사02(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State케이틀린대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State호르헤대사02_skip : TriggerState {
            internal State호르헤대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State케이틀린대사04(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 4780)) {
                    context.State = new State케이틀린탈주01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린대사04_skip : TriggerState {
            internal State케이틀린대사04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State케이틀린탈주01(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State케이틀린탈주02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린탈주02 : TriggerState {
            internal State케이틀린탈주02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003262, arg3: "$02000035_IN__MAIN__7$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State케이틀린탈주03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린탈주03 : TriggerState {
            internal State케이틀린탈주03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101_wayout");
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
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000035_IN__MAIN__11$", arg4: 2, arg5: 0);
                context.DestroyMonster(arg1: new[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State앤대사03(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 4022)) {
                    context.State = new State연출종료(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "KatelyninGrief");
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
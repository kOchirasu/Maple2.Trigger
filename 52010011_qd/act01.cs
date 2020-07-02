namespace Maple2.Trigger._52010011_qd {
    public static class _act01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetEffect(arg1: new[] {5000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new StateQuest시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest시작 : TriggerState {
            internal StateQuest시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002811}, arg3: new byte[] {2})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행 : TriggerState {
            internal State진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010011, arg2: 2, arg3: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대사_01_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_01_테모로 : TriggerState {
            internal State대사_01_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__0$", arg4: 5);
                context.SetSkip(arg1: "대사_01_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_01_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_01_테모로skip : TriggerState {
            internal State대사_01_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_02_테모로(context);
            }

            public override void OnExit() { }
        }

        private class State대사_02_테모로 : TriggerState {
            internal State대사_02_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__1$", arg4: 5);
                context.SetSkip(arg1: "대사_02_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_02_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_02_테모로skip : TriggerState {
            internal State대사_02_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_03_PC(context);
            }

            public override void OnExit() { }
        }

        private class State대사_03_PC : TriggerState {
            internal State대사_03_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52010011_QD__ACT01__2$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대사_04_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_04_테모로 : TriggerState {
            internal State대사_04_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__3$", arg4: 5);
                context.SetSkip(arg1: "대사_04_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_04_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_04_테모로skip : TriggerState {
            internal State대사_04_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_05_테모로(context);
            }

            public override void OnExit() { }
        }

        private class State대사_05_테모로 : TriggerState {
            internal State대사_05_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__4$", arg4: 5);
                context.SetSkip(arg1: "대사_05_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_05_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_05_테모로skip : TriggerState {
            internal State대사_05_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_06_PC(context);
            }

            public override void OnExit() { }
        }

        private class State대사_06_PC : TriggerState {
            internal State대사_06_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52010011_QD__ACT01__5$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대사_07_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_07_테모로 : TriggerState {
            internal State대사_07_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__6$", arg4: 5);
                context.SetSkip(arg1: "대사_07_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_07_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_07_테모로skip : TriggerState {
            internal State대사_07_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_08_테모로(context);
            }

            public override void OnExit() { }
        }

        private class State대사_08_테모로 : TriggerState {
            internal State대사_08_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__7$", arg4: 5);
                context.SetSkip(arg1: "대사_08_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_08_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_08_테모로skip : TriggerState {
            internal State대사_08_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_09_PC(context);
            }

            public override void OnExit() { }
        }

        private class State대사_09_PC : TriggerState {
            internal State대사_09_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52010011_QD__ACT01__8$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대사_10_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_10_테모로 : TriggerState {
            internal State대사_10_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__9$", arg4: 5);
                context.SetSkip(arg1: "대사_10_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_10_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_10_테모로skip : TriggerState {
            internal State대사_10_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_11_테모로(context);
            }

            public override void OnExit() { }
        }

        private class State대사_11_테모로 : TriggerState {
            internal State대사_11_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__10$", arg4: 5);
                context.SetSkip(arg1: "대사_11_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_11_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_11_테모로skip : TriggerState {
            internal State대사_11_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_12_PC(context);
            }

            public override void OnExit() { }
        }

        private class State대사_12_PC : TriggerState {
            internal State대사_12_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52010011_QD__ACT01__11$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_13_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_13_테모로 : TriggerState {
            internal State대사_13_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__12$", arg4: 5);
                context.SetSkip(arg1: "대사_13_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_13_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_13_테모로skip : TriggerState {
            internal State대사_13_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State영상준비(context);
            }

            public override void OnExit() { }
        }

        private class State영상준비 : TriggerState {
            internal State영상준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "21", arg2: 2);
                context.CameraSelectPath(arg1: new[] {601, 602}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: @"common\KarKarIntro.usm", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State대사_14_PC(context);
                }

                if (context.WaitTick(waitTick: 18000)) {
                    return new State대사_14_PC(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_14_PC : TriggerState {
            internal State대사_14_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52010011_QD__ACT01__13$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대사_15_테모로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_15_테모로 : TriggerState {
            internal State대사_15_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__14$", arg4: 5);
                context.SetSkip(arg1: "대사_15_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_15_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_15_테모로skip : TriggerState {
            internal State대사_15_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_16_테모로(context);
            }

            public override void OnExit() { }
        }

        private class State대사_16_테모로 : TriggerState {
            internal State대사_16_테모로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001314, arg3: "$52010011_QD__ACT01__15$", arg4: 5);
                context.SetSkip(arg1: "대사_16_테모로skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_16_테모로skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_16_테모로skip : TriggerState {
            internal State대사_16_테모로skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CreateMonster(arg1: new[] {1001}, arg2: true);
                context.SetSkip(arg1: "대사_17_덴덴");
            }

            public override TriggerState Execute() {
                return new State대사_17_덴덴(context);
            }

            public override void OnExit() { }
        }

        private class State대사_17_덴덴 : TriggerState {
            internal State대사_17_덴덴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1001, arg2: "MS2PatrolData_2001");
                context.SetConversation(arg1: 2, arg2: 11001313, arg3: "$52010011_QD__ACT01__16$", arg4: 5);
                context.SetSkip(arg1: "대사_17_덴덴skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대사_17_덴덴skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_17_덴덴skip : TriggerState {
            internal State대사_17_덴덴skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_18_PC(context);
            }

            public override void OnExit() { }
        }

        private class State대사_18_PC : TriggerState {
            internal State대사_18_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52010011_QD__ACT01__17$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대사_19_덴덴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_19_덴덴 : TriggerState {
            internal State대사_19_덴덴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001313, arg3: "$52010011_QD__ACT01__18$", arg4: 4);
                context.SetSkip(arg1: "대사_19_덴덴skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대사_19_덴덴skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_19_덴덴skip : TriggerState {
            internal State대사_19_덴덴skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State대사_20_PC(context);
            }

            public override void OnExit() { }
        }

        private class State대사_20_PC : TriggerState {
            internal State대사_20_PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52010011_QD__ACT01__19$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대사_21_덴덴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_21_덴덴 : TriggerState {
            internal State대사_21_덴덴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001313, arg3: "$52010011_QD__ACT01__20$", arg4: 3);
                context.SetSkip(arg1: "대사_21_덴덴skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대사_21_덴덴skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사_21_덴덴skip : TriggerState {
            internal State대사_21_덴덴skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
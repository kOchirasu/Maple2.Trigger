namespace Maple2.Trigger._02000224_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

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
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001562}, arg3: new byte[] {2})) {
                    return new State다음맵으로(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001562}, arg3: new byte[] {1})) {
                    return new StateSetupCinematic00(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001561}, arg3: new byte[] {3})) {
                    return new State아르마노있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001561}, arg3: new byte[] {2})) {
                    return new State아르마노있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001561}, arg3: new byte[] {1})) {
                    return new State아르마노있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001560}, arg3: new byte[] {3})) {
                    return new State아르마노있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001560}, arg3: new byte[] {2})) {
                    return new State아르마노있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001560}, arg3: new byte[] {1})) {
                    return new StateBasic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBasic : TriggerState {
            internal StateBasic(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuest조건체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노있음 : TriggerState {
            internal State아르마노있음(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001562}, arg3: new byte[] {1})) {
                    return new StateSetupCinematic(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001562}, arg3: new byte[] {1})) {
                    return new StateQuest조건체크(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다음맵으로 : TriggerState {
            internal State다음맵으로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic00 : TriggerState {
            internal StateSetupCinematic00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "아르마노말썽_스킵완료", arg2: "exit");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
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
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.MoveUser(arg1: 02000224, arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State티니에Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에Appear : TriggerState {
            internal State티니에Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__18$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Bore_C", arg3: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State티니에이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에이동01 : TriggerState {
            internal State티니에이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_girl01");
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아르마노대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노대사01 : TriggerState {
            internal State아르마노대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003242, arg3: "$02000224_BF__MAIN__1$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "아르마노대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State티니에대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노대사01_skip : TriggerState {
            internal State아르마노대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State티니에대사01(context);
            }

            public override void OnExit() { }
        }

        private class State티니에대사01 : TriggerState {
            internal State티니에대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__2$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "티니에대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6765)) {
                    return new State아르마노대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사01_skip : TriggerState {
            internal State티니에대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아르마노대사02(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노대사02 : TriggerState {
            internal State아르마노대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_girl02");
                context.SetConversation(arg1: 2, arg2: 11003242, arg3: "$02000224_BF__MAIN__3$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "아르마노대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4597)) {
                    return new State티니에대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노대사02_skip : TriggerState {
            internal State아르마노대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State티니에대사02(context);
            }

            public override void OnExit() { }
        }

        private class State티니에대사02 : TriggerState {
            internal State티니에대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__4$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "티니에대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7471)) {
                    return new State티니에이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사02_skip : TriggerState {
            internal State티니에대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State티니에이동02(context);
            }

            public override void OnExit() { }
        }

        private class State티니에이동02 : TriggerState {
            internal State티니에이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_girl02");
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__5$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10109)) {
                    return new State티니에대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사03 : TriggerState {
            internal State티니에대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__6$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "티니에대사03_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9090)) {
                    return new State아르마노대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사03_skip : TriggerState {
            internal State티니에대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아르마노대사03(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노대사03 : TriggerState {
            internal State아르마노대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003242, arg3: "$02000224_BF__MAIN__7$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "아르마노대사03_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5146)) {
                    return new State티니에대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노대사03_skip : TriggerState {
            internal State아르마노대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State티니에대사04(context);
            }

            public override void OnExit() { }
        }

        private class State티니에대사04 : TriggerState {
            internal State티니에대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__8$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "티니에대사04_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7418)) {
                    return new State아르마노대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사04_skip : TriggerState {
            internal State티니에대사04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아르마노대사04(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노대사04 : TriggerState {
            internal State아르마노대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003242, arg3: "$02000224_BF__MAIN__9$", arg4: 4, arg5: 0);
                context.SetSkip(arg1: "아르마노대사04_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아르마노대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노대사04_skip : TriggerState {
            internal State아르마노대사04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아르마노대사05(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노대사05 : TriggerState {
            internal State아르마노대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetConversation(arg1: 2, arg2: 11003242, arg3: "$02000224_BF__MAIN__10$", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "아르마노대사05_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3030)) {
                    return new State아르마노탈주(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노대사05_skip : TriggerState {
            internal State아르마노대사05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State아르마노탈주(context);
            }

            public override void OnExit() { }
        }

        private class State아르마노탈주 : TriggerState {
            internal State아르마노탈주(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_boy01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State티니에대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사05 : TriggerState {
            internal State티니에대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_girl03");
                context.DestroyMonster(arg1: new[] {101});
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__11$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State티니에대사06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사06 : TriggerState {
            internal State티니에대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_PC01");
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__12$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Bore_C", arg3: 4000f);
                context.SetSkip(arg1: "티니에대사06_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11023)) {
                    return new StatePC대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사06_skip : TriggerState {
            internal State티니에대사06_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StatePC대사01(context);
            }

            public override void OnExit() { }
        }

        private class StatePC대사01 : TriggerState {
            internal StatePC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000224_BF__MAIN__13$", arg4: 3, arg5: 0);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State티니에대사07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사07 : TriggerState {
            internal State티니에대사07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__14$", arg4: 4, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "ChatUp_A");
                context.SetSkip(arg1: "티니에대사07_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7810)) {
                    return new StatePC대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사07_skip : TriggerState {
            internal State티니에대사07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State티니에대사08(context);
            }

            public override void OnExit() { }
        }

        private class StatePC대사02 : TriggerState {
            internal StatePC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000224_BF__MAIN__15$", arg4: 3, arg5: 0);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 3000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State티니에대사08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사08 : TriggerState {
            internal State티니에대사08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__16$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "티니에대사08_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7497)) {
                    return new State티니에대사09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티니에대사08_skip : TriggerState {
            internal State티니에대사08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State티니에대사09(context);
            }

            public override void OnExit() { }
        }

        private class State티니에대사09 : TriggerState {
            internal State티니에대사09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003243, arg3: "$02000224_BF__MAIN__17$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7157)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아르마노말썽_스킵완료 : TriggerState {
            internal State아르마노말썽_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 103});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "foolishson");
                context.MoveUser(arg1: 02000054, arg2: 10);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
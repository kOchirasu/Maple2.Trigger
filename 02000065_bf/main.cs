namespace Maple2.Trigger._02000065_bf {
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
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001630}, arg3: new byte[] {3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001630}, arg3: new byte[] {2})) {
                    return new State앤있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001630}, arg3: new byte[] {1})) {
                    return new State앤있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001625}, arg3: new byte[] {3})) {
                    return new State앤있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001625}, arg3: new byte[] {2})) {
                    return new State연출2준비(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001625}, arg3: new byte[] {1})) {
                    return new State앤있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001624}, arg3: new byte[] {3})) {
                    return new State앤있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001624}, arg3: new byte[] {2})) {
                    return new State앤있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001624}, arg3: new byte[] {1})) {
                    return new State앤있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001623}, arg3: new byte[] {3})) {
                    return new State앤있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001623}, arg3: new byte[] {2})) {
                    return new State앤있음(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001623}, arg3: new byte[] {1})) {
                    return new State연출1준비(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001622}, arg3: new byte[] {3})) {
                    return new StateBasic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBasic : TriggerState {
            internal StateBasic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 111});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateQuest조건체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤있음 : TriggerState {
            internal State앤있음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {50001625}, arg3: new byte[] {2})) {
                    return new State연출2준비(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출1준비 : TriggerState {
            internal State연출1준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State연출1앤Appear준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출1앤Appear준비 : TriggerState {
            internal State연출1앤Appear준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State앤Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤Appear : TriggerState {
            internal State앤Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_ann01");
                context.AddCinematicTalk(npcId: 11003432, illustId: "Ann_normal", msg: "$02000065_BF__MAIN__0$", duration: 3000, align: "left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State앤Appear2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤Appear2 : TriggerState {
            internal State앤Appear2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$02000065_BF__MAIN__1$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출2준비 : TriggerState {
            internal State연출2준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.VisibleMyPc(isVisible: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State연출2준비1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출2준비1 : TriggerState {
            internal State연출2준비1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State앤대사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤대사01 : TriggerState {
            internal State앤대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010, 8011}, arg2: false);
                context.AddCinematicTalk(npcId: 11003432, msg: "$02000065_BF__MAIN__2$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 3000f);
                context.SetSceneSkip(arg1: "칼과앤_스킵완료", arg2: "nextState");
                context.SetSkip(arg1: "앤대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State칼대사01(context);
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
                return new State칼대사01(context);
            }

            public override void OnExit() { }
        }

        private class State칼대사01 : TriggerState {
            internal State칼대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000074, msg: "$02000065_BF__MAIN__3$", duration: 3000);
                context.SetSkip(arg1: "칼대사01_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State앤대사02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼대사01_skip : TriggerState {
            internal State칼대사01_skip(ITriggerContext context) : base(context) { }

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
                context.AddCinematicTalk(npcId: 11003432, msg: "$02000065_BF__MAIN__4$", duration: 4000);
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 3000f);
                context.SetSkip(arg1: "앤대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6400)) {
                    return new State칼대사02(context);
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
                return new State칼대사02(context);
            }

            public override void OnExit() { }
        }

        private class State칼대사02 : TriggerState {
            internal State칼대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000074, msg: "$02000065_BF__MAIN__5$", duration: 3000);
                context.SetSkip(arg1: "칼대사02_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8071)) {
                    return new State앤대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼대사02_skip : TriggerState {
            internal State칼대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State앤대사03(context);
            }

            public override void OnExit() { }
        }

        private class State앤대사03 : TriggerState {
            internal State앤대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003432, msg: "$02000065_BF__MAIN__6$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 2000f);
                context.SetSkip(arg1: "앤대사03_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6713)) {
                    return new State칼대사03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤대사03_skip : TriggerState {
            internal State앤대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칼대사03(context);
            }

            public override void OnExit() { }
        }

        private class State칼대사03 : TriggerState {
            internal State칼대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000074, msg: "$02000065_BF__MAIN__7$", duration: 4000);
                context.SetSkip(arg1: "칼대사03_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9769)) {
                    return new State앤대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼대사03_skip : TriggerState {
            internal State칼대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State앤대사04(context);
            }

            public override void OnExit() { }
        }

        private class State앤대사04 : TriggerState {
            internal State앤대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003432, msg: "$02000065_BF__MAIN__8$", duration: 3000);
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 2000f);
                context.SetSkip(arg1: "앤대사04_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State칼대사04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State앤대사04_skip : TriggerState {
            internal State앤대사04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칼대사04(context);
            }

            public override void OnExit() { }
        }

        private class State칼대사04 : TriggerState {
            internal State칼대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000074, msg: "$02000065_BF__MAIN__9$", duration: 3000);
                context.SetSkip(arg1: "칼대사04_skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7471)) {
                    return new State앤대사05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼대사04_skip : TriggerState {
            internal State칼대사04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State앤대사05(context);
            }

            public override void OnExit() { }
        }

        private class State앤대사05 : TriggerState {
            internal State앤대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003432, arg3: "$02000065_BF__MAIN__10$", arg4: 3, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 111, arg2: "Talk_A", arg3: 2000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3160)) {
                    return new StateCamera아웃(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera아웃 : TriggerState {
            internal StateCamera아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8000, 8001}, arg2: false);
                context.VisibleMyPc(isVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼과앤_스킵완료 : TriggerState {
            internal State칼과앤_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
                context.VisibleMyPc(isVisible: true);
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
                context.CameraReset(interpolationTime: 3.0f);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "meetingAnn");
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
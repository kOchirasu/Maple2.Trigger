namespace Maple2.Trigger._52000186_qd {
    public static class _52000186 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
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
                context.PlaySceneMovie(fileName: @"common\jp\Lapenta_Frontier.usm", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State묘지전경씬01(context);
                }

                if (context.WaitTick(waitTick: 110000)) {
                    return new State묘지전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬01 : TriggerState {
            internal State묘지전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {8000, 8001, 8002, 8003}, arg2: false);
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State묘지전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬02 : TriggerState {
            internal State묘지전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004, 8005}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52000186_QD__52000186__0$", desc: "$52000186_QD__52000186__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State묘지전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬03 : TriggerState {
            internal State묘지전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000186_QD__52000186__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201861, textId: 25201861, duration: 10000);
                context.CreateMonster(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 2000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002777}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002778}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002779}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002780}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002781}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002782}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002783}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002784}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002785}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002786}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {40002787}, arg3: new byte[] {3})) {
                    return new State출범연설시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State출범연설시작01 : TriggerState {
            internal State출범연설시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State출범연설시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State출범연설시작02 : TriggerState {
            internal State출범연설시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000186, arg2: 20);
                context.DestroyMonster(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010});
                context.CreateMonster(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 3000, 3001, 3002, 3003, 3004, 3005, 3006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State출범연설시작03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State출범연설시작03 : TriggerState {
            internal State출범연설시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002388}, arg3: new byte[] {3})) {
                    return new State베아트리체움직임01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State베아트리체움직임01 : TriggerState {
            internal State베아트리체움직임01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 3000, arg2: "MS2PatrolData_bche_Run");
                context.MoveNpc(arg1: 3001, arg2: "MS2PatrolData_alf_Run");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002389}, arg3: new byte[] {3})) {
                    return new State연설시퀀스종료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연설시퀀스종료01 : TriggerState {
            internal State연설시퀀스종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State연설시퀀스종료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연설시퀀스종료02 : TriggerState {
            internal State연설시퀀스종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 3000, 3001, 3002, 3003, 3004, 3005, 3006});
                context.MoveUser(arg1: 52010068, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State연설시퀀스종료03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연설시퀀스종료03 : TriggerState {
            internal State연설시퀀스종료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
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
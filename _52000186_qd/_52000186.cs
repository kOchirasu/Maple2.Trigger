using System;

namespace Maple2.Trigger._52000186_qd {
    public static class _52000186 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9002")) {
                    context.State = new State영상재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: @"common\jp\Lapenta_Frontier.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State묘지전경씬01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 110000)) {
                    context.State = new State묘지전경씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬01 : TriggerState {
            internal State묘지전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {8000, 8001, 8002, 8003}, arg2: 0);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State묘지전경씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬02 : TriggerState {
            internal State묘지전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004, 8005}, arg2: 0);
                context.ShowCaption(type: "VerticalCaption", title: "$52000186_QD__52000186__0$",
                    desc: "$52000186_QD__52000186__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 7000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State묘지전경씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬03 : TriggerState {
            internal State묘지전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000186_QD__52000186__2$", duration: 6000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityID: 25201861, textID: 25201861, durationTime: 10000);
                context.CreateMonster(arg1: new int[] {4000}, arg2: false);
                context.CreateMonster(arg1: new int[] {4001}, arg2: false);
                context.CreateMonster(arg1: new int[] {4002}, arg2: false);
                context.CreateMonster(arg1: new int[] {4003}, arg2: false);
                context.CreateMonster(arg1: new int[] {4004}, arg2: false);
                context.CreateMonster(arg1: new int[] {4005}, arg2: false);
                context.CreateMonster(arg1: new int[] {4006}, arg2: false);
                context.CreateMonster(arg1: new int[] {4007}, arg2: false);
                context.CreateMonster(arg1: new int[] {4008}, arg2: false);
                context.CreateMonster(arg1: new int[] {4009}, arg2: false);
                context.CreateMonster(arg1: new int[] {4010}, arg2: false);
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002777},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002778},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002779},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002780},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002781},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002782},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002783},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002784},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002785},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002786},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {40002787},
                    arg3: new byte[] {3})) {
                    context.State = new State출범연설시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State출범연설시작01 : TriggerState {
            internal State출범연설시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State출범연설시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State출범연설시작02 : TriggerState {
            internal State출범연설시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000186, arg2: 20);
                context.DestroyMonster(arg1: new int[] {4000});
                context.DestroyMonster(arg1: new int[] {4001});
                context.DestroyMonster(arg1: new int[] {4002});
                context.DestroyMonster(arg1: new int[] {4003});
                context.DestroyMonster(arg1: new int[] {4004});
                context.DestroyMonster(arg1: new int[] {4005});
                context.DestroyMonster(arg1: new int[] {4006});
                context.DestroyMonster(arg1: new int[] {4007});
                context.DestroyMonster(arg1: new int[] {4008});
                context.DestroyMonster(arg1: new int[] {4009});
                context.DestroyMonster(arg1: new int[] {4010});
                context.CreateMonster(arg1: new int[] {5000}, arg2: false);
                context.CreateMonster(arg1: new int[] {5001}, arg2: false);
                context.CreateMonster(arg1: new int[] {5002}, arg2: false);
                context.CreateMonster(arg1: new int[] {5003}, arg2: false);
                context.CreateMonster(arg1: new int[] {5004}, arg2: false);
                context.CreateMonster(arg1: new int[] {5005}, arg2: false);
                context.CreateMonster(arg1: new int[] {5006}, arg2: false);
                context.CreateMonster(arg1: new int[] {5007}, arg2: false);
                context.CreateMonster(arg1: new int[] {5008}, arg2: false);
                context.CreateMonster(arg1: new int[] {5009}, arg2: false);
                context.CreateMonster(arg1: new int[] {5010}, arg2: false);
                context.CreateMonster(arg1: new int[] {3000}, arg2: false);
                context.CreateMonster(arg1: new int[] {3001}, arg2: false);
                context.CreateMonster(arg1: new int[] {3002}, arg2: false);
                context.CreateMonster(arg1: new int[] {3003}, arg2: false);
                context.CreateMonster(arg1: new int[] {3004}, arg2: false);
                context.CreateMonster(arg1: new int[] {3005}, arg2: false);
                context.CreateMonster(arg1: new int[] {3006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State출범연설시작03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State출범연설시작03 : TriggerState {
            internal State출범연설시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002388},
                    arg3: new byte[] {3})) {
                    context.State = new State베아트리체움직임01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State베아트리체움직임01 : TriggerState {
            internal State베아트리체움직임01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 3000, arg2: "MS2PatrolData_bche_Run");
                context.MoveNpc(arg1: 3001, arg2: "MS2PatrolData_alf_Run");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002389},
                    arg3: new byte[] {3})) {
                    context.State = new State연설시퀀스종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연설시퀀스종료01 : TriggerState {
            internal State연설시퀀스종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연설시퀀스종료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연설시퀀스종료02 : TriggerState {
            internal State연설시퀀스종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {5000});
                context.DestroyMonster(arg1: new int[] {5001});
                context.DestroyMonster(arg1: new int[] {5002});
                context.DestroyMonster(arg1: new int[] {5003});
                context.DestroyMonster(arg1: new int[] {5004});
                context.DestroyMonster(arg1: new int[] {5005});
                context.DestroyMonster(arg1: new int[] {5006});
                context.DestroyMonster(arg1: new int[] {5007});
                context.DestroyMonster(arg1: new int[] {5008});
                context.DestroyMonster(arg1: new int[] {5009});
                context.DestroyMonster(arg1: new int[] {5010});
                context.DestroyMonster(arg1: new int[] {3000});
                context.DestroyMonster(arg1: new int[] {3001});
                context.DestroyMonster(arg1: new int[] {3002});
                context.DestroyMonster(arg1: new int[] {3003});
                context.DestroyMonster(arg1: new int[] {3004});
                context.DestroyMonster(arg1: new int[] {3005});
                context.DestroyMonster(arg1: new int[] {3006});
                context.MoveUser(arg1: 52010068, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연설시퀀스종료03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연설시퀀스종료03 : TriggerState {
            internal State연설시퀀스종료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
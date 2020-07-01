namespace Maple2.Trigger._52000183_qd {
    public static class _52000183 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new State영상재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {500}, arg2: false);
                context.CreateMonster(arg1: new[] {501}, arg2: false);
                context.CreateMonster(arg1: new[] {502}, arg2: false);
                context.CreateMonster(arg1: new[] {503}, arg2: false);
                context.CreateMonster(arg1: new[] {504}, arg2: false);
                context.CreateMonster(arg1: new[] {505}, arg2: false);
                context.CreateMonster(arg1: new[] {506}, arg2: false);
                context.CreateMonster(arg1: new[] {507}, arg2: false);
                context.CreateMonster(arg1: new[] {508}, arg2: false);
                context.CreateMonster(arg1: new[] {509}, arg2: false);
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChange_priest.swf", movieId: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State전경씬01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State전경씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경씬01 : TriggerState {
            internal State전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000183, arg2: 80);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 30, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
                context.CameraSelectPath(arg1: new[] {4000, 4001, 4002}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전경씬02_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경씬02_b : TriggerState {
            internal State전경씬02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Priest_HeavensPray3_A");
                context.SetNpcEmotionLoop(arg1: 500, arg2: "Bore_A", arg3: 8000f);
                context.SetNpcEmotionLoop(arg1: 501, arg2: "Idle_A", arg3: 8000f);
                context.SetNpcEmotionLoop(arg1: 502, arg2: "Idle_A", arg3: 8000f);
                context.SetNpcEmotionLoop(arg1: 503, arg2: "Bore_A", arg3: 8000f);
                context.SetNpcEmotionLoop(arg1: 504, arg2: "Idle_A", arg3: 8000f);
                context.SetNpcEmotionLoop(arg1: 505, arg2: "Bore_A", arg3: 8000f);
                context.SetNpcEmotionLoop(arg1: 506, arg2: "Idle_A", arg3: 8000f);
                context.SetNpcEmotionLoop(arg1: 507, arg2: "Bore_A", arg3: 8000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State전경씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전경씬02 : TriggerState {
            internal State전경씬02(ITriggerContext context) : base(context) { }

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
                context.MoveNpc(arg1: 502, arg2: "MS2PatrolData_502");
                context.MoveNpc(arg1: 503, arg2: "MS2PatrolData_503");
                context.MoveNpc(arg1: 505, arg2: "MS2PatrolData_505");
                context.MoveNpc(arg1: 506, arg2: "MS2PatrolData_506");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.ShowGuideSummary(entityId: 52001831, textId: 52001831, duration: 10000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002341},
                    arg3: new byte[] {3})) {
                    context.State = new State전직이펙트_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_01 : TriggerState {
            internal State전직이펙트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전직이펙트_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_02 : TriggerState {
            internal State전직이펙트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002342},
                    arg3: new byte[] {3})) {
                    context.State = new State가브란트퇴장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가브란트퇴장01 : TriggerState {
            internal State가브란트퇴장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 509, arg2: "MS2PatrolData_gabExit");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9002, arg2: new[] {509})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {509});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002343},
                    arg3: new byte[] {3})) {
                    context.State = new State전원퇴장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전원퇴장01 : TriggerState {
            internal State전원퇴장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전원퇴장01_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전원퇴장01_b : TriggerState {
            internal State전원퇴장01_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000183, arg2: 81);
                context.DestroyMonster(arg1: new[] {500});
                context.DestroyMonster(arg1: new[] {501});
                context.DestroyMonster(arg1: new[] {502});
                context.DestroyMonster(arg1: new[] {502});
                context.DestroyMonster(arg1: new[] {503});
                context.DestroyMonster(arg1: new[] {504});
                context.DestroyMonster(arg1: new[] {505});
                context.DestroyMonster(arg1: new[] {506});
                context.DestroyMonster(arg1: new[] {507});
                context.DestroyMonster(arg1: new[] {508});
                context.DestroyMonster(arg1: new[] {509});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전원퇴장02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전원퇴장02 : TriggerState {
            internal State전원퇴장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.ShowGuideSummary(entityId: 52001832, textId: 52001832, duration: 10000);
                context.CreateMonster(arg1: new[] {510}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002345},
                    arg3: new byte[] {3})) {
                    context.State = new State프론티아재단으로01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로01 : TriggerState {
            internal State프론티아재단으로01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State프론티아재단으로02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로02 : TriggerState {
            internal State프론티아재단으로02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000186, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
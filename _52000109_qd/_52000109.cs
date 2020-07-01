namespace Maple2.Trigger._52000109_qd {
    public static class _52000109 {
        public class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {10010})) {
                    context.State = new StateWait02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateWait03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait03 : TriggerState {
            internal StateWait03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000109_QD__52000109__0$",
                    desc: "$52000109_QD__52000109__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 6000, scale: 2.5f);
                context.SetOnetimeEffect(id: 40, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.MoveUser(arg1: 52000109, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에델슈타인전경씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬01 : TriggerState {
            internal State에델슈타인전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1000}, arg2: false);
                context.SetOnetimeEffect(id: 40, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000109_QD__52000109__2$", duration: 5000,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 200, msg: "$52000109_QD__52000109__3$", duration: 6000,
                    delayTick: 4000);
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 15000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬02 : TriggerState {
            internal State에델슈타인전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003292, illustId: "Ayesha_normal", msg: "$52000109_QD__52000109__4$",
                    duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000982, enable: true,
                    path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000982.xml");
                context.SetOnetimeEffect(id: 50, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬03 : TriggerState {
            internal State에델슈타인전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000109_QD__52000109__5$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 60, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬04 : TriggerState {
            internal State에델슈타인전경씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003292, illustId: "Ayesha_normal", msg: "$52000109_QD__52000109__6$",
                    duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000983, enable: true,
                    path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000983.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬05 : TriggerState {
            internal State에델슈타인전경씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000109_QD__52000109__7$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬06 : TriggerState {
            internal State에델슈타인전경씬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000109_QD__52000109__8$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬07 : TriggerState {
            internal State에델슈타인전경씬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003292, illustId: "Ayesha_normal", msg: "$52000109_QD__52000109__9$",
                    duration: 4000, align: "right");
                context.SetOnetimeEffect(id: 3000984, enable: true,
                    path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000984.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬08 : TriggerState {
            internal State에델슈타인전경씬08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000109_QD__52000109__10$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬10 : TriggerState {
            internal State에델슈타인전경씬10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1001}, arg2: false);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_Isha");
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬11 : TriggerState {
            internal State에델슈타인전경씬11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000109_QD__52000109__11$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬12 : TriggerState {
            internal State에델슈타인전경씬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", msg: "$52000109_QD__52000109__12$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬13 : TriggerState {
            internal State에델슈타인전경씬13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1002, 1003}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000109_QD__52000109__13$", duration: 5000,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 200, msg: "$52000109_QD__52000109__14$", duration: 6000,
                    delayTick: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에델슈타인전경씬14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬14 : TriggerState {
            internal State에델슈타인전경씬14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State20002302퀘스트대기01(context);
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
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_Isha");
                context.MoveUser(arg1: 52000109, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State20002302퀘스트대기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002302퀘스트대기01 : TriggerState {
            internal State20002302퀘스트대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityId: 25201091, textId: 25201091, duration: 5000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002304},
                    arg3: new byte[] {2})) {
                    context.State = new State라딘대화씬03(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002303},
                    arg3: new byte[] {3})) {
                    context.State = new State라딘대화씬01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002302},
                    arg3: new byte[] {3})) {
                    context.State = new State라딘등장씬01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002302},
                    arg3: new byte[] {2})) {
                    context.State = new State라딘등장씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘등장씬01 : TriggerState {
            internal State라딘등장씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State라딘등장씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘등장씬02 : TriggerState {
            internal State라딘등장씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_radin");
                context.CameraSelectPath(arg1: new[] {1004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State라딘등장씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘등장씬03 : TriggerState {
            internal State라딘등장씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003295, illustId: "Radin_normal", msg: "$52000109_QD__52000109__15$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State라딘등장씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘등장씬04 : TriggerState {
            internal State라딘등장씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 200, emotionName: "hello_Cait");
                context.ShowCaption(type: "NameCaption", title: "$52000109_QD__52000109__16$",
                    desc: "$52000109_QD__52000109__17$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f,
                    duration: 10000, scale: 2.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State라딘등장씬04_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘등장씬04_1 : TriggerState {
            internal State라딘등장씬04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State라딘등장씬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveNpc(arg1: 2002, arg2: "MS2PatrolData_radin");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State라딘등장씬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘등장씬05 : TriggerState {
            internal State라딘등장씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002303},
                    arg3: new byte[] {2})) {
                    context.State = new State라딘대화씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬01 : TriggerState {
            internal State라딘대화씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new[] {2004, 302}, arg2: false);
                context.DestroyMonster(arg1: new[] {2002, 200});
                context.MoveUser(arg1: 52000109, arg2: 11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State라딘대화씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬02 : TriggerState {
            internal State라딘대화씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {20002304},
                    arg3: new byte[] {2})) {
                    context.State = new State라딘대화씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬03 : TriggerState {
            internal State라딘대화씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "라딘대화씬05", arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State라딘대화씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬04 : TriggerState {
            internal State라딘대화씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000109_QD__52000109__18$",
                    desc: "$52000109_QD__52000109__19$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 10000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State라딘대화씬04_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬04_1 : TriggerState {
            internal State라딘대화씬04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State라딘대화씬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대화씬05 : TriggerState {
            internal State라딘대화씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000062, arg2: 13);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
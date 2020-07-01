namespace Maple2.Trigger._52000150_qd {
    public static class _52000150 {
        public class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2605}, arg2: false);
                context.SetEffect(arg1: new[] {2607}, arg2: true);
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001642},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트완료상태에서접속(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트완료상태에서접속(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트완료상태에서접속(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641},
                    arg3: new byte[] {1})) {
                    context.State = new StateSkip_1(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001640},
                    arg3: new byte[] {3})) {
                    context.State = new StateWait02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001640},
                    arg3: new byte[] {2})) {
                    context.State = new StateWait02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State차원의숲전경씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬01 : TriggerState {
            internal State차원의숲전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000150, arg2: 11);
                context.CameraSelectPath(arg1: new[] {1000, 1001, 1004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State차원의숲전경씬02_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬02_b : TriggerState {
            internal State차원의숲전경씬02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State차원의숲전경씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬02 : TriggerState {
            internal State차원의숲전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CameraSelectPath(arg1: new[] {1002, 1003}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52000150_QD__52000150__8$",
                    desc: "$52000150_QD__52000150__9$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 5500, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State차원의숲전경씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬03 : TriggerState {
            internal State차원의숲전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State차원의숲전경씬03_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬03_1 : TriggerState {
            internal State차원의숲전경씬03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State차원의숲전경씬종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000150, arg2: 11);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State차원의숲전경씬종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬종료 : TriggerState {
            internal State차원의숲전경씬종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_caitMove01");
                context.AddBalloonTalk(spawnPointId: 202, msg: "$52000150_QD__52000150__0$", duration: 6000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201501, textId: 25201501, duration: 10000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641},
                    arg3: new byte[] {3})) {
                    context.State = new State아노스흑화01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트완료상태에서접속(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641},
                    arg3: new byte[] {1})) {
                    context.State = new State결계흑화연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출01 : TriggerState {
            internal State결계흑화연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000150, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State결계흑화연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출02 : TriggerState {
            internal State결계흑화연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State결계흑화연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출03 : TriggerState {
            internal State결계흑화연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2608}, arg2: true);
                context.CameraSelectPath(arg1: new[] {3001, 3000}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Traped_A,Traped_Idle");
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003439, msg: "$52000150_QD__52000150__1$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new State결계흑화연출03_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출03_b : TriggerState {
            internal State결계흑화연출03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 202, emotionName: "Bore_A");
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Traped_Idle", arg3: 999999f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4200)) {
                    context.State = new State결계흑화연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출04 : TriggerState {
            internal State결계흑화연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Bore_A");
                context.CameraSelectPath(arg1: new[] {3002, 3003}, arg2: false);
                context.AddCinematicTalk(npcId: 11003442, msg: "$52000150_QD__52000150__2$", duration: 5000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State결계흑화연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출05 : TriggerState {
            internal State결계흑화연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Attack_Idle_A", arg3: 999999f);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
                context.CameraSelectPath(arg1: new[] {3004, 3005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003442, msg: "$52000150_QD__52000150__3$", duration: 5000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State결계흑화연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출06 : TriggerState {
            internal State결계흑화연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2606}, arg2: true);
                context.CameraSelectPath(arg1: new[] {3006, 3007}, arg2: false);
                context.SetEffect(arg1: new[] {2300, 2301, 2302, 2303, 2304}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2400, 2401, 2402, 2403, 2404}, arg2: true, arg3: 200, arg4: 200);
                context.SetEffect(arg1: new[] {2500, 2501, 2502, 2503, 2504}, arg2: true, arg3: 400, arg4: 200);
                context.SetEffect(arg1: new[] {2600, 2601, 2602, 2603, 2604}, arg2: true, arg3: 600, arg4: 200);
                context.CreateMonster(arg1: new[] {400, 401, 402, 403, 404}, arg2: false, arg3: 21000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State결계흑화연출07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출07 : TriggerState {
            internal State결계흑화연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2606}, arg2: true);
                context.SetEffect(arg1: new[] {2300, 2301, 2302, 2303, 2304}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2400, 2401, 2402, 2403, 2404}, arg2: true, arg3: 200, arg4: 200);
                context.SetEffect(arg1: new[] {2500, 2501, 2502, 2503, 2504}, arg2: true, arg3: 400, arg4: 200);
                context.SetEffect(arg1: new[] {2600, 2601, 2602, 2603, 2604}, arg2: true, arg3: 600, arg4: 200);
                context.CameraSelectPath(arg1: new[] {3008, 3009, 3010}, arg2: false);
                context.AddCinematicTalk(npcId: 11003442, msg: "$52000150_QD__52000150__4$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State결계흑화연출08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출08 : TriggerState {
            internal State결계흑화연출08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2606}, arg2: true);
                context.SetEffect(arg1: new[] {2300, 2301, 2302, 2303, 2304}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2400, 2401, 2402, 2403, 2404}, arg2: true, arg3: 200, arg4: 200);
                context.SetEffect(arg1: new[] {2500, 2501, 2502, 2503, 2504}, arg2: true, arg3: 400, arg4: 200);
                context.SetEffect(arg1: new[] {2600, 2601, 2602, 2603, 2604}, arg2: true, arg3: 600, arg4: 200);
                context.AddCinematicTalk(npcId: 11003442, msg: "$52000150_QD__52000150__5$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State결계흑화연출09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출09 : TriggerState {
            internal State결계흑화연출09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2606}, arg2: true);
                context.SetEffect(arg1: new[] {2300, 2301, 2302, 2303, 2304}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2400, 2401, 2402, 2403, 2404}, arg2: true, arg3: 200, arg4: 200);
                context.SetEffect(arg1: new[] {2500, 2501, 2502, 2503, 2504}, arg2: true, arg3: 400, arg4: 200);
                context.SetEffect(arg1: new[] {2600, 2601, 2602, 2603, 2604}, arg2: true, arg3: 600, arg4: 200);
                context.CameraSelectPath(arg1: new[] {3011, 3012}, arg2: false);
                context.AddCinematicTalk(npcId: 11003442, msg: "$52000150_QD__52000150__6$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State결계흑화연출10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출10 : TriggerState {
            internal State결계흑화연출10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2606}, arg2: true);
                context.SetEffect(arg1: new[] {2300, 2301, 2302, 2303, 2304}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2400, 2401, 2402, 2403, 2404}, arg2: true, arg3: 200, arg4: 200);
                context.SetEffect(arg1: new[] {2500, 2501, 2502, 2503, 2504}, arg2: true, arg3: 400, arg4: 200);
                context.SetEffect(arg1: new[] {2600, 2601, 2602, 2603, 2604}, arg2: true, arg3: 600, arg4: 200);
                context.CameraSelectPath(arg1: new[] {3013}, arg2: false);
                context.AddCinematicTalk(npcId: 11003442, msg: "$52000150_QD__52000150__7$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State결계흑화연출10_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출10_1 : TriggerState {
            internal State결계흑화연출10_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State결계흑화연출11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetEffect(arg1: new[] {2605}, arg2: false);
                context.SetEffect(arg1: new[] {2606}, arg2: false);
                context.SetEffect(arg1: new[] {2607}, arg2: false);
                context.SetEffect(arg1: new[] {2608}, arg2: false);
                context.SetEffect(arg1: new[] {2300, 2301, 2302, 2303, 2304}, arg2: false, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2400, 2401, 2402, 2403, 2404}, arg2: false, arg3: 200, arg4: 200);
                context.SetEffect(arg1: new[] {2500, 2501, 2502, 2503, 2504}, arg2: false, arg3: 400, arg4: 200);
                context.SetEffect(arg1: new[] {2600, 2601, 2602, 2603, 2604}, arg2: false, arg3: 600, arg4: 200);
                context.MoveUser(arg1: 52000150, arg2: 10);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Traped_Idle", arg3: 999999f);
                context.DestroyMonster(arg1: new[] {400, 401, 402, 403, 404});
                context.CreateMonster(arg1: new[] {400, 401, 402, 403, 404}, arg2: false, arg3: 100);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State결계흑화연출11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결계흑화연출11 : TriggerState {
            internal State결계흑화연출11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSound(arg1: 9000, arg2: true);
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {700}, arg2: false);
                context.SetUserValue(triggerId: 10001, key: "52000150", value: 1);
                context.ShowGuideSummary(entityId: 25201502, textId: 25201502, duration: 10000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아노스흑화준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화준비 : TriggerState {
            internal State아노스흑화준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 10001, key: "52000150", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "52000150monster") == 1) {
                    context.State = new State아노스흑화대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화대기 : TriggerState {
            internal State아노스흑화대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {2605}, arg2: false);
                context.SetEffect(arg1: new[] {2606}, arg2: false);
                context.SetEffect(arg1: new[] {2607}, arg2: false);
                context.SetEffect(arg1: new[] {2608}, arg2: false);
                context.MoveUser(arg1: 52000150, arg2: 10);
                context.DestroyMonster(arg1: new[] {200}, arg2: false);
                context.DestroyMonster(arg1: new[] {201}, arg2: false);
                context.DestroyMonster(arg1: new[] {202});
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.CreateMonster(arg1: new[] {700}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스흑화전대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전대사01 : TriggerState {
            internal State아노스흑화전대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "아노스흑화09", arg2: "exit");
                context.CameraSelectPath(arg1: new[] {3005}, arg2: false);
                context.AddCinematicTalk(npcId: 11003440, msg: "$52000150_QD__52000150__11$", duration: 4000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State아노스흑화전대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전대사02 : TriggerState {
            internal State아노스흑화전대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003442, illustId: "Caitlyn_serious",
                    msg: "$52000150_QD__52000150__12$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스흑화전대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전대사03 : TriggerState {
            internal State아노스흑화전대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {6000, 6001}, arg2: false);
                context.AddCinematicTalk(npcId: 11003440, msg: "$52000150_QD__52000150__13$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스흑화전대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전대사04 : TriggerState {
            internal State아노스흑화전대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003442, illustId: "Caitlyn_serious",
                    msg: "$52000150_QD__52000150__14$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스흑화전대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전대사05 : TriggerState {
            internal State아노스흑화전대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003438, illustId: "Horrhe_normal", msg: "$52000150_QD__52000150__15$",
                    duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스흑화전대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전대사06 : TriggerState {
            internal State아노스흑화전대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {6000}, arg2: false);
                context.AddCinematicTalk(npcId: 11003440, msg: "$52000150_QD__52000150__16$", duration: 3000,
                    align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스흑화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트완료상태에서접속 : TriggerState {
            internal State퀘스트완료상태에서접속(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아노스흑화09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화01 : TriggerState {
            internal State아노스흑화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(arg1: new[] {2607}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스흑화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화02 : TriggerState {
            internal State아노스흑화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {6000, 6001}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 200, arg2: "Event_02_A,Event_02_Idle");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스흑화03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화03 : TriggerState {
            internal State아노스흑화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {6002, 6003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스흑화04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화04 : TriggerState {
            internal State아노스흑화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {6004, 6005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아노스흑화05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화05 : TriggerState {
            internal State아노스흑화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2605}, arg2: true);
                context.DestroyMonster(arg1: new[] {200});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State아노스흑화06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화06 : TriggerState {
            internal State아노스흑화06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {6006, 6007, 6008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아노스흑화07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화07 : TriggerState {
            internal State아노스흑화07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.5f, endScale: 0.3f, duration: 15.0f, interpolator: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State아노스흑화08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화08 : TriggerState {
            internal State아노스흑화08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State아노스흑화08_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화08_1 : TriggerState {
            internal State아노스흑화08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아노스흑화09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스흑화09 : TriggerState {
            internal State아노스흑화09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000151, arg2: 10);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
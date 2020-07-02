namespace Maple2.Trigger._52000106_qd {
    public static class _52000106 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002323}, arg3: new byte[] {1})) {
                    return new State그림자의침략01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002323}, arg3: new byte[] {2})) {
                    return new State그림자의침략완료02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002325}, arg3: new byte[] {2})) {
                    return new State리엔을떠나다01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002323}, arg3: new byte[] {3})) {
                    return new State그림자의침략완료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략01 : TriggerState {
            internal State그림자의침략01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State그림자의침략02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략02 : TriggerState {
            internal State그림자의침략02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1000, 1001}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State그림자의침략03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략03 : TriggerState {
            internal State그림자의침략03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1002, 1003}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_ririn_Turn");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략04 : TriggerState {
            internal State그림자의침략04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {700, 701, 702, 703}, arg2: false);
                context.SetEffect(arg1: new[] {901}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략05 : TriggerState {
            internal State그림자의침략05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {704, 705, 706, 707}, arg2: false);
                context.SetEffect(arg1: new[] {901}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략06 : TriggerState {
            internal State그림자의침략06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {708, 709, 710, 711}, arg2: false);
                context.SetEffect(arg1: new[] {901}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략07 : TriggerState {
            internal State그림자의침략07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {712, 713, 714, 715}, arg2: false);
                context.SetEffect(arg1: new[] {901}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략08 : TriggerState {
            internal State그림자의침략08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {716, 717, 718, 719}, arg2: false);
                context.SetEffect(arg1: new[] {901}, arg2: true);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State그림자의침략09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_ririn_Turn");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 0.5f);
                context.CreateMonster(arg1: new[] {700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719, 716, 717, 718, 719}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State그림자의침략09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략09 : TriggerState {
            internal State그림자의침략09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {10011}, arg2: 70000109, arg3: 1, arg4: false, arg5: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.ShowGuideSummary(entityId: 25201061, textId: 25201061, duration: 5000);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_ririn_go");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000106_QD__52000106__0$", duration: 6000, delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000106_QD__52000106__1$", duration: 6000, delayTick: 2000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002323}, arg3: new byte[] {2})) {
                    return new State그림자의침략완료01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략완료01 : TriggerState {
            internal State그림자의침략완료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000106_QD__52000106__2$", duration: 6000, delayTick: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State그림자의침략완료02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략완료02 : TriggerState {
            internal State그림자의침략완료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 20, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.DestroyMonster(arg1: new[] {101, 700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715, 716, 717, 718, 719});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State그림자의침략완료03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그림자의침략완료03 : TriggerState {
            internal State그림자의침략완료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.SetOnetimeEffect(id: 20, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.MoveUser(arg1: 52000106, arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002324}, arg3: new byte[] {1})) {
                    return new State할아버지의물품조사01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002324}, arg3: new byte[] {2})) {
                    return new State할아버지의물품조사01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002324}, arg3: new byte[] {3})) {
                    return new State할아버지의물품조사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지의물품조사01 : TriggerState {
            internal State할아버지의물품조사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new[] {200});
                context.ShowGuideSummary(entityId: 25201062, textId: 25201062, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002325}, arg3: new byte[] {2})) {
                    return new State리엔을떠나다01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다01 : TriggerState {
            internal State리엔을떠나다01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "리엔을떠나다09", arg2: "exit");
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_ririn_goodBye_0");
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State리엔을떠나다02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다02 : TriggerState {
            internal State리엔을떠나다02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: false);
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1004, 1005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다03 : TriggerState {
            internal State리엔을떠나다03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003174, msg: "$52000106_QD__52000106__3$", duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new[] {1006, 1007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다04 : TriggerState {
            internal State리엔을떠나다04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003174, msg: "$52000106_QD__52000106__4$", duration: 5000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다05 : TriggerState {
            internal State리엔을떠나다05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1008, 1009}, arg2: false);
                context.AddCinematicTalk(npcId: 11003174, illustId: "Ririn_normal", msg: "$52000106_QD__52000106__5$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State리엔을떠나다06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다06 : TriggerState {
            internal State리엔을떠나다06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003174, illustId: "Ririn_normal", msg: "$52000106_QD__52000106__6$", duration: 4000, align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State리엔을떠나다07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다07 : TriggerState {
            internal State리엔을떠나다07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 40, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State리엔을떠나다08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다08 : TriggerState {
            internal State리엔을떠나다08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.ShowCaption(type: "VerticalCaption", title: "$52000106_QD__52000106__7$", desc: "$52000106_QD__52000106__8$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 10000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다08_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다08_1 : TriggerState {
            internal State리엔을떠나다08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔을떠나다09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔을떠나다09 : TriggerState {
            internal State리엔을떠나다09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000115, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
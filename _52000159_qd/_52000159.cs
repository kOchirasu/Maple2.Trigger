namespace Maple2.Trigger._52000159_qd {
    public static class _52000159 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002735}, arg3: new byte[] {2})) {
                    return new State정리_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002736}, arg3: new byte[] {2})) {
                    return new State정리_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002737}, arg3: new byte[] {2})) {
                    return new State정리_01(context);
                }

                if (context.UserDetected(arg1: new[] {2001}, arg2: 0)) {
                    return new StateWait_01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_1 : TriggerState {
            internal StateWait_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000159, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State어쌔신과거_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_01 : TriggerState {
            internal State어쌔신과거_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State어쌔신과거_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_02 : TriggerState {
            internal State어쌔신과거_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001, 4002, 4003, 4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State어쌔신과거_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_03 : TriggerState {
            internal State어쌔신과거_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.ShowCaption(type: "VerticalCaption", title: "$52000159_QD__52000159__0$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어쌔신과거_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_04 : TriggerState {
            internal State어쌔신과거_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 0, msg: "$52000159_QD__52000159__1$", duration: 4000);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어쌔신과거_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_05 : TriggerState {
            internal State어쌔신과거_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000159_QD__52000159__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52000159_QD__52000159__3$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52000159_QD__52000159__4$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52000159_QD__52000159__5$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State어쌔신과거_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_06 : TriggerState {
            internal State어쌔신과거_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52000159_QD__52000159__6$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52000159_QD__52000159__7$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State어쌔신과거_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신과거_07 : TriggerState {
            internal State어쌔신과거_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000159_QD__52000159__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52000159_QD__52000159__9$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로_01 : TriggerState {
            internal State쉐도클로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.CreateMonster(arg1: new[] {106}, arg2: false);
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.CreateMonster(arg1: new[] {108}, arg2: false);
                context.SetEffect(arg1: new[] {5005}, arg2: true);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetEffect(arg1: new[] {5006}, arg2: true);
                context.MoveUser(arg1: 52000159, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도클로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로_02 : TriggerState {
            internal State쉐도클로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_01 : TriggerState {
            internal State정리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.CreateMonster(arg1: new[] {102, 104, 109, 110, 111, 112, 113}, arg2: false);
                context.DestroyMonster(arg1: new[] {101}, arg2: false);
                context.DestroyMonster(arg1: new[] {103}, arg2: false);
                context.DestroyMonster(arg1: new[] {105}, arg2: false);
                context.DestroyMonster(arg1: new[] {106}, arg2: false);
                context.DestroyMonster(arg1: new[] {107}, arg2: false);
                context.DestroyMonster(arg1: new[] {108}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State밝아짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밝아짐 : TriggerState {
            internal State밝아짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002735}, arg3: new byte[] {2})) {
                    return new State남자의죽음_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002736}, arg3: new byte[] {2})) {
                    return new State남자의죽음_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002737}, arg3: new byte[] {2})) {
                    return new State남자의죽음_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_01 : TriggerState {
            internal State남자의죽음_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_01_02 : TriggerState {
            internal State남자의죽음_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_02 : TriggerState {
            internal State남자의죽음_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State남자의죽음_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_03 : TriggerState {
            internal State남자의죽음_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Attack_01_B");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Dead_B", arg3: 9000000000000f);
                context.SetEffect(arg1: new[] {5007}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_03_01 : TriggerState {
            internal State남자의죽음_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State남자의죽음_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_04 : TriggerState {
            internal State남자의죽음_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102}, arg2: false);
                context.CreateMonster(arg1: new[] {114}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 114, arg2: "Dead_B", arg3: 9000000000000f);
                context.CreateMonster(arg1: new[] {115}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State남자의죽음_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State남자의죽음_05 : TriggerState {
            internal State남자의죽음_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002737}, arg3: new byte[] {2})) {
                    return new State쉐도클로표창_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_01 : TriggerState {
            internal State쉐도클로표창_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로표창_01_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_01_01 : TriggerState {
            internal State쉐도클로표창_01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로표창_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_02 : TriggerState {
            internal State쉐도클로표창_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Attack_Idle_A", arg3: 4000f);
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State쉐도클로표창_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_03 : TriggerState {
            internal State쉐도클로표창_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Attack_01_B", arg3: 80000f);
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.1f, duration: 10.0f, interpolator: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도클로표창_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_03_01 : TriggerState {
            internal State쉐도클로표창_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 115, arg2: "Dead_A", arg3: 80000f);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State쉐도클로표창_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도클로표창_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_04 : TriggerState {
            internal State쉐도클로표창_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도클로표창_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도클로표창_05 : TriggerState {
            internal State쉐도클로표창_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 52000158, arg2: 6001);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
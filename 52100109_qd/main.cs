namespace Maple2.Trigger._52100109_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {91000980}, arg3: new byte[] {1})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetCinematicUI(arg1: 1);
                context.MoveUser(arg1: 52100109, arg2: 2);
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {103});
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State삼자대면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면 : TriggerState {
            internal State삼자대면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005, 4002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State삼자대면_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02 : TriggerState {
            internal State삼자대면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 5000f);
                context.AddCinematicTalk(npcId: 11004614, msg: "$52100109_QD__MAIN__0$", align: "left", illustId: "Eone_normal", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State삼자대면_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_01 : TriggerState {
            internal State삼자대면_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 8500f);
                context.AddCinematicTalk(npcId: 11004616, msg: "$52100109_QD__MAIN__1$", align: "right", illustId: "Bliche_closeEye", duration: 4500);
                context.AddCinematicTalk(npcId: 11004616, msg: "$52100109_QD__MAIN__2$", align: "right", illustId: "Bliche_normal", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new State삼자대면_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_02 : TriggerState {
            internal State삼자대면_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 9000f);
                context.AddCinematicTalk(npcId: 11004614, msg: "$52100109_QD__MAIN__3$", align: "left", illustId: "Eone_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004614, msg: "$52100109_QD__MAIN__4$", align: "left", illustId: "Eone_serious", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State삼자대면_02_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_03 : TriggerState {
            internal State삼자대면_02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 5200f);
                context.AddCinematicTalk(npcId: 11004616, msg: "$52100109_QD__MAIN__5$", align: "right", illustId: "Bliche_normal", duration: 2000);
                context.AddCinematicTalk(npcId: 11004616, msg: "$52100109_QD__MAIN__6$", align: "right", illustId: "Bliche_normal", duration: 3200);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    return new State삼자대면_02_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_04 : TriggerState {
            internal State삼자대면_02_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3200f);
                context.AddCinematicTalk(npcId: 11004614, msg: "$52100109_QD__MAIN__7$", align: "left", illustId: "Eone_closeEye", duration: 3200);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State삼자대면_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03 : TriggerState {
            internal State삼자대면_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 19000f);
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
                context.AddCinematicTalk(npcId: 11004615, msg: "$52100109_QD__MAIN__8$", align: "left", illustId: "siman_normal", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State삼자대면_03_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_00 : TriggerState {
            internal State삼자대면_03_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11004615, msg: "$52100109_QD__MAIN__9$", align: "left", illustId: "siman_normal", duration: 5000);
                context.AddCinematicTalk(npcId: 11004615, msg: "$52100109_QD__MAIN__10$", align: "left", illustId: "siman_normal", duration: 5000);
                context.AddCinematicTalk(npcId: 11004615, msg: "$52100109_QD__MAIN__11$", align: "left", illustId: "siman_normal", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State삼자대면_03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_01 : TriggerState {
            internal State삼자대면_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 5000f);
                context.AddCinematicTalk(npcId: 11004614, msg: "$52100109_QD__MAIN__12$", align: "left", illustId: "Eone_serious", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State삼자대면_03_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_02 : TriggerState {
            internal State삼자대면_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4500f);
                context.AddCinematicTalk(npcId: 11004616, msg: "$52100109_QD__MAIN__13$", align: "right", illustId: "Bliche_closeEye", duration: 4500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State삼자대면_03_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_03 : TriggerState {
            internal State삼자대면_03_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 8500f);
                context.AddCinematicTalk(npcId: 11004614, msg: "$52100109_QD__MAIN__14$", align: "left", illustId: "Eone_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004614, msg: "$52100109_QD__MAIN__15$", align: "left", illustId: "Eone_closeEye", duration: 4500);
                context.AddCinematicTalk(npcId: 11004616, msg: "$52100109_QD__MAIN__16$", align: "right", illustId: "Bliche_closeEye", duration: 2800);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11300)) {
                    return new State삼자대면_03_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_04 : TriggerState {
            internal State삼자대면_03_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4500f);
                context.AddCinematicTalk(npcId: 11004616, msg: "$52100109_QD__MAIN__17$", align: "right", illustId: "Bliche_normal", duration: 4500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State삼자대면_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_04 : TriggerState {
            internal State삼자대면_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3200f);
                context.AddCinematicTalk(npcId: 11004614, msg: "$52100109_QD__MAIN__18$", align: "left", illustId: "Eone_normal", duration: 3200);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new State삼자대면_04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_04_01 : TriggerState {
            internal State삼자대면_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4500f);
                context.AddCinematicTalk(npcId: 11004616, msg: "$52100109_QD__MAIN__19$", align: "right", illustId: "Bliche_normal", duration: 4500);
                context.AddCinematicTalk(npcId: 11004615, msg: "$52100109_QD__MAIN__20$", align: "left", illustId: "siman_normal", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State삼자대면_04_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면_04_02 : TriggerState {
            internal State삼자대면_04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 8000f);
                context.AddCinematicTalk(npcId: 11004614, msg: "$52100109_QD__MAIN__21$", align: "left", illustId: "Eone_smile", duration: 4000);
                context.AddCinematicTalk(npcId: 11004615, msg: "$52100109_QD__MAIN__22$", align: "right", illustId: "siman_normal", duration: 4000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State삼자대면끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼자대면끝 : TriggerState {
            internal State삼자대면끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리 : TriggerState {
            internal State정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103});
                context.VisibleMyPc(isVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetAchievement(arg1: 2001, arg3: "Georg");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
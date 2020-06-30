using System;

namespace Maple2.Trigger._52100109_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {91000980},
                    arg3: new byte[] {1})) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52100109, arg2: 2);
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103});
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State삼자대면(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면 : TriggerState {
            internal State삼자대면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005, 4002}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State삼자대면_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02 : TriggerState {
            internal State삼자대면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 5000f);
                context.AddCinematicTalk(npcID: 11004614, msg: "$52100109_QD__MAIN__0$", align: "left",
                    illustID: "Eone_normal", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State삼자대면_02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_01 : TriggerState {
            internal State삼자대면_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 8500f);
                context.AddCinematicTalk(npcID: 11004616, msg: "$52100109_QD__MAIN__1$", align: "right",
                    illustID: "Bliche_closeEye", duration: 4500);
                context.AddCinematicTalk(npcID: 11004616, msg: "$52100109_QD__MAIN__2$", align: "right",
                    illustID: "Bliche_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    context.State = new State삼자대면_02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_02 : TriggerState {
            internal State삼자대면_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 9000f);
                context.AddCinematicTalk(npcID: 11004614, msg: "$52100109_QD__MAIN__3$", align: "left",
                    illustID: "Eone_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004614, msg: "$52100109_QD__MAIN__4$", align: "left",
                    illustID: "Eone_serious", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State삼자대면_02_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_03 : TriggerState {
            internal State삼자대면_02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 5200f);
                context.AddCinematicTalk(npcID: 11004616, msg: "$52100109_QD__MAIN__5$", align: "right",
                    illustID: "Bliche_normal", duration: 2000);
                context.AddCinematicTalk(npcID: 11004616, msg: "$52100109_QD__MAIN__6$", align: "right",
                    illustID: "Bliche_normal", duration: 3200);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    context.State = new State삼자대면_02_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_02_04 : TriggerState {
            internal State삼자대면_02_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3200f);
                context.AddCinematicTalk(npcID: 11004614, msg: "$52100109_QD__MAIN__7$", align: "left",
                    illustID: "Eone_closeEye", duration: 3200);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    context.State = new State삼자대면_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03 : TriggerState {
            internal State삼자대면_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 19000f);
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004615, msg: "$52100109_QD__MAIN__8$", align: "left",
                    illustID: "siman_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State삼자대면_03_00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_00 : TriggerState {
            internal State삼자대면_03_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004615, msg: "$52100109_QD__MAIN__9$", align: "left",
                    illustID: "siman_normal", duration: 5000);
                context.AddCinematicTalk(npcID: 11004615, msg: "$52100109_QD__MAIN__10$", align: "left",
                    illustID: "siman_normal", duration: 5000);
                context.AddCinematicTalk(npcID: 11004615, msg: "$52100109_QD__MAIN__11$", align: "left",
                    illustID: "siman_normal", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State삼자대면_03_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_01 : TriggerState {
            internal State삼자대면_03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 5000f);
                context.AddCinematicTalk(npcID: 11004614, msg: "$52100109_QD__MAIN__12$", align: "left",
                    illustID: "Eone_serious", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State삼자대면_03_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_02 : TriggerState {
            internal State삼자대면_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4500f);
                context.AddCinematicTalk(npcID: 11004616, msg: "$52100109_QD__MAIN__13$", align: "right",
                    illustID: "Bliche_closeEye", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State삼자대면_03_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_03 : TriggerState {
            internal State삼자대면_03_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 8500f);
                context.AddCinematicTalk(npcID: 11004614, msg: "$52100109_QD__MAIN__14$", align: "left",
                    illustID: "Eone_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004614, msg: "$52100109_QD__MAIN__15$", align: "left",
                    illustID: "Eone_closeEye", duration: 4500);
                context.AddCinematicTalk(npcID: 11004616, msg: "$52100109_QD__MAIN__16$", align: "right",
                    illustID: "Bliche_closeEye", duration: 2800);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11300)) {
                    context.State = new State삼자대면_03_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_03_04 : TriggerState {
            internal State삼자대면_03_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4500f);
                context.AddCinematicTalk(npcID: 11004616, msg: "$52100109_QD__MAIN__17$", align: "right",
                    illustID: "Bliche_normal", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State삼자대면_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_04 : TriggerState {
            internal State삼자대면_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3200f);
                context.AddCinematicTalk(npcID: 11004614, msg: "$52100109_QD__MAIN__18$", align: "left",
                    illustID: "Eone_normal", duration: 3200);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    context.State = new State삼자대면_04_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_04_01 : TriggerState {
            internal State삼자대면_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4500f);
                context.AddCinematicTalk(npcID: 11004616, msg: "$52100109_QD__MAIN__19$", align: "right",
                    illustID: "Bliche_normal", duration: 4500);
                context.AddCinematicTalk(npcID: 11004615, msg: "$52100109_QD__MAIN__20$", align: "left",
                    illustID: "siman_normal", duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new State삼자대면_04_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면_04_02 : TriggerState {
            internal State삼자대면_04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 8000f);
                context.AddCinematicTalk(npcID: 11004614, msg: "$52100109_QD__MAIN__21$", align: "left",
                    illustID: "Eone_smile", duration: 4000);
                context.AddCinematicTalk(npcID: 11004615, msg: "$52100109_QD__MAIN__22$", align: "right",
                    illustID: "siman_normal", duration: 4000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State삼자대면끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State정리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State삼자대면끝 : TriggerState {
            internal State삼자대면끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State정리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리 : TriggerState {
            internal State정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {103});
                context.VisibleMyPc(isVisible: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State정리_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 2001, arg3: "Georg");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
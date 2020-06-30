using System;

namespace Maple2.Trigger._52000195_qd {
    public static class _52000195 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003407},
                    arg3: new byte[] {1})) {
                    context.State = new StateCameraEffect01(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003407},
                    arg3: new byte[] {1})) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraEffect02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {204});
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000195, arg2: 5001);
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 1);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_3 : TriggerState {
            internal StateCameraEffect03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.ShowCaption(type: "VerticalCaption", title: "$52000195_QD__52000195__0$", align: "bottomLeft",
                    offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCameraEffect03_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_4 : TriggerState {
            internal StateCameraEffect03_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_5 : TriggerState {
            internal StateCameraEffect03_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new int[] {204});
                context.VisibleMyPc(isVisible: true);
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser,HighlightGameMenu",
                    visible: false);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_6 : TriggerState {
            internal StateCameraEffect03_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_7 : TriggerState {
            internal StateCameraEffect03_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11001302, msg: "$52000195_QD__52000195__1$", align: "left",
                    illustID: "Ereb_surprise", duration: 3000);
                context.AddCinematicTalk(npcID: 11001302, msg: "$52000195_QD__52000195__2$", align: "left",
                    illustID: "Ereb_serious", duration: 3000);
                context.AddCinematicTalk(npcID: 11001302, msg: "$52000195_QD__52000195__3$", align: "left",
                    illustID: "Ereb_serious", duration: 3000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateCameraEffect03_8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new int[] {204});
                context.VisibleMyPc(isVisible: true);
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser,HighlightGameMenu",
                    visible: false);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_8 : TriggerState {
            internal StateCameraEffect03_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "2002")) {
                    context.State = new State과거장면_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_01 : TriggerState {
            internal State과거장면_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State과거장면_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_02 : TriggerState {
            internal State과거장면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: 0);
                context.CreateMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {202});
                context.CreateMonster(arg1: new int[] {203});
                context.RemoveBuff(arg1: 2002, arg2: 99910402);
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State과거장면_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_03 : TriggerState {
            internal State과거장면_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State과거장면_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_05 : TriggerState {
            internal State과거장면_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4006}, arg2: 0);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000195_QD__52000195__4$", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State과거장면_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_06 : TriggerState {
            internal State과거장면_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4007}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Talk_A", arg3: 8000f);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000195_QD__52000195__5$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000195_QD__52000195__6$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State과거장면_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_07 : TriggerState {
            internal State과거장면_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcID: 11004787, msg: "$52000195_QD__52000195__7$", align: "right",
                    illustID: "Baron_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State과거장면_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_08 : TriggerState {
            internal State과거장면_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4006}, arg2: 0);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_3001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State과거장면_08_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_08_1 : TriggerState {
            internal State과거장면_08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcID: 11004778, msg: "$52000195_QD__52000195__8$", align: "right",
                    illustID: "Karl_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State과거장면_08_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_08_2 : TriggerState {
            internal State과거장면_08_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {202});
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State과거장면_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_09 : TriggerState {
            internal State과거장면_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Bore_B");
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000195_QD__52000195__9$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State과거장면_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State과거장면_10 : TriggerState {
            internal State과거장면_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000195_QD__52000195__10$", illustID: "Ereb_surprise",
                    duration: 4000);
                context.AddCinematicTalk(npcID: 11004785, msg: "$52000195_QD__52000195__11$", illustID: "Ereb_surprise",
                    duration: 4000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State업적달성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State업적달성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State업적달성 : TriggerState {
            internal State업적달성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2002, arg3: "DreamofEreb");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000193, arg2: 5001);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
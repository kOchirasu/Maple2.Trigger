using System;

namespace Maple2.Trigger._52000087_qd {
    public static class _52000087 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {22651}, arg2: new int[] {10003370},
                    arg3: new byte[] {2})) {
                    context.State = new State보고시작준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보고시작준비_01 : TriggerState {
            internal State보고시작준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000087, arg2: 6001);
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보고시작준비_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보고시작준비_02 : TriggerState {
            internal State보고시작준비_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new State보고시작준비_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보고시작준비_03 : TriggerState {
            internal State보고시작준비_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 5000f);
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State보고시작준비_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보고시작준비_04 : TriggerState {
            internal State보고시작준비_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State보고시작_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보고시작_01 : TriggerState {
            internal State보고시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000087_QD__52000087__0$");
                context.MoveUser(arg1: 52000087, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
                context.PlaySceneMovie(fileName: "Kritias_EpicCutScene_second_01.swf", movieID: 1);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.WaitTick(waitTick: 35000)) {
                    context.State = new StateQuit(context);
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
                context.MoveUser(arg1: 52000087, arg2: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
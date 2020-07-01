using System;

namespace Maple2.Trigger._52000160_qd {
    public static class _52000160 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002742},
                    arg3: new byte[] {3})) {
                    context.State = new State떠난다_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002743},
                    arg3: new byte[] {3})) {
                    context.State = new State프론티아재단으로_01(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {2001}, arg2: 0)) {
                    context.State = new State전직컷씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직컷씬01 : TriggerState {
            internal State전직컷씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChange_Assassin.swf", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State다크윈드도착_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State다크윈드도착_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다크윈드도착_01 : TriggerState {
            internal State다크윈드도착_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State다크윈드도착_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다크윈드도착_02 : TriggerState {
            internal State다크윈드도착_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State다크윈드도착_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다크윈드도착_03 : TriggerState {
            internal State다크윈드도착_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State다크윈드도착_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다크윈드도착_04 : TriggerState {
            internal State다크윈드도착_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001, 4002}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State다크윈드도착_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다크윈드도착_05 : TriggerState {
            internal State다크윈드도착_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State다크윈드도착_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다크윈드도착_06 : TriggerState {
            internal State다크윈드도착_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State다크윈드도착_07(context);
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
                    context.State = new State다크윈드도착_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다크윈드도착_07 : TriggerState {
            internal State다크윈드도착_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전직한다(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직한다 : TriggerState {
            internal State전직한다(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002742},
                    arg3: new byte[] {2})) {
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
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State떠난다_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State떠난다_01 : TriggerState {
            internal State떠난다_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002743},
                    arg3: new byte[] {3})) {
                    context.State = new State프론티아재단으로_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_01 : TriggerState {
            internal State프론티아재단으로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State프론티아재단으로_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_02 : TriggerState {
            internal State프론티아재단으로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000186, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
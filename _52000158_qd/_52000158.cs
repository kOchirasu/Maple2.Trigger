using System;

namespace Maple2.Trigger._52000158_qd {
    public static class _52000158 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002736},
                    arg3: new byte[] {3})) {
                    context.State = new State돌아왔다준비_01(context);
                    return;
                }

                if (context.UserDetected(arg1: "2001", arg2: 0)) {
                    context.State = new Statewait_01_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_1 : TriggerState {
            internal Statewait_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000158, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewait_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_02 : TriggerState {
            internal Statewait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State커닝시티전경_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 85000)) {
                    context.State = new State커닝시티전경_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경_01 : TriggerState {
            internal State커닝시티전경_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State커닝시티전경_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경_02 : TriggerState {
            internal State커닝시티전경_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001, 4002}, arg2: 0);
                context.ShowCaption(type: "VerticalCaption", title: "$52000158_QD__52000158__0$",
                    desc: "$52000158_QD__52000158__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State어쌔신_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어쌔신_01 : TriggerState {
            internal State어쌔신_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State암전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateUI초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateUI초기화 : TriggerState {
            internal StateUI초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State밝아짐(context);
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
                    context.State = new State밝아짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State밝아짐 : TriggerState {
            internal State밝아짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
                context.CreateMonster(arg1: new int[] {101}, agr2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002733},
                    arg3: new byte[] {3})) {
                    context.State = new State이동_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002732},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트가이드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트가이드 : TriggerState {
            internal State퀘스트가이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 25201581, textID: 25201581, durationTime: 10000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002734},
                    arg3: new byte[] {2})) {
                    context.State = new State이동_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동_01 : TriggerState {
            internal State이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동_02 : TriggerState {
            internal State이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000159, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State돌아왔다준비_01 : TriggerState {
            internal State돌아왔다준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State돌아왔다_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State돌아왔다_01 : TriggerState {
            internal State돌아왔다_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State돌아왔다_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State돌아왔다_02 : TriggerState {
            internal State돌아왔다_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000158, arg2: 6001);
                context.CreateMonster(arg1: new int[] {102}, agr2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002741},
                    arg3: new byte[] {2})) {
                    context.State = new State이동2_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동2_01 : TriggerState {
            internal State이동2_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State이동2_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동2_02 : TriggerState {
            internal State이동2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000160, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
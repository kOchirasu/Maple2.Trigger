using System;

namespace Maple2.Trigger._52000155_qd {
    public static class _52000155 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001, 5002}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {40002728},
                    arg3: new byte[] {3})) {
                    context.State = new State전직하러_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {40002725},
                    arg3: new byte[] {3})) {
                    context.State = new State가이드_01(context);
                    return;
                }

                if (context.UserDetected(arg1: "2002")) {
                    context.State = new Statewait_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_02 : TriggerState {
            internal Statewait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewait_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_03 : TriggerState {
            internal Statewait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {108}, arg2: false);
                context.CreateMonster(arg1: new int[] {109}, arg2: false);
                context.CreateMonster(arg1: new int[] {110}, arg2: false);
                context.MoveUser(arg1: 52000155, arg2: 6001);
                context.CameraSelectPath(arg1: new int[] {4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State빅스제시_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State빅스제시_01 : TriggerState {
            internal State빅스제시_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State정리_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리_01 : TriggerState {
            internal State정리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State정리_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {40002725},
                    arg3: new byte[] {2})) {
                    context.State = new State만취상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State만취상태 : TriggerState {
            internal State만취상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000155_QD__52000155__0$", arg3: false);
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State만취상태_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State만취상태_01 : TriggerState {
            internal State만취상태_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
                context.CreateMonster(arg1: new int[] {106}, arg2: false);
                context.DestroyMonster(arg1: new int[] {108});
                context.DestroyMonster(arg1: new int[] {109});
                context.SetNpcEmotionLoop(arg1: 105, arg2: "Down_Idle_A", arg3: 90000000f);
                context.SetNpcEmotionLoop(arg1: 106, arg2: "Down_Idle_A", arg3: 90000000f);
                context.MoveUser(arg1: 52000155, arg2: 6002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State정리2_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리2_02 : TriggerState {
            internal State정리2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State정리2_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리2_03 : TriggerState {
            internal State정리2_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {40002726},
                    arg3: new byte[] {2})) {
                    context.State = new State가이드_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드_01 : TriggerState {
            internal State가이드_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001, 5002}, arg2: true);
                context.DestroyMonster(arg1: new int[] {110});
                context.CreateMonster(arg1: new int[] {107}, arg2: false);
                context.ShowGuideSummary(entityID: 25201551, textID: 25201551, duration: 10000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {40002727},
                    arg3: new byte[] {2})) {
                    context.State = new State가이드_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드_02 : TriggerState {
            internal State가이드_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001, 5002}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {40002728},
                    arg3: new byte[] {2})) {
                    context.State = new State전직하러_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직하러_01 : TriggerState {
            internal State전직하러_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전직하러_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직하러_02 : TriggerState {
            internal State전직하러_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000157, arg2: 6003);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
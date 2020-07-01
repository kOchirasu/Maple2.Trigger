using System;

namespace Maple2.Trigger._52010070_qd {
    public static class _52010070 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2001}, arg2: 0)) {
                    context.State = new State엔피씨스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔피씨스폰 : TriggerState {
            internal State엔피씨스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.CreateMonster(arg1: new int[] {107}, arg2: false);
                context.CreateMonster(arg1: new int[] {109}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100800},
                    arg3: new byte[] {2})) {
                    context.State = new State룬블즈_일어남(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100790},
                    arg3: new byte[] {2})) {
                    context.State = new State룬블즈_일어남(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100790},
                    arg3: new byte[] {3})) {
                    context.State = new State룬블즈_일어남(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남 : TriggerState {
            internal State룬블즈_일어남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: false);
                context.MoveUser(arg1: 52010070, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State룬블즈_일어남_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_02 : TriggerState {
            internal State룬블즈_일어남_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State룬블즈_일어남_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_03 : TriggerState {
            internal State룬블즈_일어남_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 109, arg2: "Attack_Idle_A", arg3: 4000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State룬블즈_일어남_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_04 : TriggerState {
            internal State룬블즈_일어남_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 107, arg2: "Bore_A", arg3: 4000f);
                context.SetNpcEmotionLoop(arg1: 109, arg2: "Attack_01_A", arg3: 4000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State룬블즈_일어남_04_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_04_01 : TriggerState {
            internal State룬블즈_일어남_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.5f, duration: 5.0f, interpolator: 1);
                context.SetNpcEmotionLoop(arg1: 109, arg2: "Attack_Idle_A", arg3: 4000f);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State룬블즈_일어남_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State룬블즈_일어남_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_05 : TriggerState {
            internal State룬블즈_일어남_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 30, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State룬블즈_일어남_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_07 : TriggerState {
            internal State룬블즈_일어남_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: false);
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
                context.CreateMonster(arg1: new int[] {106}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101}, arg2: false);
                context.DestroyMonster(arg1: new int[] {102}, arg2: false);
                context.DestroyMonster(arg1: new int[] {103}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State룬블즈_일어남_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_08 : TriggerState {
            internal State룬블즈_일어남_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State룬블즈_일어남_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_09 : TriggerState {
            internal State룬블즈_일어남_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State룬블즈_일어남_09_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_09_01 : TriggerState {
            internal State룬블즈_일어남_09_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State룬블즈_일어남_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 30, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State룬블즈_일어남_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_10 : TriggerState {
            internal State룬블즈_일어남_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100790},
                    arg3: new byte[] {3})) {
                    context.State = new State홀슈타트로바꾸기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트로바꾸기 : TriggerState {
            internal State홀슈타트로바꾸기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {108}, arg2: false);
                context.DestroyMonster(arg1: new int[] {109}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100800},
                    arg3: new byte[] {2})) {
                    context.State = new State에레브흑화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브흑화 : TriggerState {
            internal State에레브흑화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에레브흑화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_02 : TriggerState {
            internal State에레브흑화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에레브흑화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_03 : TriggerState {
            internal State에레브흑화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에레브흑화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_04 : TriggerState {
            internal State에레브흑화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52010070, arg2: 6001);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcID: 11004128, align: "left", illustID: "Ishura_normal",
                    msg: "$52010070_QD__52010070__0$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004191, align: "left", illustID: "11004022",
                    msg: "$52010070_QD__52010070__1$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004128, align: "left", illustID: "Ishura_normal",
                    msg: "$52010070_QD__52010070__2$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new State에레브흑화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_05 : TriggerState {
            internal State에레브흑화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "ProphecyofFall.swf", movieID: 1);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State에레브흑화_06(context);
                    return;
                }

                if (context.WaitTick(waitTick: 85000)) {
                    context.State = new State에레브흑화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에레브흑화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_06 : TriggerState {
            internal State에레브흑화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {50100800},
                    arg3: new byte[] {3})) {
                    context.State = new State이동시키기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동시키기 : TriggerState {
            internal State이동시키기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010072, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010070_qd {
    public static class _52010070 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {2001}, arg2: 0)) {
                    return new State엔피씨Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엔피씨Spawn : TriggerState {
            internal State엔피씨Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 107, 109}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100800}, arg3: new byte[] {2})) {
                    return new State룬블즈_일어남(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100790}, arg3: new byte[] {2})) {
                    return new State룬블즈_일어남(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100790}, arg3: new byte[] {3})) {
                    return new State룬블즈_일어남(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남 : TriggerState {
            internal State룬블즈_일어남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.CameraSelectPath(pathIds: new[] {4004}, arg2: false);
                context.MoveUser(arg1: 52010070, arg2: 6001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State룬블즈_일어남_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_02 : TriggerState {
            internal State룬블즈_일어남_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State룬블즈_일어남_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_03 : TriggerState {
            internal State룬블즈_일어남_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 109, arg2: "Attack_Idle_A", arg3: 4000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State룬블즈_일어남_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_04 : TriggerState {
            internal State룬블즈_일어남_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4003}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 107, arg2: "Bore_A", arg3: 4000f);
                context.SetNpcEmotionLoop(arg1: 109, arg2: "Attack_01_A", arg3: 4000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State룬블즈_일어남_04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_04_01 : TriggerState {
            internal State룬블즈_일어남_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.5f, duration: 5.0f, interpolator: 1);
                context.SetNpcEmotionLoop(arg1: 109, arg2: "Attack_Idle_A", arg3: 4000f);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State룬블즈_일어남_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State룬블즈_일어남_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_05 : TriggerState {
            internal State룬블즈_일어남_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State룬블즈_일어남_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_07 : TriggerState {
            internal State룬블즈_일어남_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new[] {4001}, arg2: false);
                context.CreateMonster(arg1: new[] {104, 105, 106}, arg2: false);
                context.DestroyMonster(arg1: new[] {101}, arg2: false);
                context.DestroyMonster(arg1: new[] {102}, arg2: false);
                context.DestroyMonster(arg1: new[] {103}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State룬블즈_일어남_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_08 : TriggerState {
            internal State룬블즈_일어남_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State룬블즈_일어남_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_09 : TriggerState {
            internal State룬블즈_일어남_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State룬블즈_일어남_09_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_09_01 : TriggerState {
            internal State룬블즈_일어남_09_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State룬블즈_일어남_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State룬블즈_일어남_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State룬블즈_일어남_10 : TriggerState {
            internal State룬블즈_일어남_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100790}, arg3: new byte[] {3})) {
                    return new State홀슈타트로바꾸기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State홀슈타트로바꾸기 : TriggerState {
            internal State홀슈타트로바꾸기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {108}, arg2: false);
                context.DestroyMonster(arg1: new[] {109}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100800}, arg3: new byte[] {2})) {
                    return new State에레브흑화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브흑화 : TriggerState {
            internal State에레브흑화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StateSkip_3(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에레브흑화_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_02 : TriggerState {
            internal State에레브흑화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new[] {4005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에레브흑화_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_03 : TriggerState {
            internal State에레브흑화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에레브흑화_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_04 : TriggerState {
            internal State에레브흑화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(arg1: 52010070, arg2: 6001);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11004128, align: Align.Left, illustId: "Ishura_normal", script: "$52010070_QD__52010070__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004191, align: Align.Left, illustId: "11004022", script: "$52010070_QD__52010070__1$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004128, align: Align.Left, illustId: "Ishura_normal", script: "$52010070_QD__52010070__2$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State에레브흑화_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_05 : TriggerState {
            internal State에레브흑화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "ProphecyofFall.swf", movieId: 1);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, arg2: "IsStop", arg3: "1")) {
                    return new State에레브흑화_06(context);
                }

                if (context.WaitTick(waitTick: 85000)) {
                    return new State에레브흑화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에레브흑화_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브흑화_06 : TriggerState {
            internal State에레브흑화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {50100800}, arg3: new byte[] {3})) {
                    return new State이동시키기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동시키기 : TriggerState {
            internal State이동시키기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010072, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
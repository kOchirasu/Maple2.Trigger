using System.Numerics;

namespace Maple2.Trigger._52100108_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000360}, arg3: new byte[] {1})) {
                    return new StateWait_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(arg1: new[] {6000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_03 : TriggerState {
            internal StateWait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.MoveUser(arg1: 52100108, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State들어왔다(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State들어왔다 : TriggerState {
            internal State들어왔다(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {4001, 4002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State들어왔다_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State들어왔다_02 : TriggerState {
            internal State들어왔다_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4006, 4005}, arg2: false);
                context.SetCinematicUI(arg1: 3);
                context.AddCinematicTalk(npcId: 0, msg: "$52100108_QD__MAIN__0$", duration: 3000);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State들어왔다_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State들어왔다_03 : TriggerState {
            internal State들어왔다_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004, 4003}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52100108_QD__MAIN__1$", duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State제어기기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제어기기 : TriggerState {
            internal State제어기기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52100108_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52100108_QD__MAIN__3$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State들킴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State들킴 : TriggerState {
            internal State들킴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(arg1: new Vector3(41f, 21f, 18f), arg2: new Vector3(130f, 130f, 130f));
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_On");
                context.AddCinematicTalk(npcId: 0, msg: "$52100108_QD__MAIN__4$", duration: 3500);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State들킴_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State들킴_02 : TriggerState {
            internal State들킴_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.AddCinematicTalk(npcId: 25022107, msg: "$52100108_QD__MAIN__5$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, msg: "$52100108_QD__MAIN__6$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State들킴_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State들킴_03 : TriggerState {
            internal State들킴_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.AddCinematicTalk(npcId: 0, msg: "$52100108_QD__MAIN__7$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State정리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetAmbientLight(arg1: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(arg1: new Vector3(41f, 21f, 18f), arg2: new Vector3(130f, 130f, 130f));
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_On");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_01 : TriggerState {
            internal State정리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
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
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State경보끝_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보끝_01 : TriggerState {
            internal State경보끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: false);
                context.SetAmbientLight(arg1: new Vector3(131f, 160f, 209f));
                context.SetDirectionalLight(arg1: new Vector3(134f, 160f, 143f), arg2: new Vector3(130f, 130f, 130f));
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 203, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 204, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 205, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 206, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 207, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 208, arg2: true, arg3: "sf_quest_light_A01_Off");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
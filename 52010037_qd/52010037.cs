using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010037_qd {
    public static class _52010037 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208}, arg2: false);
                context.SetActor(arg1: 501, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 502, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 503, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 504, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 505, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 506, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 507, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 508, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 509, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 510, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 511, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 512, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 513, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 514, arg2: true, arg3: "sf_quest_light_A01_Off");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000003}, arg3: new byte[] {2})) {
                    return new State지하기지전경씬01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000013}, arg3: new byte[] {1})) {
                    context.MoveUser(arg1: 52010038, arg2: 1);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000013}, arg3: new byte[] {2})) {
                    context.MoveUser(arg1: 52010039, arg2: 1);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000004}, arg3: new byte[] {2})) {
                    context.CreateMonster(arg1: new[] {200}, arg2: false);
                    return new State블리체와대장들이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000010}, arg3: new byte[] {3})) {
                    return new State긴급상황발동01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000004}, arg3: new byte[] {3})) {
                    context.CreateMonster(arg1: new[] {200}, arg2: false);
                    return new State블리체와대장들이동(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000003}, arg3: new byte[] {3})) {
                    return new State블리체함장Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하기지전경씬01 : TriggerState {
            internal State지하기지전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State지하기지전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하기지전경씬02 : TriggerState {
            internal State지하기지전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuit01(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new[] {3000, 3001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State지하기지전경씬02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하기지전경씬02_b : TriggerState {
            internal State지하기지전경씬02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {3002, 3003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State지하기지전경씬02_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하기지전경씬02_c : TriggerState {
            internal State지하기지전경씬02_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {3004, 3005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State지하기지전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하기지전경씬03 : TriggerState {
            internal State지하기지전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010037_QD__52010037__0$", script: "$52010037_QD__52010037__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
                context.CameraSelectPath(pathIds: new[] {3006, 3007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State지하기지전경씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하기지전경씬04 : TriggerState {
            internal State지하기지전경씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000003}, arg3: new byte[] {3})) {
                    return new State블리체함장Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블리체함장Spawn : TriggerState {
            internal State블리체함장Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_bliche_come");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000004}, arg3: new byte[] {2})) {
                    return new State블리체와대장들이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블리체와대장들이동 : TriggerState {
            internal State블리체와대장들이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_bliche_go");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_blackEye");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_alon");
                context.MoveNpc(arg1: 207, arg2: "MS2PatrolData_pray");
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData_oscal");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000010}, arg3: new byte[] {3})) {
                    return new State긴급상황발동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State긴급상황발동01 : TriggerState {
            internal State긴급상황발동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9010, arg2: true);
                context.SetAmbientLight(arg1: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(arg1: new Vector3(41f, 21f, 18f), arg2: new Vector3(130f, 130f, 130f));
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetActor(arg1: 501, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 502, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 503, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 504, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 505, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 506, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 507, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 508, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 509, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 510, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 511, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 512, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 513, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 514, arg2: true, arg3: "sf_quest_light_A01_On");
                context.DestroyMonster(arg1: new[] {204, 200});
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_conder_come");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_shatten_come");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State긴급상황발동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State긴급상황발동02 : TriggerState {
            internal State긴급상황발동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(arg1: new[] {209, 210}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
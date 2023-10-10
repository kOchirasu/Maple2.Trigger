using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010037_qd {
    public static class _52010037 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208}, arg2: false);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 502, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 503, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 504, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 505, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 506, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 507, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 508, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 509, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 510, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 511, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 512, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 513, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 514, visible: true, initialSequence: "sf_quest_light_A01_Off");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000003}, questStates: new byte[]{2})) {
                    return new State지하기지전경씬01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000013}, questStates: new byte[]{1})) {
                    context.MoveUser(mapId: 52010038, portalId: 1);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000013}, questStates: new byte[]{2})) {
                    context.MoveUser(mapId: 52010039, portalId: 1);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000004}, questStates: new byte[]{2})) {
                    context.CreateMonster(spawnIds: new []{200}, arg2: false);
                    return new State블리체와대장들이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000010}, questStates: new byte[]{3})) {
                    return new State긴급상황발동01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000004}, questStates: new byte[]{3})) {
                    context.CreateMonster(spawnIds: new []{200}, arg2: false);
                    return new State블리체와대장들이동(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000003}, questStates: new byte[]{3})) {
                    return new State블리체함장Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State지하기지전경씬01 : TriggerState {
            internal State지하기지전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{3000, 3001}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{3002, 3003}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{3004, 3005}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{3006, 3007}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000003}, questStates: new byte[]{3})) {
                    return new State블리체함장Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블리체함장Spawn : TriggerState {
            internal State블리체함장Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_bliche_come");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000004}, questStates: new byte[]{2})) {
                    return new State블리체와대장들이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블리체와대장들이동 : TriggerState {
            internal State블리체와대장들이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_bliche_go");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_blackEye");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_alon");
                context.MoveNpc(spawnId: 207, patrolName: "MS2PatrolData_pray");
                context.MoveNpc(spawnId: 208, patrolName: "MS2PatrolData_oscal");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000010}, questStates: new byte[]{3})) {
                    return new State긴급상황발동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State긴급상황발동01 : TriggerState {
            internal State긴급상황발동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 9010, enabled: true);
                context.SetAmbientLight(color: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(diffuseColor: new Vector3(41f, 21f, 18f), specularColor: new Vector3(130f, 130f, 130f));
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetActor(triggerId: 501, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 502, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 503, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 504, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 505, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 506, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 507, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 508, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 509, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 510, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 511, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 512, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 513, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 514, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.DestroyMonster(spawnIds: new []{204, 200});
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_conder_come");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_shatten_come");
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(spawnIds: new []{209, 210}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

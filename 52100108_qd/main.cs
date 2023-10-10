using System.Numerics;

namespace Maple2.Trigger._52100108_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000360}, questStates: new byte[]{1})) {
                    return new StateWait_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(triggerIds: new []{6000}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52100108, portalId: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4006, 4005}, returnView: false);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52100108_QD__MAIN__0$", duration: 3000);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4004, 4003}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52100108_QD__MAIN__1$", duration: 5000);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52100108_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52100108_QD__MAIN__3$", duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.SetAmbientLight(color: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(diffuseColor: new Vector3(41f, 21f, 18f), specularColor: new Vector3(130f, 130f, 130f));
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 202, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 204, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 206, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 208, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.AddCinematicTalk(npcId: 0, script: "$52100108_QD__MAIN__4$", duration: 3500);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.AddCinematicTalk(npcId: 25022107, script: "$52100108_QD__MAIN__5$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52100108_QD__MAIN__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52100108_QD__MAIN__7$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetEffect(triggerIds: new []{6000}, visible: false);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetAmbientLight(color: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(diffuseColor: new Vector3(41f, 21f, 18f), specularColor: new Vector3(130f, 130f, 130f));
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 202, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 204, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 206, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 208, visible: true, initialSequence: "sf_quest_light_A01_On");
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State경보끝_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보끝_01 : TriggerState {
            internal State경보끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: false);
                context.SetAmbientLight(color: new Vector3(131f, 160f, 209f));
                context.SetDirectionalLight(diffuseColor: new Vector3(134f, 160f, 143f), specularColor: new Vector3(130f, 130f, 130f));
                context.SetActor(triggerId: 201, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 202, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 203, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 204, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 205, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 206, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 207, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 208, visible: true, initialSequence: "sf_quest_light_A01_Off");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

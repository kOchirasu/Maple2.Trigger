using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020040_qd {
    public static class _52020040 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001})) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
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
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52020040, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State크리티아스로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크리티아스로 : TriggerState {
            internal State크리티아스로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State크리티아스로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크리티아스로_02 : TriggerState {
            internal State크리티아스로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003, 4004, 4005}, returnView: false);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_B", duration: 99999999999f);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_normal", align: Align.Left, script: "$52020040_QD__52020040__0$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_smile", align: Align.Right, script: "$52020040_QD__52020040__1$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_normal", align: Align.Left, script: "$52020040_QD__52020040__2$", duration: 3000);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State크리티아스로_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크리티아스로_02_01 : TriggerState {
            internal State크리티아스로_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006}, returnView: false);
                context.ShowCaption(type: CaptionType.Horizontal, title: "$52020040_QD__52020040__3$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State크리티아스로_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크리티아스로_03 : TriggerState {
            internal State크리티아스로_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.AddCinematicTalk(npcId: 11004436, illustId: "Schatten_smile", align: Align.Left, script: "$52020040_QD__52020040__4$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004438, illustId: "Mason_closeEye", align: Align.Right, script: "$52020040_QD__52020040__5$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004435, illustId: "Conder_smile", align: Align.Left, script: "$52020040_QD__52020040__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State크리티아스로_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크리티아스로_04 : TriggerState {
            internal State크리티아스로_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(232f, 92f, 53f));
                context.SetDirectionalLight(diffuseColor: new Vector3(41f, 21f, 18f), specularColor: new Vector3(130f, 130f, 130f));
                context.AddCinematicTalk(npcId: 11004435, illustId: "Conder_normal", align: Align.Left, script: "$52020040_QD__52020040__7$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State경보(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
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
                if (context.WaitTick(waitTick: 1000)) {
                    return new State경보_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보_01 : TriggerState {
            internal State경보_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_surprise", align: Align.Left, script: "$52020040_QD__52020040__8$", duration: 2500);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_surprise", align: Align.Left, script: "$52020040_QD__52020040__9$", duration: 2800);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_normal", align: Align.Right, script: "$52020040_QD__52020040__10$", duration: 2800);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_surprise", align: Align.Left, script: "$52020040_QD__52020040__11$", duration: 2800);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_normal", align: Align.Right, script: "$52020040_QD__52020040__12$", duration: 2400);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_surprise", align: Align.Left, script: "$52020040_QD__52020040__13$", duration: 2800);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_mad", align: Align.Right, script: "$52020040_QD__52020040__14$", duration: 2800);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_surprise", align: Align.Left, script: "$52020040_QD__52020040__15$", duration: 2400);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 21300)) {
                    return new State경보_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보_02 : TriggerState {
            internal State경보_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009, 4010}, returnView: false);
                context.SetEffect(triggerIds: new []{6000}, visible: false);
                context.AddCinematicTalk(npcId: 11004440, script: "$52020040_QD__52020040__16$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004440, script: "$52020040_QD__52020040__17$", duration: 5000);
                context.AddCinematicTalk(npcId: 11004440, script: "$52020040_QD__52020040__18$", duration: 2600);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10200)) {
                    return new State경보끝_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보끝_01 : TriggerState {
            internal State경보끝_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
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
                context.AddCinematicTalk(npcId: 11004435, illustId: "Conder_normal", align: Align.Right, script: "$52020040_QD__52020040__19$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State경보끝_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보끝_02_01 : TriggerState {
            internal State경보끝_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State경보끝_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보끝_02_02 : TriggerState {
            internal State경보끝_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State경보끝_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보끝_02 : TriggerState {
            internal State경보끝_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4012}, returnView: false);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_surprise", align: Align.Left, script: "$52020040_QD__52020040__20$", duration: 2800);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_surprise", align: Align.Left, script: "$52020040_QD__52020040__21$", duration: 2800);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_surprise", align: Align.Left, script: "$52020040_QD__52020040__22$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_normal", align: Align.Right, script: "$52020040_QD__52020040__23$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_normal", align: Align.Right, script: "$52020040_QD__52020040__24$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_surprise", align: Align.Left, script: "$52020040_QD__52020040__25$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004435, illustId: "Conder_normal", align: Align.Right, script: "$52020040_QD__52020040__26$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004436, illustId: "Schatten_surprise", align: Align.Left, script: "$52020040_QD__52020040__27$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004435, illustId: "Conder_normal", align: Align.Right, script: "$52020040_QD__52020040__28$", duration: 2500);
                context.AddCinematicTalk(npcId: 11004438, illustId: "Mason_normal", align: Align.Left, script: "$52020040_QD__52020040__29$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_normal", align: Align.Right, script: "$52020040_QD__52020040__30$", duration: 2500);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_normal", align: Align.Right, script: "$52020040_QD__52020040__31$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004438, illustId: "Mason_normal", align: Align.Left, script: "$52020040_QD__52020040__32$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52020040_QD__52020040__33$", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 37800)) {
                    return new State경보끝_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경보끝_03 : TriggerState {
            internal State경보끝_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011, 4013}, returnView: false);
                context.AddCinematicTalk(npcId: 11004438, illustId: "Mason_normal", script: "$52020040_QD__52020040__34$", align: Align.Left, duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52020040_QD__52020040__35$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52020040_QD__52020040__36$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004436, illustId: "Schatten_surprise", align: Align.Left, script: "$52020040_QD__52020040__37$", duration: 3500);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_normal", align: Align.Right, script: "$52020040_QD__52020040__38$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52020040_QD__52020040__39$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_closeEye", align: Align.Left, script: "$52020040_QD__52020040__40$", duration: 2800);
                context.AddCinematicTalk(npcId: 11004437, illustId: "Neirin_normal", align: Align.Right, script: "$52020040_QD__52020040__41$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_closeEye", align: Align.Left, script: "$52020040_QD__52020040__42$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004434, illustId: "Bliche_normal", align: Align.Left, script: "$52020040_QD__52020040__43$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52020040_QD__52020040__44$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 33200)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동_02 : TriggerState {
            internal State이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02020029, portalId: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

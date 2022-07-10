using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100105_qd {
    public static class _52100105_01 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{50101020}, questStates: new byte[]{2})) {
                    return new StateWait_03(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{50101030}, questStates: new byte[]{3})) {
                    return new State장치가동_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_03 : TriggerState {
            internal StateWait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카_클라디아(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아 : TriggerState {
            internal State투르카_클라디아(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.VisibleMyPc(visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State투르카_클라디아_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아_02 : TriggerState {
            internal State투르카_클라디아_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카_클라디아_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아_03 : TriggerState {
            internal State투르카_클라디아_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: Align.Right, script: "$52100105_QD__52100105_01__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: Align.Right, script: "$52100105_QD__52100105_01__1$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: Align.Right, script: "$52100105_QD__52100105_01__2$", duration: 4000);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State투르카_클라디아_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아_04 : TriggerState {
            internal State투르카_클라디아_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.AddCinematicTalk(npcId: 11004392, illustId: "cladia_normal", align: Align.Left, script: "$52100105_QD__52100105_01__3$", duration: 3500);
                context.AddCinematicTalk(npcId: 11004392, illustId: "cladia_normal", align: Align.Left, script: "$52100105_QD__52100105_01__4$", duration: 3500);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: Align.Right, script: "$52100105_QD__52100105_01__5$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State투르카_클라디아_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카_클라디아_05 : TriggerState {
            internal State투르카_클라디아_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: Align.Left, script: "$52100105_QD__52100105_01__6$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State장치가동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State장치가동_01 : TriggerState {
            internal State장치가동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.SetNpcRotation(spawnId: 102, rotation: 270);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", align: Align.Left, script: "$52100105_QD__52100105_01__7$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State장치가동_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State장치가동_01_02 : TriggerState {
            internal State장치가동_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State장치가동_01_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State장치가동_01_03 : TriggerState {
            internal State장치가동_01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State장치가동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State장치가동_02 : TriggerState {
            internal State장치가동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.CameraSelectPath(pathIds: new []{4006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State장치가동_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State장치가동_02_01 : TriggerState {
            internal State장치가동_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(spawnId: 102, rotation: 360);
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Quest_Attack_A", duration: 5000f);
                context.AddCinematicTalk(npcId: 11004392, illustId: "cladia_normal", align: Align.Right, script: "$52100105_QD__52100105_01__8$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State장치가동_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State장치가동_03 : TriggerState {
            internal State장치가동_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002, 4008}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Quest_Effect_A", duration: 12000f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State장치가동_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State장치가동_04 : TriggerState {
            internal State장치가동_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 101, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리 : TriggerState {
            internal State정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107});
                context.VisibleMyPc(visible: true);
                context.MoveUser(mapId: 52100110, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

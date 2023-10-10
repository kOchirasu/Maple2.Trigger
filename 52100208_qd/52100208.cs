using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100208_qd {
    public static class _52100208 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003300}, questStates: new byte[]{2})) {
                    return new StateWait_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_02 : TriggerState {
            internal StateWait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52100208, portalId: 5001);
                context.SetEffect(triggerIds: new []{6001, 6002, 6003}, visible: false);
                context.DestroyMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209});
                context.CreateMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{202});
                context.CreateMonster(spawnIds: new []{203});
                context.CreateMonster(spawnIds: new []{204});
                context.CreateMonster(spawnIds: new []{205});
                context.CreateMonster(spawnIds: new []{206});
                context.CreateMonster(spawnIds: new []{207});
                context.CreateMonster(spawnIds: new []{208});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카대면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면 : TriggerState {
            internal State투르카대면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카대면_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_02 : TriggerState {
            internal State투르카대면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11004678, illustId: "Neirin_surprise", align: Align.Left, script: "$52100208_QD__52100208__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004675, illustId: "Bliche_mad", align: Align.Right, script: "$52100208_QD__52100208__1$", duration: 4500);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new StatePC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC이동 : TriggerState {
            internal StatePC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 0, script: "$52100208_QD__52100208__2$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State투르카대면_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_02_01 : TriggerState {
            internal State투르카대면_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004683, script: "$52100208_QD__52100208__3$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카대면_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_03 : TriggerState {
            internal State투르카대면_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52100208_QD__52100208__4$", duration: 2500);
                context.AddCinematicTalk(npcId: 0, script: "$52100208_QD__52100208__5$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State투르카대면_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_04 : TriggerState {
            internal State투르카대면_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004, 4005, 4006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카대면_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_05 : TriggerState {
            internal State투르카대면_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{209}, arg2: false);
                context.SetEffect(triggerIds: new []{6001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State투르카대면_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_06 : TriggerState {
            internal State투르카대면_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52100208_QD__52100208__6$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State투르카대면_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_07 : TriggerState {
            internal State투르카대면_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
                context.MoveNpc(spawnId: 209, patrolName: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11004683, script: "$52100208_QD__52100208__7$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State투르카대면_07_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_07_01 : TriggerState {
            internal State투르카대면_07_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4020}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 208, sequenceName: "Attack_Idle_A", duration: 100000000f);
                context.AddCinematicTalk(npcId: 11004682, illustId: "ArcaneBlader_unfair", align: Align.Right, script: "$52100208_QD__52100208__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004680, illustId: "Eone_serious", align: Align.Right, script: "$52100208_QD__52100208__9$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State투르카대면_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_08 : TriggerState {
            internal State투르카대면_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008, 4009}, returnView: false);
                context.AddCinematicTalk(npcId: 11004683, script: "$52100208_QD__52100208__10$", duration: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State투르카대면_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_09 : TriggerState {
            internal State투르카대면_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 209, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11004683, script: "$52100208_QD__52100208__11$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State투르카대면_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_10 : TriggerState {
            internal State투르카대면_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11004675, illustId: "Bliche_mad", align: Align.Right, script: "$52100208_QD__52100208__12$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004588, illustId: "Conder_normal", align: Align.Left, script: "$52100208_QD__52100208__13$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State투르카대면_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_11 : TriggerState {
            internal State투르카대면_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011, 4012}, returnView: false);
                context.AddCinematicTalk(npcId: 11004683, script: "$52100208_QD__52100208__14$", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State투르카대면_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_12 : TriggerState {
            internal State투르카대면_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 209, sequenceName: "Bore_B");
                context.AddCinematicTalk(npcId: 11004683, script: "$52100208_QD__52100208__15$", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State투르카대면_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13 : TriggerState {
            internal State투르카대면_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4014, 4015}, returnView: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Angry_A"});
                context.AddCinematicTalk(npcId: 0, script: "$52100208_QD__52100208__16$", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State투르카대면_13_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_02 : TriggerState {
            internal State투르카대면_13_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4016}, returnView: false);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_3003");
                context.AddCinematicTalk(npcId: 11004588, illustId: "Conder_normal", align: Align.Right, script: "$52100208_QD__52100208__17$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004588, illustId: "Conder_normal", align: Align.Right, script: "$52100208_QD__52100208__18$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State투르카대면_13_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_03 : TriggerState {
            internal State투르카대면_13_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
                context.AddCinematicTalk(npcId: 11004683, script: "$52100208_QD__52100208__19$", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State투르카대면_13_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_04 : TriggerState {
            internal State투르카대면_13_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 209, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카대면_13_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_05 : TriggerState {
            internal State투르카대면_13_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4017}, returnView: false);
                context.SetEffect(triggerIds: new []{6003}, visible: true);
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Stun_A", duration: 99999999f);
                context.AddCinematicTalk(npcId: 11004588, illustId: "0", script: "$52100208_QD__52100208__20$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State투르카대면_13_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_13_06 : TriggerState {
            internal State투르카대면_13_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_3004");
                context.AddCinematicTalk(npcId: 11004678, illustId: "Neirin_surprise", align: Align.Left, script: "$52100208_QD__52100208__21$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004677, illustId: "Schatten_surprise", align: Align.Right, script: "$52100208_QD__52100208__22$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State투르카대면_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_14 : TriggerState {
            internal State투르카대면_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013}, returnView: false);
                context.AddCinematicTalk(npcId: 11004683, script: "$52100208_QD__52100208__23$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State투르카대면_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_15 : TriggerState {
            internal State투르카대면_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002}, visible: true);
                context.DestroyMonster(spawnIds: new []{209}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State투르카대면_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카대면_16 : TriggerState {
            internal State투르카대면_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4018}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52100208_QD__52100208__24$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004679, illustId: "Mason_closeEye", align: Align.Right, script: "$52100208_QD__52100208__25$", duration: 4000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_03 : TriggerState {
            internal State정리_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02020071, portalId: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

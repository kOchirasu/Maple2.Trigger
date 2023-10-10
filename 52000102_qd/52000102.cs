using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000102_qd {
    public static class _52000102 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new State입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장01 : TriggerState {
            internal State입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(spawnIds: new []{200, 202}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Walk01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State입장02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장02 : TriggerState {
            internal State입장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4010, 4011}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State입장03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장03 : TriggerState {
            internal State입장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4012}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State입장04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장04 : TriggerState {
            internal State입장04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52000102, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{20002292}, questStates: new byte[]{3})) {
                    return new StatePC화남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남01 : TriggerState {
            internal StatePC화남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StatePC화남12(context), arg2: "exit");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000102, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePC화남02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남02 : TriggerState {
            internal StatePC화남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_Trun");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11003148, illustId: "Anos_normal", script: "$52000102_QD__52000102__0$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{4000, 4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePC화남03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남03 : TriggerState {
            internal StatePC화남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003148, illustId: "Anos_normal", script: "$52000102_QD__52000102__1$", duration: 2000, align: Align.Right);
                context.SetSound(triggerId: 9005, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC화남04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남04 : TriggerState {
            internal StatePC화남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000102_QD__52000102__2$", duration: 2000, align: Align.Right);
                context.FaceEmotion(spawnId: 0, emotionName: "PC_OutOfMind_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC화남04B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남04B : TriggerState {
            internal StatePC화남04B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Dead_A"});
                context.FaceEmotion(spawnId: 0, emotionName: "PC_OutOfMind_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC화남05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남05 : TriggerState {
            internal StatePC화남05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000102_QD__52000102__3$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePC화남06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남06 : TriggerState {
            internal StatePC화남06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000102_QD__52000102__4$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePC화남08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남08 : TriggerState {
            internal StatePC화남08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003149, illustId: "Asimov_normal", script: "$52000102_QD__52000102__5$", duration: 3000, align: Align.Right);
                context.FaceEmotion(spawnId: 0, emotionName: "ChaosMod_Start");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC화남09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남09 : TriggerState {
            internal StatePC화남09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006, 4007}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000102_QD__52000102__6$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC화남10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남10 : TriggerState {
            internal StatePC화남10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StatePC화남11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남11 : TriggerState {
            internal StatePC화남11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000102_QD__52000102__7$", script: "$52000102_QD__52000102__8$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 10000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePC화남11_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남11_1 : TriggerState {
            internal StatePC화남11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC화남12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC화남12 : TriggerState {
            internal StatePC화남12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000115, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

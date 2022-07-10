using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020011_qd {
    public static class _main_a {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200015}, questStates: new byte[]{2})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.MoveUser(mapId: 52020011, portalId: 6001);
                context.SetSceneSkip(state: new StateExit(context), arg2: "Exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$map:52020011$", script: "$NpcName:11003599$의 임시 거처", align: Align.Center | Align.Left, offsetRateX: 0.05f, offsetRateY: 0.15f, duration: 3000, scale: 1.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003, 4004, 4005, 4006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Chin_Chin_A"});
            }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007, 4008}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Name, title: "$NpcName:11003599$", script: "크리티아스 왕녀", align: Align.Center | Align.Left, offsetRateX: 0.05f, offsetRateY: 0.15f, duration: 3000, scale: 2.0f);
                context.AddCinematicTalk(npcId: 11003599, script: "그래, 반갑구나.", duration: 2800);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateExit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExit : TriggerState {
            internal StateExit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

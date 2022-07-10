using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000033_qd {
    public static class _audiencewithereb_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{60100010}, questStates: new byte[]{1})) {
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
                context.MoveUser(mapId: 52000033, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePcmove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePcmove : TriggerState {
            internal StatePcmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(patrolName: "MS2PatrolData_1004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateErebTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_01 : TriggerState {
            internal StateErebTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{700}, returnView: false);
                context.AddCinematicTalk(npcId: 11001663, script: "$52000033_QD__AUDIENCEWITHEREB_02__0$", duration: 5000);
                context.SetSceneSkip(state: new StateEnd(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateErebTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_02 : TriggerState {
            internal StateErebTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{901}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11001663, script: "$52000033_QD__AUDIENCEWITHEREB_02__1$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateErebintroduce(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebintroduce : TriggerState {
            internal StateErebintroduce(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Name, scale: 2.3f, title: "$52000033_QD__AUDIENCEWITHEREB_02__18$", script: "$52000033_QD__AUDIENCEWITHEREB_02__19$", align: Align.Center | Align.Left, offsetRateX: -0.15f, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateErebTalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateErebTalk_03 : TriggerState {
            internal StateErebTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11001663, script: "$52000033_QD__AUDIENCEWITHEREB_02__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 11001663, script: "$52000033_QD__AUDIENCEWITHEREB_02__3$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateKaltalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKaltalk_01 : TriggerState {
            internal StateKaltalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001665, script: "$52000033_QD__AUDIENCEWITHEREB_02__4$", duration: 3000, illustId: "Karl_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKaltalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKaltalk_02 : TriggerState {
            internal StateKaltalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{902}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 301, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11001665, script: "$52000033_QD__AUDIENCEWITHEREB_02__5$", duration: 3000);
                context.AddCinematicTalk(npcId: 11001665, script: "$52000033_QD__AUDIENCEWITHEREB_02__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateKaltroduce(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKaltroduce : TriggerState {
            internal StateKaltroduce(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Name, scale: 2.3f, title: "$52000033_QD__AUDIENCEWITHEREB_02__20$", script: "$52000033_QD__AUDIENCEWITHEREB_02__21$", align: Align.Center | Align.Left, offsetRateX: -0.15f, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_01 : TriggerState {
            internal StateTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{601}, returnView: false);
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_normal", script: "$52000033_QD__AUDIENCEWITHEREB_02__7$", duration: 1000, delayTick: 0, align: Align.Left);
                context.AddCinematicTalk(npcId: 11001665, illustId: "Karl_normal", script: "$52000033_QD__AUDIENCEWITHEREB_02__8$", duration: 3000, delayTick: 0, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_02 : TriggerState {
            internal StateTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_serious", script: "$52000033_QD__AUDIENCEWITHEREB_02__9$", duration: 3000, delayTick: 3, align: Align.Center);
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_closeEye", script: "$52000033_QD__AUDIENCEWITHEREB_02__10$", duration: 1000, delayTick: 0, align: Align.Left);
                context.AddCinematicTalk(npcId: 11001665, illustId: "Karl_normal", script: "$52000033_QD__AUDIENCEWITHEREB_02__11$", duration: 1000, delayTick: 0, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6649)) {
                    return new StateTalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_03 : TriggerState {
            internal StateTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", script: "$52000033_QD__AUDIENCEWITHEREB_02__12$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", script: "$52000033_QD__AUDIENCEWITHEREB_02__13$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_04 : TriggerState {
            internal StateTalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", script: "$52000033_QD__AUDIENCEWITHEREB_02__14$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11001666, illustId: "Fray_normal", script: "$52000033_QD__AUDIENCEWITHEREB_02__15$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateTalk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_05 : TriggerState {
            internal StateTalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001663, illustId: "Ereb_normal", script: "$52000033_QD__AUDIENCEWITHEREB_02__16$", duration: 3000, delayTick: 0, align: Align.Left);
                context.AddCinematicTalk(npcId: 11001665, illustId: "Karl_normal", script: "$52000033_QD__AUDIENCEWITHEREB_02__17$", duration: 3000, delayTick: 3, align: Align.Right);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "AudienceWithEreb");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{60100010}, questStates: new byte[]{1})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

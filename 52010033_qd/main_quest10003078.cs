using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010033_qd {
    public static class _main_quest10003078 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003078}, questStates: new byte[]{2})) {
                    return new StateUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.VisibleMyPc(visible: false);
                context.MoveUser(mapId: 52010033, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State티나감사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State티나감사 : TriggerState {
            internal State티나감사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State나메드들어옴02(context), arg2: "exit");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.AddCinematicTalk(npcId: 11003420, script: "$52010033_QD__MAIN_QUEST10003078__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010033_QD__MAIN_QUEST10003078__1$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003420, script: "$52010033_QD__MAIN_QUEST10003078__2$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State나메드들어옴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나메드들어옴 : TriggerState {
            internal State나메드들어옴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
                context.CameraSelectPath(pathIds: new []{4002, 4001}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Talk_A");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52010033_QD__MAIN_QUEST10003078__3$", script: "$52010033_QD__MAIN_QUEST10003078__4$", align: Align.Center | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2f);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010033_QD__MAIN_QUEST10003078__5$", duration: 5000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010033_QD__MAIN_QUEST10003078__6$", duration: 4500);
                context.AddCinematicTalk(npcId: 11003420, script: "$52010033_QD__MAIN_QUEST10003078__7$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010033_QD__MAIN_QUEST10003078__8$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010033_QD__MAIN_QUEST10003078__9$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010033_QD__MAIN_QUEST10003078__10$", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 22000)) {
                    return new State나메드들어옴_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나메드들어옴_1 : TriggerState {
            internal State나메드들어옴_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State나메드들어옴02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나메드들어옴02 : TriggerState {
            internal State나메드들어옴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52010032, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

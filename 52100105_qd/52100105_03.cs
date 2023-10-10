using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100105_qd {
    public static class _52100105_03 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600, 601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1000})) {
                    return new StateQuest체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크 : TriggerState {
            internal StateQuest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{50101030}, questStates: new byte[]{3})) {
                    return new StateStart암전1(context);
                }

                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{50101030}, questStates: new byte[]{2})) {
                    return new StateEndCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{50101030}, questStates: new byte[]{1})) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart암전1 : TriggerState {
            internal StateStart암전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600, 601}, visible: false);
                context.VisibleMyPc(visible: false);
                context.SetOnetimeEffect(id: 200, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State컷신1_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State컷신1_1 : TriggerState {
            internal State컷신1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Kritias_EpicCutScene07_01.swf", movieId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "0")) {
                    // return new State컷신1_2(context);
                    return null;
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new State몹소환1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹소환1 : TriggerState {
            internal State몹소환1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{500, 1, 400, 401, 402, 403, 404}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인게임Prepare0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인게임Prepare0 : TriggerState {
            internal State인게임Prepare0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 200, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카Script1 : TriggerState {
            internal State투르카Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{500}, arg2: false);
                context.SetSceneSkip(state: new State컷신3_1(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{700, 701}, returnView: false);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", script: "$52100105_QD__52100105_03__0$", duration: 6000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", script: "$52100105_QD__52100105_03__1$", duration: 6000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State클라디아Creation1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아Creation1 : TriggerState {
            internal State클라디아Creation1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{500}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State클라디아이동1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아이동1 : TriggerState {
            internal State클라디아이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 500, patrolName: "PatrolData_500_1");
                context.CameraSelectPath(pathIds: new []{703, 704}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State클라디아Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아Script1 : TriggerState {
            internal State클라디아Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 500, sequenceName: "Talk_A", duration: 8666f);
                context.AddCinematicTalk(npcId: 11004392, illustId: "cladia_normal", script: "$52100105_QD__52100105_03__2$", duration: 5000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11004392, illustId: "cladia_angry", script: "$52100105_QD__52100105_03__3$", duration: 5000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카공격지시1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카공격지시1 : TriggerState {
            internal State투르카공격지시1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 705, enabled: true);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_normal", script: "$52100105_QD__52100105_03__4$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 400, sequenceName: "Bore_A", duration: 1333f);
                context.SetNpcEmotionLoop(spawnId: 500, sequenceName: "Attack_Idle_A", duration: 5333f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State암전1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전1 : TriggerState {
            internal State암전1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.MoveNpc(spawnId: 401, patrolName: "PatrolData_401_1");
                context.MoveNpc(spawnId: 402, patrolName: "PatrolData_402_1");
                context.MoveNpc(spawnId: 403, patrolName: "PatrolData_403_1");
                context.MoveNpc(spawnId: 404, patrolName: "PatrolData_404_1");
                context.SetOnetimeEffect(id: 100, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State컷신3_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State컷신3_1 : TriggerState {
            internal State컷신3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{401}, arg2: false);
                context.DestroyMonster(spawnIds: new []{402}, arg2: false);
                context.DestroyMonster(spawnIds: new []{403}, arg2: false);
                context.DestroyMonster(spawnIds: new []{404}, arg2: false);
                context.DestroyMonster(spawnIds: new []{500}, arg2: false);
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Kritias_EpicCutScene07_02.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State클라디아Creation2(context);
                }

                if (context.WaitTick(waitTick: 12000)) {
                    return new State클라디아Creation2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State클라디아Creation2 : TriggerState {
            internal State클라디아Creation2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{500}, arg2: false);
                context.MoveNpc(spawnId: 500, patrolName: "PatrolData_500_1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카도망1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카도망1 : TriggerState {
            internal State투르카도망1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateEndCinematic(context), arg2: "nextState");
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 100, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionLoop(spawnId: 500, sequenceName: "Attack_Idle_A", duration: 5333f);
                context.SetNpcEmotionLoop(spawnId: 400, sequenceName: "Damg_A", duration: 5333f);
                context.CameraSelect(triggerId: 706, enabled: true);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_Broken_Hood", script: "$52100105_QD__52100105_03__5$", duration: 4000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카도망2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카도망2 : TriggerState {
            internal State투르카도망2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카도망3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카도망3 : TriggerState {
            internal State투르카도망3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 400, patrolName: "PatrolData_400_1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State투르카도망4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카도망4 : TriggerState {
            internal State투르카도망4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 707, enabled: true);
                context.DestroyMonster(spawnIds: new []{500}, arg2: false);
                context.AddCinematicTalk(npcId: 11004430, illustId: "Turka_Broken_Hood", script: "$52100105_QD__52100105_03__6$", duration: 5000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State투르카도망5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State투르카도망5 : TriggerState {
            internal State투르카도망5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic : TriggerState {
            internal StateEndCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(spawnIds: new []{-1}, arg2: false);
                context.SetEffect(triggerIds: new []{600}, visible: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.VisibleMyPc(visible: true);
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52100110, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

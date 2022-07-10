using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000015_cs {
    public static class _intro01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.Guide);
                context.SetSound(triggerId: 10000, arg2: false);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5100, 5101, 5000, 5001, 5002, 5200, 5201, 5202, 5203, 5204, 5205, 5206, 5207, 6000, 8000, 8001, 8002, 8003, 8004, 8005}, visible: false);
                context.CreateMonster(spawnIds: new []{101, 201, 202, 203, 204, 205, 206}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StatePlayOpeningMovie01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStandAside10 : TriggerState {
            internal StateStandAside10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 10000, arg2: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_202");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_204");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateStandAside11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStandAside11 : TriggerState {
            internal StateStandAside11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_203");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_205");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_206");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateWeiHongQuest03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStandAside20 : TriggerState {
            internal StateStandAside20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 10000, arg2: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_202");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_204");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateStandAside21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStandAside21 : TriggerState {
            internal StateStandAside21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_203");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_205");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_206");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateGuideNextMap01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayOpeningMovie01 : TriggerState {
            internal StatePlayOpeningMovie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{90000430}, questStates: new byte[]{2})) {
                    return new StateStandAside10(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{90000430}, questStates: new byte[]{3})) {
                    return new StateStandAside20(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePlayOpeningMovie02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayOpeningMovie02 : TriggerState {
            internal StatePlayOpeningMovie02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: @"common\Common_Opening.usm", movieId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "2")) {
                    return new StatePlayMovie01(context);
                }

                if (context.WaitTick(waitTick: 190000)) {
                    return new StatePlayMovie01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie01 : TriggerState {
            internal StatePlayMovie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePlayMovie02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie02 : TriggerState {
            internal StatePlayMovie02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Cut_Blackstar_Crash.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateWeiHongTalk01(context);
                }

                if (context.WaitTick(waitTick: 66000)) {
                    return new StateWeiHongTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk01 : TriggerState {
            internal StateWeiHongTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 10000, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enable: true);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateWeiHongTalk02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{6000}, visible: false);
            }
        }

        private class StateWeiHongTalk02 : TriggerState {
            internal StateWeiHongTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enable: true);
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000015_CS__INTRO01__0$", arg4: 6);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetSkip(state: new StateWeiHongTalk03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateWeiHongTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk03 : TriggerState {
            internal StateWeiHongTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{8000}, visible: false);
            }

            public override TriggerState? Execute() {
                return new StateWeiHongTalk04(context);
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk04 : TriggerState {
            internal StateWeiHongTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000015_CS__INTRO01__1$", arg4: 6);
                context.SetEffect(triggerIds: new []{8001}, visible: true);
                context.SetSkip(state: new StateWeiHongTalk05(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateWeiHongTalk05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk05 : TriggerState {
            internal StateWeiHongTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{8001}, visible: false);
            }

            public override TriggerState? Execute() {
                return new StateWeiHongTalk06(context);
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk06 : TriggerState {
            internal StateWeiHongTalk06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000015_CS__INTRO01__2$", arg4: 5);
                context.SetEffect(triggerIds: new []{8002}, visible: true);
                context.SetSkip(state: new StateWeiHongTalk07(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWeiHongTalk07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk07 : TriggerState {
            internal StateWeiHongTalk07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{8002}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 601, enable: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateStandAside01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStandAside01 : TriggerState {
            internal StateStandAside01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_202");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_204");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateStandAside02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStandAside02 : TriggerState {
            internal StateStandAside02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_203");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_205");
                context.MoveNpc(spawnId: 206, patrolName: "MS2PatrolData_206");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    return new StateStandAside03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStandAside03 : TriggerState {
            internal StateStandAside03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateKeytypeSelect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKeytypeSelect01 : TriggerState {
            internal StateKeytypeSelect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10020005);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.Guide, condition: "IsTriggerEvent", value: "10020009")) {
                    return new StateMeetWeiHong01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetWeiHong01 : TriggerState {
            internal StateMeetWeiHong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5002, 5100, 5101}, visible: true);
                context.ShowGuideSummary(entityId: 10020010, textId: 10020010);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateMeetWeiHong02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetWeiHong02 : TriggerState {
            internal StateMeetWeiHong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetEffect(triggerIds: new []{5000, 5002, 5100, 5101}, visible: false);
                context.HideGuideSummary(entityId: 10020010);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWeiHongTalk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk10 : TriggerState {
            internal StateWeiHongTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 602, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWeiHongTalk11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk11 : TriggerState {
            internal StateWeiHongTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000015_CS__INTRO01__3$", arg4: 5);
                context.SetEffect(triggerIds: new []{8005}, visible: true);
                context.SetSkip(state: new StateWeiHongTalk12(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWeiHongTalk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk12 : TriggerState {
            internal StateWeiHongTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{8005}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                return new StateWeiHongTalk13(context);
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk13 : TriggerState {
            internal StateWeiHongTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000015_CS__INTRO01__4$", arg4: 5);
                context.SetEffect(triggerIds: new []{8003}, visible: true);
                context.SetSkip(state: new StateWeiHongTalk14(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWeiHongTalk14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk14 : TriggerState {
            internal StateWeiHongTalk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{8003}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                return new StateMafiaTalk10(context);
            }

            public override void OnExit() { }
        }

        private class StateMafiaTalk10 : TriggerState {
            internal StateMafiaTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetConversation(type: 1, spawnId: 201, script: "$63000015_CS__INTRO01__5$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMafiaTalk11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMafiaTalk11 : TriggerState {
            internal StateMafiaTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Idle_A");
                context.SetConversation(type: 1, spawnId: 202, script: "$63000015_CS__INTRO01__6$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMafiaTalk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMafiaTalk12 : TriggerState {
            internal StateMafiaTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Idle_A");
                context.SetConversation(type: 1, spawnId: 206, script: "$63000015_CS__INTRO01__7$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 206, sequenceName: "Talk_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateWeiHongTalk20(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{6000}, visible: false);
            }
        }

        private class StateWeiHongTalk20 : TriggerState {
            internal StateWeiHongTalk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 206, sequenceName: "Idle_A");
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000015_CS__INTRO01__8$", arg4: 6);
                context.SetEffect(triggerIds: new []{8004}, visible: true);
                context.SetSkip(state: new StateWeiHongQuest01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateWeiHongQuest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongQuest01 : TriggerState {
            internal StateWeiHongQuest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{8004}, visible: false);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 602, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWeiHongQuest02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongQuest02 : TriggerState {
            internal StateWeiHongQuest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10020020, textId: 10020020);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{90000430}, questStates: new byte[]{2})) {
                    return new StateWeiHongQuest03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongQuest03 : TriggerState {
            internal StateWeiHongQuest03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10020020);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10020021, textId: 10020021);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9100}, questIds: new []{90000430}, questStates: new byte[]{3})) {
                    return new StateGuideNextMap01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap01 : TriggerState {
            internal StateGuideNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10020021);
                context.SetPortal(portalId: 1, visible: true, enabled: false, minimapVisible: true);
                context.SetEffect(triggerIds: new []{5200, 5201, 5202, 5203, 5204, 5205, 5206, 5207}, visible: true);
                context.ShowGuideSummary(entityId: 10020012, textId: 10020012);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateGuideNextMap02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap02 : TriggerState {
            internal StateGuideNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10020012);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.ShowGuideSummary(entityId: 10020011, textId: 10020011);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9100})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10020011);
                context.SetEffect(triggerIds: new []{5200, 5201, 5202, 5203, 5204, 5205, 5206, 5207}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

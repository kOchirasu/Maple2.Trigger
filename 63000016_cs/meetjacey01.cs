using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000016_cs {
    public static class _meetjacey01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.Guide);
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: true);
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5000, 6000}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToJacey01 : TriggerState {
            internal StateMoveToJacey01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000016, portalId: 10, boxId: 9000);
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMoveToJacey02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToJacey02 : TriggerState {
            internal StateMoveToJacey02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateJaceyQuest02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWalkIn01 : TriggerState {
            internal StateWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000431}, questStates: new byte[]{2})) {
                    return new StateMoveToJacey01(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWalkIn02 : TriggerState {
            internal StateWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enabled: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWalkIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWalkIn03 : TriggerState {
            internal StateWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateMeetJacey01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetJacey01 : TriggerState {
            internal StateMeetJacey01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__0$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMeetJacey02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetJacey02 : TriggerState {
            internal StateMeetJacey02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 602, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMeetJacey03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetJacey03 : TriggerState {
            internal StateMeetJacey03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1001");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateJaceyTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk01 : TriggerState {
            internal StateJaceyTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__1$", arg4: 5);
                context.SetSkip(state: new StateJaceyTalk02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateJaceyTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk02 : TriggerState {
            internal StateJaceyTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateJaceyTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk03 : TriggerState {
            internal StateJaceyTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1002");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_102");
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__2$", arg4: 4);
                context.SetSkip(state: new StateJaceyTalk04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJaceyTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk04 : TriggerState {
            internal StateJaceyTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateJaceyTalk05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk05 : TriggerState {
            internal StateJaceyTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__3$", arg4: 4);
                context.SetSkip(state: new StateJaceyTalk06(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJaceyTalk06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk06 : TriggerState {
            internal StateJaceyTalk06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(triggerId: 602, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMinimapGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMinimapGuide01 : TriggerState {
            internal StateMinimapGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10021010);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.Guide, condition: "IsTriggerEvent", value: "10021013")) {
                    return new StateMinimapGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMinimapGuide02 : TriggerState {
            internal StateMinimapGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateJaceyTalk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk10 : TriggerState {
            internal StateJaceyTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__4$", arg4: 4);
                context.SetSkip(state: new StateJaceyTalk11(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJaceyTalk11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk11 : TriggerState {
            internal StateJaceyTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateJaceyTalk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk12 : TriggerState {
            internal StateJaceyTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__5$", arg4: 4);
                context.SetSkip(state: new StateJaceyTalk13(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJaceyTalk13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk13 : TriggerState {
            internal StateJaceyTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePatrolWithJacey01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolWithJacey01 : TriggerState {
            internal StatePatrolWithJacey01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10021020, textId: 10021020);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_103");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9100, spawnIds: new []{101})) {
                    return new StatePatrolWithJacey02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolWithJacey02 : TriggerState {
            internal StatePatrolWithJacey02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$63000016_CS__MEETJACEY01__6$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$63000016_CS__MEETJACEY01__7$", arg4: 3, arg5: 3);
                context.SetConversation(type: 1, spawnId: 101, script: "$63000016_CS__MEETJACEY01__8$", arg4: 3, arg5: 6);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9101, spawnIds: new []{101})) {
                    return new StatePatrolWithJacey03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolWithJacey03 : TriggerState {
            internal StatePatrolWithJacey03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$63000016_CS__MEETJACEY01__9$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$63000016_CS__MEETJACEY01__10$", arg4: 3, arg5: 3);
                context.SetConversation(type: 1, spawnId: 101, script: "$63000016_CS__MEETJACEY01__11$", arg4: 3, arg5: 6);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9102, spawnIds: new []{101})) {
                    return new StatePatrolWithJacey04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolWithJacey04 : TriggerState {
            internal StatePatrolWithJacey04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$63000016_CS__MEETJACEY01__12$", arg4: 3);
                context.HideGuideSummary(entityId: 10021020);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCallNextRoom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom01 : TriggerState {
            internal StateCallNextRoom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 700, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCallNextRoom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom02 : TriggerState {
            internal StateCallNextRoom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCallNextRoom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom03 : TriggerState {
            internal StateCallNextRoom03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__13$", arg4: 4);
                context.SetSkip(state: new StateCallNextRoom04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCallNextRoom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom04 : TriggerState {
            internal StateCallNextRoom04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.CameraSelect(triggerId: 700, enabled: false);
                context.SetEffect(triggerIds: new []{6000}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateJaceyQuest00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest00 : TriggerState {
            internal StateJaceyQuest00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10021030, textId: 10021030);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9002}, questIds: new []{90000431}, questStates: new byte[]{2})) {
                    return new StateJaceyQuest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest01 : TriggerState {
            internal StateJaceyQuest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10021030);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateJaceyQuest02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest02 : TriggerState {
            internal StateJaceyQuest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__14$", arg4: 4);
                context.SetSkip(state: new StateJaceyQuest03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJaceyQuest03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest03 : TriggerState {
            internal StateJaceyQuest03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateJaceyQuest04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest04 : TriggerState {
            internal StateJaceyQuest04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__15$", arg4: 4);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.SetSkip(state: new StateJaceyQuest05(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJaceyQuest05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest05 : TriggerState {
            internal StateJaceyQuest05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateAboutPotion01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAboutPotion01 : TriggerState {
            internal StateAboutPotion01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__16$", arg4: 4);
                context.SetSkip(state: new StateAboutPotion02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateAboutPotion02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAboutPotion02 : TriggerState {
            internal StateAboutPotion02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateAboutPotion03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAboutPotion03 : TriggerState {
            internal StateAboutPotion03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001620, script: "$63000016_CS__MEETJACEY01__17$", arg4: 4);
                context.SetSkip(state: new StateAboutPotion04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateAboutPotion04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAboutPotion04 : TriggerState {
            internal StateAboutPotion04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_301");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateJaceyLeve01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.GuideEvent(eventId: 10021120);
            }
        }

        private class StateJaceyLeve01 : TriggerState {
            internal StateJaceyLeve01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 103, script: "$63000016_CS__MEETJACEY01__18$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateJaceyLeve02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJaceyLeve02 : TriggerState {
            internal StateJaceyLeve02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.DestroyMonster(spawnIds: new []{103});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSendSignalToGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSendSignalToGuide01 : TriggerState {
            internal StateSendSignalToGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10021050);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePortalOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOpen01 : TriggerState {
            internal StatePortalOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9002})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

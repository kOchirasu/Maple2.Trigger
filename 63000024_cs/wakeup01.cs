using Maple2.Trigger.Enum;

namespace Maple2.Trigger._63000024_cs {
    public static class _wakeup01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.Guide);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5100, 5102, 5200, 5300, 5301, 5302, 5303, 5304, 5500, 5501, 5502, 5503, 5504, 5505, 5506, 6000, 6001, 6002}, visible: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StatePlayMovie01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie01 : TriggerState {
            internal StatePlayMovie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000444}, questStates: new byte[]{1})) {
                    return new StateQuestOnGoing04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000443}, questStates: new byte[]{3})) {
                    return new StateQuestOnGoing03(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000443}, questStates: new byte[]{2})) {
                    return new StateQuestOnGoing02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000443}, questStates: new byte[]{1})) {
                    return new StateQuestOnGoing01(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing01 : TriggerState {
            internal StateQuestOnGoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000024, portalId: 10, boxId: 9900);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new StateMoveToGetWeapon01(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing02 : TriggerState {
            internal StateQuestOnGoing02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000024, portalId: 10, boxId: 9900);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing03 : TriggerState {
            internal StateQuestOnGoing03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000024, portalId: 10, boxId: 9900);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestStart03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing04 : TriggerState {
            internal StateQuestOnGoing04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000024, portalId: 10, boxId: 9900);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.SetPortal(portalId: 1, visible: true, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTimeToLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 500, enable: true);
                context.SetSceneSkip(state: new StateTinChaiTalk04_CSkip(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCDownIdle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCDownIdle01 : TriggerState {
            internal StatePCDownIdle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_D", duration: 9000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCDownIdle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCDownIdle02 : TriggerState {
            internal StatePCDownIdle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLookAround01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{501, 502}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateLookAround02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Sit_Ground_Idle_A", duration: 18000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLookAround03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround03 : TriggerState {
            internal StateLookAround03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLookAround04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround04 : TriggerState {
            internal StateLookAround04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 510, enable: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_105");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLookAround05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround05 : TriggerState {
            internal StateLookAround05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLookAround06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround06 : TriggerState {
            internal StateLookAround06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 511, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLookAround07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround07 : TriggerState {
            internal StateLookAround07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 600, enable: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_102");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTinChaiTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk01 : TriggerState {
            internal StateTinChaiTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000024_CS__WAKEUP01__0$", arg4: 7);
                context.SetSkip(state: new StateTinChaiTalk02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateTinChaiTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk02 : TriggerState {
            internal StateTinChaiTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateTinChaiTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk03 : TriggerState {
            internal StateTinChaiTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000024_CS__WAKEUP01__1$", arg4: 5);
                context.SetSkip(state: new StateTinChaiTalk04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTinChaiTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk04 : TriggerState {
            internal StateTinChaiTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveUser(mapId: 63000024, portalId: 10, boxId: 9900);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 600, enable: false);
            }

            public override TriggerState? Execute() {
                return new State키타입설정안내01(context);
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk04_CSkip : TriggerState {
            internal StateTinChaiTalk04_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_102");
                context.MoveUser(mapId: 63000024, portalId: 10, boxId: 9900);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 600, enable: false);
            }

            public override TriggerState? Execute() {
                return new State키타입설정안내01(context);
            }

            public override void OnExit() { }
        }

        private class State키타입설정안내01 : TriggerState {
            internal State키타입설정안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10030005);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.Guide, condition: "IsTriggerEvent", value: "10030009")) {
                    return new StateMeetTinChai01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetTinChai01 : TriggerState {
            internal StateMeetTinChai01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001, 5100, 5200, 5300, 5301, 5302, 5303, 5304}, visible: true);
                context.ShowGuideSummary(entityId: 10030010, textId: 10030010);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateMeetTinChai02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetTinChai02 : TriggerState {
            internal StateMeetTinChai02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: false);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetEffect(triggerIds: new []{5100, 5200, 5300, 5301, 5302, 5303, 5304}, visible: false);
                context.HideGuideSummary(entityId: 10030010);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTinChaiTalk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk10 : TriggerState {
            internal StateTinChaiTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTinChaiTalk11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk11 : TriggerState {
            internal StateTinChaiTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000024_CS__WAKEUP01__2$", arg4: 6);
                context.SetSkip(state: new StateTinChaiTalk14(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTinChaiTalk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk12 : TriggerState {
            internal StateTinChaiTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateTinChaiTalk13(context);
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk13 : TriggerState {
            internal StateTinChaiTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000024_CS__WAKEUP01__3$", arg4: 5);
                context.SetSkip(state: new StateTinChaiTalk14(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTinChaiTalk14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk14 : TriggerState {
            internal StateTinChaiTalk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10030020, textId: 10030020);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000443}, questStates: new byte[]{1})) {
                    return new StateQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10030020);
            }
        }

        private class StateQuestStart01 : TriggerState {
            internal StateQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000443}, questStates: new byte[]{2})) {
                    return new StateQuestStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestStart02 : TriggerState {
            internal StateQuestStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000443}, questStates: new byte[]{3})) {
                    return new StateQuestStart03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestStart03 : TriggerState {
            internal StateQuestStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000444}, questStates: new byte[]{1})) {
                    return new StateQuestStart04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestStart04 : TriggerState {
            internal StateQuestStart04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: false, minimapVisible: false);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTimeToLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_103");
                context.SetConversation(type: 1, spawnId: 103, script: "$63000024_CS__WAKEUP01__4$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateGuideNextMap01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap01 : TriggerState {
            internal StateGuideNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10030010, textId: 10030010);
                context.SetEffect(triggerIds: new []{5001, 5102, 5500, 5501, 5502, 5503, 5504, 5505, 5506}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9003})) {
                    return new StateGuideNextMap02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap02 : TriggerState {
            internal StateGuideNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_104");
                context.HideGuideSummary(entityId: 10030010);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(triggerIds: new []{5002, 5000}, visible: true);
                context.ShowGuideSummary(entityId: 1060, textId: 1060);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGuideNextMap03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap03 : TriggerState {
            internal StateGuideNextMap03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103});
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 1060);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

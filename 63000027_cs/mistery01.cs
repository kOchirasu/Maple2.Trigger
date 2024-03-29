namespace Maple2.Trigger._63000027_cs {
    public static class _mistery01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5200, 5300, 5400, 5401, 5402, 5500}, visible: false);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "CollapseEnd", value: 0);
                context.SetUserValue(key: "ZoomIn", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000451}, questStates: new byte[]{1})) {
                    return new StateQuestOnGoing01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000450}, questStates: new byte[]{3})) {
                    return new StateQuestOnGoing11(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000450}, questStates: new byte[]{2})) {
                    return new StateDelay01(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing01 : TriggerState {
            internal StateQuestOnGoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTimeToLeave01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateQuestOnGoing11 : TriggerState {
            internal StateQuestOnGoing11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSecondQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 500, enabled: true);
                context.SetSceneSkip(state: new StateVisionApp02(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLookAround01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLookAround02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enabled: true);
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
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
                context.SetConversation(type: 1, spawnId: 0, script: "$63000027_CS__MISTERY01__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLookAround04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround04 : TriggerState {
            internal StateLookAround04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 502, enabled: true);
                context.SetPcEmotionSequence(sequenceNames: new []{"Bore_C"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateVisionApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionApp01 : TriggerState {
            internal StateVisionApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 600, enabled: true);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateVisionApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionApp02 : TriggerState {
            internal StateVisionApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateVisionTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk01 : TriggerState {
            internal StateVisionTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5400}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001560, script: "$63000027_CS__MISTERY01__1$", arg4: 5);
                context.SetSkip(state: new StateVisionTalk04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateVisionTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk02 : TriggerState {
            internal StateVisionTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateVisionTalk03(context);
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk03 : TriggerState {
            internal StateVisionTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001560, script: "$63000027_CS__MISTERY01__2$", arg4: 5);
                context.SetSkip(state: new StateVisionTalk04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateVisionTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk04 : TriggerState {
            internal StateVisionTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.CameraSelect(triggerId: 601, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateVisionTalk05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk05 : TriggerState {
            internal StateVisionTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFirstQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10034010, textId: 10034010);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StateFirstQuestEnd02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10034010);
            }
        }

        private class StateFirstQuestEnd02 : TriggerState {
            internal StateFirstQuestEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10034020, textId: 10034020);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000450}, questStates: new byte[]{3})) {
                    return new StateSecondQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10034020);
            }
        }

        private class StateSecondQuestStart01 : TriggerState {
            internal StateSecondQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10034030, textId: 10034030);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000451}, questStates: new byte[]{1})) {
                    return new StateTimeToLeave01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10034030);
            }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(triggerId: 700, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    return new StateTimeToLeave02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave02 : TriggerState {
            internal StateTimeToLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.MoveUser(mapId: 63000027, portalId: 10, boxId: 9900);
                context.SetSceneSkip(state: new StateVisionSayGoodbye04(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    return new StateTimeToLeave03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave03 : TriggerState {
            internal StateTimeToLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 701, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCGetEffect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGetEffect01 : TriggerState {
            internal StatePCGetEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9900}, skillId: 70000097, level: 1);
                context.SetEffect(triggerIds: new []{5500}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateVisionSayGoodbye01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionSayGoodbye01 : TriggerState {
            internal StateVisionSayGoodbye01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5402}, visible: true);
                context.SetConversation(type: 1, spawnId: 103, script: "$63000027_CS__MISTERY01__3$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateVisionSayGoodbye02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionSayGoodbye02 : TriggerState {
            internal StateVisionSayGoodbye02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5401}, visible: true);
                context.SetConversation(type: 1, spawnId: 103, script: "$63000027_CS__MISTERY01__4$", arg4: 4, arg5: 0);
                context.SetConversation(type: 1, spawnId: 103, script: "$63000027_CS__MISTERY01__5$", arg4: 3, arg5: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateVisionSayGoodbye03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionSayGoodbye03 : TriggerState {
            internal StateVisionSayGoodbye03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_102");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateVisionSayGoodbye04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVisionSayGoodbye04 : TriggerState {
            internal StateVisionSayGoodbye04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCollapse01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse01 : TriggerState {
            internal StateCollapse01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5200}, visible: true);
                context.CameraSelect(triggerId: 710, enabled: true);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 2, key: "CollapseStart", value: 1);
                context.SetEffect(triggerIds: new []{5300}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ZoomIn") == 1) {
                    return new StateCollapse02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapse02 : TriggerState {
            internal StateCollapse02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 711, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CollapseEnd") == 1) {
                    return new StatePCFainted01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFainted01 : TriggerState {
            internal StatePCFainted01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Down2_A", "Down_Idle_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2667)) {
                    return new StatePCTeleport01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport01 : TriggerState {
            internal StatePCTeleport01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 10000f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCTeleport02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport02 : TriggerState {
            internal StatePCTeleport02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000028, portalId: 1, boxId: 9900);
                context.CameraSelect(triggerId: 711, enabled: false);
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

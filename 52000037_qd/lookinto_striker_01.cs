namespace Maple2.Trigger._52000037_qd {
    public static class _lookinto_striker_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: false, initialSequence: "Dead_A");
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000175}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{40002604}, questStates: new byte[]{3}, jobCode: 100)) {
                    return new StateStrikerSetting04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{40002604}, questStates: new byte[]{2}, jobCode: 100)) {
                    return new StateStrikerSetting03(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{40002604}, questStates: new byte[]{1}, jobCode: 100)) {
                    return new StateStrikerSetting05(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60100065}, questStates: new byte[]{3}, jobCode: 100)) {
                    return new StateStrikerSetting02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60100065}, questStates: new byte[]{2}, jobCode: 100)) {
                    return new StateStrikerSetting01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStrikerSetting02 : TriggerState {
            internal StateStrikerSetting02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{202, 302, 101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9200})) {
                    return new StateNextQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStrikerSetting05 : TriggerState {
            internal StateStrikerSetting05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000175}, state: 1);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{202, 302, 101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9200})) {
                    return new StateNextQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStrikerSetting03 : TriggerState {
            internal StateStrikerSetting03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStrikerSetting04 : TriggerState {
            internal StateStrikerSetting04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStrikerSetting01 : TriggerState {
            internal StateStrikerSetting01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{201, 301}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StateSayHi01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSayHi01 : TriggerState {
            internal StateSayHi01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 201, script: "$52000037_QD__LOOKINTO_STRIKER_01__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCMove01 : TriggerState {
            internal StatePCMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(triggerId: 600, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCMove02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCMove02 : TriggerState {
            internal StatePCMove02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000037, portalId: 10, boxId: 9900);
                context.CreateMonster(spawnIds: new []{401}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePatrol01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 601, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePatrol02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol02 : TriggerState {
            internal StatePatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
                context.SetConversation(type: 1, spawnId: 201, script: "$52000037_QD__LOOKINTO_STRIKER_01__1$", arg4: 3, arg5: 0);
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_401");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePatrol03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol03 : TriggerState {
            internal StatePatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_301");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePatrol04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol04 : TriggerState {
            internal StatePatrol04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 301, script: "$52000037_QD__LOOKINTO_STRIKER_01__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateComeAcrossSB01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateComeAcrossSB01 : TriggerState {
            internal StateComeAcrossSB01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 700, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateComeAcrossSB02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateComeAcrossSB02 : TriggerState {
            internal StateComeAcrossSB02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 301, script: "$52000037_QD__LOOKINTO_STRIKER_01__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateComeAcrossSB03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateComeAcrossSB03 : TriggerState {
            internal StateComeAcrossSB03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSBRunAway01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSBRunAway01 : TriggerState {
            internal StateSBRunAway01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 401, script: "$52000037_QD__LOOKINTO_STRIKER_01__14$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSBRunAway02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSBRunAway02 : TriggerState {
            internal StateSBRunAway02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 401, patrolName: "MS2PatrolData_402");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSBRunAway03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSBRunAway03 : TriggerState {
            internal StateSBRunAway03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 701, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDialogue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000037_QD__LOOKINTO_STRIKER_01__4$", arg4: 5);
                context.SetSkip(state: new StateDialogue02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDialogue02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateDialogue03(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue03 : TriggerState {
            internal StateDialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{401});
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000037_QD__LOOKINTO_STRIKER_01__5$", arg4: 5);
                context.SetSkip(state: new StateDialogue04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDialogue04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue04 : TriggerState {
            internal StateDialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 701, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStepInside01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStepInside01 : TriggerState {
            internal StateStepInside01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 301, script: "$52000037_QD__LOOKINTO_STRIKER_01__6$", arg4: 4, arg5: 0);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_202");
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_302");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStepInside02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStepInside02 : TriggerState {
            internal StateStepInside02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 201, script: "$52000037_QD__LOOKINTO_STRIKER_01__7$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFirstQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestStart01 : TriggerState {
            internal StateFirstQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000175}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{60100065}, questStates: new byte[]{3}, jobCode: 100)) {
                    return new StateTalkJabethNBravo01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkJabethNBravo01 : TriggerState {
            internal StateTalkJabethNBravo01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000037_QD__LOOKINTO_STRIKER_01__8$", arg4: 5);
                context.SetSkip(state: new StateTalkJabethNBravo02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTalkJabethNBravo02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkJabethNBravo02 : TriggerState {
            internal StateTalkJabethNBravo02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateTalkJabethNBravo03(context);
            }

            public override void OnExit() { }
        }

        private class StateTalkJabethNBravo03 : TriggerState {
            internal StateTalkJabethNBravo03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000037_QD__LOOKINTO_STRIKER_01__9$", arg4: 5);
                context.SetSkip(state: new StateTalkJabethNBravo04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTalkJabethNBravo04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkJabethNBravo04 : TriggerState {
            internal StateTalkJabethNBravo04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new StateNPCChange01(context);
            }

            public override void OnExit() { }
        }

        private class StateNPCChange01 : TriggerState {
            internal StateNPCChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201, 301});
                context.CreateMonster(spawnIds: new []{202, 302}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNextQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextQuestStart01 : TriggerState {
            internal StateNextQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 202, script: "$52000037_QD__LOOKINTO_STRIKER_01__10$", arg4: 4, arg5: 0);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_203");
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_303");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNextQuestStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextQuestStart02 : TriggerState {
            internal StateNextQuestStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002604}, questStates: new byte[]{2}, jobCode: 100)) {
                    return new StateReadyToLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave01 : TriggerState {
            internal StateReadyToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000037_QD__LOOKINTO_STRIKER_01__11$", arg4: 6);
                context.SetSkip(state: new StateReadyToLeave02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateReadyToLeave02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave02 : TriggerState {
            internal StateReadyToLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToLeave03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave03 : TriggerState {
            internal StateReadyToLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_304");
                context.SetConversation(type: 1, spawnId: 302, script: "$52000037_QD__LOOKINTO_STRIKER_01__12$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToLeave04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave04 : TriggerState {
            internal StateReadyToLeave04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_204");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReadyToLeave05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave05 : TriggerState {
            internal StateReadyToLeave05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 202, script: "$52000037_QD__LOOKINTO_STRIKER_01__13$", arg4: 3, arg5: 0);
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_305");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateNPCLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCLeave01 : TriggerState {
            internal StateNPCLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{302});
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_205");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateNPCLeave02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCLeave02 : TriggerState {
            internal StateNPCLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.DestroyMonster(spawnIds: new []{202});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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

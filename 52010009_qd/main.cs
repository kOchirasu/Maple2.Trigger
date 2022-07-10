namespace Maple2.Trigger._52010009_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000866, 10000880, 10000915}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{20002091}, questStates: new byte[]{1})) {
                    return new StateEvent_01_Idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_Idle : TriggerState {
            internal StateEvent_01_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
                context.SetInteractObject(interactIds: new []{10000866}, state: 1);
            }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 111, textId: 25201901);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000866}, arg2: 0)) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 111);
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
                context.SetConversation(type: 1, spawnId: 111, script: "$52010009_QD__MAIN__0$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData0_1001");
            }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102})) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
                context.SetInteractObject(interactIds: new []{10000880}, state: 1);
            }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 111, textId: 25201901);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000880}, arg2: 0)) {
                    return new StateEvent_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 111);
                context.CreateMonster(spawnIds: new []{112}, arg2: false);
                context.SetConversation(type: 1, spawnId: 112, script: "$52010009_QD__MAIN__1$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 112, patrolName: "MS2PatrolData0_1001");
            }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{103})) {
                    return new StateEvent_06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
                context.SetInteractObject(interactIds: new []{10000915}, state: 1);
            }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 111, textId: 25201901);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000915}, arg2: 0)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 111);
                context.CreateMonster(spawnIds: new []{113}, arg2: false);
                context.SetConversation(type: 1, spawnId: 113, script: "$52010009_QD__MAIN__2$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 113, patrolName: "MS2PatrolData0_1001");
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "findrepairman");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

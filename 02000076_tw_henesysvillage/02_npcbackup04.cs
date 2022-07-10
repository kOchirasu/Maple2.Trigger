namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _02_npcbackup04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{1002}, questIds: new []{10002041}, questStates: new byte[]{1})) {
                    return new StateReinforcementsCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsCreation : TriggerState {
            internal StateReinforcementsCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{204}, arg2: false);
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_24");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 4004, spawnIds: new []{204})) {
                    return new StateMoveReinforcements(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveReinforcements : TriggerState {
            internal StateMoveReinforcements(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 204, script: "$02000076_TW_HenesysVillage__02_NPCBACKUP04__0$", arg4: 1);
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_204");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 2001, spawnIds: new []{204})) {
                    return new StateReinforcementsDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsDead : TriggerState {
            internal StateReinforcementsDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{204});
                context.SetTimer(timerId: "1", seconds: 120);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

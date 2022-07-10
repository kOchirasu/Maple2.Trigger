namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _01_npcbackup07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{1001}, questIds: new []{10002041}, questStates: new byte[]{1})) {
                    return new StateReinforcementsCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsCreation : TriggerState {
            internal StateReinforcementsCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{107}, arg2: false);
                context.MoveNpc(spawnId: 107, patrolName: "MS2PatrolData_17");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 3007, spawnIds: new []{107})) {
                    return new StateMoveReinforcements(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveReinforcements : TriggerState {
            internal StateMoveReinforcements(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 104, script: "$02000076_TW_HenesysVillage__01_NPCBACKUP07__0$", arg4: 1);
                context.MoveNpc(spawnId: 107, patrolName: "MS2PatrolData_107");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 2001, spawnIds: new []{107})) {
                    return new StateReinforcementsDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsDead : TriggerState {
            internal StateReinforcementsDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{107});
                context.SetTimer(timerId: "3", seconds: 90);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

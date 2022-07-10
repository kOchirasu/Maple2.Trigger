namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _01_npcbackup06 {
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
                context.CreateMonster(spawnIds: new []{106}, arg2: false);
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_16");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 3006, spawnIds: new []{106})) {
                    return new StateMoveReinforcements(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveReinforcements : TriggerState {
            internal StateMoveReinforcements(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_106");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 2001, spawnIds: new []{106})) {
                    return new StateReinforcementsDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsDead : TriggerState {
            internal StateReinforcementsDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{106});
                context.SetTimer(timerId: "6", seconds: 120);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

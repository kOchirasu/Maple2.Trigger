namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _02_npcbackup02 {
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
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_22");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 4002, spawnIds: new []{202})) {
                    return new StateMoveReinforcements(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveReinforcements : TriggerState {
            internal StateMoveReinforcements(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_202");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 2001, spawnIds: new []{202})) {
                    return new StateReinforcementsDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsDead : TriggerState {
            internal StateReinforcementsDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{202});
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

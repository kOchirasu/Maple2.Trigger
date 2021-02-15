namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _01_npcbackup05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {1001}, arg2: new[] {10002041}, arg3: new byte[] {1})) {
                    return new StateReinforcementsCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsCreation : TriggerState {
            internal StateReinforcementsCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_15");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 3005, arg2: new[] {105})) {
                    return new StateMoveReinforcements(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveReinforcements : TriggerState {
            internal StateMoveReinforcements(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_105");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new[] {105})) {
                    return new StateReinforcementsDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsDead : TriggerState {
            internal StateReinforcementsDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {105});
                context.SetTimer(arg1: "5", arg2: 90);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
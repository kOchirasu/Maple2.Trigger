namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _02_npcbackup05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {1002}, arg2: new[] {10002041}, arg3: new byte[] {1})) {
                    return new StateReinforcementsCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsCreation : TriggerState {
            internal StateReinforcementsCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: false);
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_25");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 4005, arg2: new[] {205})) {
                    return new StateMoveReinforcements(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveReinforcements : TriggerState {
            internal StateMoveReinforcements(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_205");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new[] {205})) {
                    return new StateReinforcementsDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsDead : TriggerState {
            internal StateReinforcementsDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {205});
                context.SetTimer(arg1: "1", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000076_tw_henesysvillage {
    public static class _01_npcbackup01 {
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
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_11");
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000076_TW_HenesysVillage__01_NPCBACKUP01__0$", arg4: 1);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 3001, arg2: new[] {101})) {
                    return new StateMoveReinforcements(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveReinforcements : TriggerState {
            internal StateMoveReinforcements(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 2001, arg2: new[] {101})) {
                    return new StateReinforcementsDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReinforcementsDead : TriggerState {
            internal StateReinforcementsDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.SetTimer(id: "1", arg2: 60);
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
namespace Maple2.Trigger._52020039_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000590},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC소환(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000600},
                    arg3: new byte[] {1})) {
                    context.State = new StateNPC소환(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000600},
                    arg3: new byte[] {2})) {
                    context.State = new StateNPC소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소환 : TriggerState {
            internal StateNPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.CreateMonster(arg1: new[] {105}, arg2: false);
                context.CreateMonster(arg1: new[] {106}, arg2: false);
                context.CreateMonster(arg1: new[] {107}, arg2: false);
                context.CreateMonster(arg1: new[] {108}, arg2: false);
                context.CreateMonster(arg1: new[] {109}, arg2: false);
                context.CreateMonster(arg1: new[] {110}, arg2: false);
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.CreateMonster(arg1: new[] {112}, arg2: false);
                context.CreateMonster(arg1: new[] {113}, arg2: false);
                context.CreateMonster(arg1: new[] {114}, arg2: false);
                context.CreateMonster(arg1: new[] {115}, arg2: false);
                context.CreateMonster(arg1: new[] {116}, arg2: false);
                context.CreateMonster(arg1: new[] {117}, arg2: false);
                context.CreateMonster(arg1: new[] {118}, arg2: false);
                context.CreateMonster(arg1: new[] {119}, arg2: false);
                context.CreateMonster(arg1: new[] {120}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
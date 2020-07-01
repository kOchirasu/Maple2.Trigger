namespace Maple2.Trigger._52000093_qd {
    public static class _52000093_trigger {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3003, 3004}, arg2: false);
                context.DestroyMonster(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {50100490},
                    arg3: new byte[] {1})) {
                    context.State = new State20002274진행중일때(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {20002274},
                    arg3: new byte[] {1})) {
                    context.State = new State20002274진행중일때(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20002274진행중일때 : TriggerState {
            internal State20002274진행중일때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008},
                    arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008})) {
                    context.State = new State20002274진행중일때(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
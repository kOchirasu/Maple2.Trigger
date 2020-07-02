namespace Maple2.Trigger._52000093_qd {
    public static class _52000093_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3003, 3004}, arg2: false);
                context.DestroyMonster(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008});
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {50100490}, arg3: new byte[] {1})) {
                    return new State20002274진행중일때(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9100}, arg2: new[] {20002274}, arg3: new byte[] {1})) {
                    return new State20002274진행중일때(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20002274진행중일때 : TriggerState {
            internal State20002274진행중일때(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008})) {
                    return new State20002274진행중일때(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000213_bf {
    public static class _spawncheck {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1099})) {
                    context.State = new State잡몹소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잡몹소멸 : TriggerState {
            internal State잡몹소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
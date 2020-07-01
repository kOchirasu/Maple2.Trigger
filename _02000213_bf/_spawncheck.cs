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
                context.DestroyMonster(arg1: new[] {1001});
                context.DestroyMonster(arg1: new[] {1002});
                context.DestroyMonster(arg1: new[] {1003});
                context.DestroyMonster(arg1: new[] {1004});
                context.DestroyMonster(arg1: new[] {1005});
                context.DestroyMonster(arg1: new[] {1006});
                context.DestroyMonster(arg1: new[] {1007});
                context.DestroyMonster(arg1: new[] {1008});
                context.DestroyMonster(arg1: new[] {1009});
                context.DestroyMonster(arg1: new[] {1010});
                context.DestroyMonster(arg1: new[] {1011});
                context.DestroyMonster(arg1: new[] {1012});
                context.DestroyMonster(arg1: new[] {1013});
                context.DestroyMonster(arg1: new[] {1014});
                context.DestroyMonster(arg1: new[] {1015});
                context.DestroyMonster(arg1: new[] {1016});
                context.DestroyMonster(arg1: new[] {1017});
                context.DestroyMonster(arg1: new[] {1018});
                context.DestroyMonster(arg1: new[] {1019});
                context.DestroyMonster(arg1: new[] {1020});
                context.DestroyMonster(arg1: new[] {1021});
                context.DestroyMonster(arg1: new[] {1022});
                context.DestroyMonster(arg1: new[] {1023});
                context.DestroyMonster(arg1: new[] {1024});
                context.DestroyMonster(arg1: new[] {1025});
                context.DestroyMonster(arg1: new[] {1026});
                context.DestroyMonster(arg1: new[] {1027});
                context.DestroyMonster(arg1: new[] {1028});
                context.DestroyMonster(arg1: new[] {1029});
                context.DestroyMonster(arg1: new[] {1030});
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
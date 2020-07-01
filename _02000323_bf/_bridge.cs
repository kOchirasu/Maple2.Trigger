namespace Maple2.Trigger._02000323_bf {
    public static class _bridge {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {99})) {
                    context.State = new State발판01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판01 : TriggerState {
            internal State발판01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010},
                    arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    context.State = new State재생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재생성 : TriggerState {
            internal State재생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
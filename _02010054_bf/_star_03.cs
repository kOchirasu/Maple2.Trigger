namespace Maple2.Trigger._02010054_bf {
    public static class _star_03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000861}, arg2: 2);
                context.SetEffect(arg1: new[] {606}, arg2: false);
                context.SetMesh(arg1: new[] {3310, 3311, 3312, 3313}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3126}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3310, 3311, 3312, 3313}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3126}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new[] {3310, 3311, 3312, 3313}, arg2: false, arg3: 0, arg4: 900, arg5: 3f);
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.CreateMonster(arg1: new[] {2005}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2005})) {
                    context.SetInteractObject(arg1: new[] {10000861}, arg2: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
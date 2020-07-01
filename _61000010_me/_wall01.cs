namespace Maple2.Trigger._61000010_me {
    public static class _wall01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000042}, arg2: 1);
                context.SetMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000042}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205}, arg2: true, arg3: 0, arg4: 0,
                        arg5: 0f);
                    context.State = new State쿨타임(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쿨타임 : TriggerState {
            internal State쿨타임(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
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
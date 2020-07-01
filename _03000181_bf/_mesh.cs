namespace Maple2.Trigger._03000181_bf {
    public static class _mesh {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003}, arg2: true, arg3: 0, arg4: 300, arg5: 3f);
                context.SetInteractObject(arg1: new[] {10000728}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000728}, arg2: 0)) {
                    return new State부서짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부서짐 : TriggerState {
            internal State부서짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003}, arg2: false, arg3: 0, arg4: 300, arg5: 3f);
                context.SetTimer(arg1: "25", arg2: 25);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
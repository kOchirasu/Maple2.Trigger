using System;

namespace Maple2.Trigger._02010036_bf {
    public static class _water {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 30, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State부서짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부서짐 : TriggerState {
            internal State부서짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 30, arg5: 2f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "101")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
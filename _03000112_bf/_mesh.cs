using System;

namespace Maple2.Trigger._03000112_bf {
    public static class _mesh {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010},
                    arg2: true, arg3: 0, arg4: 50, arg5: 3f);
                context.SetInteractObject(arg1: new int[] {10000729}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000729}, arg2: 0)) {
                    context.State = new State부서짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State부서짐 : TriggerState {
            internal State부서짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010},
                    arg2: false, arg3: 0, arg4: 50, arg5: 3f);
                context.SetTimer(arg1: "25", arg2: 25);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
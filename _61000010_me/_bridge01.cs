using System;

namespace Maple2.Trigger._61000010_me {
    public static class _bridge01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000041}, arg2: 1);
                context.SetMesh(arg1: new int[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000041}, arg2: 0)) {
                    context.SetMesh(arg1: new int[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110},
                        arg2: false, arg3: 0, arg4: 100, arg5: 1f);
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
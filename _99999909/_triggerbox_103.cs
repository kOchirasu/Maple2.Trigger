using System;

namespace Maple2.Trigger._99999909 {
    public static class _triggerbox_103 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State블록(context);

        private class State블록 : TriggerState {
            internal State블록(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3031, 3032, 3033, 3034, 3035, 3036, 3037}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "103")) {
                    context.State = new State블록생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블록생성 : TriggerState {
            internal State블록생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new int[] {3031, 3032, 3033, 3034, 3035, 3036, 3037}, arg2: true, arg3: 4,
                    arg4: 0, arg5: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
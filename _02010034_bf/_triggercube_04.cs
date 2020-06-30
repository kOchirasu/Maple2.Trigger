using System;

namespace Maple2.Trigger._02010034_bf {
    public static class _triggercube_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3004}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "104")) {
                    context.State = new State발판(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판 : TriggerState {
            internal State발판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3004}, arg2: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "104")) {
                    context.State = new State발판숨김(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판숨김 : TriggerState {
            internal State발판숨김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
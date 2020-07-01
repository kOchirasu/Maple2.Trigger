using System;

namespace Maple2.Trigger._02010026_bf {
    public static class _05_mesh12 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5004}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {50004})) {
                    context.State = new State발판01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판01 : TriggerState {
            internal State발판01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {5004}, arg2: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {50004})) {
                    context.State = new State발판01끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판01끝 : TriggerState {
            internal State발판01끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
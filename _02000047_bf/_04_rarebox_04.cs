using System;

namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {404}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {204})) {
                    context.State = new State발판04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판04 : TriggerState {
            internal State발판04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {404}, arg2: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {204})) {
                    context.State = new State발판04끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판04끝 : TriggerState {
            internal State발판04끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "504", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "504")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
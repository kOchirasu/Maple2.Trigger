using System;

namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {402}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "202")) {
                    context.State = new State발판02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판02 : TriggerState {
            internal State발판02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {402}, arg2: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "202")) {
                    context.State = new State발판02끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판02끝 : TriggerState {
            internal State발판02끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "502", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "502")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
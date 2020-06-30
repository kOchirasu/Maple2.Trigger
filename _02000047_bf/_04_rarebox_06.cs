using System;

namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_06 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {406}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "206")) {
                    context.State = new State발판06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판06 : TriggerState {
            internal State발판06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {406}, arg2: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "206")) {
                    context.State = new State발판06끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판06끝 : TriggerState {
            internal State발판06끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "506", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "506")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
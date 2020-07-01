using System;

namespace Maple2.Trigger._61000010_me {
    public static class _winner {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {102})) {
                    context.State = new State업적(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State업적 : TriggerState {
            internal State업적(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 102, arg2: "trigger", arg3: "WinSanghaiRunners");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
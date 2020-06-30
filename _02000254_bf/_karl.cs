using System;

namespace Maple2.Trigger._02000254_bf {
    public static class _karl {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {450}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "904")) {
                    context.State = new State말풍선(context);
                    return;
                }

                if (context.MonsterInCombat(arg1: new int[] {106})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선 : TriggerState {
            internal State말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "8", arg2: 8);
                context.SetEffect(arg1: new int[] {450}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$02000254_BF__KARL__0$", arg4: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "8")) {
                    context.State = new State시작(context);
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
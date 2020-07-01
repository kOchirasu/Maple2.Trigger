namespace Maple2.Trigger._02000254_bf {
    public static class _karl {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {450}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {904})) {
                    return new State말풍선(context);
                }

                if (context.MonsterInCombat(arg1: new[] {106})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선 : TriggerState {
            internal State말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "8", arg2: 8);
                context.SetEffect(arg1: new[] {450}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$02000254_BF__KARL__0$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "8")) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
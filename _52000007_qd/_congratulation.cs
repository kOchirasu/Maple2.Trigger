namespace Maple2.Trigger._52000007_qd {
    public static class _congratulation {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200, 201}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State축하대기1(context);
            }

            public override void OnExit() { }
        }

        private class State축하대기1 : TriggerState {
            internal State축하대기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.BonusGameRewardDetected(arg1: 101, arg2: true)) {
                    return new State축하1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State축하1 : TriggerState {
            internal State축하1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200, 201}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State축하2(context);
            }

            public override void OnExit() { }
        }

        private class State축하2 : TriggerState {
            internal State축하2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$52000007_QD__CONGRATULATION__0$");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000007_QD__CONGRATULATION__1$");
                context.SetTimer(arg1: "1", arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {200, 201}, arg2: false);
            }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
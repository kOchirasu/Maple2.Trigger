namespace Maple2.Trigger._02010051_bf {
    public static class _soundeffect05 {
        public class State대기01 : TriggerState {
            internal State대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000, 6001, 6002, 6003, 900}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new State음성연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State음성연출 : TriggerState {
            internal State음성연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
                context.SetEffect(arg1: new[] {900}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기02 : TriggerState {
            internal State대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {10000})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {900}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
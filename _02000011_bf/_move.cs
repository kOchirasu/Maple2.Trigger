namespace Maple2.Trigger._02000011_bf {
    public static class _move {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2, arg3: false);
                context.SetBreakable(arg1: new[] {7000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000361}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000361}, arg2: 0)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6, arg3: false);
                context.SetBreakable(arg1: new[] {7000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
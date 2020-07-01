namespace Maple2.Trigger._02010028_bf {
    public static class _portal02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 50, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new[] {10000903}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000903}, arg2: 0)) {
                    return new State생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 50, arg2: true, arg3: true, arg4: false);
                context.SetTimer(arg1: "2", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.SetPortal(arg1: 50, arg2: false, arg3: false, arg4: false);
                    return new State재사용대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재사용대기 : TriggerState {
            internal State재사용대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
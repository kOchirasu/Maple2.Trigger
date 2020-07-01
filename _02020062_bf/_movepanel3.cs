namespace Maple2.Trigger._02020062_bf {
    public static class _movepanel3 {
        public class State발판초기화 : TriggerState {
            internal State발판초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, arg2: false);
                context.SetUserValue(triggerId: 99990026, key: "MovePanel03", value: 0);
                context.SetInteractObject(arg1: new[] {12000117}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MovePanel03") == 1) {
                    return new State레버생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버생성 : TriggerState {
            internal State레버생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000117}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000117}, arg2: 0)) {
                    return new State발판이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판이동 : TriggerState {
            internal State발판이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000117}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9202})) {
                    context.SetBreakable(arg1: new[] {2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, arg2: true);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State발판이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
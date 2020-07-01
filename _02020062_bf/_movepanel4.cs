namespace Maple2.Trigger._02020062_bf {
    public static class _movepanel4 {
        public class State발판초기화 : TriggerState {
            internal State발판초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: false);
                context.SetUserValue(triggerId: 99990027, key: "MovePanel04", value: 0);
                context.SetInteractObject(arg1: new[] {12000118}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MovePanel04") == 1) {
                    return new State레버생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버생성 : TriggerState {
            internal State레버생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000118}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000118}, arg2: 0)) {
                    return new State발판이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판이동 : TriggerState {
            internal State발판이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000118}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9203})) {
                    context.SetBreakable(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: true);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: false);
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
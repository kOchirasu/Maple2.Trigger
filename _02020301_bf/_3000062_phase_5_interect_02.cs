namespace Maple2.Trigger._02020301_bf {
    public static class _3000062_phase_5_interect_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200033, 200034}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Phase_5_Interect_02") == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State인터렉트_설정(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_설정 : TriggerState {
            internal State인터렉트_설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200033, 200034}, arg2: true);
                context.SetInteractObject(arg1: new[] {10003102}, arg2: 1);
                context.SetVisibleBreakableObject(arg1: new[] {5520}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003102}, arg2: 0)) {
                    context.State = new State인터렉트_동작(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_5_Interect_02") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200033, 200034}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State인터렉트_리셋(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_5_Interect_02") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State인터렉트_설정(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_5_Interect_02") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
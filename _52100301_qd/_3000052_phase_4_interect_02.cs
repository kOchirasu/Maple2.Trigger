namespace Maple2.Trigger._52100301_qd {
    public static class _3000052_phase_4_interect_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200023, 200024}, arg2: false);
                context.SetInteractObject(arg1: new[] {10003112}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Phase_4_Interect_02") == 1) {
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
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State인터렉트_설정(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_4_Interect_02") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_설정 : TriggerState {
            internal State인터렉트_설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200023, 200024}, arg2: true);
                context.SetInteractObject(arg1: new[] {10003112}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003112}, arg2: 0)) {
                    context.State = new State인터렉트_동작(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_4_Interect_02") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200023, 200024}, arg2: false);
                context.SetAiExtraData(key: "Phase_4_Sub_Bomb_2", value: 1, isModify: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State인터렉트_리셋(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_4_Interect_02") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Phase_4_Sub_Bomb_2", value: 0, isModify: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State인터렉트_설정(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_4_Interect_02") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
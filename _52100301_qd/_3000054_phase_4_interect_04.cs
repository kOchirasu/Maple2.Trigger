namespace Maple2.Trigger._52100301_qd {
    public static class _3000054_phase_4_interect_04 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200027, 200028}, arg2: false);
                context.SetInteractObject(arg1: new[] {10003114}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Phase_4_Interect_04") == 1) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State인터렉트_설정(context);
                }

                if (context.GetUserValue(key: "Phase_4_Interect_04") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_설정 : TriggerState {
            internal State인터렉트_설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200027, 200028}, arg2: true);
                context.SetInteractObject(arg1: new[] {10003114}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003114}, arg2: 0)) {
                    return new State인터렉트_동작(context);
                }

                if (context.GetUserValue(key: "Phase_4_Interect_04") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200027, 200028}, arg2: false);
                context.SetAiExtraData(key: "Phase_4_Sub_Bomb_4", value: 1, isModify: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인터렉트_리셋(context);
                }

                if (context.GetUserValue(key: "Phase_4_Interect_04") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Phase_4_Sub_Bomb_4", value: 0, isModify: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State인터렉트_설정(context);
                }

                if (context.GetUserValue(key: "Phase_4_Interect_04") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
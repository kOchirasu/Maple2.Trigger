namespace Maple2.Trigger._02020301_bf {
    public static class _3000041_phase_3_interect_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200015, 200016, 200017, 200018}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Phase_3_Interect_01") == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1003}, arg2: 62100168, arg3: 1);
            }

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
                context.SetEffect(arg1: new[] {200015, 200016, 200017, 200018}, arg2: true);
                context.SetInteractObject(arg1: new[] {10003122}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003122}, arg2: 0)) {
                    context.State = new State인터렉트_동작(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_3_Interect_01") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200015, 200016, 200017, 200018}, arg2: false);
                context.SetAiExtraData(key: "Shoot_Cannon_1", value: 1, isModify: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State인터렉트_리셋(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_3_Interect_01") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Shoot_Cannon_1", value: 0, isModify: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State인터렉트_설정(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_3_Interect_01") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
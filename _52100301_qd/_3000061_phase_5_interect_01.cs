namespace Maple2.Trigger._52100301_qd {
    public static class _3000061_phase_5_interect_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200031, 200032}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Phase_5_Interect_01") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52100301_QD__3000061_PHASE_5_INTERECT_01__0$", arg3: 4000);
                context.CreateMonster(arg1: new[] {999}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State탈것_Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_Appear : TriggerState {
            internal State탈것_Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003126}, arg2: 1);
                context.DestroyMonster(arg1: new[] {999});
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003126}, arg2: 0)) {
                    return new State인터렉트_동작(context);
                }

                if (context.GetUserValue(key: "Phase_5_Interect_01") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인터렉트_리셋(context);
                }

                if (context.GetUserValue(key: "Phase_5_Interect_01") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 0, additionalEffectId: 62100152, level: true)) {
                    return new State리셋_대기(context);
                }

                if (context.GetUserValue(key: "Phase_5_Interect_01") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리셋_대기 : TriggerState {
            internal State리셋_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "Phase_5_Interect_01") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
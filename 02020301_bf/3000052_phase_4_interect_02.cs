namespace Maple2.Trigger._02020301_bf {
    public static class _3000052_phase_4_interect_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200023, 200024}, visible: false);
                context.SetInteractObject(interactIds: new []{10003112}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Phase_4_Interect_02") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State인터렉트_설정(context);
                }

                if (context.GetUserValue(key: "Phase_4_Interect_02") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_설정 : TriggerState {
            internal State인터렉트_설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200023, 200024}, visible: true);
                context.SetInteractObject(interactIds: new []{10003112}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003112}, arg2: 0)) {
                    return new State인터렉트_동작(context);
                }

                if (context.GetUserValue(key: "Phase_4_Interect_02") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200023, 200024}, visible: false);
                context.SetAiExtraData(key: "Phase_4_Sub_Bomb_2", value: 1, isModify: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인터렉트_리셋(context);
                }

                if (context.GetUserValue(key: "Phase_4_Interect_02") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Phase_4_Sub_Bomb_2", value: 0, isModify: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State인터렉트_설정(context);
                }

                if (context.GetUserValue(key: "Phase_4_Interect_02") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

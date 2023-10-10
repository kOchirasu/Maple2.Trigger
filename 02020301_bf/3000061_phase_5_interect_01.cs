namespace Maple2.Trigger._02020301_bf {
    public static class _3000061_phase_5_interect_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200031, 200032}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Phase_5_Interect_01") == 1) {
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
                if (context.WaitTick(waitTick: 3000)) {
                    return new State인터렉트_설정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_설정 : TriggerState {
            internal State인터렉트_설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200031, 200032}, visible: true);
                context.SetInteractObject(interactIds: new []{10003101}, state: 1);
                context.SetVisibleBreakableObject(triggerIds: new []{5510}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003101}, arg2: 0)) {
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

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200031, 200032}, visible: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State인터렉트_설정(context);
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

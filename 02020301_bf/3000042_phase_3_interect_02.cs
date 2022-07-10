namespace Maple2.Trigger._02020301_bf {
    public static class _3000042_phase_3_interect_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200011, 200012, 200013, 200014}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Phase_3_Interect_02") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{1003}, skillId: 62100168, level: 1);
            }

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
                context.SetEffect(triggerIds: new []{200011, 200012, 200013, 200014}, visible: true);
                context.SetInteractObject(interactIds: new []{10003121}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003121}, arg2: 0)) {
                    return new State인터렉트_동작(context);
                }

                if (context.GetUserValue(key: "Phase_3_Interect_02") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200011, 200012, 200013, 200014}, visible: false);
                context.SetAiExtraData(key: "Shoot_Cannon_2", value: 1, isModify: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State인터렉트_리셋(context);
                }

                if (context.GetUserValue(key: "Phase_3_Interect_02") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Shoot_Cannon_2", value: 0, isModify: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State인터렉트_설정(context);
                }

                if (context.GetUserValue(key: "Phase_3_Interect_02") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

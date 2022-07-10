namespace Maple2.Trigger._02000376_bf {
    public static class _02_givelight {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001022}, state: 0);
                context.SetUserValue(key: "InnerLight", value: 0);
                context.SetUserValue(key: "InactivateLotus", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "InnerLight") == 1) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001022}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001022}, arg2: 0)) {
                    return new StateGiveLight01(context);
                }

                if (context.GetUserValue(key: "InactivateLotus") == 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGiveLight01 : TriggerState {
            internal StateGiveLight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9100}, skillId: 70000102, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDelay01(context);
                }

                if (context.GetUserValue(key: "InactivateLotus") == 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

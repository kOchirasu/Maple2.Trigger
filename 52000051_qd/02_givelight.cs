namespace Maple2.Trigger._52000051_qd {
    public static class _02_givelight {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001022}, arg2: 0);
                context.SetUserValue(key: "InnerLight", value: 0);
                context.SetUserValue(key: "InactivateLotus", value: 0);
            }

            public override TriggerState Execute() {
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
                context.SetInteractObject(arg1: new[] {10001022}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001022}, arg2: 0)) {
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
                context.AddBuff(arg1: new[] {9100}, arg2: 70000102, arg3: 1);
            }

            public override TriggerState Execute() {
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
namespace Maple2.Trigger._52000051_qd {
    public static class _03_removelight {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ResetInnerLight", value: 0);
                context.SetUserValue(key: "RemoveInnerLight", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ResetInnerLight") == 1) {
                    return new StatePlay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlay : TriggerState {
            internal StatePlay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ResetInnerLight", value: 0);
                context.SetUserValue(key: "RemoveInnerLight", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RemoveInnerLight") == 1) {
                    return new StateRemoveLight01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemoveLight01 : TriggerState {
            internal StateRemoveLight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9001}, skillId: 70000103, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

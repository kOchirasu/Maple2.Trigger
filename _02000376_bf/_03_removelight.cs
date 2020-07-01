namespace Maple2.Trigger._02000376_bf {
    public static class _03_removelight {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ResetInnerLight", value: 0);
                context.SetUserValue(key: "RemoveInnerLight", value: 0);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.AddBuff(arg1: new[] {9001}, arg2: 70000103, arg3: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
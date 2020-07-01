using System.Numerics;

namespace Maple2.Trigger._02000376_bf {
    public static class _09_lightup {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLightOff01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLightOff01 : TriggerState {
            internal StateLightOff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9200, arg2: new[] {900})) {
                    context.State = new StateLightOff02(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 9200, arg2: new[] {900})) {
                    context.State = new StateRemoveTotem01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLightOff02 : TriggerState {
            internal StateLightOff02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "InnerLight", value: 1);
                context.SetUserValue(triggerId: 3, key: "ResetInnerLight", value: 1);
                context.SetAmbientLight(arg1: new Vector3(0f, 0f, 0f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(0f, 0f, 0f));
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRemoveTotem01 : TriggerState {
            internal StateRemoveTotem01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "RemoveInnerLight", value: 1);
                context.SetUserValue(triggerId: 2, key: "InactivateLotus", value: 1);
                context.SetAmbientLight(arg1: new Vector3(96f, 160f, 157f));
                context.SetDirectionalLight(arg1: new Vector3(193f, 180f, 137f), arg2: new Vector3(100f, 100f, 100f));
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
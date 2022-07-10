using System.Numerics;

namespace Maple2.Trigger._02000376_bf {
    public static class _09_lightup {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) == 1) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLightOff01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLightOff01 : TriggerState {
            internal StateLightOff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9200, spawnIds: new []{900})) {
                    return new StateLightOff02(context);
                }

                if (!context.NpcDetected(boxId: 9200, spawnIds: new []{900})) {
                    return new StateRemoveTotem01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLightOff02 : TriggerState {
            internal StateLightOff02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "InnerLight", value: 1);
                context.SetUserValue(triggerId: 3, key: "ResetInnerLight", value: 1);
                context.SetAmbientLight(color: default);
                context.SetDirectionalLight(diffuseColor: default, specularColor: default);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemoveTotem01 : TriggerState {
            internal StateRemoveTotem01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "RemoveInnerLight", value: 1);
                context.SetUserValue(triggerId: 2, key: "InactivateLotus", value: 1);
                context.SetAmbientLight(color: new Vector3(96f, 160f, 157f));
                context.SetDirectionalLight(diffuseColor: new Vector3(193f, 180f, 137f), specularColor: new Vector3(100f, 100f, 100f));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

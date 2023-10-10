using System.Numerics;

namespace Maple2.Trigger._99999908 {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(1f, 1f, 1f));
                context.SetDirectionalLight(diffuseColor: new Vector3(1f, 1f, 1f), specularColor: default);
                context.SetTimer(timerId: "240", seconds: 240, autoRemove: true, display: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwitch : TriggerState {
            internal StateSwitch(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

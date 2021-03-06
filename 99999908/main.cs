using System.Numerics;

namespace Maple2.Trigger._99999908 {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(1f, 1f, 1f));
                context.SetDirectionalLight(arg1: new Vector3(1f, 1f, 1f), arg2: new Vector3(0f, 0f, 0f));
                context.SetTimer(id: "240", arg2: 240, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwitch : TriggerState {
            internal StateSwitch(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
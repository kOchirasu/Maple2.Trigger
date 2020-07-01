using System.Numerics;

namespace Maple2.Trigger._99999908 {
    public static class _main {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(1f, 1f, 1f));
                context.SetDirectionalLight(arg1: new Vector3(1f, 1f, 1f), arg2: new Vector3(0f, 0f, 0f));
                context.SetTimer(arg1: "240", arg2: 240, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Stateswitch : TriggerState {
            internal Stateswitch(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
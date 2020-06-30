using System;

namespace Maple2.Trigger._02100001_bf {
    public static class _3004_falldown {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9004")) {
                    context.State = new StateRemoveMesh(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRemoveMesh : TriggerState {
            internal StateRemoveMesh(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9004")) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
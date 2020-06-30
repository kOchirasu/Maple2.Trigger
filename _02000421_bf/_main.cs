using System;

namespace Maple2.Trigger._02000421_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {6001}, arg2: false);
                context.SetMesh(arg1: new int[] {6002}, arg2: false);
                context.SetMesh(arg1: new int[] {6003}, arg2: false);
                context.SetMesh(arg1: new int[] {6004}, arg2: false);
                context.SetMesh(arg1: new int[] {6005}, arg2: false);
                context.SetMesh(arg1: new int[] {6006}, arg2: false);
                context.SetMesh(arg1: new int[] {6007}, arg2: false);
                context.SetMesh(arg1: new int[] {6008}, arg2: false);
                context.SetMesh(arg1: new int[] {6009}, arg2: false);
                context.SetMesh(arg1: new int[] {6010}, arg2: false);
                context.SetMesh(arg1: new int[] {6011}, arg2: false);
                context.SetMesh(arg1: new int[] {6012}, arg2: false);
                context.SetMesh(arg1: new int[] {6013}, arg2: false);
                context.SetMesh(arg1: new int[] {6014}, arg2: false);
                context.SetMesh(arg1: new int[] {6015}, arg2: false);
                context.SetMesh(arg1: new int[] {6016}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 700, arg2: 1)) {
                    context.State = new StateReady_Idle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle : TriggerState {
            internal StateReady_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
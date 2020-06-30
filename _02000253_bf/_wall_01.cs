using System;

namespace Maple2.Trigger._02000253_bf {
    public static class _wall_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9001", arg2: true);
                context.SetAgent(arg1: "9002", arg2: true);
                context.SetMesh(arg1: new int[] {501, 502}, arg2: true);
                context.SetMesh(arg1: new int[] {601, 602, 603}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000437}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000437}, arg2: 0)) {
                    context.State = new State열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "9001", arg2: false);
                context.SetAgent(arg1: "9002", arg2: false);
                context.SetMesh(arg1: new int[] {501, 502}, arg2: false);
                context.SetMesh(arg1: new int[] {601, 602, 603}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
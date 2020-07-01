using System;

namespace Maple2.Trigger._02000298_bf {
    public static class _door_11 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 211, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {3111}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3112}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: "9111", arg2: true);
                context.SetAgent(arg1: "9112", arg2: true);
                context.SetAgent(arg1: "9113", arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {111})) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 211, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3111}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMesh(arg1: new int[] {3112}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetAgent(arg1: "9111", arg2: false);
                context.SetAgent(arg1: "9112", arg2: false);
                context.SetAgent(arg1: "9113", arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
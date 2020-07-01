using System;

namespace Maple2.Trigger._02000241_bf {
    public static class _trigger_01_04 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {303}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {403})) {
                    context.State = new State버튼눌림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버튼눌림 : TriggerState {
            internal State버튼눌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {303}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {701, 702}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
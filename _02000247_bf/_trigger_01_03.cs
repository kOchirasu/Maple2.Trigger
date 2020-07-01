using System;

namespace Maple2.Trigger._02000247_bf {
    public static class _trigger_01_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {302}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {402})) {
                    context.State = new State버튼눌림(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {405})) {
                    context.State = new State사라짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버튼눌림 : TriggerState {
            internal State버튼눌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {302}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {402})) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {405})) {
                    context.State = new State사라짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사라짐 : TriggerState {
            internal State사라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {302}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
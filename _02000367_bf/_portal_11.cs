using System;

namespace Maple2.Trigger._02000367_bf {
    public static class _portal_11 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 811, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000993}, arg2: 0)) {
                    context.State = new State포털활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털활성화 : TriggerState {
            internal State포털활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 811, arg2: false, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetInteractObject(arg1: new int[] {10000993}, arg2: 1);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
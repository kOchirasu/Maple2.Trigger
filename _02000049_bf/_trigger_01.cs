using System;

namespace Maple2.Trigger._02000049_bf {
    public static class _trigger_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000289}, arg2: 1);
                context.SetEffect(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000289}, arg2: 0)) {
                    context.State = new State비내림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비내림 : TriggerState {
            internal State비내림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {101}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
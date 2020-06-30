using System;

namespace Maple2.Trigger._02000325_bf {
    public static class _heal02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {702}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000740}, arg2: 0)) {
                    context.State = new State스킬작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬작동 : TriggerState {
            internal State스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {702}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.SetSkill(arg1: new int[] {702}, arg2: false);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.SetInteractObject(arg1: new int[] {10000740}, arg2: 2);
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
using System;

namespace Maple2.Trigger._02010086_bf {
    public static class _boss_bomb {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 799, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {6001}, arg2: true);
                context.SetSkill(arg1: new int[] {6002}, arg2: true);
                context.SetSkill(arg1: new int[] {6003}, arg2: true);
                context.SetSkill(arg1: new int[] {6004}, arg2: true);
                context.SetEffect(arg1: new int[] {6010}, arg2: true);
                context.SetEffect(arg1: new int[] {6011}, arg2: true);
                context.SetEffect(arg1: new int[] {6012}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
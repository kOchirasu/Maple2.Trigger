using System;

namespace Maple2.Trigger._02000336_bf {
    public static class _touchevent {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 702, arg2: 1)) {
                    context.State = new State몬스터생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {118, 119}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
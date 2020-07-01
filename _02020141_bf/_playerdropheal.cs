using System;

namespace Maple2.Trigger._02020141_bf {
    public static class _playerdropheal {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State트리거시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거시작 : TriggerState {
            internal State트리거시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {102})) {
                    context.State = new State드랍지점회복(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State드랍지점회복 : TriggerState {
            internal State드랍지점회복(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {102}, arg2: 50000554, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State트리거시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
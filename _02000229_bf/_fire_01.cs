using System;

namespace Maple2.Trigger._02000229_bf {
    public static class _fire_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000051}, arg2: 1);
                context.SetEffect(arg1: new int[] {501}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000051}, arg2: 0)) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {501}, arg2: true);
                context.CreateMonster(arg1: new int[] {101});
            }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000229_BF__FIRE_01__0$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State딜레이2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {501}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101});
            }
        }

        private class State딜레이2 : TriggerState {
            internal State딜레이2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
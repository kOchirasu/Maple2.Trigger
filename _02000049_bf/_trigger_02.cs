using System;

namespace Maple2.Trigger._02000049_bf {
    public static class _trigger_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201});
                context.SetInteractObject(arg1: new int[] {10000286}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000286}, arg2: 0)) {
                    context.State = new State반항(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반항 : TriggerState {
            internal State반항(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000049_BF__TRIGGER_02__0$", arg4: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State반항2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반항2 : TriggerState {
            internal State반항2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: false);
                context.SetInteractObject(arg1: new int[] {10000286}, arg2: 2);
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
using System;

namespace Maple2.Trigger._02000421_bf {
    public static class _eventnpcappearance {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State보스등장대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장대기 : TriggerState {
            internal State보스등장대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {111}, arg2: true);
                context.CreateMonster(arg1: new int[] {121}, arg2: true);
                context.CreateMonster(arg1: new int[] {131}, arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "EventNpcAppearance", value: 1)) {
                    context.State = new State우호적NPC등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State우호적NPC등장 : TriggerState {
            internal State우호적NPC등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {111}, arg2: true);
                context.DestroyMonster(arg1: new int[] {121}, arg2: true);
                context.DestroyMonster(arg1: new int[] {131}, arg2: true);
                context.CreateMonster(arg1: new int[] {11}, arg2: true);
                context.CreateMonster(arg1: new int[] {21}, arg2: true);
                context.CreateMonster(arg1: new int[] {31}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "EventNpcAppearance", value: 2)) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
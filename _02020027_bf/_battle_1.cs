using System;

namespace Maple2.Trigger._02020027_bf {
    public static class _battle_1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State전투시작(context);

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State전투시작_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작_2 : TriggerState {
            internal State전투시작_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "summon_1_1", value: 1)) {
                    context.State = new State몬스터소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환 : TriggerState {
            internal State몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {301, 302, 303, 304, 305, 306});
                context.SetEventUI(arg1: 1, arg2: "$02020027_BF__battle_1__0$", arg3: new int[] {4000});
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02020027_BF__battle_1__1$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$02020027_BF__battle_1__2$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 305, arg3: "$02020027_BF__battle_1__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {301, 302, 303, 304, 305, 306})) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {201}, arg2: 62000002, arg3: 1, arg4: true);
                context.AddBuff(arg1: new int[] {201}, arg2: 51200002, arg3: 1, arg4: true);
            }

            public override void Execute() {
                if (true) { }
            }

            public override void OnExit() { }
        }
    }
}
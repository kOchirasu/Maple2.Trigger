using System;

namespace Maple2.Trigger._02020019_bf {
    public static class _02020019_5phase {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "5Phase", value: 1)) {
                    context.State = new State크림슨발록스폰체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨발록스폰체크 : TriggerState {
            internal State크림슨발록스폰체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new int[] {241}, arg2: 49218001, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new int[] {242}, arg2: 49218001, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new int[] {243}, arg2: 49218001, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new int[] {244}, arg2: 49218001, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new int[] {245}, arg2: 49218001, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new int[] {246}, arg2: 49218001, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_01", arg1: new int[] {247}, arg2: 49218001, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new int[] {241}, arg2: 49218002, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new int[] {242}, arg2: 49218002, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new int[] {243}, arg2: 49218002, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new int[] {244}, arg2: 49218002, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new int[] {245}, arg2: 49218002, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new int[] {246}, arg2: 49218002, arg3: 1,
                    arg4: true);
                context.AddBuff(feature: "FameChallengeBuff_02", arg1: new int[] {247}, arg2: 49218002, arg3: 1,
                    arg4: true);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {242})) {
                    context.State = new State크림슨스피어죽음(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨스피어죽음 : TriggerState {
            internal State크림슨스피어죽음(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {241})) {
                    context.State = new State발록에게신호쏴주기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발록에게신호쏴주기 : TriggerState {
            internal State발록에게신호쏴주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "SpearDead", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
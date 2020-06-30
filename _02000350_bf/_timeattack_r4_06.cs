using System;

namespace Maple2.Trigger._02000350_bf {
    public static class _timeattack_r4_06 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 140, arg2: new int[] {104099})) {
                    context.State = new State몹스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹스폰 : TriggerState {
            internal State몹스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnID: new int[] {104006}, score: 4100);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {104099})) {
                    context.DestroyMonster(arg1: new int[] {104006});
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {104006})) {
                    context.State = new State몹스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
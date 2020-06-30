using System;

namespace Maple2.Trigger._02000498_bf {
    public static class _timeattack_r8_06 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 140, arg2: new int[] {108099})) {
                    context.State = new State몹스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹스폰 : TriggerState {
            internal State몹스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnID: new int[] {108006}, score: 8000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {108099})) {
                    context.DestroyMonster(arg1: new int[] {108006});
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {108006})) {
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
namespace Maple2.Trigger._02000498_bf {
    public static class _timeattack_r8_07 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 140, arg2: new[] {108099})) {
                    return new State몹스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹스폰 : TriggerState {
            internal State몹스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {108007}, score: 8000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {108099})) {
                    context.DestroyMonster(arg1: new[] {108007});
                    return new State종료(context);
                }

                if (context.MonsterDead(arg1: new[] {108007})) {
                    return new State몹스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
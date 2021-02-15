namespace Maple2.Trigger._02000498_bf {
    public static class _timeattack_r4_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 140, arg2: new[] {104099})) {
                    return new State몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹Spawn : TriggerState {
            internal State몹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {104007}, score: 4100);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {104099})) {
                    context.DestroyMonster(arg1: new[] {104007});
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {104007})) {
                    return new State몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000350_bf {
    public static class _timeattack_r8_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 140, arg2: new[] {108099})) {
                    return new State몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹Spawn : TriggerState {
            internal State몹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnId: new[] {108005}, score: 8000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {108099})) {
                    context.DestroyMonster(arg1: new[] {108005});
                    return new StateEnd(context);
                }

                if (context.MonsterDead(arg1: new[] {108005})) {
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
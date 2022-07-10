namespace Maple2.Trigger._02000350_bf {
    public static class _timeattack_r24_08 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 140, spawnIds: new []{124099})) {
                    return new State몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹Spawn : TriggerState {
            internal State몹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStreamSpawnMonster(spawnIds: new []{124008}, score: 32000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{124099})) {
                    context.DestroyMonster(spawnIds: new []{124008});
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{124008})) {
                    return new State몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

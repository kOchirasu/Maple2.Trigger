namespace Maple2.Trigger._02000498_bf {
    public static class _r11_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 103, spawnIds: new []{111001})) {
                    return new State몹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹Spawn : TriggerState {
            internal State몹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111003}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111001})) {
                    context.DestroyMonster(spawnIds: new []{111003});
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{111003})) {
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

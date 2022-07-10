namespace Maple2.Trigger._02000334_bf {
    public static class _gameover {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{200, 999}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{200})) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{999});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02000525_bf {
    public static class _bossspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10})) {
                    return new State난이도별BossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도별BossSpawn : TriggerState {
            internal State난이도별BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonId() == 23048003) {
                    return new State일반난이도_BossSpawn(context);
                }

                if (context.GetDungeonId() == 23049003) {
                    return new State어려움난이도_BossSpawn(context);
                }

                if (context.WaitTick(waitTick: 1100)) {
                    return new State일반난이도_BossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일반난이도_BossSpawn : TriggerState {
            internal State일반난이도_BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateClear처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어려움난이도_BossSpawn : TriggerState {
            internal State어려움난이도_BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102})) {
                    return new StateClear처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear처리 : TriggerState {
            internal StateClear처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.DungeonClear();
                    return new StateEnd처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd처리 : TriggerState {
            internal StateEnd처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

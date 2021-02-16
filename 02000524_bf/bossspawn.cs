namespace Maple2.Trigger._02000524_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State난이도별BossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도별BossSpawn : TriggerState {
            internal State난이도별BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonId() == 23046003) {
                    return new State일반난이도_BossSpawn(context);
                }

                if (context.GetDungeonId() == 23047003) {
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
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(arg1: new[] {98}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {98})) {
                    return new StateClear처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어려움난이도_BossSpawn : TriggerState {
            internal State어려움난이도_BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(arg1: new[] {99}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    return new StateClear처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear처리 : TriggerState {
            internal StateClear처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02020111_bf {
    public static class _thema_02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1003})) {
                    return new State소환Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환Prepare : TriggerState {
            internal State소환Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{151, 152, 153, 154, 155, 156});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "monster_die") == 1) {
                    return new StateMonsterDestroy(context);
                }

                if (context.MonsterDead(spawnIds: new []{151, 152, 153, 154, 155, 156})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "monster_die") == 1) {
                    return new StateMonsterDestroy(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDestroy : TriggerState {
            internal StateMonsterDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{151, 152, 153, 154, 155, 156});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakFail") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

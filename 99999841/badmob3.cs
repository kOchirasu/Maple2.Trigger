namespace Maple2.Trigger._99999841 {
    public static class _badmob3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990005, key: "BadMob", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 903) == true) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{993}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{991, 992, 993})) {
                    return new State신호쏴주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State신호쏴주기 : TriggerState {
            internal State신호쏴주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990005, key: "BadMob", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonVariable(id: 903) == false) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

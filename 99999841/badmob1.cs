namespace Maple2.Trigger._99999841 {
    public static class _badmob1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990003, key: "BadMob", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 901) == true) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {991}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {991, 992, 993})) {
                    return new State신호쏴주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State신호쏴주기 : TriggerState {
            internal State신호쏴주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990003, key: "BadMob", value: 1);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 901) == false) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02020101_bf {
    public static class _gimmick1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "summon") == 1) {
                    return new StateMonster소환(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204}, arg2: false);
                context.SetUserValue(triggerId: 900003, key: "summon", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201, 202, 203, 204}, arg2: false);
                context.SetUserValue(triggerId: 900003, key: "summon", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}

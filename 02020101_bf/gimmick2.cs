namespace Maple2.Trigger._02020101_bf {
    public static class _gimmick2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Plant") == 1) {
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
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State힌트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State힌트 : TriggerState {
            internal State힌트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020101_BF__GIMMICK2__0$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    return new State알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 25000)) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{301, 302, 303, 304})) {
                    context.SetUserValue(triggerId: 900009, key: "Seed", value: 1);
                    context.SetUserValue(triggerId: 900004, key: "Plant", value: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{301, 302, 303, 304}, arg2: false);
                context.SetUserValue(triggerId: 900004, key: "Plant", value: 0);
                context.SetUserValue(triggerId: 900009, key: "Seed", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}

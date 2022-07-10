namespace Maple2.Trigger._02020201_bf {
    public static class _altar1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new StateBattleStart체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart체크 : TriggerState {
            internal StateBattleStart체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{101})) {
                    return new StateCreationWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreationWait : TriggerState {
            internal StateCreationWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "gogo") == 1) {
                    return new StateCreationWait2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreationWait2 : TriggerState {
            internal StateCreationWait2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterInCombat(spawnIds: new []{101})) {
                    return new State제단Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단Creation : TriggerState {
            internal State제단Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State제단파괴체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단파괴체크 : TriggerState {
            internal State제단파괴체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    return new State제단재Creation시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단재Creation시간 : TriggerState {
            internal State제단재Creation시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Sidephase", value: 1, isModify: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 40000)) {
                    context.SetAiExtraData(key: "Sidephase", value: -1, isModify: true);
                    return new State전투체크(context);
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

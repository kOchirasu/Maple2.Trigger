namespace Maple2.Trigger._02020201_bf {
    public static class _altar3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new StateBattleStart체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart체크 : TriggerState {
            internal StateBattleStart체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {101})) {
                    return new StateCreation대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation대기 : TriggerState {
            internal StateCreation대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "gogo") == 1) {
                    return new StateCreation대기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation대기2 : TriggerState {
            internal StateCreation대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new State전투체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {101})) {
                    return new State제단Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단Creation : TriggerState {
            internal State제단Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: false);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {203})) {
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
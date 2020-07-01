namespace Maple2.Trigger._02000207_bf {
    public static class _999108_lavaflow {
        public class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {2001})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "LavaflowLeft") == 1) {
                    return new State왼쪽용암생성(context);
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State왼쪽용암생성 : TriggerState {
            internal State왼쪽용암생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999108, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerId: 999108, key: "LavaflowLeftStop", value: 0);
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002A");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "LavaflowLeftStop") == 1) {
                    return new State왼쪽용암내려가기(context);
                }

                if (context.GetUserValue(key: "BattleEnd2") == 1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State왼쪽용암내려가기 : TriggerState {
            internal State왼쪽용암내려가기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999108, key: "LavaflowLeft", value: 0);
                context.SetUserValue(triggerId: 999108, key: "LavaflowLeftStop", value: 0);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002C");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(arg1: new[] {1002});
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1002});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
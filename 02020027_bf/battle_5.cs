namespace Maple2.Trigger._02020027_bf {
    public static class _battle_5 {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateBattleStart_2(context);
            }

            public override void OnExit() { }
        }

        private class StateBattleStart_2 : TriggerState {
            internal StateBattleStart_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "summon_2_3") == 1) {
                    return new StateMonster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401, 402, 403, 404, 405, 406});
                context.SetConversation(arg1: 1, arg2: 401, script: "$02020027_BF__battle_1__1$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 403, script: "$02020027_BF__battle_1__2$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 405, script: "$02020027_BF__battle_1__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {401, 402, 403, 404, 405, 406})) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {201}, arg2: 62000002, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {201}, arg2: 51200002, arg3: 1, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
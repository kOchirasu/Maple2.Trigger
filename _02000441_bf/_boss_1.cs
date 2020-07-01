namespace Maple2.Trigger._02000441_bf {
    public static class _boss_1 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "monster_buff") == 1) {
                    return new State몬스터_사망(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터_사망 : TriggerState {
            internal State몬스터_사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {401}) || context.MonsterDead(arg1: new[] {402})) {
                    return new State초강력버프(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초강력버프 : TriggerState {
            internal State초강력버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {401, 402}, arg2: 49200001, arg3: 1, arg4: true);
            }

            public override TriggerState Execute() {
                if (true) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
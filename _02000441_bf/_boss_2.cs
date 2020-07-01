namespace Maple2.Trigger._02000441_bf {
    public static class _boss_2 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "monster_respawn") == 1) {
                    return new State몬스터체력_75(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터체력_75 : TriggerState {
            internal State몬스터체력_75(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 209) <= 0.75f) {
                    return new State몬스터체력_35(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {210, 211, 212, 213}, arg2: true);
            }
        }

        private class State몬스터체력_35 : TriggerState {
            internal State몬스터체력_35(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 209) <= 0.35f) {
                    return new State몬스터_마지막_리스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터_마지막_리스폰 : TriggerState {
            internal State몬스터_마지막_리스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {214, 215, 216, 217}, arg2: true);
            }

            public override TriggerState Execute() {
                if (true) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
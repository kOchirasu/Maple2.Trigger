namespace Maple2.Trigger._52010038_qd {
    public static class _mob_1_3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "bombStart") == 1) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2097}, arg2: false);
                context.SpawnNpcRange(rangeId: new[] {2008, 2009, 2010}, isAutoTargeting: true);
                context.SpawnNpcRange(rangeId: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107}, isAutoTargeting: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2097})) {
                    context.SetUserValue(triggerId: 999001, key: "CoreIsDead", value: 1);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
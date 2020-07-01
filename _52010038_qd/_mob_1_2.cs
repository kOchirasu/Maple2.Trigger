namespace Maple2.Trigger._52010038_qd {
    public static class _mob_1_2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "WaveStart") == 1) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SpawnNpcRange(rangeId: new[] {2005, 2006, 2007}, isAutoTargeting: true);
            }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4000}, arg2: false);
                context.SpawnNpcRange(rangeId: new[] {2005, 2006, 2007}, isAutoTargeting: true, randomPickCount: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State생성(context);
                    return;
                }

                if (context.GetUserValue(key: "WaveEnd") == 1) {
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
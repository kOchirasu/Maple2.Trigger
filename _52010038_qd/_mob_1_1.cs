namespace Maple2.Trigger._52010038_qd {
    public static class _mob_1_1 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "WaveStart") == 1) {
                    return new State생성(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SpawnNpcRange(rangeId: new[] {2001, 2002, 2003, 2004}, isAutoTargeting: true);
                context.SpawnNpcRange(rangeId: new[] {2001, 2002, 2003, 2004}, isAutoTargeting: true);
                context.SpawnNpcRange(rangeId: new[] {2001, 2002, 2003, 2004}, isAutoTargeting: true);
                context.CreateMonster(arg1: new[] {2011}, arg2: true);
            }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2011}, arg2: true);
                context.SpawnNpcRange(rangeId: new[] {2001, 2002, 2003, 2004}, isAutoTargeting: true, randomPickCount: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State생성(context);
                }

                if (context.GetUserValue(key: "WaveSlowDown") == 1) {
                    return new State생성2(context);
                }

                if (context.GetUserValue(key: "WaveEnd") == 1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생성2 : TriggerState {
            internal State생성2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2011}, arg2: true);
                context.SpawnNpcRange(rangeId: new[] {2001, 2002, 2003, 2004}, isAutoTargeting: true, randomPickCount: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new State생성2(context);
                }

                if (context.GetUserValue(key: "WaveEnd") == 1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
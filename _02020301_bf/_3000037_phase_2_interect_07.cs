namespace Maple2.Trigger._02020301_bf {
    public static class _3000037_phase_2_interect_07 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Phase_2_Interect_07") == 1) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {706}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {706})) {
                    return new State재생성(context);
                }

                if (context.GetUserValue(key: "Phase_2_Interect_07") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재생성 : TriggerState {
            internal State재생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State시작(context);
                }

                if (context.GetUserValue(key: "Phase_2_Interect_07") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
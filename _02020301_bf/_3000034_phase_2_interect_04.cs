namespace Maple2.Trigger._02020301_bf {
    public static class _3000034_phase_2_interect_04 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Phase_2_Interect_04") == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {703}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {703})) {
                    context.State = new State재생성(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_2_Interect_04") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재생성 : TriggerState {
            internal State재생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_2_Interect_04") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
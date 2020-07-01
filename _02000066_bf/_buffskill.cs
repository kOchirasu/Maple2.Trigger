namespace Maple2.Trigger._02000066_bf {
    public static class _buffskill {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new StateA스킬작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateA스킬작동 : TriggerState {
            internal StateA스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: false);
                context.SetSkill(arg1: new[] {7001}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7001}, arg2: false);
                    context.SetEffect(arg1: new[] {6002}, arg2: false);
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
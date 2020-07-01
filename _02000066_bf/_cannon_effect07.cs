namespace Maple2.Trigger._02000066_bf {
    public static class _cannon_effect07 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {807}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {117})) {
                    return new State이펙트대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트대기 : TriggerState {
            internal State이펙트대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 117, arg2: new[] {8007})) {
                    return new State이펙트on(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트on : TriggerState {
            internal State이펙트on(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {807}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {8007})) {
                    return new State대기시간(context);
                }

                if (!context.UserDetected(arg1: new[] {117})) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {807}, arg2: false);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
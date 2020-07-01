namespace Maple2.Trigger._02000347_bf {
    public static class _weather {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000804}, arg2: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {60002})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000804}, arg2: 1);
                context.SetEffect(arg1: new[] {600}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    context.State = new State비내림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비내림 : TriggerState {
            internal State비내림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetTimer(arg1: "30", arg2: 30);
                context.SetEventUI(arg1: 1, arg2: "$02000347_BF__MAIN1__4$", arg3: 2000, arg4: "0");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.SetEventUI(arg1: 1, arg2: "$02000347_BF__MAIN1__3$", arg3: 2000, arg4: "0");
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.SetEffect(arg1: new[] {600}, arg2: false);
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
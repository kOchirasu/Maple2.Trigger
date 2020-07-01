namespace Maple2.Trigger._61000008_me {
    public static class _02_wait {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 60, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100001, textId: 26100001, duration: 5000);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9001) == 50) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기2(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100002, textId: 26100002, duration: 5000);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9001) == 50) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
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
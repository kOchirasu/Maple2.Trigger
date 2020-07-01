namespace Maple2.Trigger._66000002_gd {
    public static class _wait_springbeach {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "60", arg2: 30, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {302})) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100001, textId: 26100001);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 302) == 50) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State대기2(context);
                }

                if (context.TimeExpired(arg1: "60")) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 26100001);
            }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100002, textId: 26100002);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 302) == 50) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State대기(context);
                }

                if (context.TimeExpired(arg1: "60")) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 26100002);
            }
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
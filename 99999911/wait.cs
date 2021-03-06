namespace Maple2.Trigger._99999911 {
    public static class _wait {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new StateStartWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartWait : TriggerState {
            internal StateStartWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 10, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100001, textId: 26100001);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 20) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait2(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 26100001);
            }
        }

        private class StateWait2 : TriggerState {
            internal StateWait2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26100002, textId: 26100002);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 20) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                if (context.TimeExpired(arg1: "60")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 26100002);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
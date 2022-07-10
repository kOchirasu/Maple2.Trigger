namespace Maple2.Trigger._61000004_me {
    public static class _wait {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "60", seconds: 60, clearAtZero: true, display: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "ME_001_Wait_00");
                context.ShowGuideSummary(entityId: 26100001, textId: 26100001);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 101) == 20) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait2(context);
                }

                if (context.TimeExpired(timerId: "60")) {
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
                context.PlaySystemSoundInBox(sound: "ME_001_Wait_00");
                context.ShowGuideSummary(entityId: 26100002, textId: 26100002);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 101) == 20) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                if (context.TimeExpired(timerId: "60")) {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

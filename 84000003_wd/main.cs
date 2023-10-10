namespace Maple2.Trigger._84000003_wd {
    public static class _main {
        public class StateStart_타이머설정 : TriggerState {
            internal StateStart_타이머설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4000", seconds: 300, autoRemove: true, display: false);
                context.SetPortal(portalId: 10001, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return new StateCamera세팅(context);
            }

            public override void OnExit() { }
        }

        private class StateCamera세팅 : TriggerState {
            internal StateCamera세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPhotoStudio(enabled: true);
                context.SetPortal(portalId: 10001, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return new State강제ExitWait(context);
            }

            public override void OnExit() { }
        }

        private class State강제ExitWait : TriggerState {
            internal State강제ExitWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "exitstudio") == 1) {
                    return new State강제ExitPrepare(context);
                }

                if (context.TimeExpired(timerId: "4000")) {
                    return new State강퇴안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강퇴안내 : TriggerState {
            internal State강퇴안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400138);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State강제ExitPrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제ExitPrepare : TriggerState {
            internal State강제ExitPrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 28400138);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State강제Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제Exit : TriggerState {
            internal State강제Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RoomExpire();
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

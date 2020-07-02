namespace Maple2.Trigger._84000005_wd {
    public static class _main {
        public class StateStart_타이머설정 : TriggerState {
            internal StateStart_타이머설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4000", arg2: 300, arg3: true, arg4: false);
                context.SetPortal(arg1: 10001, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                return new StateCamera세팅(context);
            }

            public override void OnExit() { }
        }

        private class StateCamera세팅 : TriggerState {
            internal StateCamera세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPhotoStudio(isEnable: true);
                context.SetPortal(arg1: 10001, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return new State강제퇴장대기(context);
            }

            public override void OnExit() { }
        }

        private class State강제퇴장대기 : TriggerState {
            internal State강제퇴장대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "exitstudio") == 1) {
                    return new State강제퇴장준비(context);
                }

                if (context.TimeExpired(arg1: "4000")) {
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State강제퇴장준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제퇴장준비 : TriggerState {
            internal State강제퇴장준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 28400138);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State강제퇴장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제퇴장 : TriggerState {
            internal State강제퇴장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RoomExpire();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
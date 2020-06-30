using System;

namespace Maple2.Trigger._84000005_wd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작_타이머설정(context);

        private class State시작_타이머설정 : TriggerState {
            internal State시작_타이머설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4000", arg2: 300, arg3: true, arg4: false);
                context.SetPortal(arg1: 10001, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State카메라세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라세팅 : TriggerState {
            internal State카메라세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPhotoStudio(isEnable: true);
                context.SetPortal(arg1: 10001, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State강제퇴장대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제퇴장대기 : TriggerState {
            internal State강제퇴장대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "exitstudio", value: 1)) {
                    context.State = new State강제퇴장준비(context);
                    return;
                }

                if (context.TimeExpired(arg1: "4000")) {
                    context.State = new State강퇴안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강퇴안내 : TriggerState {
            internal State강퇴안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 28400138);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State강제퇴장준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제퇴장준비 : TriggerState {
            internal State강제퇴장준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 28400138);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State강제퇴장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제퇴장 : TriggerState {
            internal State강제퇴장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RoomExpire();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
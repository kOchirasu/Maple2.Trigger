using System;

namespace Maple2.Trigger._52000014_qd {
    public static class _steam_5700 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new State딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발사01 : TriggerState {
            internal State발사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
                context.CreateMonster(arg1: new int[] {570}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State발사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발사02 : TriggerState {
            internal State발사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.CreateMonster(arg1: new int[] {571}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State딜레이02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이02 : TriggerState {
            internal State딜레이02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 1);
                context.DestroyMonster(arg1: new int[] {570});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State발사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발사03 : TriggerState {
            internal State발사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 2);
                context.CreateMonster(arg1: new int[] {571}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {571});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
using System;

namespace Maple2.Trigger._52000004_qd {
    public static class _massege {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {103})) {
                    context.State = new State메세지01(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메세지01 : TriggerState {
            internal State메세지01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityID: 25200404, textID: 25200404);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State메세지02(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 25200404);
            }
        }

        private class State메세지02 : TriggerState {
            internal State메세지02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityID: 25200405, textID: 25200405);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State메세지02대기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 25200405);
            }
        }

        private class State메세지02대기 : TriggerState {
            internal State메세지02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {104})) {
                    context.State = new State메세지03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메세지03 : TriggerState {
            internal State메세지03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityID: 25200406, textID: 25200406);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State메세지03대기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 25200406);
            }
        }

        private class State메세지03대기 : TriggerState {
            internal State메세지03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {105})) {
                    context.State = new State메세지04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메세지04 : TriggerState {
            internal State메세지04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityID: 25200407, textID: 25200407);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State메세지04대기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 25200407);
            }
        }

        private class State메세지04대기 : TriggerState {
            internal State메세지04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {106})) {
                    context.State = new State메세지05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메세지05 : TriggerState {
            internal State메세지05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityID: 25200408, textID: 25200408);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State메세지05대기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 25200408);
            }
        }

        private class State메세지05대기 : TriggerState {
            internal State메세지05대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {107})) {
                    context.State = new State메세지06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메세지06 : TriggerState {
            internal State메세지06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityID: 25200409, textID: 25200409);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 25200409);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
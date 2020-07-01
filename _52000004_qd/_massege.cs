namespace Maple2.Trigger._52000004_qd {
    public static class _massege {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State메세지01(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지01 : TriggerState {
            internal State메세지01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityId: 25200404, textId: 25200404);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State메세지02(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200404);
            }
        }

        private class State메세지02 : TriggerState {
            internal State메세지02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityId: 25200405, textId: 25200405);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State메세지02대기(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200405);
            }
        }

        private class State메세지02대기 : TriggerState {
            internal State메세지02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new State메세지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지03 : TriggerState {
            internal State메세지03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityId: 25200406, textId: 25200406);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State메세지03대기(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200406);
            }
        }

        private class State메세지03대기 : TriggerState {
            internal State메세지03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    return new State메세지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지04 : TriggerState {
            internal State메세지04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityId: 25200407, textId: 25200407);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State메세지04대기(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200407);
            }
        }

        private class State메세지04대기 : TriggerState {
            internal State메세지04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    return new State메세지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지05 : TriggerState {
            internal State메세지05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityId: 25200408, textId: 25200408);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State메세지05대기(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200408);
            }
        }

        private class State메세지05대기 : TriggerState {
            internal State메세지05대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {107})) {
                    return new State메세지06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지06 : TriggerState {
            internal State메세지06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityId: 25200409, textId: 25200409);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State종료(context);
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200409);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new State대기(context);
            }

            public override void OnExit() { }
        }
    }
}
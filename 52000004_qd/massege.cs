namespace Maple2.Trigger._52000004_qd {
    public static class _massege {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new State메세지01(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지01 : TriggerState {
            internal State메세지01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 25200404, textId: 25200404);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State메세지02(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
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
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 25200405, textId: 25200405);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State메세지02Wait(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200405);
            }
        }

        private class State메세지02Wait : TriggerState {
            internal State메세지02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new State메세지03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지03 : TriggerState {
            internal State메세지03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 25200406, textId: 25200406);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State메세지03Wait(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200406);
            }
        }

        private class State메세지03Wait : TriggerState {
            internal State메세지03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    return new State메세지04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지04 : TriggerState {
            internal State메세지04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 25200407, textId: 25200407);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State메세지04Wait(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200407);
            }
        }

        private class State메세지04Wait : TriggerState {
            internal State메세지04Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{106})) {
                    return new State메세지05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지05 : TriggerState {
            internal State메세지05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 25200408, textId: 25200408);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State메세지05Wait(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200408);
            }
        }

        private class State메세지05Wait : TriggerState {
            internal State메세지05Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{107})) {
                    return new State메세지06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지06 : TriggerState {
            internal State메세지06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.ShowGuideSummary(entityId: 25200409, textId: 25200409);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEnd(context);
                }

                if (!context.UserDetected(boxIds: new []{199})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200409);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}

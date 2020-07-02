namespace Maple2.Trigger._02000351_bf {
    public static class _lever_check {
        public class State레버체크 : TriggerState {
            internal State레버체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000819, 10000820}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000819}, arg2: 1)) {
                    return new State레버체크2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000820}, arg2: 1)) {
                    return new State레버체크2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버체크2 : TriggerState {
            internal State레버체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000820}, arg2: 0)) {
                    return new State레버체크3_1개(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000819}, arg2: 0)) {
                    return new State레버체크4_1개(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버체크3_1개 : TriggerState {
            internal State레버체크3_1개(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000819}, arg2: 0)) {
                    return new State레버체크완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버체크4_1개 : TriggerState {
            internal State레버체크4_1개(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000820}, arg2: 0)) {
                    return new State레버체크완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버체크완료 : TriggerState {
            internal State레버체크완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetMesh(arg1: new[] {6005}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State열림_끝(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State열림_끝 : TriggerState {
            internal State열림_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEnd(context);
                }

                if (context.GetUserCount(boxId: 704) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 113);
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
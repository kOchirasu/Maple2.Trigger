namespace Maple2.Trigger._02000351_bf {
    public static class _lever_check {
        public class StateLeverCheck : TriggerState {
            internal StateLeverCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000819, 10000820}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000819}, arg2: 1)) {
                    return new StateLeverCheck2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000820}, arg2: 1)) {
                    return new StateLeverCheck2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCheck2 : TriggerState {
            internal StateLeverCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000820}, arg2: 0)) {
                    return new StateLeverCheck3_1개(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000819}, arg2: 0)) {
                    return new StateLeverCheck4_1개(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCheck3_1개 : TriggerState {
            internal StateLeverCheck3_1개(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000819}, arg2: 0)) {
                    return new StateLeverCheck완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCheck4_1개 : TriggerState {
            internal StateLeverCheck4_1개(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000820}, arg2: 0)) {
                    return new StateLeverCheck완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCheck완료 : TriggerState {
            internal StateLeverCheck완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetMesh(triggerIds: new []{6005}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State열림_끝(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class State열림_끝 : TriggerState {
            internal State열림_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

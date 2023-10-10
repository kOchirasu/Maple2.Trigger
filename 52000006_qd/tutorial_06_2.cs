namespace Maple2.Trigger._52000006_qd {
    public static class _tutorial_06_2 {
        public class State엔터Waiting : TriggerState {
            internal State엔터Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateWaitOpening(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitOpening : TriggerState {
            internal StateWaitOpening(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000016})) {
                    return new State화면효과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면효과 : TriggerState {
            internal State화면효과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State화면효과2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면효과2 : TriggerState {
            internal State화면효과2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$52000006_QD__TUTORIAL_06_2__0$");
                context.SetEffect(triggerIds: new []{401}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State화면효과3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화면효과3 : TriggerState {
            internal State화면효과3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.CameraSelect(triggerId: 303, enabled: true);
                context.SetEffect(triggerIds: new []{402}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State맵이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State맵이동 : TriggerState {
            internal State맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.MoveUser(mapId: 52000007, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

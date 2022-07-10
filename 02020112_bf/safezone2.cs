namespace Maple2.Trigger._02020112_bf {
    public static class _safezone2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990017, key: "Safe", value: 0);
                context.SetInteractObject(interactIds: new []{10002118}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{903})) {
                    return new State안전장치Enabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안전장치Enabled : TriggerState {
            internal State안전장치Enabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10002118}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002118}, arg2: 0)) {
                    return new State안전장치_작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안전장치_작동 : TriggerState {
            internal State안전장치_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020112_BF__SAFEZONE2__0$", duration: 5000);
                context.SetUserValue(triggerId: 99990017, key: "Safe", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

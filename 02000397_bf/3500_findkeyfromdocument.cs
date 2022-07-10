namespace Maple2.Trigger._02000397_bf {
    public static class _3500_findkeyfromdocument {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3500}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3501}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001144}, state: 0);
                context.SetUserValue(key: "FindKey", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FindKey") == 1) {
                    return new StateTrue(context);
                }

                if (context.GetUserValue(key: "FindKey") == 2) {
                    return new StateFalse(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrue : TriggerState {
            internal StateTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3501}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10001144}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001144}, arg2: 0)) {
                    return new StateKeyFound(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKeyFound : TriggerState {
            internal StateKeyFound(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3500}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 1, key: "PortalOn", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateFalse : TriggerState {
            internal StateFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001144}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001144}, arg2: 0)) {
                    return new StateNothingHappened(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3501}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

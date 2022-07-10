namespace Maple2.Trigger._02000397_bf {
    public static class _3200_hidden_bookcase {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.SetLadder(triggerId: 520, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 521, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 522, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 523, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 524, visible: false, animationEffect: false, animationDelay: 0);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001141}, state: 0);
                context.SetUserValue(key: "HiddenRouteOpen", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "HiddenRouteOpen") == 1) {
                    return new StateOpened(context);
                }

                if (context.GetUserValue(key: "HiddenRouteOpen") == 2) {
                    return new StateClosed(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpened : TriggerState {
            internal StateOpened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3202}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001141}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001141}, arg2: 0)) {
                    return new StateLadderOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetMesh(triggerIds: new []{3203}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(triggerId: 520, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 521, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 522, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 523, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 524, visible: true, animationEffect: true, animationDelay: 2);
                context.SetMesh(triggerIds: new []{3200}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(triggerIds: new []{3201}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateClosed : TriggerState {
            internal StateClosed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3202}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001141}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001141}, arg2: 0)) {
                    return new StateNothingHappened(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3202}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02000483_bf {
    public static class _3600_hidden_woodbox {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: false);
                context.SetLadder(triggerId: 530, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 531, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 532, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 533, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 534, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 535, visible: false, animationEffect: false, animationDelay: 0);
                context.SetMesh(triggerIds: new []{3600, 3601, 3602, 3603}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002043}, state: 0);
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
                context.SetMesh(triggerIds: new []{3602}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002043}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002043}, arg2: 0)) {
                    return new StateLadderOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.SetMesh(triggerIds: new []{3600}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(triggerIds: new []{3601}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(triggerIds: new []{3603}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(triggerId: 530, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 531, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 532, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 533, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 534, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 535, visible: true, animationEffect: true, animationDelay: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateClosed : TriggerState {
            internal StateClosed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3602}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002043}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002043}, arg2: 0)) {
                    return new StateNothingHappened(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3602}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

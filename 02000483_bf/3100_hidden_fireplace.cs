namespace Maple2.Trigger._02000483_bf {
    public static class _3100_hidden_fireplace {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "he_in_prop_fireplace_A01_Closed");
                context.SetLadder(triggerId: 510, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 511, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 512, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 513, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 514, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 515, visible: false, animationEffect: false, animationDelay: 0);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002038}, state: 0);
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
                context.SetActor(triggerId: 4000, visible: false, initialSequence: "he_in_prop_fireplace_A01_Closed");
                context.SetInteractObject(interactIds: new []{10002038}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002038}, arg2: 0)) {
                    return new StateLadderOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetMesh(triggerIds: new []{3102}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(triggerId: 510, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 511, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 512, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 513, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 514, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 515, visible: true, animationEffect: true, animationDelay: 2);
                context.SetMesh(triggerIds: new []{3100}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(triggerIds: new []{3101}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateClosed : TriggerState {
            internal StateClosed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: false, initialSequence: "he_in_prop_fireplace_A01_Closed");
                context.SetInteractObject(interactIds: new []{10002038}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002038}, arg2: 0)) {
                    return new StateNothingHappened(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "he_in_prop_fireplace_A01_Opened");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

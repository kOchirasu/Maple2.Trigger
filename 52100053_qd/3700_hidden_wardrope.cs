namespace Maple2.Trigger._52100053_qd {
    public static class _3700_hidden_wardrope {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5004}, visible: false);
                context.SetLadder(triggerId: 540, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 541, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 542, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 543, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 544, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 545, visible: false, animationEffect: false, animationDelay: 0);
                context.SetMesh(triggerIds: new []{3700, 3701, 3704, 3702, 3703}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002097}, state: 0);
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
                context.SetMesh(triggerIds: new []{3702}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002097}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002097}, arg2: 0)) {
                    return new StateLadderOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5004}, visible: true);
                context.SetMesh(triggerIds: new []{3700}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(triggerIds: new []{3701, 3704}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(triggerIds: new []{3703}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(triggerId: 540, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 541, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 542, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 543, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 544, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 545, visible: true, animationEffect: true, animationDelay: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateClosed : TriggerState {
            internal StateClosed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3702}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002097}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002097}, arg2: 0)) {
                    return new StateNothingHappened(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3702}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02000331_bf {
    public static class _switch16 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000802}, state: 2);
                context.SetEffect(triggerIds: new []{4100}, visible: false);
                context.SetUserValue(key: "FirstBridgeOff", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State첫번째전투종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째전투종료 : TriggerState {
            internal State첫번째전투종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "FirstBridgeOff") == 1) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State유저재시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저재시작 : TriggerState {
            internal State유저재시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동안내 : TriggerState {
            internal State이동안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.SetInteractObject(interactIds: new []{10000802}, state: 0);
                context.SetInteractObject(interactIds: new []{10000802}, state: 1);
                context.SetEffect(triggerIds: new []{4100}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State스위치켜기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스위치켜기 : TriggerState {
            internal State스위치켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000802})) {
                    return new State다리재Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리재Creation : TriggerState {
            internal State다리재Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016}, visible: true, meshCount: 16, arg4: 100, delay: 100);
                context.SetEffect(triggerIds: new []{777701}, visible: true);
                context.SetMesh(triggerIds: new []{90000, 90001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{4100}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
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

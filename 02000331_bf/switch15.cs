namespace Maple2.Trigger._02000331_bf {
    public static class _switch15 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000801}, state: 2);
                context.SetEffect(triggerIds: new []{4200}, visible: false);
                context.SetUserValue(key: "SecondBridgeOff", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{99993})) {
                    return new State전투체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SecondBridgeOff") == 1) {
                    return new State스위치Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스위치Prepare : TriggerState {
            internal State스위치Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{777703, 777804}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{99995})) {
                    return new State스위치켜기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스위치켜기 : TriggerState {
            internal State스위치켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.SetInteractObject(interactIds: new []{10000801}, state: 0);
                context.SetInteractObject(interactIds: new []{10000801}, state: 1);
                context.SetEffect(triggerIds: new []{4200}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000801})) {
                    return new State외다리재Creation(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{7775}, visible: true);
            }
        }

        private class State외다리재Creation : TriggerState {
            internal State외다리재Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{90008}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(triggerIds: new []{10040, 10041, 10042, 10043, 10044}, visible: true, meshCount: 5, arg4: 100, delay: 100);
                context.SetEffect(triggerIds: new []{777703}, visible: true);
                context.SetEffect(triggerIds: new []{4200}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{99992})) {
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
                context.SetMesh(triggerIds: new []{90008}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetRandomMesh(triggerIds: new []{10040, 10041, 10042, 10043, 10044}, visible: true, meshCount: 5, arg4: 150, delay: 150);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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

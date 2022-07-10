namespace Maple2.Trigger._80000014_bonus {
    public static class _lever {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001314}, state: 1);
                context.SetMesh(triggerIds: new []{3501, 3502, 3503, 3504, 3505, 3506}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State안내(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001314}, arg2: 0)) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내 : TriggerState {
            internal State안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$80000014_bonus__lever__0$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001314}, arg2: 0)) {
                    return new State문열림(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3501, 3502, 3503, 3504, 3505, 3506}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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

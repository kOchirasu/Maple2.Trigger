namespace Maple2.Trigger._02000312_bf {
    public static class _magictree_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001028}, state: 1);
                context.SetMesh(triggerIds: new []{1030, 1031, 1032, 1033, 1034}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001028}, arg2: 0)) {
                    return new StateRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemove : TriggerState {
            internal StateRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001028}, state: 0);
                context.SetRandomMesh(triggerIds: new []{1030, 1031, 1032, 1033, 1034}, visible: false, meshCount: 5, arg4: 500, delay: 100);
                context.SetUserValue(triggerId: 10, key: "3rdTreeRemove", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02000312_bf {
    public static class _magictree_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001028}, arg2: 1);
                context.SetMesh(arg1: new[] {1030, 1031, 1032, 1033, 1034}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001028}, arg2: 0)) {
                    return new StateRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemove : TriggerState {
            internal StateRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001028}, arg2: 0);
                context.SetRandomMesh(arg1: new[] {1030, 1031, 1032, 1033, 1034}, arg2: false, arg3: 5, arg4: 500, arg5: 100);
                context.SetUserValue(triggerId: 10, key: "3rdTreeRemove", value: 1);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
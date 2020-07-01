namespace Maple2.Trigger._02000397_bf {
    public static class _3400_findkeyfromcandle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3400}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3401}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001143}, arg2: 0);
                context.SetUserValue(key: "FindKey", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "FindKey") == 1) {
                    context.State = new StateTrue(context);
                    return;
                }

                if (context.GetUserValue(key: "FindKey") == 2) {
                    context.State = new StateFalse(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrue : TriggerState {
            internal StateTrue(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3401}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10001143}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001143}, arg2: 0)) {
                    context.State = new StateKeyFound(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKeyFound : TriggerState {
            internal StateKeyFound(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3400}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 1, key: "PortalOn", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateFalse : TriggerState {
            internal StateFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001143}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001143}, arg2: 0)) {
                    context.State = new StateNothingHappened(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3401}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
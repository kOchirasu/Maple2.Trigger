namespace Maple2.Trigger._02000397_bf {
    public static class _3600_hidden_woodbox {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: false);
                context.SetLadder(arg1: 530, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 531, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 532, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 533, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 534, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 535, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(arg1: new[] {3600, 3601, 3602, 3603}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001145}, arg2: 0);
                context.SetUserValue(key: "HiddenRouteOpen", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "HiddenRouteOpen") == 1) {
                    context.State = new StateOpened(context);
                    return;
                }

                if (context.GetUserValue(key: "HiddenRouteOpen") == 2) {
                    context.State = new StateClosed(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOpened : TriggerState {
            internal StateOpened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3602}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10001145}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001145}, arg2: 0)) {
                    context.State = new StateLadderOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetMesh(arg1: new[] {3600}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(arg1: new[] {3601}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(arg1: new[] {3603}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(arg1: 530, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 531, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 532, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 533, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 534, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 535, arg2: true, arg3: true, arg4: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateClosed : TriggerState {
            internal StateClosed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3602}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10001145}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001145}, arg2: 0)) {
                    context.State = new StateNothingHappened(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3602}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000397_bf {
    public static class _3100_hidden_fireplace {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetActor(arg1: 4000, arg2: true, arg3: "he_in_prop_fireplace_A01_Closed");
                context.SetLadder(arg1: 510, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 511, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 512, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 513, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 514, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 515, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(arg1: new[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3101}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3102}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001140}, arg2: 0);
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
                context.SetActor(arg1: 4000, arg2: false, arg3: "he_in_prop_fireplace_A01_Closed");
                context.SetInteractObject(arg1: new[] {10001140}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001140}, arg2: 0)) {
                    context.State = new StateLadderOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetMesh(arg1: new[] {3102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(arg1: 510, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 511, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 512, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 513, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 514, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 515, arg2: true, arg3: true, arg4: 2);
                context.SetMesh(arg1: new[] {3100}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(arg1: new[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateClosed : TriggerState {
            internal StateClosed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: false, arg3: "he_in_prop_fireplace_A01_Closed");
                context.SetInteractObject(arg1: new[] {10001140}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001140}, arg2: 0)) {
                    context.State = new StateNothingHappened(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "he_in_prop_fireplace_A01_Opened");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
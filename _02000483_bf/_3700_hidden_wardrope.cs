namespace Maple2.Trigger._02000483_bf {
    public static class _3700_hidden_wardrope {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: false);
                context.SetLadder(arg1: 540, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 541, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 542, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 543, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 544, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 545, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(arg1: new[] {3700, 3701, 3704, 3702, 3703}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002044}, arg2: 0);
                context.SetUserValue(key: "HiddenRouteOpen", value: 0);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {3702}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002044}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002044}, arg2: 0)) {
                    return new StateLadderOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.SetMesh(arg1: new[] {3700}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(arg1: new[] {3701, 3704}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(arg1: new[] {3703}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(arg1: 540, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 541, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 542, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 543, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 544, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 545, arg2: true, arg3: true, arg4: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateClosed : TriggerState {
            internal StateClosed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3702}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002044}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002044}, arg2: 0)) {
                    return new StateNothingHappened(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3702}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
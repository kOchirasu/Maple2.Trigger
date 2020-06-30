using System;

namespace Maple2.Trigger._52100053_qd {
    public static class _3200_hidden_bookcase {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetLadder(arg1: 520, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 521, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 522, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 523, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 524, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(arg1: new int[] {3200}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3201}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3202}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3203}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10002092}, arg2: 0);
                context.SetUserValue(key: "HiddenRouteOpen", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "HiddenRouteOpen", value: 1)) {
                    context.State = new StateOpened(context);
                    return;
                }

                if (context.UserValue(key: "HiddenRouteOpen", value: 2)) {
                    context.State = new StateClosed(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOpened : TriggerState {
            internal StateOpened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3202}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10002092}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002092}, arg2: 0)) {
                    context.State = new StateLadderOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetMesh(arg1: new int[] {3203}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(arg1: 520, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 521, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 522, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 523, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 524, arg2: true, arg3: true, arg4: 2);
                context.SetMesh(arg1: new int[] {3200}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
                context.SetMesh(arg1: new int[] {3201}, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateClosed : TriggerState {
            internal StateClosed(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3202}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10002092}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002092}, arg2: 0)) {
                    context.State = new StateNothingHappened(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNothingHappened : TriggerState {
            internal StateNothingHappened(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3202}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
using System;

namespace Maple2.Trigger._02000312_bf {
    public static class _magictree_09 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001032}, arg2: 1);
                context.SetMesh(arg1: new int[] {1080, 1081, 1082}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001032}, arg2: 0)) {
                    context.State = new StateRemove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRemove : TriggerState {
            internal StateRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001032}, arg2: 0);
                context.SetRandomMesh(arg1: new int[] {1080, 1081, 1082}, arg2: false, arg3: 3, arg4: 500, arg5: 100);
                context.SetUserValue(triggerID: 10, key: "8thTreeRemove", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
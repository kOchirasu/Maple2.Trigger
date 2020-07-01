using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _03_removedropout {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9002})) {
                    context.State = new StateRemove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRemove : TriggerState {
            internal StateRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveToPortal(boxId: 9002, userTagId: 1, portalId: 21);
                context.MoveToPortal(boxId: 9002, userTagId: 2, portalId: 22);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9002})) {
                    context.State = new StateRemove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
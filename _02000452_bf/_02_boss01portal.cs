using System;

namespace Maple2.Trigger._02000452_bf {
    public static class _02_boss01portal {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 30, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9900, arg2: new int[] {901})) {
                    context.State = new StateActionPortal01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActionPortal01 : TriggerState {
            internal StateActionPortal01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 30, arg2: false, arg3: true, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
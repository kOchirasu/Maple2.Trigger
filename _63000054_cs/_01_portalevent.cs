using System;

namespace Maple2.Trigger._63000054_cs {
    public static class _01_portalevent {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 20007001, arg2: false, arg3: false, arg4: true);
                context.SetPortal(arg1: 20023001, arg2: false, arg3: false, arg4: true);
                context.CreateWidget(arg1: "ReverseRaidPortal");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
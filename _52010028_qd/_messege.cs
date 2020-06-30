using System;

namespace Maple2.Trigger._52010028_qd {
    public static class _messege {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "2003")) {
                    context.State = new Statemessege(context);
                    return;
                }

                if (context.UserDetected(arg1: "2004")) {
                    context.State = new Statemessege(context);
                    return;
                }

                if (context.UserDetected(arg1: "2005")) {
                    context.State = new Statemessege(context);
                    return;
                }

                if (context.UserDetected(arg1: "2006")) {
                    context.State = new Statemessege(context);
                    return;
                }

                if (context.UserDetected(arg1: "2007")) {
                    context.State = new Statemessege(context);
                    return;
                }

                if (context.UserDetected(arg1: "2008")) {
                    context.State = new Statemessege(context);
                    return;
                }

                if (context.UserDetected(arg1: "2009")) {
                    context.State = new Statemessege(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemessege : TriggerState {
            internal Statemessege(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52010028_QD__MESSEGE__0$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
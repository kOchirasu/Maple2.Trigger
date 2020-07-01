namespace Maple2.Trigger._52010028_qd {
    public static class _messege {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {2003})) {
                    return new Statemessege(context);
                }

                if (context.UserDetected(arg1: new[] {2004})) {
                    return new Statemessege(context);
                }

                if (context.UserDetected(arg1: new[] {2005})) {
                    return new Statemessege(context);
                }

                if (context.UserDetected(arg1: new[] {2006})) {
                    return new Statemessege(context);
                }

                if (context.UserDetected(arg1: new[] {2007})) {
                    return new Statemessege(context);
                }

                if (context.UserDetected(arg1: new[] {2008})) {
                    return new Statemessege(context);
                }

                if (context.UserDetected(arg1: new[] {2009})) {
                    return new Statemessege(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statemessege : TriggerState {
            internal Statemessege(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52010028_QD__MESSEGE__0$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new Stateidle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52010028_qd {
    public static class _messege {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2003})) {
                    return new StateMessege(context);
                }

                if (context.UserDetected(boxIds: new []{2004})) {
                    return new StateMessege(context);
                }

                if (context.UserDetected(boxIds: new []{2005})) {
                    return new StateMessege(context);
                }

                if (context.UserDetected(boxIds: new []{2006})) {
                    return new StateMessege(context);
                }

                if (context.UserDetected(boxIds: new []{2007})) {
                    return new StateMessege(context);
                }

                if (context.UserDetected(boxIds: new []{2008})) {
                    return new StateMessege(context);
                }

                if (context.UserDetected(boxIds: new []{2009})) {
                    return new StateMessege(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMessege : TriggerState {
            internal StateMessege(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52010028_QD__MESSEGE__0$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

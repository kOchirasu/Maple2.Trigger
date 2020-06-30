using System;

namespace Maple2.Trigger._02000389_bf {
    public static class _error {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Error", value: 1)) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.UserDetected(arg1: "702")) {
                    context.State = new Stateerror(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateerror : TriggerState {
            internal Stateerror(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000389, arg2: 5, arg3: 702, arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
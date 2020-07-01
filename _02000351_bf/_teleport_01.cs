using System;

namespace Maple2.Trigger._02000351_bf {
    public static class _teleport_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {705}, arg2: 1)) {
                    context.State = new Statestart_sound(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {9000005}, arg2: true);
            }
        }

        private class Statestart_sound : TriggerState {
            internal Statestart_sound(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {9000005}, arg2: false);
            }
        }
    }
}
using System;

namespace Maple2.Trigger._99999927 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "701")) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 99910120, arg3: 1, arg4: false, arg5: false);
                context.SetGravity(gravity: -25f);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
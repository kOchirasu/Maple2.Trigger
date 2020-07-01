using System;

namespace Maple2.Trigger._02000532_bf {
    public static class _talk {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {703}, arg2: 0)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 216, msg: "$02000532_BF__TALK__0$", duration: 3500, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    // context.State = new State(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000532_bf {
    public static class _talk {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {703}, arg2: 0)) {
                    return new Stateready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 216, msg: "$02000532_BF__TALK__0$", duration: 3500, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000539_bf {
    public static class _talk {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{703}, jobCode: 0)) {
                    return new State말풍선1(context);
                }

                if (context.UserDetected(boxIds: new []{704}, jobCode: 0)) {
                    return new State말풍선2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선1 : TriggerState {
            internal State말풍선1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 201, msg: "$02000539_BF__TALK__0$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 201, msg: "$02000539_BF__TALK__1$", duration: 3500, delayTick: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선2 : TriggerState {
            internal State말풍선2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 202, msg: "$02000539_BF__TALK__2$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnId: 202, msg: "$02000539_BF__TALK__3$", duration: 3500, delayTick: 3500);
                context.AddBalloonTalk(spawnId: 202, msg: "$02000539_BF__TALK__4$", duration: 3500, delayTick: 7000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

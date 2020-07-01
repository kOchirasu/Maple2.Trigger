using System;

namespace Maple2.Trigger._02000539_bf {
    public static class _talk {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {703}, arg2: 0)) {
                    context.State = new State말풍선1(context);
                    return;
                }

                if (context.UserDetected(arg1: new int[] {704}, arg2: 0)) {
                    context.State = new State말풍선2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선1 : TriggerState {
            internal State말풍선1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 201, msg: "$02000539_BF__TALK__0$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 201, msg: "$02000539_BF__TALK__1$", duration: 3500,
                    delayTick: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선2 : TriggerState {
            internal State말풍선2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 202, msg: "$02000539_BF__TALK__2$", duration: 3500, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 202, msg: "$02000539_BF__TALK__3$", duration: 3500,
                    delayTick: 3500);
                context.AddBalloonTalk(spawnPointID: 202, msg: "$02000539_BF__TALK__4$", duration: 3500,
                    delayTick: 7000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
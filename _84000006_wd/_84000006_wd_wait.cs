namespace Maple2.Trigger._84000006_wd {
    public static class _84000006_wd_wait {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 40, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 102, msg: "$84000006_WD__84000006_WD_WAIT__0$", duration: 5000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityId: 28500001, textId: 28500001, duration: 5000);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9000) == 70) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기2(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 102, msg: "$84000006_WD__84000006_WD_WAIT__1$", duration: 5000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityId: 28500002, textId: 28500002, duration: 5000);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9000) == 70) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
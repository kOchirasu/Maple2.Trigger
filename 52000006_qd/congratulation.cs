namespace Maple2.Trigger._52000006_qd {
    public static class _congratulation {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200, 201}, visible: false);
            }

            public override TriggerState? Execute() {
                return new State축하Wait1(context);
            }

            public override void OnExit() { }
        }

        private class State축하Wait1 : TriggerState {
            internal State축하Wait1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.BonusGameRewardDetected(boxId: 101)) {
                    return new State축하1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State축하1 : TriggerState {
            internal State축하1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200, 201}, visible: true);
            }

            public override TriggerState? Execute() {
                return new State축하2(context);
            }

            public override void OnExit() { }
        }

        private class State축하2 : TriggerState {
            internal State축하2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$52000006_QD__CONGRATULATION__0$");
                context.SetConversation(type: 1, spawnId: 101, script: "$52000006_QD__CONGRATULATION__1$");
                context.SetTimer(timerId: "1", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{200, 201}, visible: false);
            }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

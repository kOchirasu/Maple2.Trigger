namespace Maple2.Trigger._02000254_bf {
    public static class _karl {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{450}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{904})) {
                    return new State말풍선(context);
                }

                if (context.MonsterInCombat(spawnIds: new []{106})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선 : TriggerState {
            internal State말풍선(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "8", seconds: 8);
                context.SetEffect(triggerIds: new []{450}, visible: true);
                context.SetConversation(type: 1, spawnId: 107, script: "$02000254_BF__KARL__0$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "8")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

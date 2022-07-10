namespace Maple2.Trigger._02020141_bf {
    public static class _playerdropheal {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateTrigger시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger시작 : TriggerState {
            internal StateTrigger시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State드랍지점회복(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State드랍지점회복 : TriggerState {
            internal State드랍지점회복(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{102}, skillId: 50000554, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrigger시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

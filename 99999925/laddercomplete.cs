namespace Maple2.Trigger._99999925 {
    public static class _laddercomplete {
        public class StateIsLadderComplete : TriggerState {
            internal StateIsLadderComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 311, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 312, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 313, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 314, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 315, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 316, visible: false, animationEffect: false, animationDelay: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ladderComp") == 1) {
                    return new StateLadderComplete(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderComplete : TriggerState {
            internal StateLadderComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 311, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 312, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 313, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 314, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 315, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 316, visible: true, animationEffect: true, animationDelay: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
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

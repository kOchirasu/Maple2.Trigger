namespace Maple2.Trigger._61000010_me {
    public static class _ladder01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 701, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 702, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 711, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 712, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 721, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 722, visible: false, animationEffect: false);
            }

            public override TriggerState? Execute() {
                return new StateRandom(context);
            }

            public override void OnExit() { }
        }

        private class StateRandom : TriggerState {
            internal StateRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 34f)) {
                    context.SetLadder(triggerId: 701, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 702, visible: true, animationEffect: true);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    context.SetLadder(triggerId: 711, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 712, visible: true, animationEffect: true);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    context.SetLadder(triggerId: 721, visible: true, animationEffect: true);
                    context.SetLadder(triggerId: 722, visible: true, animationEffect: true);
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

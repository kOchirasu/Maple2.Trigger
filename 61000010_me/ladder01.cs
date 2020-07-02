namespace Maple2.Trigger._61000010_me {
    public static class _ladder01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 701, arg2: false, arg3: false);
                context.SetLadder(arg1: 702, arg2: false, arg3: false);
                context.SetLadder(arg1: 711, arg2: false, arg3: false);
                context.SetLadder(arg1: 712, arg2: false, arg3: false);
                context.SetLadder(arg1: 721, arg2: false, arg3: false);
                context.SetLadder(arg1: 722, arg2: false, arg3: false);
            }

            public override TriggerState Execute() {
                return new StateRandom(context);
            }

            public override void OnExit() { }
        }

        private class StateRandom : TriggerState {
            internal StateRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 34f)) {
                    context.SetLadder(arg1: 701, arg2: true, arg3: true);
                    context.SetLadder(arg1: 702, arg2: true, arg3: true);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.SetLadder(arg1: 711, arg2: true, arg3: true);
                    context.SetLadder(arg1: 712, arg2: true, arg3: true);
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.SetLadder(arg1: 721, arg2: true, arg3: true);
                    context.SetLadder(arg1: 722, arg2: true, arg3: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
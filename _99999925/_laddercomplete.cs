namespace Maple2.Trigger._99999925 {
    public static class _laddercomplete {
        public class StateIsLadderComplete : TriggerState {
            internal StateIsLadderComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 311, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 312, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 313, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 314, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 315, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 316, arg2: false, arg3: false, arg4: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ladderComp") == 1) {
                    return new StateladderComplete(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateladderComplete : TriggerState {
            internal StateladderComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 311, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 312, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 313, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 314, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 315, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 316, arg2: true, arg3: true, arg4: 0);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52000084_qd {
    public static class _4000_ladder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 4001, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4002, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4003, arg2: false, arg3: false, arg4: 0);
                context.SetInteractObject(arg1: new[] {10001128}, arg2: 0, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9100, arg2: new[] {101})) {
                    return new StatePCComeDown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCComeDown : TriggerState {
            internal StatePCComeDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9300})) {
                    return new StateLadderOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 4001, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4002, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4003, arg2: true, arg3: true, arg4: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
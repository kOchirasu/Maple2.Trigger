namespace Maple2.Trigger._02000451_bf {
    public static class _4100_ladder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 4100, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4101, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4102, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4103, arg2: false, arg3: false, arg4: 0);
                context.SetInteractObject(arg1: new[] {10001128}, arg2: 0, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9200, arg2: new[] {101})) {
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
                if (context.UserDetected(arg1: new[] {9400})) {
                    return new StateLadderOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 4100, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4101, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4102, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4103, arg2: true, arg3: true, arg4: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
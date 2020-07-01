namespace Maple2.Trigger._02000451_bf {
    public static class _4200_ladder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 4200, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4201, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4202, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4203, arg2: false, arg3: false, arg4: 0);
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
                context.SetLadder(arg1: 4200, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4201, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4202, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4203, arg2: true, arg3: true, arg4: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
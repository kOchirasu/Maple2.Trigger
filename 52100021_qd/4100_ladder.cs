namespace Maple2.Trigger._52100021_qd {
    public static class _4100_ladder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 4100, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 4101, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 4102, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 4103, visible: false, animationEffect: false, animationDelay: 0);
                context.SetInteractObject(interactIds: new []{10001128}, state: 0, arg4: false);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9200, spawnIds: new []{101})) {
                    return new StatePCComeDown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCComeDown : TriggerState {
            internal StatePCComeDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9400})) {
                    return new StateLadderOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 4100, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 4101, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 4102, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 4103, visible: true, animationEffect: true, animationDelay: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

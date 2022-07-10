namespace Maple2.Trigger._52000084_qd {
    public static class _4000_ladder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 4001, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 4002, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 4003, visible: false, animationEffect: false, animationDelay: 0);
                context.SetInteractObject(interactIds: new []{10001128}, state: 0, arg4: false);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9100, spawnIds: new []{101})) {
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
                if (context.UserDetected(boxIds: new []{9300})) {
                    return new StateLadderOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 4001, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 4002, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 4003, visible: true, animationEffect: true, animationDelay: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

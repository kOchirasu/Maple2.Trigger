namespace Maple2.Trigger._02000139_bf {
    public static class _01_trigger02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712}, visible: false);
                context.SetInteractObject(interactIds: new []{10000160}, state: 1);
                context.SetLadder(triggerId: 601, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 602, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 603, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 604, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 605, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 606, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 607, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 608, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 609, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 610, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 611, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 612, visible: false, animationEffect: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000160}, arg2: 0)) {
                    return new StateLadder(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder : TriggerState {
            internal StateLadder(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 601, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{701}, visible: true);
                context.SetLadder(triggerId: 602, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{702}, visible: true);
                context.SetLadder(triggerId: 603, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{703}, visible: true);
                context.SetLadder(triggerId: 604, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{704}, visible: true);
                context.SetLadder(triggerId: 605, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{705}, visible: true);
                context.SetLadder(triggerId: 606, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{706}, visible: true);
                context.SetLadder(triggerId: 607, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{707}, visible: true);
                context.SetLadder(triggerId: 608, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{708}, visible: true);
                context.SetLadder(triggerId: 609, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{709}, visible: true);
                context.SetLadder(triggerId: 610, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{710}, visible: true);
                context.SetLadder(triggerId: 611, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{711}, visible: true);
                context.SetLadder(triggerId: 612, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{713}, visible: true);
                context.SetTimer(timerId: "4", seconds: 18);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

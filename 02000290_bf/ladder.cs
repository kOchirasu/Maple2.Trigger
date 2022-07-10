namespace Maple2.Trigger._02000290_bf {
    public static class _ladder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(triggerId: 511, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 512, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 513, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 514, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 515, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 516, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 517, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 518, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 519, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 520, visible: false, animationEffect: false);
                context.SetEffect(triggerIds: new []{5100, 5102, 5200}, visible: false);
                context.SetInteractObject(interactIds: new []{10000429}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new State폭포안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭포안내 : TriggerState {
            internal State폭포안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000429}, state: 1);
                context.SetEffect(triggerIds: new []{5200, 5000}, visible: true);
                context.ShowGuideSummary(entityId: 20002902, textId: 20002902);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000429}, arg2: 0)) {
                    return new State폭포갈라짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State폭포갈라짐 : TriggerState {
            internal State폭포갈라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002902);
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310}, visible: false, arg3: 0, arg4: 200, arg5: 2f);
                context.SetEffect(triggerIds: new []{5200}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLadder생김(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder생김 : TriggerState {
            internal StateLadder생김(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002907, textId: 20002907, duration: 5000);
                context.SetEffect(triggerIds: new []{5000, 5100}, visible: true);
                context.SetLadder(triggerId: 511, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 512, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 513, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 514, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 515, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 516, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 517, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 518, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 519, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 520, visible: true, animationEffect: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

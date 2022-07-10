namespace Maple2.Trigger._02000254_bf {
    public static class _pillar_03 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000442}, state: 0);
                context.SetSkill(triggerIds: new []{703}, arg2: false);
                context.SetEffect(triggerIds: new []{446, 447, 462}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 907, spawnIds: new []{105})) {
                    return new State반응Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000442}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000442}, arg2: 0)) {
                    return new State스턴(context);
                }

                if (!context.NpcDetected(boxId: 907, spawnIds: new []{105})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스턴 : TriggerState {
            internal State스턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{446, 447, 462}, visible: true);
                context.SetSkill(triggerIds: new []{703}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State스턴2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스턴2 : TriggerState {
            internal State스턴2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{703}, arg2: false);
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

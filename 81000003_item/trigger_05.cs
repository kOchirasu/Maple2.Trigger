namespace Maple2.Trigger._81000003_item {
    public static class _trigger_05 {
        public class StateLever : TriggerState {
            internal StateLever(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000214}, state: 1);
                context.SetMesh(triggerIds: new []{551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 565, 566, 567, 568}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000214}, arg2: 0)) {
                    return new State바닥열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥열기 : TriggerState {
            internal State바닥열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 200);
                context.SetMesh(triggerIds: new []{551, 552, 553, 554, 555, 556, 557, 558, 559, 560, 561, 562, 563, 564, 565, 566, 567, 568}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new StateLever(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

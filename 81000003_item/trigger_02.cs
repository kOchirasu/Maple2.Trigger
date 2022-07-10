namespace Maple2.Trigger._81000003_item {
    public static class _trigger_02 {
        public class StateLever : TriggerState {
            internal StateLever(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000225}, state: 1);
                context.SetMesh(triggerIds: new []{530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000225}, arg2: 0)) {
                    return new State바닥열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥열기 : TriggerState {
            internal State바닥열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "8", seconds: 200);
                context.SetMesh(triggerIds: new []{530, 531, 532, 533, 534, 535, 536, 537, 538, 539, 540, 541, 542, 543, 544, 545, 546, 547, 548, 549, 550}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "8")) {
                    return new StateLever(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

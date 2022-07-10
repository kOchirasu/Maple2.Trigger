namespace Maple2.Trigger._02000351_bf {
    public static class _lever_02 {
        public class State닫힘상태 : TriggerState {
            internal State닫힘상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000819}, state: 0);
                context.SetMesh(triggerIds: new []{6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062}, visible: true, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{6081, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092}, visible: false, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000819}, arg2: 1)) {
                    return new State작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000819}, arg2: 0)) {
                    return new StateOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen : TriggerState {
            internal StateOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetEffect(triggerIds: new []{9000003}, visible: true);
                context.SetMesh(triggerIds: new []{6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062}, visible: false, arg4: 200, arg5: 15f);
                context.SetMesh(triggerIds: new []{6081, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092}, visible: true, arg4: 200, arg5: 15f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

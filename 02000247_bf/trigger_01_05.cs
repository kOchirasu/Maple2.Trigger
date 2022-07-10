namespace Maple2.Trigger._02000247_bf {
    public static class _trigger_01_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{304}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{404})) {
                    return new State버튼눌림(context);
                }

                if (context.UserDetected(boxIds: new []{405})) {
                    return new State사라짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버튼눌림 : TriggerState {
            internal State버튼눌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{304}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{404})) {
                    return new StateWait(context);
                }

                if (context.UserDetected(boxIds: new []{405})) {
                    return new State사라짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사라짐 : TriggerState {
            internal State사라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{304}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

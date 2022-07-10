namespace Maple2.Trigger._02000351_bf {
    public static class _lever_03 {
        public class State닫힘상태 : TriggerState {
            internal State닫힘상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000820}, state: 0);
                context.SetMesh(triggerIds: new []{6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162}, visible: true, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{6181, 6182, 6183, 6184, 6185, 6186, 6187, 6188, 6189, 6190, 6191, 6192}, visible: false, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000820}, arg2: 1)) {
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
                if (context.ObjectInteracted(interactIds: new []{10000820}, arg2: 0)) {
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
                context.SetEffect(triggerIds: new []{9000004}, visible: true);
                context.SetMesh(triggerIds: new []{6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162}, visible: false, arg4: 200, arg5: 15f);
                context.SetMesh(triggerIds: new []{6181, 6182, 6183, 6184, 6185, 6186, 6187, 6188, 6189, 6190, 6191, 6192}, visible: true, arg4: 200, arg5: 0f);
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

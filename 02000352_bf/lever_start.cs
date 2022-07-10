namespace Maple2.Trigger._02000352_bf {
    public static class _lever_start {
        public class State작동 : TriggerState {
            internal State작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6201}, visible: false, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000821}, state: 1);
                context.SetMesh(triggerIds: new []{6150, 6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162, 6163}, visible: true, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{6150, 6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162, 6163}, visible: false, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000821}, arg2: 0)) {
                    return new StateOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateOpen : TriggerState {
            internal StateOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetEffect(triggerIds: new []{9000001}, visible: true);
                context.SetMesh(triggerIds: new []{6211}, visible: false, arg4: 200, arg5: 15f);
                context.SetMesh(triggerIds: new []{6201}, visible: true, arg4: 200, arg5: 15f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6001}, visible: false, arg4: 0, arg5: 10f);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State열림_끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열림_끝 : TriggerState {
            internal State열림_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

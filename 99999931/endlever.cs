namespace Maple2.Trigger._99999931 {
    public static class _endlever {
        public class State게임종료 : TriggerState {
            internal State게임종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{211, 212}, visible: true);
                context.SetMesh(triggerIds: new []{551, 552}, visible: false);
                context.SetInteractObject(interactIds: new []{10000216}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000216}, arg2: 0)) {
                    return new StateEnd안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd안내 : TriggerState {
            internal StateEnd안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 3);
                context.SetEventUI(arg1: 5, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State문열기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기 : TriggerState {
            internal State문열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 7);
                context.SetMesh(triggerIds: new []{211, 212}, visible: false);
                context.SetMesh(triggerIds: new []{551, 552}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State문닫기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문닫기 : TriggerState {
            internal State문닫기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetMesh(triggerIds: new []{211, 212}, visible: true);
                context.SetMesh(triggerIds: new []{551, 552}, visible: false);
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208}, visible: true);
                context.SetPortal(portalId: 101, visible: false, enabled: true);
                context.SetPortal(portalId: 102, visible: false, enabled: true);
                context.SetPortal(portalId: 103, visible: false, enabled: true);
                context.SetPortal(portalId: 104, visible: false, enabled: true);
                context.SetPortal(portalId: 115, visible: false, enabled: true);
                context.SetPortal(portalId: 116, visible: false, enabled: true);
                context.SetPortal(portalId: 117, visible: false, enabled: true);
                context.SetPortal(portalId: 118, visible: false, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State게임종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

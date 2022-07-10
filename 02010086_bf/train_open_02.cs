namespace Maple2.Trigger._02010086_bf {
    public static class _train_open_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000897}, state: 0);
                context.SetEffect(triggerIds: new []{7003, 7004}, visible: false);
                context.SetMesh(triggerIds: new []{1161, 1162, 1163}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000897}, arg2: 1)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 113, textId: 20003363);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000897}, arg2: 0)) {
                    return new State작동_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 113);
            }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7003, 7004}, visible: true);
                context.SetMesh(triggerIds: new []{1171, 1172, 1173}, visible: false, arg4: 300, arg5: 10f);
                context.SetMesh(triggerIds: new []{1161, 1162, 1163}, visible: true, arg4: 300, arg5: 10f);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State작동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_02 : TriggerState {
            internal State작동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2111}, visible: false, arg4: 30, arg5: 0f);
                context.SetMesh(triggerIds: new []{1161, 1162, 1163}, visible: false, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{2101}, visible: false, arg4: 50, arg5: 1f);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State벽Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽Remove : TriggerState {
            internal State벽Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02000336_bf {
    public static class _train_lever_02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8211, 8212, 8213, 8214}, visible: false);
                context.SetInteractObject(interactIds: new []{10000897}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000897}, arg2: 0)) {
                    return new State작동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8211, 8212, 8213, 8214}, visible: true, arg4: 300, arg5: 10f);
                context.SetMesh(triggerIds: new []{8201, 8202, 8203, 8204}, visible: false, arg4: 300, arg5: 10f);
                context.SetEffect(triggerIds: new []{7011}, visible: true);
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
                context.SetMesh(triggerIds: new []{8021, 8022, 8023, 8024}, visible: false, arg4: 0, arg5: 10f);
                context.SetSkill(triggerIds: new []{5807}, enabled: true);
                context.SetMesh(triggerIds: new []{8205}, visible: false, arg4: 30, arg5: 0f);
                context.SetMesh(triggerIds: new []{8211, 8212, 8213, 8214}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

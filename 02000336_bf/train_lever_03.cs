namespace Maple2.Trigger._02000336_bf {
    public static class _train_lever_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8161, 8162, 8163, 8164}, visible: false);
                context.SetInteractObject(interactIds: new []{10000898}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000898}, arg2: 0)) {
                    return new State작동_01(context);
                }

                if (context.GetUserCount(boxId: 709) == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 113, textId: 20003363, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000898}, arg2: 0)) {
                    return new State작동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8161, 8162, 8163, 8164}, visible: true, arg4: 300, arg5: 10f);
                context.SetMesh(triggerIds: new []{8261, 8262, 8263, 8264}, visible: false, arg4: 300, arg5: 10f);
                context.SetEffect(triggerIds: new []{7012}, visible: true);
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
                context.SetMesh(triggerIds: new []{8064, 8065, 8066, 8067, 8068}, visible: false, arg4: 0, arg5: 10f);
                context.SetSkill(triggerIds: new []{5808}, enabled: true);
                context.SetMesh(triggerIds: new []{8069}, visible: false, arg4: 30, arg5: 0f);
                context.SetMesh(triggerIds: new []{8161, 8162, 8163, 8164}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02000336_bf {
    public static class _train_lever_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8111, 8112, 8113, 8114}, visible: false);
                context.SetInteractObject(interactIds: new []{10000896}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000896}, arg2: 0)) {
                    return new State작동_01(context);
                }

                if (context.GetUserCount(boxId: 708) == 1) {
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
                if (context.ObjectInteracted(interactIds: new []{10000896}, arg2: 0)) {
                    return new State작동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_01 : TriggerState {
            internal State작동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8111, 8112, 8113, 8114}, visible: true, arg4: 300, arg5: 10f);
                context.SetMesh(triggerIds: new []{8101, 8102, 8103, 8104}, visible: false, arg4: 300, arg5: 10f);
                context.SetEffect(triggerIds: new []{7010}, visible: true);
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
                context.SetMesh(triggerIds: new []{8050, 8051, 8052, 8053, 8054}, visible: false, arg4: 0, arg5: 10f);
                context.SetSkill(triggerIds: new []{5806}, arg2: true);
                context.SetMesh(triggerIds: new []{8055}, visible: false, arg4: 30, arg5: 0f);
                context.SetMesh(triggerIds: new []{8111, 8112, 8113, 8114}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

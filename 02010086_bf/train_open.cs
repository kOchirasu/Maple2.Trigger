namespace Maple2.Trigger._02010086_bf {
    public static class _train_open {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001, 7002}, visible: false);
                context.SetMesh(triggerIds: new []{1061, 1062, 1063, 2011, 2012, 2013}, visible: false);
                context.SetInteractObject(interactIds: new []{10000896}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000896}, arg2: 1)) {
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
                if (context.ObjectInteracted(interactIds: new []{10000896}, arg2: 0)) {
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
                context.SetEffect(triggerIds: new []{7001, 7002}, visible: true);
                context.SetMesh(triggerIds: new []{1071, 1072, 1073}, visible: false, arg4: 300, arg5: 10f);
                context.SetMesh(triggerIds: new []{1061, 1062, 1063}, visible: true, arg4: 300, arg5: 10f);
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
                context.SetMesh(triggerIds: new []{1055}, visible: false, arg4: 30, arg5: 0f);
                context.SetMesh(triggerIds: new []{1061, 1062, 1063}, visible: false, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{1005}, visible: false, arg4: 50, arg5: 1f);
                context.SetActor(triggerId: 1022, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{1021}, visible: false, arg4: 0, arg5: 10f);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

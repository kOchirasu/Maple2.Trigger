namespace Maple2.Trigger._02000336_bf {
    public static class _train_open {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{16014, 16015, 16016}, visible: false);
                context.SetInteractObject(interactIds: new []{10000805}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 706) == 1) {
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
                context.ShowGuideSummary(entityId: 113, textId: 20003363);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000805}, arg2: 0)) {
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
                context.SetMesh(triggerIds: new []{16011, 16012, 16013}, visible: false, arg4: 300, arg5: 10f);
                context.SetMesh(triggerIds: new []{16014, 16015, 16016}, visible: true, arg4: 300, arg5: 10f);
                context.SetEffect(triggerIds: new []{7013}, visible: true);
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
                context.SetSkill(triggerIds: new []{5802}, enabled: true);
                context.SetMesh(triggerIds: new []{16001}, visible: false, arg4: 30, arg5: 0f);
                context.SetMesh(triggerIds: new []{16014, 16015, 16016}, visible: false, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{16000}, visible: false, arg4: 50, arg5: 1f);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new State작동_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작동_03 : TriggerState {
            internal State작동_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{305, 306, 307, 308}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

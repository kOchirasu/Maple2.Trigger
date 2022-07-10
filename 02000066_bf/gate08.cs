namespace Maple2.Trigger._02000066_bf {
    public static class _gate08 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{3008});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: false);
                context.SetInteractObject(interactIds: new []{10000340}, state: 0);
                context.CreateMonster(spawnIds: new []{3008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3008})) {
                    return new State게이트열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게이트열림 : TriggerState {
            internal State게이트열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetInteractObject(interactIds: new []{10000340}, state: 1);
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.ShowGuideSummary(entityId: 20000664, textId: 20000664);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.HideGuideSummary(entityId: 20000664);
                    return new State게이트닫힘(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게이트닫힘 : TriggerState {
            internal State게이트닫힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000340}, arg2: 0)) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

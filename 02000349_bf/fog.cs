namespace Maple2.Trigger._02000349_bf {
    public static class _fog {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000813}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 136, spawnIds: new []{2006})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1098});
                context.SetEffect(triggerIds: new []{600, 602}, visible: false);
                context.SetInteractObject(interactIds: new []{10000813}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1098})) {
                    return new State포그(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포그 : TriggerState {
            internal State포그(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{600}, visible: true);
                context.SetInteractObject(interactIds: new []{10000813}, state: 1);
                context.ShowGuideSummary(entityId: 20003494, textId: 20003494);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000813}, arg2: 0)) {
                    return new StateWaitTime(context);
                }

                if (context.MonsterDead(spawnIds: new []{1099})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20003494);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetInteractObject(interactIds: new []{10000813}, state: 0);
                context.SetTimer(timerId: "10", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

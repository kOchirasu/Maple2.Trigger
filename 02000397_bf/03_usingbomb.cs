namespace Maple2.Trigger._02000397_bf {
    public static class _03_usingbomb {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103, 5200, 5201, 5202, 5203}, visible: false);
                context.DestroyMonster(spawnIds: new []{910, 911});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9200})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{910, 911}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateArrowGuideOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArrowGuideOn : TriggerState {
            internal StateArrowGuideOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039703, textId: 20039703, duration: 4000);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103, 5200, 5201, 5202, 5203}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9201})) {
                    return new StateArrowGuideOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArrowGuideOff : TriggerState {
            internal StateArrowGuideOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103, 5200, 5201, 5202, 5203}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

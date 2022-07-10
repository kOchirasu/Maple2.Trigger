namespace Maple2.Trigger._02000329_bf {
    public static class _bossgate {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{710})) {
                    return new StateLadderGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderGuide : TriggerState {
            internal StateLadderGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 106, textId: 20000060);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 106);
            }
        }
    }
}

namespace Maple2.Trigger._02000177_bf {
    public static class _guide {
        public class Stateguide : TriggerState {
            internal Stateguide(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    context.State = new StateGuide_Climb(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide_Climb : TriggerState {
            internal StateGuide_Climb(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20001771, textId: 20001771, duration: 4000);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    context.State = new StateGuide_Climb_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide_Climb_02 : TriggerState {
            internal StateGuide_Climb_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20001771, textId: 20001771, duration: 4000);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
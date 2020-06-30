using System;

namespace Maple2.Trigger._02000177_bf {
    public static class _guide {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateguide(context);

        private class Stateguide : TriggerState {
            internal Stateguide(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 702, arg2: 1)) {
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
                context.ShowGuideSummary(entityID: 20001771, textID: 20001771, durationTime: 4000);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 703, arg2: 1)) {
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
                context.ShowGuideSummary(entityID: 20001771, textID: 20001771, durationTime: 4000);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
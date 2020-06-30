using System;

namespace Maple2.Trigger._52100053_qd {
    public static class _02_searchhiddenroute {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {920, 921});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9100")) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {920, 921}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePickRandomRoute(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickRandomRoute : TriggerState {
            internal StatePickRandomRoute(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20039702, textID: 20039702, duration: 4000);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateBehindWoodbox(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateBehindWardrope(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBehindWoodbox : TriggerState {
            internal StateBehindWoodbox(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 3600, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerID: 3700, key: "HiddenRouteOpen", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateBehindWardrope : TriggerState {
            internal StateBehindWardrope(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 3600, key: "HiddenRouteOpen", value: 1);
                context.SetUserValue(triggerID: 3700, key: "HiddenRouteOpen", value: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
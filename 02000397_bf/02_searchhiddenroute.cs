namespace Maple2.Trigger._02000397_bf {
    public static class _02_searchhiddenroute {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{920, 921});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{920, 921}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePickRandomRoute(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickRandomRoute : TriggerState {
            internal StatePickRandomRoute(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039702, textId: 20039702, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    return new StateBehindWoodbox(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateBehindWardrope(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBehindWoodbox : TriggerState {
            internal StateBehindWoodbox(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3600, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3700, key: "HiddenRouteOpen", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateBehindWardrope : TriggerState {
            internal StateBehindWardrope(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3600, key: "HiddenRouteOpen", value: 1);
                context.SetUserValue(triggerId: 3700, key: "HiddenRouteOpen", value: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

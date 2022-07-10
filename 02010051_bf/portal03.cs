namespace Maple2.Trigger._02010051_bf {
    public static class _portal03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000, 6001, 6002, 6003}, visible: false);
                context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{837}, visible: false);
                context.SetMesh(triggerIds: new []{2000, 2001, 2002, 2003, 2100, 2101, 2102, 2103, 2104, 2105, 2200}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{13001, 13002, 13003, 13004, 13005, 13006, 13007, 13008, 13009, 13010, 13011, 13012, 13013, 13014, 13015, 13016, 13017, 13018, 13019, 13020, 13021, 13022, 13023, 13024, 13025, 13026, 13027, 13028, 13029, 13030, 13031, 13032, 13033, 13034, 13035, 13036, 13037, 13038, 13039}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000837}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9012})) {
                    return new State입장Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장Delay01 : TriggerState {
            internal State입장Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 2);
                context.SetMesh(triggerIds: new []{2000, 2001, 2002, 2003, 2100, 2101, 2102, 2103, 2104, 2105}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateGuidePrepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuidePrepare01 : TriggerState {
            internal StateGuidePrepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105101, textId: 20105101, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000837}, arg2: 0)) {
                    return new StatePortalEnable01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable01 : TriggerState {
            internal StatePortalEnable01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7, key: "timercheck", value: 1);
                context.SetTimer(timerId: "10", seconds: 2);
                context.SetPortal(portalId: 50, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(triggerIds: new []{6003, 837}, visible: true);
                context.SetRandomMesh(triggerIds: new []{5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, visible: true, meshCount: 10, arg4: 50, delay: 50);
                context.SetMesh(triggerIds: new []{13001, 13002, 13003, 13004, 13005, 13006, 13007, 13008, 13009, 13010, 13011, 13012, 13013, 13014, 13015, 13016, 13017, 13018, 13019, 13020, 13021, 13022, 13023, 13024, 13025, 13026, 13027, 13028, 13029, 13030, 13031, 13032, 13033, 13034, 13035, 13036, 13037, 13038, 13039}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{2200}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State대화SetupCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화SetupCinematic01 : TriggerState {
            internal State대화SetupCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                return new StateCinematic대화01(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematic대화01 : TriggerState {
            internal StateCinematic대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 3);
                context.SetConversation(type: 2, spawnId: 11001319, script: "$02010051_BF__PORTAL03__0$", arg4: 3);
                context.SetSkip(state: new State대화StopCinematic01(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new State대화StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화StopCinematic01 : TriggerState {
            internal State대화StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6003}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

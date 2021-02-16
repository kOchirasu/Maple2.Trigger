namespace Maple2.Trigger._02010051_bf {
    public static class _portal03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000, 6001, 6002, 6003}, arg2: false);
                context.SetPortal(arg1: 50, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {837}, arg2: false);
                context.SetMesh(arg1: new[] {2000, 2001, 2002, 2003, 2100, 2101, 2102, 2103, 2104, 2105, 2200}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {13001, 13002, 13003, 13004, 13005, 13006, 13007, 13008, 13009, 13010, 13011, 13012, 13013, 13014, 13015, 13016, 13017, 13018, 13019, 13020, 13021, 13022, 13023, 13024, 13025, 13026, 13027, 13028, 13029, 13030, 13031, 13032, 13033, 13034, 13035, 13036, 13037, 13038, 13039}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000837}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9012})) {
                    return new State입장Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장Delay01 : TriggerState {
            internal State입장Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetMesh(arg1: new[] {2000, 2001, 2002, 2003, 2100, 2101, 2102, 2103, 2104, 2105}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
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

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000837}, arg2: 0)) {
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
                context.SetTimer(arg1: "10", arg2: 2);
                context.SetPortal(arg1: 50, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new[] {6003, 837}, arg2: true);
                context.SetRandomMesh(arg1: new[] {5000, 5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009}, arg2: true, arg3: 10, arg4: 50, arg5: 50);
                context.SetMesh(arg1: new[] {13001, 13002, 13003, 13004, 13005, 13006, 13007, 13008, 13009, 13010, 13011, 13012, 13013, 13014, 13015, 13016, 13017, 13018, 13019, 13020, 13021, 13022, 13023, 13024, 13025, 13026, 13027, 13028, 13029, 13030, 13031, 13032, 13033, 13034, 13035, 13036, 13037, 13038, 13039}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {2200}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State대화SetupCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화SetupCinematic01 : TriggerState {
            internal State대화SetupCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                return new StateCinematic대화01(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematic대화01 : TriggerState {
            internal StateCinematic대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001319, arg3: "$02010051_BF__PORTAL03__0$", arg4: 3);
                context.SetSkip(state: new State대화StopCinematic01(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
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
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
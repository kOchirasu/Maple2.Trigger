namespace Maple2.Trigger._52100022_qd {
    public static class _1122330_move {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, visible: true);
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021}, visible: false);
                context.SetInteractObject(interactIds: new []{10001107}, state: 2);
                context.SetUserValue(key: "ElevatorOn", value: 0);
                context.SetUserValue(key: "DungeonClear", value: 0);
                context.SetUserValue(key: "AgentOff", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ElevatorOn") == 1) {
                    return new StateBoardApp01(context);
                }

                if (context.GetUserValue(key: "AgentOff") == 1) {
                    return new StateAgentOff01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardApp01 : TriggerState {
            internal StateBoardApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20038102, textId: 20038102);
                context.SetInteractObject(interactIds: new []{10001107}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001107}, arg2: 0)) {
                    return new StateBoardGoUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp01 : TriggerState {
            internal StateBoardGoUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20038102);
                context.SetInteractObject(interactIds: new []{10001107}, state: 2);
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021}, visible: true);
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121}, visible: false, arg3: 200, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221}, visible: false, arg3: 200, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateBoardGoUp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp02 : TriggerState {
            internal StateBoardGoUp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121}, visible: true, arg3: 100, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBoardGoUp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardGoUp03 : TriggerState {
            internal StateBoardGoUp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021}, visible: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEmergencyPortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEmergencyPortalOn : TriggerState {
            internal StateEmergencyPortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateAgentOff01 : TriggerState {
            internal StateAgentOff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

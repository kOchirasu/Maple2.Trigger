namespace Maple2.Trigger._02000368_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3100}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000999}, state: 0);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 30, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 40, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 60, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 70, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 80, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 100, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1001})) {
                    return new StateCombatDetection(context);
                }

                if (context.UserDetected(boxIds: new []{1002})) {
                    return new StateCombatDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCombatDetection : TriggerState {
            internal StateCombatDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 111, 201, 211, 301, 311, 401, 411, 501, 511, 601, 611})) {
                    return new StateCombatDetection2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCombatDetection2 : TriggerState {
            internal StateCombatDetection2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102, 202, 302, 402, 502, 602})) {
                    return new StatePortalEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable : TriggerState {
            internal StatePortalEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000999}, state: 1);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 30, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 40, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 50, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 60, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 70, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 80, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000999}, arg2: 0)) {
                    return new State다리Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Creation : TriggerState {
            internal State다리Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3002, 3003, 3004, 3005, 3100}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119, 3120, 3121, 3122, 3123, 3124, 3125, 3126, 3127, 3128, 3129, 3130, 3131, 3132, 3133, 3134, 3135, 3136, 3137, 3138, 3139, 3140, 3141, 3142, 3143, 3144, 3145, 3146, 3147}, visible: true, arg3: 0, arg4: 10, arg5: 0f);
                context.SetPortal(portalId: 100, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

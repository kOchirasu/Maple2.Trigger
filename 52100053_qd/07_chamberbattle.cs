namespace Maple2.Trigger._52100053_qd {
    public static class _07_chamberbattle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10002099}, state: 0);
                context.DestroyMonster(spawnIds: new []{940, 941, 942});
                context.SetBreakable(triggerIds: new []{6200}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{6200}, visible: false);
                context.SetMesh(triggerIds: new []{3910}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3920}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5300}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9400})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002099}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGuideFindPortal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuideFindPortal : TriggerState {
            internal StateGuideFindPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039705, textId: 20039705);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMobTrapOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobTrapOn : TriggerState {
            internal StateMobTrapOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{940, 941, 942}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002099}, arg2: 0)) {
                    return new StateRockMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockMove01 : TriggerState {
            internal StateRockMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3910}, visible: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetBreakable(triggerIds: new []{6200}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{6200}, visible: true);
                context.SetEffect(triggerIds: new []{5300}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateRockMove02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockMove02 : TriggerState {
            internal StateRockMove02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRockMove03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockMove03 : TriggerState {
            internal StateRockMove03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3920}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(triggerIds: new []{6200}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{6200}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

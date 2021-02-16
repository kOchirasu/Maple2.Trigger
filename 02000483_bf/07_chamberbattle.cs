namespace Maple2.Trigger._02000483_bf {
    public static class _07_chamberbattle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: false);
                context.SetInteractObject(arg1: new[] {10002046}, arg2: 0);
                context.DestroyMonster(arg1: new[] {940, 941, 942});
                context.SetBreakable(arg1: new[] {6200}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {6200}, arg2: false);
                context.SetMesh(arg1: new[] {3910}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3920}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5300}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9400})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039706, textId: 20039706);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {940, 941, 942}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateMobTrapOnEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateMobTrapOnEnd : TriggerState {
            internal StateMobTrapOnEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942})) {
                    return new StateSwichOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwichOn : TriggerState {
            internal StateSwichOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002046}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002046}, arg2: 0)) {
                    return new StateRockMove01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRockMove01 : TriggerState {
            internal StateRockMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3910}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetBreakable(arg1: new[] {6200}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {6200}, arg2: true);
                context.SetEffect(arg1: new[] {5300}, arg2: true);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {3920}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new[] {6200}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {6200}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
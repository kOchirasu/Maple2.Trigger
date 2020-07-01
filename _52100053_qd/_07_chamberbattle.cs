namespace Maple2.Trigger._52100053_qd {
    public static class _07_chamberbattle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new[] {10002099}, arg2: 0);
                context.DestroyMonster(arg1: new[] {940, 941, 942});
                context.SetBreakable(arg1: new[] {6200}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {6200}, arg2: false);
                context.SetMesh(arg1: new[] {3910}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3920}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5300}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9400})) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002099}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGuideFindPortal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideFindPortal : TriggerState {
            internal StateGuideFindPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039705, textId: 20039705);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMobTrapOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobTrapOn : TriggerState {
            internal StateMobTrapOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {940, 941, 942}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002099}, arg2: 0)) {
                    context.State = new StateRockMove01(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateRockMove02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRockMove02 : TriggerState {
            internal StateRockMove02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRockMove03(context);
                    return;
                }
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

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
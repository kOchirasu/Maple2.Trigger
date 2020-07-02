namespace Maple2.Trigger._02010051_bf {
    public static class _portal01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {835, 6000, 6001, 6002, 6003}, arg2: false);
                context.SetMesh(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008, 11009, 11010, 11011, 11012, 11013, 11014, 11015, 11016, 11017, 11018, 11019, 11020, 11021, 11022, 11023, 11024, 11025, 11026, 11027, 11028}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000835}, arg2: 1);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9010})) {
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
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateGuide준비01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide준비01 : TriggerState {
            internal StateGuide준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105101, textId: 20105101, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000835}, arg2: 0)) {
                    return new StatePortalEnable01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable01 : TriggerState {
            internal StatePortalEnable01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 1);
                context.SetEffect(arg1: new[] {835, 6001}, arg2: true);
                context.SetMesh(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008, 11009, 11010, 11011, 11012, 11013, 11014, 11015, 11016, 11017, 11018, 11019, 11020, 11021, 11022, 11023, 11024, 11025, 11026, 11027, 11028}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new StatePortalEnable02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable02 : TriggerState {
            internal StatePortalEnable02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 21, arg2: true, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000836}, arg2: 0)) {
                    return new StatePortalDisable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalDisable : TriggerState {
            internal StatePortalDisable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetEffect(arg1: new[] {6001}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
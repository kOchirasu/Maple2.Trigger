namespace Maple2.Trigger._02000344_bf {
    public static class _dress {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6701, 6702, 6703, 6704, 6705}, arg2: true, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {6711, 6712, 6713, 6714, 6715}, arg2: false, arg3: 0, arg4: 10);
                context.SetInteractObject(arg1: new[] {10001066}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 60002) == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003441, textId: 20003441, duration: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000344_BF__DRESS__0$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6701, 6702, 6703, 6704, 6705}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {6711, 6712, 6713, 6714, 6715}, arg2: true, arg3: 0, arg4: 10);
                context.ShowGuideSummary(entityId: 20003444, textId: 20003444, duration: 5000);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
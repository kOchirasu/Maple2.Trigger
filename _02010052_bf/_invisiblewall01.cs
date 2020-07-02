namespace Maple2.Trigger._02010052_bf {
    public static class _invisiblewall01 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {20100, 20101, 20102, 20103, 20104, 20105, 20106, 20107, 20108, 20109, 20110, 20111, 20112}, arg2: true, arg4: 0, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 710) == 1) {
                    return new State벽면처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {20100, 20101, 20102, 20103, 20104, 20105, 20106, 20107, 20108, 20109, 20110, 20111, 20112}, arg2: false, arg4: 0, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 710) != 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
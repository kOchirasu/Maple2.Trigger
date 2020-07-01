namespace Maple2.Trigger._02010052_bf {
    public static class _invisiblewall02 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {20200, 20201, 20202, 20203, 20204, 20205, 20206, 20207, 20208, 20209, 20210, 20211, 20212, 20213, 20214, 20215, 20216, 20217, 20218, 20219, 20220, 20221, 20222, 20223, 20224, 20225, 20226, 20227, 20228, 20229, 20230}, arg2: true, arg4: 0, arg5: 3f);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 711) == 1) {
                    context.State = new State벽면처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {20200, 20201, 20202, 20203, 20204, 20205, 20206, 20207, 20208, 20209, 20210, 20211, 20212, 20213, 20214, 20215, 20216, 20217, 20218, 20219, 20220, 20221, 20222, 20223, 20224, 20225, 20226, 20227, 20228, 20229, 20230}, arg2: false, arg4: 0, arg5: 3f);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 711) != 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
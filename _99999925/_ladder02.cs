namespace Maple2.Trigger._99999925 {
    public static class _ladder02 {
        public class StateladderIdle : TriggerState {
            internal StateladderIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001078}, arg2: 0)) {
                    context.State = new StateladderWolk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateladderWolk : TriggerState {
            internal StateladderWolk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {702}, arg2: false, arg3: 1);
                context.SetAiExtraData(key: "LadderCnt", value: 1, isModify: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateladderEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateladderEnd : TriggerState {
            internal StateladderEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._99999925 {
    public static class _ladder01 {
        public class StateLadderIdle : TriggerState {
            internal StateLadderIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001077}, arg2: 0)) {
                    return new StateLadderWolk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderWolk : TriggerState {
            internal StateLadderWolk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {701}, arg2: false, arg3: 1);
                context.SetAiExtraData(key: "LadderCnt", value: 1, isModify: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLadderEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderEnd : TriggerState {
            internal StateLadderEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
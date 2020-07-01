namespace Maple2.Trigger._99999925 {
    public static class _checkpolymorph {
        public class StateCheckIdle : TriggerState {
            internal StateCheckIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BuffGo") == 1) {
                    context.State = new StateCheckpoly(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckpoly : TriggerState {
            internal StateCheckpoly(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BuffStart", value: 1, isModify: true);
                context.SetUserValue(key: "BuffGo", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCheckIdle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
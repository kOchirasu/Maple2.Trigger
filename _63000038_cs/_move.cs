namespace Maple2.Trigger._63000038_cs {
    public static class _move {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(
                    arg1: new[] {
                        7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015,
                        7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023
                    }, arg2: false);
                context.SetInteractObject(arg1: new[] {10001024}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Setlever") == 1) {
                    context.State = new State레버반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버반응대기 : TriggerState {
            internal State레버반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300382, textId: 26300382);
                context.SetInteractObject(arg1: new[] {10001024}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001024}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 26300382);
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(
                    arg1: new[] {
                        7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015,
                        7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
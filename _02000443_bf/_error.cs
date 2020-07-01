namespace Maple2.Trigger._02000443_bf {
    public static class _error {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new Statebuff_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff_1 : TriggerState {
            internal Statebuff_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 49200002, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    context.State = new Statebuff_2(context);
                    return;
                }

                if (context.GetUserValue(key: "debuff") == 1) {
                    // context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff_2 : TriggerState {
            internal Statebuff_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 49200002, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    context.State = new Statebuff_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000283_bf {
    public static class _ladder {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 511, arg2: false, arg3: false);
                context.SetLadder(arg1: 512, arg2: false, arg3: false);
                context.SetLadder(arg1: 513, arg2: false, arg3: false);
                context.SetLadder(arg1: 514, arg2: false, arg3: false);
                context.SetInteractObject(arg1: new[] {10000429}, arg2: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {2001})) {
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000429}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000429}, arg2: 0)) {
                    context.State = new State사다리생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리생성 : TriggerState {
            internal State사다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 511, arg2: true, arg3: true);
                context.SetLadder(arg1: 512, arg2: true, arg3: true);
                context.SetLadder(arg1: 513, arg2: true, arg3: true);
                context.SetLadder(arg1: 514, arg2: true, arg3: true);
                context.SetTimer(arg1: "10", arg2: 10, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
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
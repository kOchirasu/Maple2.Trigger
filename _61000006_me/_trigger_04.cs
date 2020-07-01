namespace Maple2.Trigger._61000006_me {
    public static class _trigger_04 {
        public class State레버 : TriggerState {
            internal State레버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {510, 511, 512, 513, 514, 515, 516}, arg2: true);
                context.SetEffect(arg1: new[] {701}, arg2: false);
                context.SetEffect(arg1: new[] {702}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {401})) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {510, 511, 512, 513, 514, 515, 516}, arg2: false);
                context.SetEffect(arg1: new[] {701}, arg2: true);
                context.SetEffect(arg1: new[] {702}, arg2: true);
                context.SetTimer(arg1: "11", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State폭죽끄기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State폭죽끄기 : TriggerState {
            internal State폭죽끄기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 120);
                context.SetEffect(arg1: new[] {701}, arg2: false);
                context.SetEffect(arg1: new[] {702}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State레버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000136_ad {
    public static class _01_trigger02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {801, 802, 803}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000067}, arg2: 1);
                context.SetMesh(arg1: new[] {14, 17, 16}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000067}, arg2: 0)) {
                    context.State = new State발판등장1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판등장1 : TriggerState {
            internal State발판등장1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {14}, arg2: true);
                context.SetEffect(arg1: new[] {801}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State발판등장2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판등장2 : TriggerState {
            internal State발판등장2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {17}, arg2: true);
                context.SetEffect(arg1: new[] {802}, arg2: true);
                context.SetTimer(arg1: "3", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State발판등장3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판등장3 : TriggerState {
            internal State발판등장3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {16}, arg2: true);
                context.SetEffect(arg1: new[] {803}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
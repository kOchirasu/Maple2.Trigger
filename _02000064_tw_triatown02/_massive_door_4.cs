namespace Maple2.Trigger._02000064_tw_triatown02 {
    public static class _massive_door_4 {
        public class State클로즈대기중 : TriggerState {
            internal State클로즈대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State클로즈5초전 : TriggerState {
            internal State클로즈5초전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "115", arg2: 115);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "115")) {
                    context.State = new State클로즈중1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "115");
            }
        }

        private class State클로즈중1 : TriggerState {
            internal State클로즈중1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State클로즈중2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "5");
            }
        }

        private class State클로즈중2 : TriggerState {
            internal State클로즈중2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State클로즈대기중(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "6");
            }
        }
    }
}
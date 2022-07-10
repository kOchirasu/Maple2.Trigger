namespace Maple2.Trigger._02000251_bf {
    public static class _end {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스1 : TriggerState {
            internal State어나운스1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 7);
                context.SetEventUI(arg1: 1, script: "$02000251_BF__END__0$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State어나운스2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스2 : TriggerState {
            internal State어나운스2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 7);
                context.SetEventUI(arg1: 1, script: "$02000251_BF__END__1$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State어나운스3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스3 : TriggerState {
            internal State어나운스3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 7);
                context.SetEventUI(arg1: 1, script: "$02000251_BF__END__2$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State어나운스4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스4 : TriggerState {
            internal State어나운스4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State통과(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State통과 : TriggerState {
            internal State통과(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 300);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

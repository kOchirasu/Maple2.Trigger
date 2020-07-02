namespace Maple2.Trigger._02000133_ad {
    public static class _board {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000346}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000346}, arg2: 0)) {
                    return new State어나운스(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스 : TriggerState {
            internal State어나운스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000133_AD__BOARD__0$", arg3: 4000, arg4: "101");
                context.SetTimer(arg1: "5", arg2: 5, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
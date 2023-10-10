namespace Maple2.Trigger._02000133_ad {
    public static class _board {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000346}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000346}, arg2: 0)) {
                    return new State어나운스(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어나운스 : TriggerState {
            internal State어나운스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000133_AD__BOARD__0$", duration: 4000, boxId: 101);
                context.SetTimer(timerId: "5", seconds: 5, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

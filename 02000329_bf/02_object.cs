namespace Maple2.Trigger._02000329_bf {
    public static class _02_object {
        public class State오브젝트_01 : TriggerState {
            internal State오브젝트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{10001}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100})) {
                    return new State오브젝트_01_작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트_01_작동 : TriggerState {
            internal State오브젝트_01_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{10001}, enabled: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

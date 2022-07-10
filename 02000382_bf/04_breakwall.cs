namespace Maple2.Trigger._02000382_bf {
    public static class _04_breakwall {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7000}, arg2: false);
                context.SetUserValue(key: "BossKill", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StateBreakWall(context);
                }

                if (context.GetUserValue(key: "BossKill") == 1) {
                    return new StateBreakWall(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBreakWall : TriggerState {
            internal StateBreakWall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7000}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

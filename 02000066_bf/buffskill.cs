namespace Maple2.Trigger._02000066_bf {
    public static class _buffskill {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateASkillCast(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateASkillCast : TriggerState {
            internal StateASkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002}, visible: false);
                context.SetSkill(triggerIds: new []{7001}, arg2: true);
                context.SetTimer(timerId: "60", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "60")) {
                    context.SetSkill(triggerIds: new []{7001}, arg2: false);
                    context.SetEffect(triggerIds: new []{6002}, visible: false);
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

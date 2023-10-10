namespace Maple2.Trigger._99999905 {
    public static class _buffskill_01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10601})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkillRandom : TriggerState {
            internal StateSkillRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Dead_A");
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{10601})) {
                    return new StateReset(context);
                }

                if (context.RandomCondition(rate: 33)) {
                    return new StateASkillCast(context);
                }

                if (context.RandomCondition(rate: 33)) {
                    return new StateBSkillCast(context);
                }

                if (context.RandomCondition(rate: 34)) {
                    return new StateCSkillCast(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateASkillCast : TriggerState {
            internal StateASkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7101}, enabled: true);
                context.SetTimer(timerId: "60", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "60")) {
                    context.SetSkill(triggerIds: new []{7101}, enabled: false);
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBSkillCast : TriggerState {
            internal StateBSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7102}, enabled: true);
                context.SetTimer(timerId: "60", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "60")) {
                    context.SetSkill(triggerIds: new []{7102}, enabled: false);
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCSkillCast : TriggerState {
            internal StateCSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7103}, enabled: true);
                context.SetTimer(timerId: "60", seconds: 60);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "60")) {
                    context.SetSkill(triggerIds: new []{7103}, enabled: false);
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{7101, 7102, 7103}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

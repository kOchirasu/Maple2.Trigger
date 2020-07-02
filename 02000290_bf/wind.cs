namespace Maple2.Trigger._02000290_bf {
    public static class _wind {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {701}, arg2: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkillRandom : TriggerState {
            internal StateSkillRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateASkillCast(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateBSkillCast(context);
                }

                if (context.RandomCondition(arg1: 34f)) {
                    return new StateCSkillCast(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateASkillCast : TriggerState {
            internal StateASkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    context.ShowGuideSummary(entityId: 20002906, textId: 20002906);
                    return new StateActivateSkill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBSkillCast : TriggerState {
            internal StateBSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    context.ShowGuideSummary(entityId: 20002906, textId: 20002906);
                    return new StateActivateSkill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCSkillCast : TriggerState {
            internal StateCSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 8000)) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    context.ShowGuideSummary(entityId: 20002906, textId: 20002906);
                    return new StateActivateSkill(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivateSkill : TriggerState {
            internal StateActivateSkill(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.HideGuideSummary(entityId: 20002906);
                    context.SetEffect(arg1: new[] {602, 603, 604, 605}, arg2: true);
                    context.SetSkill(arg1: new[] {701}, arg2: true);
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002906);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
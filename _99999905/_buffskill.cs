namespace Maple2.Trigger._99999905 {
    public static class _buffskill {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkillRandom : TriggerState {
            internal StateSkillRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$99999905__BUFFSKILL__0$", arg3: 2000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {103})) {
                    return new StateReset(context);
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

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7001}, arg2: true);
                context.SetTimer(arg1: "120", arg2: 120);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    context.SetSkill(arg1: new[] {7001}, arg2: false);
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBSkillCast : TriggerState {
            internal StateBSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7002}, arg2: true);
                context.SetTimer(arg1: "120", arg2: 120);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    context.SetSkill(arg1: new[] {7002}, arg2: false);
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCSkillCast : TriggerState {
            internal StateCSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7003}, arg2: true);
                context.SetTimer(arg1: "120", arg2: 120);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    context.SetSkill(arg1: new[] {7003}, arg2: false);
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {7001, 7002, 7003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
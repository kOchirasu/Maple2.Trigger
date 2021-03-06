namespace Maple2.Trigger._99999905 {
    public static class _buffskill_04 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 204, arg2: true, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10604})) {
                    return new StateSkillRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkillRandom : TriggerState {
            internal StateSkillRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 204, arg2: true, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {10604})) {
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
                context.SetSkill(arg1: new[] {7401}, arg2: true);
                context.SetTimer(id: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7401}, arg2: false);
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBSkillCast : TriggerState {
            internal StateBSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7402}, arg2: true);
                context.SetTimer(id: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7402}, arg2: false);
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCSkillCast : TriggerState {
            internal StateCSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7403}, arg2: true);
                context.SetTimer(id: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7403}, arg2: false);
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
                context.SetSkill(arg1: new[] {7401, 7402, 7403}, arg2: false);
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
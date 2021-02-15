namespace Maple2.Trigger._65000002_bd {
    public static class _buffskill {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State2초Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2초Wait : TriggerState {
            internal State2초Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
                context.PlaySystemSoundInBox(arg2: "BD_Buffskill_00");
                context.ShowGuideSummary(entityId: 26500202, textId: 26500202, duration: 3000);
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
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
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
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
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
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
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
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
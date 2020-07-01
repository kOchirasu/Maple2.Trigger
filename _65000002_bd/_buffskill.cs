namespace Maple2.Trigger._65000002_bd {
    public static class _buffskill {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State2초대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2초대기 : TriggerState {
            internal State2초대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬랜덤 : TriggerState {
            internal State스킬랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.PlaySystemSoundInBox(arg2: "BD_Buffskill_00");
                context.ShowGuideSummary(entityId: 26500202, textId: 26500202, duration: 3000);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {103})) {
                    return new State초기화(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateA스킬작동(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateB스킬작동(context);
                }

                if (context.RandomCondition(arg1: 34f)) {
                    return new StateC스킬작동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateA스킬작동 : TriggerState {
            internal StateA스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7001}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7001}, arg2: false);
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB스킬작동 : TriggerState {
            internal StateB스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7002}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7002}, arg2: false);
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC스킬작동 : TriggerState {
            internal StateC스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7003}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7003}, arg2: false);
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {7001, 7002, 7003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._65000003_bd {
    public static class _buffskill_04 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 204, arg2: true, arg3: "Idle_A");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10604})) {
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬랜덤 : TriggerState {
            internal State스킬랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 204, arg2: true, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {10604})) {
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
                context.SetSkill(arg1: new[] {7401}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7401}, arg2: false);
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB스킬작동 : TriggerState {
            internal StateB스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7402}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7402}, arg2: false);
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC스킬작동 : TriggerState {
            internal StateC스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7403}, arg2: true);
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.SetSkill(arg1: new[] {7403}, arg2: false);
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {7401, 7402, 7403}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000290_bf {
    public static class _wind {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {701}, arg2: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬랜덤 : TriggerState {
            internal State스킬랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State종료(context);
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

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    context.ShowGuideSummary(entityId: 20002906, textId: 20002906);
                    return new State스킬발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB스킬작동 : TriggerState {
            internal StateB스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    context.ShowGuideSummary(entityId: 20002906, textId: 20002906);
                    return new State스킬발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateC스킬작동 : TriggerState {
            internal StateC스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 8000)) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    context.ShowGuideSummary(entityId: 20002906, textId: 20002906);
                    return new State스킬발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킬발동 : TriggerState {
            internal State스킬발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.HideGuideSummary(entityId: 20002906);
                    context.SetEffect(arg1: new[] {602, 603, 604, 605}, arg2: true);
                    context.SetSkill(arg1: new[] {701}, arg2: true);
                    return new State스킬랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

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
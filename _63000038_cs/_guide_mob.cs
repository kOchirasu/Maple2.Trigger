namespace Maple2.Trigger._63000038_cs {
    public static class _guide_mob {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {2101})) {
                    return new State가이드출력(context);
                }

                if (context.MonsterInCombat(arg1: new[] {2102})) {
                    return new State가이드출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드출력 : TriggerState {
            internal State가이드출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300383, textId: 26300383);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new State가이드삭제대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드삭제대기 : TriggerState {
            internal State가이드삭제대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State가이드삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드삭제 : TriggerState {
            internal State가이드삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2103})) {
                    context.HideGuideSummary(entityId: 26300383);
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
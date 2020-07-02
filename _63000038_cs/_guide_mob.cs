namespace Maple2.Trigger._63000038_cs {
    public static class _guide_mob {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {2101})) {
                    return new StateGuide출력(context);
                }

                if (context.MonsterInCombat(arg1: new[] {2102})) {
                    return new StateGuide출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide출력 : TriggerState {
            internal StateGuide출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300383, textId: 26300383);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new StateGuide삭제대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide삭제대기 : TriggerState {
            internal StateGuide삭제대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGuide삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide삭제 : TriggerState {
            internal StateGuide삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2103})) {
                    context.HideGuideSummary(entityId: 26300383);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000314_bf {
    public static class _guide {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {112})) {
                    return new State타이어가이드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이어가이드 : TriggerState {
            internal State타이어가이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003141, textId: 20003141, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {113})) {
                    return new State타이어가이드2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이어가이드2 : TriggerState {
            internal State타이어가이드2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003141, textId: 20003141, duration: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
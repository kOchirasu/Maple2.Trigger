using System;

namespace Maple2.Trigger._02000314_bf {
    public static class _guide {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "112")) {
                    context.State = new State타이어가이드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이어가이드 : TriggerState {
            internal State타이어가이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003141, textID: 20003141, durationTime: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "113")) {
                    context.State = new State타이어가이드2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이어가이드2 : TriggerState {
            internal State타이어가이드2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003141, textID: 20003141, durationTime: 5000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
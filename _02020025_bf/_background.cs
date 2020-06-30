using System;

namespace Maple2.Trigger._02020025_bf {
    public static class _background {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "903")) {
                    context.State = new State지하배경(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지하배경 : TriggerState {
            internal State지하배경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeBackground(dds: "BG_Cave_D.dds");
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "903")) {
                    context.State = new State지상배경(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State지상배경 : TriggerState {
            internal State지상배경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeBackground(dds: "BG_Tria.dds");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "903")) {
                    context.State = new State지하배경(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000375_bf {
    public static class _1122000 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 13500, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ChangeBGM") == 1) {
                    context.State = new StateBGM변경(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBGM변경 : TriggerState {
            internal StateBGM변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 13500, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
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
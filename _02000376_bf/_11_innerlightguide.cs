namespace Maple2.Trigger._02000376_bf {
    public static class _11_innerlightguide {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonStart", value: 0);
                context.SetEffect(arg1: new[] {5100}, arg2: false);
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.SetEffect(arg1: new[] {5102}, arg2: false);
                context.SetEffect(arg1: new[] {5103}, arg2: false);
                context.SetEffect(arg1: new[] {5104}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "DungeonStart") == 1) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGuideOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideOn : TriggerState {
            internal StateGuideOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000376_BF__11_INNERLIGHTGUIdE__0$", arg3: 4000,
                    arg4: "0");
                context.SetEffect(arg1: new[] {5100}, arg2: true);
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.SetEffect(arg1: new[] {5104}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5100}, arg2: false);
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.SetEffect(arg1: new[] {5102}, arg2: false);
                context.SetEffect(arg1: new[] {5103}, arg2: false);
                context.SetEffect(arg1: new[] {5104}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
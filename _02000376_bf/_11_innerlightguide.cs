using System;

namespace Maple2.Trigger._02000376_bf {
    public static class _11_innerlightguide {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonStart", value: 0);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.SetEffect(arg1: new int[] {5103}, arg2: false);
                context.SetEffect(arg1: new int[] {5104}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "DungeonStart", value: 1)) {
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
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000376_BF__11_INNERLIGHTGUIDE__0$", arg3: new int[] {4000},
                    arg4: "0");
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
                context.SetEffect(arg1: new int[] {5102}, arg2: true);
                context.SetEffect(arg1: new int[] {5103}, arg2: true);
                context.SetEffect(arg1: new int[] {5104}, arg2: true);
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
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.SetEffect(arg1: new int[] {5103}, arg2: false);
                context.SetEffect(arg1: new int[] {5104}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
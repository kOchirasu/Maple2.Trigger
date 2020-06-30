using System;

namespace Maple2.Trigger._02000376_bf {
    public static class _02_givelight {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001022}, arg2: 0);
                context.SetUserValue(key: "InnerLight", value: 0);
                context.SetUserValue(key: "InactivateLotus", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "InnerLight", value: 1)) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001022}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001022}, arg2: 0)) {
                    context.State = new StateGiveLight01(context);
                    return;
                }

                if (context.UserValue(key: "InactivateLotus", value: 1)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGiveLight01 : TriggerState {
            internal StateGiveLight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9100}, arg2: 70000102, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateDelay01(context);
                    return;
                }

                if (context.UserValue(key: "InactivateLotus", value: 1)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
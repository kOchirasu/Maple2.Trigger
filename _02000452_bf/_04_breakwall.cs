using System;

namespace Maple2.Trigger._02000452_bf {
    public static class _04_breakwall {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7000}, arg2: false);
                context.SetUserValue(key: "BossKill", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9100})) {
                    context.State = new StateBreakWall(context);
                    return;
                }

                if (context.UserValue(key: "BossKill", value: 1)) {
                    context.State = new StateBreakWall(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBreakWall : TriggerState {
            internal StateBreakWall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7000}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
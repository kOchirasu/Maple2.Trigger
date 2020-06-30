using System;

namespace Maple2.Trigger._99999883 {
    public static class _testtrigger5_anyone {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {901});
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateStartDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartDelay : TriggerState {
            internal StateStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {901}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateCheckAnyOne(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckAnyOne : TriggerState {
            internal StateCheckAnyOne(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000) || context.MonsterDead(arg1: new int[] {901})) {
                    context.State = new StateQuitDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuitDelay : TriggerState {
            internal StateQuitDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {901});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
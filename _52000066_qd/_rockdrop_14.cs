using System;

namespace Maple2.Trigger._52000066_qd {
    public static class _rockdrop_14 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {8008}, arg2: false);
                context.SetSkill(arg1: new int[] {8009}, arg2: false);
                context.SetSkill(arg1: new int[] {8010}, arg2: false);
                context.SetEffect(arg1: new int[] {7008}, arg2: false);
                context.SetEffect(arg1: new int[] {7009}, arg2: false);
                context.SetEffect(arg1: new int[] {7010}, arg2: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateRockDrop01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRockDrop01 : TriggerState {
            internal StateRockDrop01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7010}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new StateRockDrop02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRockDrop02 : TriggerState {
            internal StateRockDrop02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {8010}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new StateRockDrop11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRockDrop11 : TriggerState {
            internal StateRockDrop11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7009}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new StateRockDrop12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRockDrop12 : TriggerState {
            internal StateRockDrop12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {8009}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateRockDrop21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRockDrop21 : TriggerState {
            internal StateRockDrop21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7008}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new StateRockDrop22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRockDrop22 : TriggerState {
            internal StateRockDrop22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {8008}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {8008}, arg2: false);
                context.SetSkill(arg1: new int[] {8009}, arg2: false);
                context.SetSkill(arg1: new int[] {8010}, arg2: false);
                context.SetEffect(arg1: new int[] {7008}, arg2: false);
                context.SetEffect(arg1: new int[] {7009}, arg2: false);
                context.SetEffect(arg1: new int[] {7010}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new StateRockDrop01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
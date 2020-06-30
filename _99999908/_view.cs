using System;

namespace Maple2.Trigger._99999908 {
    public static class _view {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new Statebuff_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff_01 : TriggerState {
            internal Statebuff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 99910221, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statebuff_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff_02 : TriggerState {
            internal Statebuff_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 99910221, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statebuff_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff_03 : TriggerState {
            internal Statebuff_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 99910221, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statebuff_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff_04 : TriggerState {
            internal Statebuff_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 99910221, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statebuff_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff_05 : TriggerState {
            internal Statebuff_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120
                });
                context.SpawnNpcRange(
                    rangeID: new int[] {
                        101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
                        120
                    }, isAutoTargeting: false, randomPickCount: 3, score: 100);
                context.AddBuff(arg1: new int[] {701}, arg2: 99910221, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
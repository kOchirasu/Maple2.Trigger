using System;

namespace Maple2.Trigger._02000426_bf {
    public static class _999991_zakumarmsudden {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SummonZakumArmRegenCheck", value: 0);
                context.SetUserValue(key: "SummonZakumArmMany", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {199})) {
                    context.State = new State대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기중 : TriggerState {
            internal State대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "SummonZakumArmRegenCheck", value: 1)) {
                    context.State = new State자쿰몸통무적버프로직_시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자쿰몸통무적버프로직_시작대기중 : TriggerState {
            internal State자쿰몸통무적버프로직_시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State자쿰몸통무적버프로직_작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자쿰몸통무적버프로직_작동 : TriggerState {
            internal State자쿰몸통무적버프로직_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {2011}, arg2: 50000265, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new int[] {2012}, arg2: 50000265, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "SummonZakumArmMany", value: 0)) {
                    context.State = new State자쿰몸통무적버프_제거대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자쿰몸통무적버프_제거대기 : TriggerState {
            internal State자쿰몸통무적버프_제거대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State자쿰몸통무적버프_제거작업(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State자쿰몸통무적버프_제거작업 : TriggerState {
            internal State자쿰몸통무적버프_제거작업(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointID: 2011, additionalEffectID: 50000265);
                context.NpcRemoveAdditionalEffect(spawnPointID: 2012, additionalEffectID: 50000265);
                context.SetUserValue(key: "SummonZakumArmRegenCheck", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new State대기중(context);
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
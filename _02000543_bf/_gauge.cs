using System;

namespace Maple2.Trigger._02000543_bf {
    public static class _gauge {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "GaugeOpen", value: 1)) {
                    context.State = new State게이지시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게이지시작 : TriggerState {
            internal State게이지시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpedition(type: "OpenBossGauge", title: "$02000543_BF__GAUGE__0$", maxGaugePoint: 1000);
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 1000)) {
                    context.State = new State성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpedition(type: "CloseBossGauge");
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetUserValue(triggerID: 2001, key: "WaveEnd", value: 1);
                context.SetUserValue(triggerID: 2003, key: "WaveEnd", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
namespace Maple2.Trigger._02000543_bf {
    public static class _gauge {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "GaugeOpen") == 1) {
                    return new State게이지시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게이지시작 : TriggerState {
            internal State게이지시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpeditionOpenBossGauge(title: "$02000543_BF__GAUGE__0$", maxGaugePoint: 1000);
            }

            public override TriggerState Execute() {
                if (context.GetShadowExpeditionPoints() >= 1000) {
                    return new State성공(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성공 : TriggerState {
            internal State성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpeditionCloseBossGauge();
                context.DestroyMonster(arg1: new[] {-1});
                context.SetUserValue(triggerId: 2001, key: "WaveEnd", value: 1);
                context.SetUserValue(triggerId: 2003, key: "WaveEnd", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
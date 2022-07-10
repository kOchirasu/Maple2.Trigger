namespace Maple2.Trigger._02000543_bf {
    public static class _gauge {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.GetShadowExpeditionPoints() >= 1000) {
                    return new StateSuccess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuccess : TriggerState {
            internal StateSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpeditionCloseBossGauge();
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetUserValue(triggerId: 2001, key: "WaveEnd", value: 1);
                context.SetUserValue(triggerId: 2003, key: "WaveEnd", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

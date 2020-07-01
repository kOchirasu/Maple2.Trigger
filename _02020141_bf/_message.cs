namespace Maple2.Trigger._02020141_bf {
    public static class _message {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new State메시지작동준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지작동준비 : TriggerState {
            internal State메시지작동준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MessageAlarm", value: 0);
                context.SetUserValue(key: "TriggerEnd", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State메시지작동대기버프체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지작동대기버프체크 : TriggerState {
            internal State메시지작동대기버프체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "TriggerEnd") == 99) {
                    context.State = new State트리거종료(context);
                    return;
                }

                if (context.GetUserValue(key: "MessageAlarm") == 13) {
                    context.State = new State경고메시지출력(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 99, additionalEffectId: 50000348, level: 1)) {
                    context.State = new State카운트다운체크(context);
                    return;
                }

                if (!context.CheckNpcAdditionalEffect(spawnPointId: 99, additionalEffectId: 50000348, level: 1)) {
                    context.State = new State카운트다운초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트다운체크 : TriggerState {
            internal State카운트다운체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddUserValue(key: "MessageAlarm", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State메시지작동대기버프체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트다운초기화 : TriggerState {
            internal State카운트다운초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MessageAlarm", value: 0);
                context.HideGuideSummary(entityId: 29200006);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State메시지작동대기버프체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경고메시지출력 : TriggerState {
            internal State경고메시지출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 29200006, textId: 29200006, duration: 4000);
                context.AddUserValue(key: "MessageAlarm", value: -11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State메시지작동대기버프체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거종료 : TriggerState {
            internal State트리거종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 29200006);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
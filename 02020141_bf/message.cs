namespace Maple2.Trigger._02020141_bf {
    public static class _message {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new State메시지작동Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메시지작동Prepare : TriggerState {
            internal State메시지작동Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MessageAlarm", value: 0);
                context.SetUserValue(key: "TriggerEnd", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State메시지작동WaitBuff체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메시지작동WaitBuff체크 : TriggerState {
            internal State메시지작동WaitBuff체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TriggerEnd") == 99) {
                    return new StateTrigger종료(context);
                }

                if (context.GetUserValue(key: "MessageAlarm") == 13) {
                    return new State경고DisplayGuide(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 99, additionalEffectId: 50000348, level: 1)) {
                    return new StateCount다운체크(context);
                }

                if (!context.CheckNpcAdditionalEffect(spawnId: 99, additionalEffectId: 50000348, level: 1)) {
                    return new StateCount다운Reset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount다운체크 : TriggerState {
            internal StateCount다운체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddUserValue(key: "MessageAlarm", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State메시지작동WaitBuff체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount다운Reset : TriggerState {
            internal StateCount다운Reset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "MessageAlarm", value: 0);
                context.HideGuideSummary(entityId: 29200006);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State메시지작동WaitBuff체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경고DisplayGuide : TriggerState {
            internal State경고DisplayGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 29200006, textId: 29200006, duration: 4000);
                context.AddUserValue(key: "MessageAlarm", value: -11);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State메시지작동WaitBuff체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger종료 : TriggerState {
            internal StateTrigger종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 29200006);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

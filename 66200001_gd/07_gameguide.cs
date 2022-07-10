namespace Maple2.Trigger._66200001_gd {
    public static class _07_gameguide {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GameGuide") == 1) {
                    return new StateGameGuide_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameGuide_20 : TriggerState {
            internal StateGameGuide_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 19, clearAtZero: true, display: false);
            }

            public override TriggerState? Execute() {
                return new StateNormalGameGuide_01(context);
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_01 : TriggerState {
            internal StateNormalGameGuide_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620104, textId: 26620104, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNormalGameGuide_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_02 : TriggerState {
            internal StateNormalGameGuide_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620105, textId: 26620105, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNormalGameGuide_03(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_03 : TriggerState {
            internal StateNormalGameGuide_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620104, textId: 26620104, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateNormalGameGuide_04(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_04 : TriggerState {
            internal StateNormalGameGuide_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620105, textId: 26620105, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GameGuide", value: 0);
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

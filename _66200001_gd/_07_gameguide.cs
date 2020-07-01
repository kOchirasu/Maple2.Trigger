namespace Maple2.Trigger._66200001_gd {
    public static class _07_gameguide {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "GameGuide") == 1) {
                    context.State = new StateGameGuide_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuide_20 : TriggerState {
            internal StateGameGuide_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 19, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNormalGameGuide_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_01 : TriggerState {
            internal StateNormalGameGuide_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620104, textId: 26620104, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNormalGameGuide_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_02 : TriggerState {
            internal StateNormalGameGuide_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620105, textId: 26620105, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNormalGameGuide_03(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_03 : TriggerState {
            internal StateNormalGameGuide_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620104, textId: 26620104, duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNormalGameGuide_04(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalGameGuide_04 : TriggerState {
            internal StateNormalGameGuide_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26620105, textId: 26620105, duration: 4000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GameGuide", value: 0);
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
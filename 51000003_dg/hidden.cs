namespace Maple2.Trigger._51000003_dg {
    public static class _hidden {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateHidden_ready_01 : TriggerState {
            internal StateHidden_ready_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 99, visible: false, enabled: false, minimapVisible: false);
                context.SetEventUI(arg1: 1, script: "$51000003_DG__HIdDEN__0$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateHidden_ready_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHidden_ready_02 : TriggerState {
            internal StateHidden_ready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$51000003_DG__HIdDEN__1$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateHidden_ready_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHidden_ready_03 : TriggerState {
            internal StateHidden_ready_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, script: "6,6", duration: 0, boxId: 0);
                context.CameraSelect(triggerId: 8002, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateHidden_ready_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHidden_ready_04 : TriggerState {
            internal StateHidden_ready_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$61000004_ME__TRIGGER_01__1$", stage: 0, count: 5);
                context.SetAchievement(triggerId: 710, type: "trigger", code: "boomboombeach_hidden_start");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateHidden_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHidden_Start : TriggerState {
            internal StateHidden_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991104, key: "Round_06", value: 1);
                context.SetUserValue(triggerId: 991105, key: "Round_06", value: 1);
                context.SetUserValue(triggerId: 991106, key: "Round_06", value: 1);
                context.SetUserValue(triggerId: 991107, key: "Round_06", value: 1);
                context.SetUserValue(triggerId: 991108, key: "Round_06", value: 1);
                context.SetTimer(timerId: "150", seconds: 150, display: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

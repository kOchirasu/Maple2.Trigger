namespace Maple2.Trigger._51000003_dg {
    public static class _hidden {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateHidden_ready_01 : TriggerState {
            internal StateHidden_ready_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 99, visible: false, enabled: false, minimapVisible: false);
                context.SetEventUI(arg1: 1, script: "$51000003_DG__HIdDEN__0$", arg3: 4000, arg4: "0");
            }

            public override TriggerState Execute() {
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
                context.SetEventUI(arg1: 1, script: "$51000003_DG__HIdDEN__1$", arg3: 4000, arg4: "0");
            }

            public override TriggerState Execute() {
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
                context.SetEventUI(arg1: 0, script: "6,6", arg3: 0, arg4: "0");
                context.CameraSelect(arg1: 8002, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetAchievement(arg1: 710, arg2: "trigger", arg3: "boomboombeach_hidden_start");
            }

            public override TriggerState Execute() {
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
                context.SetTimer(id: "150", arg2: 150, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
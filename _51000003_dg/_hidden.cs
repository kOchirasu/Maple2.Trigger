using System;

namespace Maple2.Trigger._51000003_dg {
    public static class _hidden {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateStart(context);

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateHidden_ready_01 : TriggerState {
            internal StateHidden_ready_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 99, arg2: false, arg3: false, arg4: false);
                context.SetEventUI(arg1: 1, arg2: "$51000003_DG__HIDDEN__0$", arg3: new int[] {4000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateHidden_ready_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHidden_ready_02 : TriggerState {
            internal StateHidden_ready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$51000003_DG__HIDDEN__1$", arg3: new int[] {4000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateHidden_ready_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHidden_ready_03 : TriggerState {
            internal StateHidden_ready_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "6,6", arg3: new int[] {0}, arg4: "0");
                context.CameraSelect(arg1: 8002, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateHidden_ready_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHidden_ready_04 : TriggerState {
            internal StateHidden_ready_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$61000004_ME__TRIGGER_01__1$", stage: 0, count: 5);
                context.SetAchievement(arg1: 710, arg2: "trigger", arg3: "boomboombeach_hidden_start");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateHidden_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateHidden_Start : TriggerState {
            internal StateHidden_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991104, key: "Round_06", value: 1);
                context.SetUserValue(triggerID: 991105, key: "Round_06", value: 1);
                context.SetUserValue(triggerID: 991106, key: "Round_06", value: 1);
                context.SetUserValue(triggerID: 991107, key: "Round_06", value: 1);
                context.SetUserValue(triggerID: 991108, key: "Round_06", value: 1);
                context.SetTimer(arg1: "150", arg2: 150, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
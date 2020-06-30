using System;

namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8240 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Barrier24", value: 1)) {
                    context.State = new StateSensor7241(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 2)) {
                    context.State = new StateSensor7242(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 3)) {
                    context.State = new StateSensor7243(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 4)) {
                    context.State = new StateSensor7244(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 5)) {
                    context.State = new StateSensor7245(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7241 : TriggerState {
            internal StateSensor7241(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9240, arg2: 1, arg3: "Equal")) {
                    context.State = new StateActivate7241(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7241 : TriggerState {
            internal StateActivate7241(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9240, arg2: 1, arg3: "Equal")) {
                    context.State = new StateSensor7241(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7242 : TriggerState {
            internal StateSensor7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 1);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9240, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSafeGreen7242(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7242 : TriggerState {
            internal StateSafeGreen7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9240, arg2: 2, arg3: "Equal")) {
                    context.State = new StateEnable7242(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9240, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7242(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7242 : TriggerState {
            internal StateEnable7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9240}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000945}, arg2: 0)) {
                    context.State = new StateActivate7242(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9240, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7242(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7242 : TriggerState {
            internal StateActivate7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8240}, arg2: true);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9240, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7242(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7242(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7242 : TriggerState {
            internal StateDelay7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9240, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7242(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000961}, arg2: 0)) {
                    context.State = new StateDeActivate7242(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7242 : TriggerState {
            internal StateDeActivate7242(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7242(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7243 : TriggerState {
            internal StateSensor7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 1);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9240, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSafeGreen7243(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7243 : TriggerState {
            internal StateSafeGreen7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9240, arg2: 3, arg3: "Equal")) {
                    context.State = new StateEnable7243(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9240, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7243(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7243 : TriggerState {
            internal StateEnable7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9240}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000945}, arg2: 0)) {
                    context.State = new StateActivate7243(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9240, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7243(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7243 : TriggerState {
            internal StateActivate7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8240}, arg2: true);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9240, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7243(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7243(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7243 : TriggerState {
            internal StateDelay7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9240, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7243(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000961}, arg2: 0)) {
                    context.State = new StateDeActivate7243(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7243 : TriggerState {
            internal StateDeActivate7243(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7243(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7244 : TriggerState {
            internal StateSensor7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 1);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9240, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSafeGreen7244(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7244 : TriggerState {
            internal StateSafeGreen7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9240, arg2: 4, arg3: "Equal")) {
                    context.State = new StateEnable7244(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9240, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7244(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7244 : TriggerState {
            internal StateEnable7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9240}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000945}, arg2: 0)) {
                    context.State = new StateActivate7244(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9240, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7244(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7244 : TriggerState {
            internal StateActivate7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8240}, arg2: true);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9240, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7244(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7244(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7244 : TriggerState {
            internal StateDelay7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9240, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7244(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000961}, arg2: 0)) {
                    context.State = new StateDeActivate7244(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7244 : TriggerState {
            internal StateDeActivate7244(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7244(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7245 : TriggerState {
            internal StateSensor7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 1);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9240, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSafeGreen7245(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7245 : TriggerState {
            internal StateSafeGreen7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7240, key: "Color24", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9240, arg2: 5, arg3: "Equal")) {
                    context.State = new StateEnable7245(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9240, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7245(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7245 : TriggerState {
            internal StateEnable7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9240}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000945}, arg2: 0)) {
                    context.State = new StateActivate7245(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9240, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7245(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7245 : TriggerState {
            internal StateActivate7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8240}, arg2: true);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9240, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7245(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7245(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7245 : TriggerState {
            internal StateDelay7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9240, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7245(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000961}, arg2: 0)) {
                    context.State = new StateDeActivate7245(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7245 : TriggerState {
            internal StateDeActivate7245(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7245(context);
                    return;
                }

                if (context.UserValue(key: "Barrier24", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8241, 8242, 8243, 8244, 8245, 8246}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8240}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000945}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000961}, arg2: 0);
                context.SetUserValue(key: "Barrier24", value: 0);
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
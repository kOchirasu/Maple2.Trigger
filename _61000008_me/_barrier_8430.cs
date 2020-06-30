using System;

namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8430 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Barrier43", value: 1)) {
                    context.State = new StateSensor7431(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 2)) {
                    context.State = new StateSensor7432(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 3)) {
                    context.State = new StateSensor7433(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 4)) {
                    context.State = new StateSensor7434(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 5)) {
                    context.State = new StateSensor7435(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7431 : TriggerState {
            internal StateSensor7431(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9430, arg2: 1, arg3: "Equal")) {
                    context.State = new StateActivate7431(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7431 : TriggerState {
            internal StateActivate7431(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9430, arg2: 1, arg3: "Equal")) {
                    context.State = new StateSensor7431(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7432 : TriggerState {
            internal StateSensor7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 1);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9430, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSafeGreen7432(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7432 : TriggerState {
            internal StateSafeGreen7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9430, arg2: 2, arg3: "Equal")) {
                    context.State = new StateEnable7432(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9430, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7432(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7432 : TriggerState {
            internal StateEnable7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9430}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000952}, arg2: 0)) {
                    context.State = new StateActivate7432(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9430, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7432(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7432 : TriggerState {
            internal StateActivate7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8430}, arg2: true);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9430, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7432(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7432(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7432 : TriggerState {
            internal StateDelay7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9430, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7432(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000968}, arg2: 0)) {
                    context.State = new StateDeActivate7432(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7432 : TriggerState {
            internal StateDeActivate7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7432(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7433 : TriggerState {
            internal StateSensor7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 1);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9430, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSafeGreen7433(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7433 : TriggerState {
            internal StateSafeGreen7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9430, arg2: 3, arg3: "Equal")) {
                    context.State = new StateEnable7433(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9430, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7433(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7433 : TriggerState {
            internal StateEnable7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9430}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000952}, arg2: 0)) {
                    context.State = new StateActivate7433(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9430, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7433(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7433 : TriggerState {
            internal StateActivate7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8430}, arg2: true);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9430, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7433(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7433(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7433 : TriggerState {
            internal StateDelay7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9430, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7433(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000968}, arg2: 0)) {
                    context.State = new StateDeActivate7433(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7433 : TriggerState {
            internal StateDeActivate7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7433(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7434 : TriggerState {
            internal StateSensor7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 1);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9430, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSafeGreen7434(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7434 : TriggerState {
            internal StateSafeGreen7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9430, arg2: 4, arg3: "Equal")) {
                    context.State = new StateEnable7434(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9430, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7434(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7434 : TriggerState {
            internal StateEnable7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9430}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000952}, arg2: 0)) {
                    context.State = new StateActivate7434(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9430, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7434(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7434 : TriggerState {
            internal StateActivate7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8430}, arg2: true);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9430, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7434(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7434(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7434 : TriggerState {
            internal StateDelay7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9430, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7434(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000968}, arg2: 0)) {
                    context.State = new StateDeActivate7434(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7434 : TriggerState {
            internal StateDeActivate7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7434(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7435 : TriggerState {
            internal StateSensor7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 1);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9430, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSafeGreen7435(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7435 : TriggerState {
            internal StateSafeGreen7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7430, key: "Color43", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9430, arg2: 5, arg3: "Equal")) {
                    context.State = new StateEnable7435(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9430, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7435(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7435 : TriggerState {
            internal StateEnable7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9430}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000952}, arg2: 0)) {
                    context.State = new StateActivate7435(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9430, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7435(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7435 : TriggerState {
            internal StateActivate7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8430}, arg2: true);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9430, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7435(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7435(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7435 : TriggerState {
            internal StateDelay7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9430, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7435(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000968}, arg2: 0)) {
                    context.State = new StateDeActivate7435(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7435 : TriggerState {
            internal StateDeActivate7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7435(context);
                    return;
                }

                if (context.UserValue(key: "Barrier43", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000952}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000968}, arg2: 0);
                context.SetUserValue(key: "Barrier43", value: 0);
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
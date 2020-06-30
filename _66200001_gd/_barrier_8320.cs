using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8320 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Barrier32", value: 1)) {
                    context.State = new StateSensor7321(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 2)) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 3)) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 4)) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 5)) {
                    context.State = new StateSensor7325(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7321 : TriggerState {
            internal StateSensor7321(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9320, arg2: 1, arg3: "Equal")) {
                    context.State = new StateActivate7321(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7321 : TriggerState {
            internal StateActivate7321(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9320, arg2: 1, arg3: "Equal")) {
                    context.State = new StateSensor7321(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7322 : TriggerState {
            internal StateSensor7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9320, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSafeGreen7322(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7322 : TriggerState {
            internal StateSafeGreen7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9320, arg2: 2, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7322(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7322 : TriggerState {
            internal StateCheckSameUserTag7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9320)
                    && context.CountUsers(arg1: 9320, arg2: 2, arg3: "Equal")) {
                    context.State = new StateEnable7322(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9320)) {
                    context.State = new StateSafeGreen7322(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7322 : TriggerState {
            internal StateEnable7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001194}, arg2: 0)) {
                    context.State = new StateActivate7322(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7322 : TriggerState {
            internal StateActivate7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8320}, arg2: true);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9320, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7322(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7322 : TriggerState {
            internal StateDelay7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9320, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001210}, arg2: 0)) {
                    context.State = new StateDeActivate7322(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7322 : TriggerState {
            internal StateDeActivate7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7323 : TriggerState {
            internal StateSensor7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9320, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSafeGreen7323(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7323 : TriggerState {
            internal StateSafeGreen7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9320, arg2: 3, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7323(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7323 : TriggerState {
            internal StateCheckSameUserTag7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9320)
                    && context.CountUsers(arg1: 9320, arg2: 3, arg3: "Equal")) {
                    context.State = new StateEnable7323(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9320)) {
                    context.State = new StateSafeGreen7323(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7323 : TriggerState {
            internal StateEnable7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001194}, arg2: 0)) {
                    context.State = new StateActivate7323(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7323 : TriggerState {
            internal StateActivate7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8320}, arg2: true);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9320, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7323(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7323 : TriggerState {
            internal StateDelay7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9320, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001210}, arg2: 0)) {
                    context.State = new StateDeActivate7323(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7323 : TriggerState {
            internal StateDeActivate7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7324 : TriggerState {
            internal StateSensor7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9320, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSafeGreen7324(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7324 : TriggerState {
            internal StateSafeGreen7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9320, arg2: 4, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7324(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7324 : TriggerState {
            internal StateCheckSameUserTag7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9320)
                    && context.CountUsers(arg1: 9320, arg2: 4, arg3: "Equal")) {
                    context.State = new StateEnable7324(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9320)) {
                    context.State = new StateSafeGreen7324(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7324 : TriggerState {
            internal StateEnable7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001194}, arg2: 0)) {
                    context.State = new StateActivate7324(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7324 : TriggerState {
            internal StateActivate7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8320}, arg2: true);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9320, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7324(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7324 : TriggerState {
            internal StateDelay7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9320, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001210}, arg2: 0)) {
                    context.State = new StateDeActivate7324(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7324 : TriggerState {
            internal StateDeActivate7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7325 : TriggerState {
            internal StateSensor7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9320, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSafeGreen7325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7325 : TriggerState {
            internal StateSafeGreen7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9320, arg2: 5, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7325(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7325 : TriggerState {
            internal StateCheckSameUserTag7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9320)
                    && context.CountUsers(arg1: 9320, arg2: 5, arg3: "Equal")) {
                    context.State = new StateEnable7325(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9320)) {
                    context.State = new StateSafeGreen7325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7325 : TriggerState {
            internal StateEnable7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001194}, arg2: 0)) {
                    context.State = new StateActivate7325(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9320, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7325 : TriggerState {
            internal StateActivate7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8320}, arg2: true);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9320, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7325(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7325 : TriggerState {
            internal StateDelay7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9320, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001210}, arg2: 0)) {
                    context.State = new StateDeActivate7325(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7325 : TriggerState {
            internal StateDeActivate7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier32", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001194}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001210}, arg2: 0);
                context.SetUserValue(key: "Barrier32", value: 0);
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
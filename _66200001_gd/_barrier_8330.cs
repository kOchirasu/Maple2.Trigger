using System;

namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8330 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Barrier33", value: 1)) {
                    context.State = new StateSensor7331(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 2)) {
                    context.State = new StateSensor7332(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 3)) {
                    context.State = new StateSensor7333(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 4)) {
                    context.State = new StateSensor7334(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 5)) {
                    context.State = new StateSensor7335(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7331 : TriggerState {
            internal StateSensor7331(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 1, arg3: "Equal")) {
                    context.State = new StateActivate7331(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7331 : TriggerState {
            internal StateActivate7331(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 1, arg3: "Equal")) {
                    context.State = new StateSensor7331(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7332 : TriggerState {
            internal StateSensor7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 1);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSafeGreen7332(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7332 : TriggerState {
            internal StateSafeGreen7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 2, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7332(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7332(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7332 : TriggerState {
            internal StateCheckSameUserTag7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9330)
                    && context.CountUsers(arg1: 9330, arg2: 2, arg3: "Equal")) {
                    context.State = new StateEnable7332(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7332(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9330)) {
                    context.State = new StateSafeGreen7332(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7332 : TriggerState {
            internal StateEnable7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001195}, arg2: 0)) {
                    context.State = new StateActivate7332(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7332(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7332 : TriggerState {
            internal StateActivate7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7332(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7332(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7332 : TriggerState {
            internal StateDelay7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7332(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001211}, arg2: 0)) {
                    context.State = new StateDeActivate7332(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7332 : TriggerState {
            internal StateDeActivate7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7332(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7333 : TriggerState {
            internal StateSensor7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 1);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSafeGreen7333(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7333 : TriggerState {
            internal StateSafeGreen7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 3, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7333(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7333(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7333 : TriggerState {
            internal StateCheckSameUserTag7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9330)
                    && context.CountUsers(arg1: 9330, arg2: 3, arg3: "Equal")) {
                    context.State = new StateEnable7333(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7333(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9330)) {
                    context.State = new StateSafeGreen7333(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7333 : TriggerState {
            internal StateEnable7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001195}, arg2: 0)) {
                    context.State = new StateActivate7333(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7333(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7333 : TriggerState {
            internal StateActivate7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7333(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7333(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7333 : TriggerState {
            internal StateDelay7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7333(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001211}, arg2: 0)) {
                    context.State = new StateDeActivate7333(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7333 : TriggerState {
            internal StateDeActivate7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7333(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7334 : TriggerState {
            internal StateSensor7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 1);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSafeGreen7334(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7334 : TriggerState {
            internal StateSafeGreen7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 4, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7334(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7334(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7334 : TriggerState {
            internal StateCheckSameUserTag7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9330)
                    && context.CountUsers(arg1: 9330, arg2: 4, arg3: "Equal")) {
                    context.State = new StateEnable7334(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7334(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9330)) {
                    context.State = new StateSafeGreen7334(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7334 : TriggerState {
            internal StateEnable7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001195}, arg2: 0)) {
                    context.State = new StateActivate7334(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7334(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7334 : TriggerState {
            internal StateActivate7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7334(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7334(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7334 : TriggerState {
            internal StateDelay7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7334(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001211}, arg2: 0)) {
                    context.State = new StateDeActivate7334(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7334 : TriggerState {
            internal StateDeActivate7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7334(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7335 : TriggerState {
            internal StateSensor7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 1);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSafeGreen7335(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7335 : TriggerState {
            internal StateSafeGreen7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 5, arg3: "Equal")) {
                    context.State = new StateCheckSameUserTag7335(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7335(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7335 : TriggerState {
            internal StateCheckSameUserTag7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxID: 9330)
                    && context.CountUsers(arg1: 9330, arg2: 5, arg3: "Equal")) {
                    context.State = new StateEnable7335(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7335(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxID: 9330)) {
                    context.State = new StateSafeGreen7335(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7335 : TriggerState {
            internal StateEnable7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001195}, arg2: 0)) {
                    context.State = new StateActivate7335(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7335(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7335 : TriggerState {
            internal StateActivate7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7335(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7335(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7335 : TriggerState {
            internal StateDelay7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7335(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10001211}, arg2: 0)) {
                    context.State = new StateDeActivate7335(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7335 : TriggerState {
            internal StateDeActivate7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7335(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001195}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10001211}, arg2: 0);
                context.SetUserValue(key: "Barrier33", value: 0);
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
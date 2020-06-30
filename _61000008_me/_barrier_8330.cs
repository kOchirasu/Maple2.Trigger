using System;

namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8330 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 2);
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

                if (context.UserValue(key: "Barrier33", value: 7)) {
                    context.State = new StateSensor7337(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 8)) {
                    context.State = new StateSensor7338(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 9)) {
                    context.State = new StateSensor7339(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 6)) {
                    context.State = new StateSensor7336(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 15)) {
                    context.State = new StateSensor73315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 20)) {
                    context.State = new StateSensor73320(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 25)) {
                    context.State = new StateSensor73325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 30)) {
                    context.State = new StateSensor73330(context);
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
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
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
                    context.State = new StateEnable7332(context);
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

        private class StateEnable7332 : TriggerState {
            internal StateEnable7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
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
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
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

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
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
                    context.State = new StateEnable7333(context);
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

        private class StateEnable7333 : TriggerState {
            internal StateEnable7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
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
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
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

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
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
                    context.State = new StateEnable7334(context);
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

        private class StateEnable7334 : TriggerState {
            internal StateEnable7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
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
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
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

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
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
                    context.State = new StateEnable7335(context);
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

        private class StateEnable7335 : TriggerState {
            internal StateEnable7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
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
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
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

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
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

        private class StateSensor7337 : TriggerState {
            internal StateSensor7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 7, arg3: "Equal")) {
                    context.State = new StateSafeGreen7337(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7337 : TriggerState {
            internal StateSafeGreen7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 7, arg3: "Equal")) {
                    context.State = new StateEnable7337(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 7, arg3: "Equal")) {
                    context.State = new StateSensor7337(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7337 : TriggerState {
            internal StateEnable7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
                    context.State = new StateActivate7337(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 7, arg3: "Equal")) {
                    context.State = new StateSensor7337(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7337 : TriggerState {
            internal StateActivate7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 7, arg3: "Equal")) {
                    context.State = new StateSensor7337(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7337(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7337 : TriggerState {
            internal StateDelay7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 7, arg3: "Equal")) {
                    context.State = new StateSensor7337(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
                    context.State = new StateDeActivate7337(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7337 : TriggerState {
            internal StateDeActivate7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7337(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7338 : TriggerState {
            internal StateSensor7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 8, arg3: "Equal")) {
                    context.State = new StateSafeGreen7338(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7338 : TriggerState {
            internal StateSafeGreen7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 8, arg3: "Equal")) {
                    context.State = new StateEnable7338(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 8, arg3: "Equal")) {
                    context.State = new StateSensor7338(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7338 : TriggerState {
            internal StateEnable7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
                    context.State = new StateActivate7338(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 8, arg3: "Equal")) {
                    context.State = new StateSensor7338(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7338 : TriggerState {
            internal StateActivate7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 8, arg3: "Equal")) {
                    context.State = new StateSensor7338(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7338(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7338 : TriggerState {
            internal StateDelay7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 8, arg3: "Equal")) {
                    context.State = new StateSensor7338(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
                    context.State = new StateDeActivate7338(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7338 : TriggerState {
            internal StateDeActivate7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7338(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7339 : TriggerState {
            internal StateSensor7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 9, arg3: "Equal")) {
                    context.State = new StateSafeGreen7339(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7339 : TriggerState {
            internal StateSafeGreen7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 9, arg3: "Equal")) {
                    context.State = new StateEnable7339(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 9, arg3: "Equal")) {
                    context.State = new StateSensor7339(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7339 : TriggerState {
            internal StateEnable7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
                    context.State = new StateActivate7339(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 9, arg3: "Equal")) {
                    context.State = new StateSensor7339(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7339 : TriggerState {
            internal StateActivate7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 9, arg3: "Equal")) {
                    context.State = new StateSensor7339(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7339(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7339 : TriggerState {
            internal StateDelay7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 9, arg3: "Equal")) {
                    context.State = new StateSensor7339(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
                    context.State = new StateDeActivate7339(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7339 : TriggerState {
            internal StateDeActivate7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7339(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7336 : TriggerState {
            internal StateSensor7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 10, arg3: "Equal")) {
                    context.State = new StateSafeGreen7336(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7336 : TriggerState {
            internal StateSafeGreen7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 10, arg3: "Equal")) {
                    context.State = new StateEnable7336(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 10, arg3: "Equal")) {
                    context.State = new StateSensor7336(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7336 : TriggerState {
            internal StateEnable7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
                    context.State = new StateActivate7336(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 10, arg3: "Equal")) {
                    context.State = new StateSensor7336(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7336 : TriggerState {
            internal StateActivate7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 10, arg3: "Equal")) {
                    context.State = new StateSensor7336(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7336(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7336 : TriggerState {
            internal StateDelay7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 10, arg3: "Equal")) {
                    context.State = new StateSensor7336(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
                    context.State = new StateDeActivate7336(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7336 : TriggerState {
            internal StateDeActivate7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7336(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor73315 : TriggerState {
            internal StateSensor73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 15, arg3: "Equal")) {
                    context.State = new StateSafeGreen73315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73315 : TriggerState {
            internal StateSafeGreen73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 15, arg3: "Equal")) {
                    context.State = new StateEnable73315(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 15, arg3: "Equal")) {
                    context.State = new StateSensor73315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable73315 : TriggerState {
            internal StateEnable73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
                    context.State = new StateActivate73315(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 15, arg3: "Equal")) {
                    context.State = new StateSensor73315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate73315 : TriggerState {
            internal StateActivate73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 15, arg3: "Equal")) {
                    context.State = new StateSensor73315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay73315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay73315 : TriggerState {
            internal StateDelay73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 15, arg3: "Equal")) {
                    context.State = new StateSensor73315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
                    context.State = new StateDeActivate73315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73315 : TriggerState {
            internal StateDeActivate73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor73315(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor73320 : TriggerState {
            internal StateSensor73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 20, arg3: "Equal")) {
                    context.State = new StateSafeGreen73320(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73320 : TriggerState {
            internal StateSafeGreen73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 20, arg3: "Equal")) {
                    context.State = new StateEnable73320(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 20, arg3: "Equal")) {
                    context.State = new StateSensor73320(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable73320 : TriggerState {
            internal StateEnable73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
                    context.State = new StateActivate73320(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 20, arg3: "Equal")) {
                    context.State = new StateSensor73320(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate73320 : TriggerState {
            internal StateActivate73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 20, arg3: "Equal")) {
                    context.State = new StateSensor73320(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay73320(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay73320 : TriggerState {
            internal StateDelay73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 20, arg3: "Equal")) {
                    context.State = new StateSensor73320(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
                    context.State = new StateDeActivate73320(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73320 : TriggerState {
            internal StateDeActivate73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor73320(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor73325 : TriggerState {
            internal StateSensor73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 25, arg3: "Equal")) {
                    context.State = new StateSafeGreen73325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73325 : TriggerState {
            internal StateSafeGreen73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 25, arg3: "Equal")) {
                    context.State = new StateEnable73325(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 25, arg3: "Equal")) {
                    context.State = new StateSensor73325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable73325 : TriggerState {
            internal StateEnable73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
                    context.State = new StateActivate73325(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 25, arg3: "Equal")) {
                    context.State = new StateSensor73325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate73325 : TriggerState {
            internal StateActivate73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 25, arg3: "Equal")) {
                    context.State = new StateSensor73325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay73325(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay73325 : TriggerState {
            internal StateDelay73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 25, arg3: "Equal")) {
                    context.State = new StateSensor73325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
                    context.State = new StateDeActivate73325(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73325 : TriggerState {
            internal StateDeActivate73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor73325(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor73330 : TriggerState {
            internal StateSensor73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 30, arg3: "Equal")) {
                    context.State = new StateSafeGreen73330(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73330 : TriggerState {
            internal StateSafeGreen73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7330, key: "Color33", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9330, arg2: 30, arg3: "Equal")) {
                    context.State = new StateEnable73330(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 30, arg3: "Equal")) {
                    context.State = new StateSensor73330(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable73330 : TriggerState {
            internal StateEnable73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000948}, arg2: 0)) {
                    context.State = new StateActivate73330(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9330, arg2: 30, arg3: "Equal")) {
                    context.State = new StateSensor73330(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate73330 : TriggerState {
            internal StateActivate73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: true);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 30, arg3: "Equal")) {
                    context.State = new StateSensor73330(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay73330(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay73330 : TriggerState {
            internal StateDelay73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9330, arg2: 30, arg3: "Equal")) {
                    context.State = new StateSensor73330(context);
                    return;
                }

                if (context.UserValue(key: "Barrier33", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000964}, arg2: 0)) {
                    context.State = new StateDeActivate73330(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73330 : TriggerState {
            internal StateDeActivate73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8330}, arg2: false);
                context.SetMesh(arg1: new int[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor73330(context);
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
                context.SetInteractObject(arg1: new int[] {10000948}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000964}, arg2: 0);
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
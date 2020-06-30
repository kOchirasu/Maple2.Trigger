using System;

namespace Maple2.Trigger._84000007_wd {
    public static class _barrier_8340 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Barrier34", value: 1)) {
                    context.State = new StateSensor7341(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 2)) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 3)) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 4)) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 5)) {
                    context.State = new StateSensor7345(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7341 : TriggerState {
            internal StateSensor7341(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 1);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9340, arg2: 1, arg3: "Equal")) {
                    context.State = new StateActivate7341(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7341 : TriggerState {
            internal StateActivate7341(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9340, arg2: 1, arg3: "Equal")) {
                    context.State = new StateSensor7341(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7342 : TriggerState {
            internal StateSensor7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 1);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9340, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSafeGreen7342(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7342 : TriggerState {
            internal StateSafeGreen7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9340, arg2: 2, arg3: "Equal")) {
                    context.State = new StateEnable7342(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9340, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7342 : TriggerState {
            internal StateEnable7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9340}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000949}, arg2: 0)) {
                    context.State = new StateActivate7342(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9340, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7342 : TriggerState {
            internal StateActivate7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8340}, arg2: true);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9340, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7342(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7342 : TriggerState {
            internal StateDelay7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9340, arg2: 2, arg3: "Equal")) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000965}, arg2: 0)) {
                    context.State = new StateDeActivate7342(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7342 : TriggerState {
            internal StateDeActivate7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7343 : TriggerState {
            internal StateSensor7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 1);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9340, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSafeGreen7343(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7343 : TriggerState {
            internal StateSafeGreen7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9340, arg2: 3, arg3: "Equal")) {
                    context.State = new StateEnable7343(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9340, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7343 : TriggerState {
            internal StateEnable7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9340}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000949}, arg2: 0)) {
                    context.State = new StateActivate7343(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9340, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7343 : TriggerState {
            internal StateActivate7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8340}, arg2: true);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9340, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7343(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7343 : TriggerState {
            internal StateDelay7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9340, arg2: 3, arg3: "Equal")) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000965}, arg2: 0)) {
                    context.State = new StateDeActivate7343(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7343 : TriggerState {
            internal StateDeActivate7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7344 : TriggerState {
            internal StateSensor7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 1);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9340, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSafeGreen7344(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7344 : TriggerState {
            internal StateSafeGreen7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9340, arg2: 4, arg3: "Equal")) {
                    context.State = new StateEnable7344(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9340, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7344 : TriggerState {
            internal StateEnable7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9340}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000949}, arg2: 0)) {
                    context.State = new StateActivate7344(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9340, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7344 : TriggerState {
            internal StateActivate7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8340}, arg2: true);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9340, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7344(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7344 : TriggerState {
            internal StateDelay7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9340, arg2: 4, arg3: "Equal")) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000965}, arg2: 0)) {
                    context.State = new StateDeActivate7344(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7344 : TriggerState {
            internal StateDeActivate7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7345 : TriggerState {
            internal StateSensor7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 1);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 0);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9340, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSafeGreen7345(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7345 : TriggerState {
            internal StateSafeGreen7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9340, arg2: 5, arg3: "Equal")) {
                    context.State = new StateEnable7345(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9340, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7345 : TriggerState {
            internal StateEnable7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9340}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000949}, arg2: 0)) {
                    context.State = new StateActivate7345(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9340, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7345 : TriggerState {
            internal StateActivate7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8340}, arg2: true);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 2);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9340, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7345(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7345 : TriggerState {
            internal StateDelay7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 1);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9340, arg2: 5, arg3: "Equal")) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000965}, arg2: 0)) {
                    context.State = new StateDeActivate7345(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7345 : TriggerState {
            internal StateDeActivate7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.UserValue(key: "Barrier34", value: 10)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetEffect(arg1: new int[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000949}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000965}, arg2: 0);
                context.SetUserValue(key: "Barrier34", value: 0);
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
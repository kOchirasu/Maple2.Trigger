namespace Maple2.Trigger._84000007_wd {
    public static class _barrier_8320 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Barrier32") == 1) {
                    context.State = new StateSensor7321(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 2) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 3) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 4) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 5) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 7) {
                    context.State = new StateSensor7327(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 8) {
                    context.State = new StateSensor7328(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 9) {
                    context.State = new StateSensor7329(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 6) {
                    context.State = new StateSensor7326(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 15) {
                    context.State = new StateSensor73215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 20) {
                    context.State = new StateSensor73220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 25) {
                    context.State = new StateSensor73225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 30) {
                    context.State = new StateSensor73230(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7321 : TriggerState {
            internal StateSensor7321(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 1) {
                    context.State = new StateActivate7321(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7321 : TriggerState {
            internal StateActivate7321(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 1) {
                    context.State = new StateSensor7321(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7322 : TriggerState {
            internal StateSensor7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 2) {
                    context.State = new StateSafeGreen7322(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7322 : TriggerState {
            internal StateSafeGreen7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 2) {
                    context.State = new StateEnable7322(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 2) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7322 : TriggerState {
            internal StateEnable7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate7322(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 2) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7322 : TriggerState {
            internal StateActivate7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 2) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
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
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 2) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate7322(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7322 : TriggerState {
            internal StateDeActivate7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7322(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7323 : TriggerState {
            internal StateSensor7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 3) {
                    context.State = new StateSafeGreen7323(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7323 : TriggerState {
            internal StateSafeGreen7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 3) {
                    context.State = new StateEnable7323(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 3) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7323 : TriggerState {
            internal StateEnable7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate7323(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 3) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7323 : TriggerState {
            internal StateActivate7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 3) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
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
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 3) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate7323(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7323 : TriggerState {
            internal StateDeActivate7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7323(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7324 : TriggerState {
            internal StateSensor7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 4) {
                    context.State = new StateSafeGreen7324(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7324 : TriggerState {
            internal StateSafeGreen7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 4) {
                    context.State = new StateEnable7324(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 4) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7324 : TriggerState {
            internal StateEnable7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate7324(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 4) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7324 : TriggerState {
            internal StateActivate7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 4) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
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
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 4) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate7324(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7324 : TriggerState {
            internal StateDeActivate7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7324(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7325 : TriggerState {
            internal StateSensor7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 5) {
                    context.State = new StateSafeGreen7325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7325 : TriggerState {
            internal StateSafeGreen7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 5) {
                    context.State = new StateEnable7325(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 5) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7325 : TriggerState {
            internal StateEnable7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate7325(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 5) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7325 : TriggerState {
            internal StateActivate7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 5) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
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
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 5) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate7325(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7325 : TriggerState {
            internal StateDeActivate7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7325(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7327 : TriggerState {
            internal StateSensor7327(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 3);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 7) {
                    context.State = new StateSafeGreen7327(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7327 : TriggerState {
            internal StateSafeGreen7327(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 7) {
                    context.State = new StateEnable7327(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 7) {
                    context.State = new StateSensor7327(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7327 : TriggerState {
            internal StateEnable7327(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate7327(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 7) {
                    context.State = new StateSensor7327(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7327 : TriggerState {
            internal StateActivate7327(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 7) {
                    context.State = new StateSensor7327(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7327(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7327 : TriggerState {
            internal StateDelay7327(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 7) {
                    context.State = new StateSensor7327(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate7327(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7327 : TriggerState {
            internal StateDeActivate7327(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7327(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7328 : TriggerState {
            internal StateSensor7328(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 3);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 8) {
                    context.State = new StateSafeGreen7328(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7328 : TriggerState {
            internal StateSafeGreen7328(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 8) {
                    context.State = new StateEnable7328(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 8) {
                    context.State = new StateSensor7328(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7328 : TriggerState {
            internal StateEnable7328(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate7328(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 8) {
                    context.State = new StateSensor7328(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7328 : TriggerState {
            internal StateActivate7328(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 8) {
                    context.State = new StateSensor7328(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7328(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7328 : TriggerState {
            internal StateDelay7328(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 8) {
                    context.State = new StateSensor7328(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate7328(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7328 : TriggerState {
            internal StateDeActivate7328(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7328(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7329 : TriggerState {
            internal StateSensor7329(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 3);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 9) {
                    context.State = new StateSafeGreen7329(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7329 : TriggerState {
            internal StateSafeGreen7329(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 9) {
                    context.State = new StateEnable7329(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 9) {
                    context.State = new StateSensor7329(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7329 : TriggerState {
            internal StateEnable7329(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate7329(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 9) {
                    context.State = new StateSensor7329(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7329 : TriggerState {
            internal StateActivate7329(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 9) {
                    context.State = new StateSensor7329(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7329(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7329 : TriggerState {
            internal StateDelay7329(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 9) {
                    context.State = new StateSensor7329(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate7329(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7329 : TriggerState {
            internal StateDeActivate7329(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7329(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7326 : TriggerState {
            internal StateSensor7326(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 3);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 10) {
                    context.State = new StateSafeGreen7326(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7326 : TriggerState {
            internal StateSafeGreen7326(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 10) {
                    context.State = new StateEnable7326(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 10) {
                    context.State = new StateSensor7326(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7326 : TriggerState {
            internal StateEnable7326(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate7326(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 10) {
                    context.State = new StateSensor7326(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7326 : TriggerState {
            internal StateActivate7326(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 10) {
                    context.State = new StateSensor7326(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7326(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7326 : TriggerState {
            internal StateDelay7326(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 10) {
                    context.State = new StateSensor7326(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate7326(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7326 : TriggerState {
            internal StateDeActivate7326(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7326(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor73215 : TriggerState {
            internal StateSensor73215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 3);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 15) {
                    context.State = new StateSafeGreen73215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73215 : TriggerState {
            internal StateSafeGreen73215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 15) {
                    context.State = new StateEnable73215(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 15) {
                    context.State = new StateSensor73215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable73215 : TriggerState {
            internal StateEnable73215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate73215(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 15) {
                    context.State = new StateSensor73215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate73215 : TriggerState {
            internal StateActivate73215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 15) {
                    context.State = new StateSensor73215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay73215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay73215 : TriggerState {
            internal StateDelay73215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 15) {
                    context.State = new StateSensor73215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate73215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73215 : TriggerState {
            internal StateDeActivate73215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor73215(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor73220 : TriggerState {
            internal StateSensor73220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 3);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 20) {
                    context.State = new StateSafeGreen73220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73220 : TriggerState {
            internal StateSafeGreen73220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 20) {
                    context.State = new StateEnable73220(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 20) {
                    context.State = new StateSensor73220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable73220 : TriggerState {
            internal StateEnable73220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate73220(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 20) {
                    context.State = new StateSensor73220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate73220 : TriggerState {
            internal StateActivate73220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 20) {
                    context.State = new StateSensor73220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay73220(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay73220 : TriggerState {
            internal StateDelay73220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 20) {
                    context.State = new StateSensor73220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate73220(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73220 : TriggerState {
            internal StateDeActivate73220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor73220(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor73225 : TriggerState {
            internal StateSensor73225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 3);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 25) {
                    context.State = new StateSafeGreen73225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73225 : TriggerState {
            internal StateSafeGreen73225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 25) {
                    context.State = new StateEnable73225(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 25) {
                    context.State = new StateSensor73225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable73225 : TriggerState {
            internal StateEnable73225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate73225(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 25) {
                    context.State = new StateSensor73225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate73225 : TriggerState {
            internal StateActivate73225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 25) {
                    context.State = new StateSensor73225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay73225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay73225 : TriggerState {
            internal StateDelay73225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 25) {
                    context.State = new StateSensor73225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate73225(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73225 : TriggerState {
            internal StateDeActivate73225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor73225(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor73230 : TriggerState {
            internal StateSensor73230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 3);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 30) {
                    context.State = new StateSafeGreen73230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73230 : TriggerState {
            internal StateSafeGreen73230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 30) {
                    context.State = new StateEnable73230(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 30) {
                    context.State = new StateSensor73230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable73230 : TriggerState {
            internal StateEnable73230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000947}, arg2: 0)) {
                    context.State = new StateActivate73230(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 30) {
                    context.State = new StateSensor73230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate73230 : TriggerState {
            internal StateActivate73230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000947}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 30) {
                    context.State = new StateSensor73230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay73230(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay73230 : TriggerState {
            internal StateDelay73230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000963}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) != 30) {
                    context.State = new StateSensor73230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000963}, arg2: 0)) {
                    context.State = new StateDeActivate73230(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73230 : TriggerState {
            internal StateDeActivate73230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor73230(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000947, 10000963}, arg2: 0);
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
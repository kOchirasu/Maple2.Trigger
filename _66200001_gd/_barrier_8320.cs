namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8320 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001194, 10001210}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Barrier32") == 1) {
                    return new StateSensor7321(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 2) {
                    return new StateSensor7322(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 3) {
                    return new StateSensor7323(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 4) {
                    return new StateSensor7324(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 5) {
                    return new StateSensor7325(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7321 : TriggerState {
            internal StateSensor7321(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) == 1) {
                    return new StateActivate7321(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7321 : TriggerState {
            internal StateActivate7321(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) != 1) {
                    return new StateSensor7321(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7322 : TriggerState {
            internal StateSensor7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001194, 10001210}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) == 2) {
                    return new StateSafeGreen7322(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7322 : TriggerState {
            internal StateSafeGreen7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) == 2) {
                    return new StateCheckSameUserTag7322(context);
                }

                if (context.GetUserCount(boxId: 9320) != 2) {
                    return new StateSensor7322(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7322 : TriggerState {
            internal StateCheckSameUserTag7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9320) && context.GetUserCount(boxId: 9320) == 2) {
                    return new StateEnable7322(context);
                }

                if (context.GetUserCount(boxId: 9320) != 2) {
                    return new StateSensor7322(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9320)) {
                    return new StateSafeGreen7322(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7322 : TriggerState {
            internal StateEnable7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001194}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001194}, arg2: 0)) {
                    return new StateActivate7322(context);
                }

                if (context.GetUserCount(boxId: 9320) != 2) {
                    return new StateSensor7322(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7322 : TriggerState {
            internal StateActivate7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001194}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) != 2) {
                    return new StateSensor7322(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7322(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7322 : TriggerState {
            internal StateDelay7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001210}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) != 2) {
                    return new StateSensor7322(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001210}, arg2: 0)) {
                    return new StateDeActivate7322(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7322 : TriggerState {
            internal StateDeActivate7322(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7322(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7323 : TriggerState {
            internal StateSensor7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001194, 10001210}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) == 3) {
                    return new StateSafeGreen7323(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7323 : TriggerState {
            internal StateSafeGreen7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) == 3) {
                    return new StateCheckSameUserTag7323(context);
                }

                if (context.GetUserCount(boxId: 9320) != 3) {
                    return new StateSensor7323(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7323 : TriggerState {
            internal StateCheckSameUserTag7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9320) && context.GetUserCount(boxId: 9320) == 3) {
                    return new StateEnable7323(context);
                }

                if (context.GetUserCount(boxId: 9320) != 3) {
                    return new StateSensor7323(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9320)) {
                    return new StateSafeGreen7323(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7323 : TriggerState {
            internal StateEnable7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001194}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001194}, arg2: 0)) {
                    return new StateActivate7323(context);
                }

                if (context.GetUserCount(boxId: 9320) != 3) {
                    return new StateSensor7323(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7323 : TriggerState {
            internal StateActivate7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001194}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) != 3) {
                    return new StateSensor7323(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7323(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7323 : TriggerState {
            internal StateDelay7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001210}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) != 3) {
                    return new StateSensor7323(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001210}, arg2: 0)) {
                    return new StateDeActivate7323(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7323 : TriggerState {
            internal StateDeActivate7323(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7323(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7324 : TriggerState {
            internal StateSensor7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001194, 10001210}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) == 4) {
                    return new StateSafeGreen7324(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7324 : TriggerState {
            internal StateSafeGreen7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) == 4) {
                    return new StateCheckSameUserTag7324(context);
                }

                if (context.GetUserCount(boxId: 9320) != 4) {
                    return new StateSensor7324(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7324 : TriggerState {
            internal StateCheckSameUserTag7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9320) && context.GetUserCount(boxId: 9320) == 4) {
                    return new StateEnable7324(context);
                }

                if (context.GetUserCount(boxId: 9320) != 4) {
                    return new StateSensor7324(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9320)) {
                    return new StateSafeGreen7324(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7324 : TriggerState {
            internal StateEnable7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001194}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001194}, arg2: 0)) {
                    return new StateActivate7324(context);
                }

                if (context.GetUserCount(boxId: 9320) != 4) {
                    return new StateSensor7324(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7324 : TriggerState {
            internal StateActivate7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001194}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) != 4) {
                    return new StateSensor7324(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7324(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7324 : TriggerState {
            internal StateDelay7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001210}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) != 4) {
                    return new StateSensor7324(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001210}, arg2: 0)) {
                    return new StateDeActivate7324(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7324 : TriggerState {
            internal StateDeActivate7324(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7324(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7325 : TriggerState {
            internal StateSensor7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 1);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001194, 10001210}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) == 5) {
                    return new StateSafeGreen7325(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7325 : TriggerState {
            internal StateSafeGreen7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7320, key: "Color32", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) == 5) {
                    return new StateCheckSameUserTag7325(context);
                }

                if (context.GetUserCount(boxId: 9320) != 5) {
                    return new StateSensor7325(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7325 : TriggerState {
            internal StateCheckSameUserTag7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9320) && context.GetUserCount(boxId: 9320) == 5) {
                    return new StateEnable7325(context);
                }

                if (context.GetUserCount(boxId: 9320) != 5) {
                    return new StateSensor7325(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9320)) {
                    return new StateSafeGreen7325(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7325 : TriggerState {
            internal StateEnable7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001194}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001194}, arg2: 0)) {
                    return new StateActivate7325(context);
                }

                if (context.GetUserCount(boxId: 9320) != 5) {
                    return new StateSensor7325(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7325 : TriggerState {
            internal StateActivate7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: true);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001194}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) != 5) {
                    return new StateSensor7325(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7325(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7325 : TriggerState {
            internal StateDelay7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001210}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9320) != 5) {
                    return new StateSensor7325(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001210}, arg2: 0)) {
                    return new StateDeActivate7325(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7325 : TriggerState {
            internal StateDeActivate7325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7325(context);
                }

                if (context.GetUserValue(key: "Barrier32") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8321, 8322, 8323, 8324, 8325, 8326, 8327, 8328}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8320}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001194, 10001210}, arg2: 0);
                context.SetUserValue(key: "Barrier32", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
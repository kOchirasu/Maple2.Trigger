namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8330 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001195, 10001211}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Barrier33") == 1) {
                    return new StateSensor7331(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 2) {
                    return new StateSensor7332(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 3) {
                    return new StateSensor7333(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 4) {
                    return new StateSensor7334(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 5) {
                    return new StateSensor7335(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7331 : TriggerState {
            internal StateSensor7331(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 1) {
                    return new StateActivate7331(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7331 : TriggerState {
            internal StateActivate7331(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 1) {
                    return new StateSensor7331(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7332 : TriggerState {
            internal StateSensor7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 1);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001195, 10001211}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 2) {
                    return new StateSafeGreen7332(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7332 : TriggerState {
            internal StateSafeGreen7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 2) {
                    return new StateCheckSameUserTag7332(context);
                }

                if (context.GetUserCount(boxId: 9330) != 2) {
                    return new StateSensor7332(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7332 : TriggerState {
            internal StateCheckSameUserTag7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9330) && context.GetUserCount(boxId: 9330) == 2) {
                    return new StateEnable7332(context);
                }

                if (context.GetUserCount(boxId: 9330) != 2) {
                    return new StateSensor7332(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9330)) {
                    return new StateSafeGreen7332(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7332 : TriggerState {
            internal StateEnable7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001195}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001195}, arg2: 0)) {
                    return new StateActivate7332(context);
                }

                if (context.GetUserCount(boxId: 9330) != 2) {
                    return new StateSensor7332(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7332 : TriggerState {
            internal StateActivate7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001195}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 2) {
                    return new StateSensor7332(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7332(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7332 : TriggerState {
            internal StateDelay7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001211}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 2) {
                    return new StateSensor7332(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001211}, arg2: 0)) {
                    return new StateDeActivate7332(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7332 : TriggerState {
            internal StateDeActivate7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7332(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7333 : TriggerState {
            internal StateSensor7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 1);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001195, 10001211}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 3) {
                    return new StateSafeGreen7333(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7333 : TriggerState {
            internal StateSafeGreen7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 3) {
                    return new StateCheckSameUserTag7333(context);
                }

                if (context.GetUserCount(boxId: 9330) != 3) {
                    return new StateSensor7333(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7333 : TriggerState {
            internal StateCheckSameUserTag7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9330) && context.GetUserCount(boxId: 9330) == 3) {
                    return new StateEnable7333(context);
                }

                if (context.GetUserCount(boxId: 9330) != 3) {
                    return new StateSensor7333(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9330)) {
                    return new StateSafeGreen7333(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7333 : TriggerState {
            internal StateEnable7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001195}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001195}, arg2: 0)) {
                    return new StateActivate7333(context);
                }

                if (context.GetUserCount(boxId: 9330) != 3) {
                    return new StateSensor7333(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7333 : TriggerState {
            internal StateActivate7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001195}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 3) {
                    return new StateSensor7333(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7333(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7333 : TriggerState {
            internal StateDelay7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001211}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 3) {
                    return new StateSensor7333(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001211}, arg2: 0)) {
                    return new StateDeActivate7333(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7333 : TriggerState {
            internal StateDeActivate7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7333(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7334 : TriggerState {
            internal StateSensor7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 1);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001195, 10001211}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 4) {
                    return new StateSafeGreen7334(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7334 : TriggerState {
            internal StateSafeGreen7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 4) {
                    return new StateCheckSameUserTag7334(context);
                }

                if (context.GetUserCount(boxId: 9330) != 4) {
                    return new StateSensor7334(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7334 : TriggerState {
            internal StateCheckSameUserTag7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9330) && context.GetUserCount(boxId: 9330) == 4) {
                    return new StateEnable7334(context);
                }

                if (context.GetUserCount(boxId: 9330) != 4) {
                    return new StateSensor7334(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9330)) {
                    return new StateSafeGreen7334(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7334 : TriggerState {
            internal StateEnable7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001195}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001195}, arg2: 0)) {
                    return new StateActivate7334(context);
                }

                if (context.GetUserCount(boxId: 9330) != 4) {
                    return new StateSensor7334(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7334 : TriggerState {
            internal StateActivate7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001195}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 4) {
                    return new StateSensor7334(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7334(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7334 : TriggerState {
            internal StateDelay7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001211}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 4) {
                    return new StateSensor7334(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001211}, arg2: 0)) {
                    return new StateDeActivate7334(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7334 : TriggerState {
            internal StateDeActivate7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7334(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7335 : TriggerState {
            internal StateSensor7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 1);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001195, 10001211}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 5) {
                    return new StateSafeGreen7335(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7335 : TriggerState {
            internal StateSafeGreen7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 5) {
                    return new StateCheckSameUserTag7335(context);
                }

                if (context.GetUserCount(boxId: 9330) != 5) {
                    return new StateSensor7335(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7335 : TriggerState {
            internal StateCheckSameUserTag7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9330) && context.GetUserCount(boxId: 9330) == 5) {
                    return new StateEnable7335(context);
                }

                if (context.GetUserCount(boxId: 9330) != 5) {
                    return new StateSensor7335(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9330)) {
                    return new StateSafeGreen7335(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7335 : TriggerState {
            internal StateEnable7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001195}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001195}, arg2: 0)) {
                    return new StateActivate7335(context);
                }

                if (context.GetUserCount(boxId: 9330) != 5) {
                    return new StateSensor7335(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7335 : TriggerState {
            internal StateActivate7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001195}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 5) {
                    return new StateSensor7335(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7335(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7335 : TriggerState {
            internal StateDelay7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001211}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 5) {
                    return new StateSensor7335(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001211}, arg2: 0)) {
                    return new StateDeActivate7335(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7335 : TriggerState {
            internal StateDeActivate7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7335(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001195, 10001211}, arg2: 0);
                context.SetUserValue(key: "Barrier33", value: 0);
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
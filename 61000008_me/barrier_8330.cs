namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8330 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 2);
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

                if (context.GetUserValue(key: "Barrier33") == 7) {
                    return new StateSensor7337(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 8) {
                    return new StateSensor7338(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 9) {
                    return new StateSensor7339(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 6) {
                    return new StateSensor7336(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 15) {
                    return new StateSensor73315(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 20) {
                    return new StateSensor73320(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 25) {
                    return new StateSensor73325(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 30) {
                    return new StateSensor73330(context);
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
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
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
                    return new StateEnable7332(context);
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

        private class StateEnable7332 : TriggerState {
            internal StateEnable7332(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
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
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 2) {
                    return new StateSensor7332(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
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
                    return new StateEnable7333(context);
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

        private class StateEnable7333 : TriggerState {
            internal StateEnable7333(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
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
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 3) {
                    return new StateSensor7333(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
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
                    return new StateEnable7334(context);
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

        private class StateEnable7334 : TriggerState {
            internal StateEnable7334(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
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
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 4) {
                    return new StateSensor7334(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
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
                    return new StateEnable7335(context);
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

        private class StateEnable7335 : TriggerState {
            internal StateEnable7335(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
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
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
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
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 5) {
                    return new StateSensor7335(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
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

        private class StateSensor7337 : TriggerState {
            internal StateSensor7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 7) {
                    return new StateSafeGreen7337(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7337 : TriggerState {
            internal StateSafeGreen7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 7) {
                    return new StateEnable7337(context);
                }

                if (context.GetUserCount(boxId: 9330) != 7) {
                    return new StateSensor7337(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7337 : TriggerState {
            internal StateEnable7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
                    return new StateActivate7337(context);
                }

                if (context.GetUserCount(boxId: 9330) != 7) {
                    return new StateSensor7337(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7337 : TriggerState {
            internal StateActivate7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 7) {
                    return new StateSensor7337(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7337(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7337 : TriggerState {
            internal StateDelay7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 7) {
                    return new StateSensor7337(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
                    return new StateDeActivate7337(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7337 : TriggerState {
            internal StateDeActivate7337(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7337(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7338 : TriggerState {
            internal StateSensor7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 8) {
                    return new StateSafeGreen7338(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7338 : TriggerState {
            internal StateSafeGreen7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 8) {
                    return new StateEnable7338(context);
                }

                if (context.GetUserCount(boxId: 9330) != 8) {
                    return new StateSensor7338(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7338 : TriggerState {
            internal StateEnable7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
                    return new StateActivate7338(context);
                }

                if (context.GetUserCount(boxId: 9330) != 8) {
                    return new StateSensor7338(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7338 : TriggerState {
            internal StateActivate7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 8) {
                    return new StateSensor7338(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7338(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7338 : TriggerState {
            internal StateDelay7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 8) {
                    return new StateSensor7338(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
                    return new StateDeActivate7338(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7338 : TriggerState {
            internal StateDeActivate7338(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7338(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7339 : TriggerState {
            internal StateSensor7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 9) {
                    return new StateSafeGreen7339(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7339 : TriggerState {
            internal StateSafeGreen7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 9) {
                    return new StateEnable7339(context);
                }

                if (context.GetUserCount(boxId: 9330) != 9) {
                    return new StateSensor7339(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7339 : TriggerState {
            internal StateEnable7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
                    return new StateActivate7339(context);
                }

                if (context.GetUserCount(boxId: 9330) != 9) {
                    return new StateSensor7339(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7339 : TriggerState {
            internal StateActivate7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 9) {
                    return new StateSensor7339(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7339(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7339 : TriggerState {
            internal StateDelay7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 9) {
                    return new StateSensor7339(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
                    return new StateDeActivate7339(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7339 : TriggerState {
            internal StateDeActivate7339(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7339(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7336 : TriggerState {
            internal StateSensor7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 10) {
                    return new StateSafeGreen7336(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7336 : TriggerState {
            internal StateSafeGreen7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 10) {
                    return new StateEnable7336(context);
                }

                if (context.GetUserCount(boxId: 9330) != 10) {
                    return new StateSensor7336(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7336 : TriggerState {
            internal StateEnable7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
                    return new StateActivate7336(context);
                }

                if (context.GetUserCount(boxId: 9330) != 10) {
                    return new StateSensor7336(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7336 : TriggerState {
            internal StateActivate7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 10) {
                    return new StateSensor7336(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7336(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7336 : TriggerState {
            internal StateDelay7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 10) {
                    return new StateSensor7336(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
                    return new StateDeActivate7336(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7336 : TriggerState {
            internal StateDeActivate7336(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7336(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor73315 : TriggerState {
            internal StateSensor73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 15) {
                    return new StateSafeGreen73315(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73315 : TriggerState {
            internal StateSafeGreen73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 15) {
                    return new StateEnable73315(context);
                }

                if (context.GetUserCount(boxId: 9330) != 15) {
                    return new StateSensor73315(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable73315 : TriggerState {
            internal StateEnable73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
                    return new StateActivate73315(context);
                }

                if (context.GetUserCount(boxId: 9330) != 15) {
                    return new StateSensor73315(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate73315 : TriggerState {
            internal StateActivate73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 15) {
                    return new StateSensor73315(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay73315(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay73315 : TriggerState {
            internal StateDelay73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 15) {
                    return new StateSensor73315(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
                    return new StateDeActivate73315(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73315 : TriggerState {
            internal StateDeActivate73315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor73315(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor73320 : TriggerState {
            internal StateSensor73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 20) {
                    return new StateSafeGreen73320(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73320 : TriggerState {
            internal StateSafeGreen73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 20) {
                    return new StateEnable73320(context);
                }

                if (context.GetUserCount(boxId: 9330) != 20) {
                    return new StateSensor73320(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable73320 : TriggerState {
            internal StateEnable73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
                    return new StateActivate73320(context);
                }

                if (context.GetUserCount(boxId: 9330) != 20) {
                    return new StateSensor73320(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate73320 : TriggerState {
            internal StateActivate73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 20) {
                    return new StateSensor73320(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay73320(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay73320 : TriggerState {
            internal StateDelay73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 20) {
                    return new StateSensor73320(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
                    return new StateDeActivate73320(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73320 : TriggerState {
            internal StateDeActivate73320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor73320(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor73325 : TriggerState {
            internal StateSensor73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 25) {
                    return new StateSafeGreen73325(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73325 : TriggerState {
            internal StateSafeGreen73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 25) {
                    return new StateEnable73325(context);
                }

                if (context.GetUserCount(boxId: 9330) != 25) {
                    return new StateSensor73325(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable73325 : TriggerState {
            internal StateEnable73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
                    return new StateActivate73325(context);
                }

                if (context.GetUserCount(boxId: 9330) != 25) {
                    return new StateSensor73325(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate73325 : TriggerState {
            internal StateActivate73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 25) {
                    return new StateSensor73325(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay73325(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay73325 : TriggerState {
            internal StateDelay73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 25) {
                    return new StateSensor73325(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
                    return new StateDeActivate73325(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73325 : TriggerState {
            internal StateDeActivate73325(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor73325(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor73330 : TriggerState {
            internal StateSensor73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 3);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 30) {
                    return new StateSafeGreen73330(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen73330 : TriggerState {
            internal StateSafeGreen73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7330, key: "Color33", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) == 30) {
                    return new StateEnable73330(context);
                }

                if (context.GetUserCount(boxId: 9330) != 30) {
                    return new StateSensor73330(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable73330 : TriggerState {
            internal StateEnable73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9330}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000948}, arg2: 0)) {
                    return new StateActivate73330(context);
                }

                if (context.GetUserCount(boxId: 9330) != 30) {
                    return new StateSensor73330(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate73330 : TriggerState {
            internal StateActivate73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: true);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000948}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 30) {
                    return new StateSensor73330(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay73330(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay73330 : TriggerState {
            internal StateDelay73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000964}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9330) != 30) {
                    return new StateSensor73330(context);
                }

                if (context.GetUserValue(key: "Barrier33") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000964}, arg2: 0)) {
                    return new StateDeActivate73330(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate73330 : TriggerState {
            internal StateDeActivate73330(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8330}, arg2: false);
                context.SetMesh(arg1: new[] {8331, 8332, 8333, 8334, 8335, 8336, 8337, 8338}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor73330(context);
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
                context.SetInteractObject(arg1: new[] {10000948, 10000964}, arg2: 0);
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
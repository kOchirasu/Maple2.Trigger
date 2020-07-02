namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8430 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001199, 10001215}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Barrier43") == 1) {
                    return new StateSensor7431(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 2) {
                    return new StateSensor7432(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 3) {
                    return new StateSensor7433(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 4) {
                    return new StateSensor7434(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 5) {
                    return new StateSensor7435(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7431 : TriggerState {
            internal StateSensor7431(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) == 1) {
                    return new StateActivate7431(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7431 : TriggerState {
            internal StateActivate7431(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) != 1) {
                    return new StateSensor7431(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7432 : TriggerState {
            internal StateSensor7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 1);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001199, 10001215}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) == 2) {
                    return new StateSafeGreen7432(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7432 : TriggerState {
            internal StateSafeGreen7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) == 2) {
                    return new StateCheckSameUserTag7432(context);
                }

                if (context.GetUserCount(boxId: 9430) != 2) {
                    return new StateSensor7432(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7432 : TriggerState {
            internal StateCheckSameUserTag7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9430) && context.GetUserCount(boxId: 9430) == 2) {
                    return new StateEnable7432(context);
                }

                if (context.GetUserCount(boxId: 9430) != 2) {
                    return new StateSensor7432(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9430)) {
                    return new StateSafeGreen7432(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7432 : TriggerState {
            internal StateEnable7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9430}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001199}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001199}, arg2: 0)) {
                    return new StateActivate7432(context);
                }

                if (context.GetUserCount(boxId: 9430) != 2) {
                    return new StateSensor7432(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7432 : TriggerState {
            internal StateActivate7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8430}, arg2: true);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001199}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) != 2) {
                    return new StateSensor7432(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7432(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7432 : TriggerState {
            internal StateDelay7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001215}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) != 2) {
                    return new StateSensor7432(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001215}, arg2: 0)) {
                    return new StateDeActivate7432(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7432 : TriggerState {
            internal StateDeActivate7432(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7432(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7433 : TriggerState {
            internal StateSensor7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 1);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001199, 10001215}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) == 3) {
                    return new StateSafeGreen7433(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7433 : TriggerState {
            internal StateSafeGreen7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) == 3) {
                    return new StateCheckSameUserTag7433(context);
                }

                if (context.GetUserCount(boxId: 9430) != 3) {
                    return new StateSensor7433(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7433 : TriggerState {
            internal StateCheckSameUserTag7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9430) && context.GetUserCount(boxId: 9430) == 3) {
                    return new StateEnable7433(context);
                }

                if (context.GetUserCount(boxId: 9430) != 3) {
                    return new StateSensor7433(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9430)) {
                    return new StateSafeGreen7433(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7433 : TriggerState {
            internal StateEnable7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9430}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001199}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001199}, arg2: 0)) {
                    return new StateActivate7433(context);
                }

                if (context.GetUserCount(boxId: 9430) != 3) {
                    return new StateSensor7433(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7433 : TriggerState {
            internal StateActivate7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8430}, arg2: true);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001199}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) != 3) {
                    return new StateSensor7433(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7433(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7433 : TriggerState {
            internal StateDelay7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001215}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) != 3) {
                    return new StateSensor7433(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001215}, arg2: 0)) {
                    return new StateDeActivate7433(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7433 : TriggerState {
            internal StateDeActivate7433(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7433(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7434 : TriggerState {
            internal StateSensor7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 1);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001199, 10001215}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) == 4) {
                    return new StateSafeGreen7434(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7434 : TriggerState {
            internal StateSafeGreen7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) == 4) {
                    return new StateCheckSameUserTag7434(context);
                }

                if (context.GetUserCount(boxId: 9430) != 4) {
                    return new StateSensor7434(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7434 : TriggerState {
            internal StateCheckSameUserTag7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9430) && context.GetUserCount(boxId: 9430) == 4) {
                    return new StateEnable7434(context);
                }

                if (context.GetUserCount(boxId: 9430) != 4) {
                    return new StateSensor7434(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9430)) {
                    return new StateSafeGreen7434(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7434 : TriggerState {
            internal StateEnable7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9430}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001199}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001199}, arg2: 0)) {
                    return new StateActivate7434(context);
                }

                if (context.GetUserCount(boxId: 9430) != 4) {
                    return new StateSensor7434(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7434 : TriggerState {
            internal StateActivate7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8430}, arg2: true);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001199}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) != 4) {
                    return new StateSensor7434(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7434(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7434 : TriggerState {
            internal StateDelay7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001215}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) != 4) {
                    return new StateSensor7434(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001215}, arg2: 0)) {
                    return new StateDeActivate7434(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7434 : TriggerState {
            internal StateDeActivate7434(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7434(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7435 : TriggerState {
            internal StateSensor7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 1);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001199, 10001215}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) == 5) {
                    return new StateSafeGreen7435(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7435 : TriggerState {
            internal StateSafeGreen7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7430, key: "Color43", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) == 5) {
                    return new StateCheckSameUserTag7435(context);
                }

                if (context.GetUserCount(boxId: 9430) != 5) {
                    return new StateSensor7435(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7435 : TriggerState {
            internal StateCheckSameUserTag7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9430) && context.GetUserCount(boxId: 9430) == 5) {
                    return new StateEnable7435(context);
                }

                if (context.GetUserCount(boxId: 9430) != 5) {
                    return new StateSensor7435(context);
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9430)) {
                    return new StateSafeGreen7435(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7435 : TriggerState {
            internal StateEnable7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9430}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001199}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001199}, arg2: 0)) {
                    return new StateActivate7435(context);
                }

                if (context.GetUserCount(boxId: 9430) != 5) {
                    return new StateSensor7435(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7435 : TriggerState {
            internal StateActivate7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8430}, arg2: true);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001199}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) != 5) {
                    return new StateSensor7435(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7435(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7435 : TriggerState {
            internal StateDelay7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001215}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9430) != 5) {
                    return new StateSensor7435(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001215}, arg2: 0)) {
                    return new StateDeActivate7435(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7435 : TriggerState {
            internal StateDeActivate7435(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7435(context);
                }

                if (context.GetUserValue(key: "Barrier43") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8431, 8432, 8433, 8434, 8435, 8436}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8430}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001199, 10001215}, arg2: 0);
                context.SetUserValue(key: "Barrier43", value: 0);
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
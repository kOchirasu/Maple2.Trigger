namespace Maple2.Trigger._84000007_wd {
    public static class _barrier_8340 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetInteractObject(interactIds: new []{10000949, 10000965}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Barrier34") == 1) {
                    return new StateSensor7341(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 2) {
                    return new StateSensor7342(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 3) {
                    return new StateSensor7343(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 4) {
                    return new StateSensor7344(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 5) {
                    return new StateSensor7345(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7341 : TriggerState {
            internal StateSensor7341(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) == 1) {
                    return new StateActivate7341(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7341 : TriggerState {
            internal StateActivate7341(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) != 1) {
                    return new StateSensor7341(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7342 : TriggerState {
            internal StateSensor7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetInteractObject(interactIds: new []{10000949, 10000965}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) == 2) {
                    return new StateSafeGreen7342(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7342 : TriggerState {
            internal StateSafeGreen7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) == 2) {
                    return new StateEnable7342(context);
                }

                if (context.GetUserCount(boxId: 9340) != 2) {
                    return new StateSensor7342(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7342 : TriggerState {
            internal StateEnable7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9340}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000949}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000949}, arg2: 0)) {
                    return new StateActivate7342(context);
                }

                if (context.GetUserCount(boxId: 9340) != 2) {
                    return new StateSensor7342(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7342 : TriggerState {
            internal StateActivate7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8340}, visible: true);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000949}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) != 2) {
                    return new StateSensor7342(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7342(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7342 : TriggerState {
            internal StateDelay7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000965}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) != 2) {
                    return new StateSensor7342(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000965}, arg2: 0)) {
                    return new StateDeActivate7342(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7342 : TriggerState {
            internal StateDeActivate7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7342(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7343 : TriggerState {
            internal StateSensor7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetInteractObject(interactIds: new []{10000949, 10000965}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) == 3) {
                    return new StateSafeGreen7343(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7343 : TriggerState {
            internal StateSafeGreen7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) == 3) {
                    return new StateEnable7343(context);
                }

                if (context.GetUserCount(boxId: 9340) != 3) {
                    return new StateSensor7343(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7343 : TriggerState {
            internal StateEnable7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9340}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000949}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000949}, arg2: 0)) {
                    return new StateActivate7343(context);
                }

                if (context.GetUserCount(boxId: 9340) != 3) {
                    return new StateSensor7343(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7343 : TriggerState {
            internal StateActivate7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8340}, visible: true);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000949}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) != 3) {
                    return new StateSensor7343(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7343(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7343 : TriggerState {
            internal StateDelay7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000965}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) != 3) {
                    return new StateSensor7343(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000965}, arg2: 0)) {
                    return new StateDeActivate7343(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7343 : TriggerState {
            internal StateDeActivate7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7343(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7344 : TriggerState {
            internal StateSensor7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetInteractObject(interactIds: new []{10000949, 10000965}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) == 4) {
                    return new StateSafeGreen7344(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7344 : TriggerState {
            internal StateSafeGreen7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) == 4) {
                    return new StateEnable7344(context);
                }

                if (context.GetUserCount(boxId: 9340) != 4) {
                    return new StateSensor7344(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7344 : TriggerState {
            internal StateEnable7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9340}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000949}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000949}, arg2: 0)) {
                    return new StateActivate7344(context);
                }

                if (context.GetUserCount(boxId: 9340) != 4) {
                    return new StateSensor7344(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7344 : TriggerState {
            internal StateActivate7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8340}, visible: true);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000949}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) != 4) {
                    return new StateSensor7344(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7344(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7344 : TriggerState {
            internal StateDelay7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000965}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) != 4) {
                    return new StateSensor7344(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000965}, arg2: 0)) {
                    return new StateDeActivate7344(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7344 : TriggerState {
            internal StateDeActivate7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7344(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7345 : TriggerState {
            internal StateSensor7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetInteractObject(interactIds: new []{10000949, 10000965}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) == 5) {
                    return new StateSafeGreen7345(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7345 : TriggerState {
            internal StateSafeGreen7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) == 5) {
                    return new StateEnable7345(context);
                }

                if (context.GetUserCount(boxId: 9340) != 5) {
                    return new StateSensor7345(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7345 : TriggerState {
            internal StateEnable7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9340}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000949}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000949}, arg2: 0)) {
                    return new StateActivate7345(context);
                }

                if (context.GetUserCount(boxId: 9340) != 5) {
                    return new StateSensor7345(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7345 : TriggerState {
            internal StateActivate7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8340}, visible: true);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000949}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) != 5) {
                    return new StateSensor7345(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7345(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7345 : TriggerState {
            internal StateDelay7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000965}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9340) != 5) {
                    return new StateSensor7345(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000965}, arg2: 0)) {
                    return new StateDeActivate7345(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7345 : TriggerState {
            internal StateDeActivate7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7345(context);
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8341, 8342, 8343, 8344, 8345, 8346}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8340}, visible: false);
                context.SetInteractObject(interactIds: new []{10000949, 10000965}, state: 0);
                context.SetUserValue(key: "Barrier34", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

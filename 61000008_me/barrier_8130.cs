namespace Maple2.Trigger._61000008_me {
    public static class _barrier_8130 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetInteractObject(interactIds: new []{10000940, 10000956}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Barrier13") == 1) {
                    return new StateSensor7131(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 2) {
                    return new StateSensor7132(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 3) {
                    return new StateSensor7133(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 4) {
                    return new StateSensor7134(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 5) {
                    return new StateSensor7135(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7131 : TriggerState {
            internal StateSensor7131(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) == 1) {
                    return new StateActivate7131(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7131 : TriggerState {
            internal StateActivate7131(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) != 1) {
                    return new StateSensor7131(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7132 : TriggerState {
            internal StateSensor7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetInteractObject(interactIds: new []{10000940, 10000956}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) == 2) {
                    return new StateSafeGreen7132(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7132 : TriggerState {
            internal StateSafeGreen7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) == 2) {
                    return new StateEnable7132(context);
                }

                if (context.GetUserCount(boxId: 9130) != 2) {
                    return new StateSensor7132(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7132 : TriggerState {
            internal StateEnable7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9130}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000940}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000940}, arg2: 0)) {
                    return new StateActivate7132(context);
                }

                if (context.GetUserCount(boxId: 9130) != 2) {
                    return new StateSensor7132(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7132 : TriggerState {
            internal StateActivate7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8130}, visible: true);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000940}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) != 2) {
                    return new StateSensor7132(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7132(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7132 : TriggerState {
            internal StateDelay7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000956}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) != 2) {
                    return new StateSensor7132(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000956}, arg2: 0)) {
                    return new StateDeActivate7132(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7132 : TriggerState {
            internal StateDeActivate7132(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7132(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7133 : TriggerState {
            internal StateSensor7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetInteractObject(interactIds: new []{10000940, 10000956}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) == 3) {
                    return new StateSafeGreen7133(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7133 : TriggerState {
            internal StateSafeGreen7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) == 3) {
                    return new StateEnable7133(context);
                }

                if (context.GetUserCount(boxId: 9130) != 3) {
                    return new StateSensor7133(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7133 : TriggerState {
            internal StateEnable7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9130}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000940}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000940}, arg2: 0)) {
                    return new StateActivate7133(context);
                }

                if (context.GetUserCount(boxId: 9130) != 3) {
                    return new StateSensor7133(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7133 : TriggerState {
            internal StateActivate7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8130}, visible: true);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000940}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) != 3) {
                    return new StateSensor7133(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7133(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7133 : TriggerState {
            internal StateDelay7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000956}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) != 3) {
                    return new StateSensor7133(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000956}, arg2: 0)) {
                    return new StateDeActivate7133(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7133 : TriggerState {
            internal StateDeActivate7133(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7133(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7134 : TriggerState {
            internal StateSensor7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetInteractObject(interactIds: new []{10000940, 10000956}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) == 4) {
                    return new StateSafeGreen7134(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7134 : TriggerState {
            internal StateSafeGreen7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) == 4) {
                    return new StateEnable7134(context);
                }

                if (context.GetUserCount(boxId: 9130) != 4) {
                    return new StateSensor7134(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7134 : TriggerState {
            internal StateEnable7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9130}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000940}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000940}, arg2: 0)) {
                    return new StateActivate7134(context);
                }

                if (context.GetUserCount(boxId: 9130) != 4) {
                    return new StateSensor7134(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7134 : TriggerState {
            internal StateActivate7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8130}, visible: true);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000940}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) != 4) {
                    return new StateSensor7134(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7134(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7134 : TriggerState {
            internal StateDelay7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000956}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) != 4) {
                    return new StateSensor7134(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000956}, arg2: 0)) {
                    return new StateDeActivate7134(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7134 : TriggerState {
            internal StateDeActivate7134(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7134(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7135 : TriggerState {
            internal StateSensor7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 1);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetInteractObject(interactIds: new []{10000940, 10000956}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) == 5) {
                    return new StateSafeGreen7135(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7135 : TriggerState {
            internal StateSafeGreen7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7130, key: "Color13", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) == 5) {
                    return new StateEnable7135(context);
                }

                if (context.GetUserCount(boxId: 9130) != 5) {
                    return new StateSensor7135(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7135 : TriggerState {
            internal StateEnable7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9130}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000940}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000940}, arg2: 0)) {
                    return new StateActivate7135(context);
                }

                if (context.GetUserCount(boxId: 9130) != 5) {
                    return new StateSensor7135(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7135 : TriggerState {
            internal StateActivate7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8130}, visible: true);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000940}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) != 5) {
                    return new StateSensor7135(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7135(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7135 : TriggerState {
            internal StateDelay7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000956}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9130) != 5) {
                    return new StateSensor7135(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000956}, arg2: 0)) {
                    return new StateDeActivate7135(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7135 : TriggerState {
            internal StateDeActivate7135(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7135(context);
                }

                if (context.GetUserValue(key: "Barrier13") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8131, 8132, 8133, 8134, 8135, 8136}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8130}, visible: false);
                context.SetInteractObject(interactIds: new []{10000940, 10000956}, state: 0);
                context.SetUserValue(key: "Barrier13", value: 0);
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

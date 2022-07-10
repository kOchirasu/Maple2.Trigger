namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8410 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetInteractObject(interactIds: new []{10001197, 10001213}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Barrier41") == 1) {
                    return new StateSensor7411(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 2) {
                    return new StateSensor7412(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 3) {
                    return new StateSensor7413(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 4) {
                    return new StateSensor7414(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 5) {
                    return new StateSensor7415(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7411 : TriggerState {
            internal StateSensor7411(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) == 1) {
                    return new StateActivate7411(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7411 : TriggerState {
            internal StateActivate7411(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) != 1) {
                    return new StateSensor7411(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7412 : TriggerState {
            internal StateSensor7412(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 1);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetInteractObject(interactIds: new []{10001197, 10001213}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) == 2) {
                    return new StateSafeGreen7412(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7412 : TriggerState {
            internal StateSafeGreen7412(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) == 2) {
                    return new StateCheckSameUserTag7412(context);
                }

                if (context.GetUserCount(boxId: 9410) != 2) {
                    return new StateSensor7412(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7412 : TriggerState {
            internal StateCheckSameUserTag7412(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9410) && context.GetUserCount(boxId: 9410) == 2) {
                    return new StateEnable7412(context);
                }

                if (context.GetUserCount(boxId: 9410) != 2) {
                    return new StateSensor7412(context);
                }

                if (!context.CheckSameUserTag(boxId: 9410)) {
                    return new StateSafeGreen7412(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7412 : TriggerState {
            internal StateEnable7412(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9410}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001197}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001197}, arg2: 0)) {
                    return new StateActivate7412(context);
                }

                if (context.GetUserCount(boxId: 9410) != 2) {
                    return new StateSensor7412(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7412 : TriggerState {
            internal StateActivate7412(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8410}, visible: true);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001197}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) != 2) {
                    return new StateSensor7412(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7412(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7412 : TriggerState {
            internal StateDelay7412(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001213}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) != 2) {
                    return new StateSensor7412(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001213}, arg2: 0)) {
                    return new StateDeActivate7412(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7412 : TriggerState {
            internal StateDeActivate7412(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7412(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7413 : TriggerState {
            internal StateSensor7413(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 1);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetInteractObject(interactIds: new []{10001197, 10001213}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) == 3) {
                    return new StateSafeGreen7413(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7413 : TriggerState {
            internal StateSafeGreen7413(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) == 3) {
                    return new StateCheckSameUserTag7413(context);
                }

                if (context.GetUserCount(boxId: 9410) != 3) {
                    return new StateSensor7413(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7413 : TriggerState {
            internal StateCheckSameUserTag7413(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9410) && context.GetUserCount(boxId: 9410) == 3) {
                    return new StateEnable7413(context);
                }

                if (context.GetUserCount(boxId: 9410) != 3) {
                    return new StateSensor7413(context);
                }

                if (!context.CheckSameUserTag(boxId: 9410)) {
                    return new StateSafeGreen7413(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7413 : TriggerState {
            internal StateEnable7413(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9410}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001197}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001197}, arg2: 0)) {
                    return new StateActivate7413(context);
                }

                if (context.GetUserCount(boxId: 9410) != 3) {
                    return new StateSensor7413(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7413 : TriggerState {
            internal StateActivate7413(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8410}, visible: true);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001197}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) != 3) {
                    return new StateSensor7413(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7413(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7413 : TriggerState {
            internal StateDelay7413(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001213}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) != 3) {
                    return new StateSensor7413(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001213}, arg2: 0)) {
                    return new StateDeActivate7413(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7413 : TriggerState {
            internal StateDeActivate7413(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7413(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7414 : TriggerState {
            internal StateSensor7414(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 1);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetInteractObject(interactIds: new []{10001197, 10001213}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) == 4) {
                    return new StateSafeGreen7414(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7414 : TriggerState {
            internal StateSafeGreen7414(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) == 4) {
                    return new StateCheckSameUserTag7414(context);
                }

                if (context.GetUserCount(boxId: 9410) != 4) {
                    return new StateSensor7414(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7414 : TriggerState {
            internal StateCheckSameUserTag7414(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9410) && context.GetUserCount(boxId: 9410) == 4) {
                    return new StateEnable7414(context);
                }

                if (context.GetUserCount(boxId: 9410) != 4) {
                    return new StateSensor7414(context);
                }

                if (!context.CheckSameUserTag(boxId: 9410)) {
                    return new StateSafeGreen7414(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7414 : TriggerState {
            internal StateEnable7414(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9410}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001197}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001197}, arg2: 0)) {
                    return new StateActivate7414(context);
                }

                if (context.GetUserCount(boxId: 9410) != 4) {
                    return new StateSensor7414(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7414 : TriggerState {
            internal StateActivate7414(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8410}, visible: true);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001197}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) != 4) {
                    return new StateSensor7414(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7414(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7414 : TriggerState {
            internal StateDelay7414(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001213}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) != 4) {
                    return new StateSensor7414(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001213}, arg2: 0)) {
                    return new StateDeActivate7414(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7414 : TriggerState {
            internal StateDeActivate7414(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7414(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7415 : TriggerState {
            internal StateSensor7415(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 1);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetInteractObject(interactIds: new []{10001197, 10001213}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) == 5) {
                    return new StateSafeGreen7415(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7415 : TriggerState {
            internal StateSafeGreen7415(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7410, key: "Color41", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) == 5) {
                    return new StateCheckSameUserTag7415(context);
                }

                if (context.GetUserCount(boxId: 9410) != 5) {
                    return new StateSensor7415(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7415 : TriggerState {
            internal StateCheckSameUserTag7415(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9410) && context.GetUserCount(boxId: 9410) == 5) {
                    return new StateEnable7415(context);
                }

                if (context.GetUserCount(boxId: 9410) != 5) {
                    return new StateSensor7415(context);
                }

                if (!context.CheckSameUserTag(boxId: 9410)) {
                    return new StateSafeGreen7415(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7415 : TriggerState {
            internal StateEnable7415(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9410}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001197}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001197}, arg2: 0)) {
                    return new StateActivate7415(context);
                }

                if (context.GetUserCount(boxId: 9410) != 5) {
                    return new StateSensor7415(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7415 : TriggerState {
            internal StateActivate7415(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8410}, visible: true);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001197}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) != 5) {
                    return new StateSensor7415(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7415(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7415 : TriggerState {
            internal StateDelay7415(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001213}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9410) != 5) {
                    return new StateSensor7415(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001213}, arg2: 0)) {
                    return new StateDeActivate7415(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7415 : TriggerState {
            internal StateDeActivate7415(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7415(context);
                }

                if (context.GetUserValue(key: "Barrier41") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8411, 8412, 8413, 8414}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8410}, visible: false);
                context.SetInteractObject(interactIds: new []{10001197, 10001213}, state: 0);
                context.SetUserValue(key: "Barrier41", value: 0);
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

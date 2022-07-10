namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8420 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetInteractObject(interactIds: new []{10001198, 10001214}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Barrier42") == 1) {
                    return new StateSensor7421(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 2) {
                    return new StateSensor7422(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 3) {
                    return new StateSensor7423(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 4) {
                    return new StateSensor7424(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 5) {
                    return new StateSensor7425(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7421 : TriggerState {
            internal StateSensor7421(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) == 1) {
                    return new StateActivate7421(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7421 : TriggerState {
            internal StateActivate7421(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) != 1) {
                    return new StateSensor7421(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7422 : TriggerState {
            internal StateSensor7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetInteractObject(interactIds: new []{10001198, 10001214}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) == 2) {
                    return new StateSafeGreen7422(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7422 : TriggerState {
            internal StateSafeGreen7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) == 2) {
                    return new StateCheckSameUserTag7422(context);
                }

                if (context.GetUserCount(boxId: 9420) != 2) {
                    return new StateSensor7422(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7422 : TriggerState {
            internal StateCheckSameUserTag7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9420) && context.GetUserCount(boxId: 9420) == 2) {
                    return new StateEnable7422(context);
                }

                if (context.GetUserCount(boxId: 9420) != 2) {
                    return new StateSensor7422(context);
                }

                if (!context.CheckSameUserTag(boxId: 9420)) {
                    return new StateSafeGreen7422(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7422 : TriggerState {
            internal StateEnable7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9420}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001198}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001198}, arg2: 0)) {
                    return new StateActivate7422(context);
                }

                if (context.GetUserCount(boxId: 9420) != 2) {
                    return new StateSensor7422(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7422 : TriggerState {
            internal StateActivate7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8420}, visible: true);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001198}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) != 2) {
                    return new StateSensor7422(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7422(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7422 : TriggerState {
            internal StateDelay7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001214}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) != 2) {
                    return new StateSensor7422(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001214}, arg2: 0)) {
                    return new StateDeActivate7422(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7422 : TriggerState {
            internal StateDeActivate7422(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7422(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7423 : TriggerState {
            internal StateSensor7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetInteractObject(interactIds: new []{10001198, 10001214}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) == 3) {
                    return new StateSafeGreen7423(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7423 : TriggerState {
            internal StateSafeGreen7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) == 3) {
                    return new StateCheckSameUserTag7423(context);
                }

                if (context.GetUserCount(boxId: 9420) != 3) {
                    return new StateSensor7423(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7423 : TriggerState {
            internal StateCheckSameUserTag7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9420) && context.GetUserCount(boxId: 9420) == 3) {
                    return new StateEnable7423(context);
                }

                if (context.GetUserCount(boxId: 9420) != 3) {
                    return new StateSensor7423(context);
                }

                if (!context.CheckSameUserTag(boxId: 9420)) {
                    return new StateSafeGreen7423(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7423 : TriggerState {
            internal StateEnable7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9420}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001198}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001198}, arg2: 0)) {
                    return new StateActivate7423(context);
                }

                if (context.GetUserCount(boxId: 9420) != 3) {
                    return new StateSensor7423(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7423 : TriggerState {
            internal StateActivate7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8420}, visible: true);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001198}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) != 3) {
                    return new StateSensor7423(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7423(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7423 : TriggerState {
            internal StateDelay7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001214}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) != 3) {
                    return new StateSensor7423(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001214}, arg2: 0)) {
                    return new StateDeActivate7423(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7423 : TriggerState {
            internal StateDeActivate7423(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7423(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7424 : TriggerState {
            internal StateSensor7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetInteractObject(interactIds: new []{10001198, 10001214}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) == 4) {
                    return new StateSafeGreen7424(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7424 : TriggerState {
            internal StateSafeGreen7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) == 4) {
                    return new StateCheckSameUserTag7424(context);
                }

                if (context.GetUserCount(boxId: 9420) != 4) {
                    return new StateSensor7424(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7424 : TriggerState {
            internal StateCheckSameUserTag7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9420) && context.GetUserCount(boxId: 9420) == 4) {
                    return new StateEnable7424(context);
                }

                if (context.GetUserCount(boxId: 9420) != 4) {
                    return new StateSensor7424(context);
                }

                if (!context.CheckSameUserTag(boxId: 9420)) {
                    return new StateSafeGreen7424(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7424 : TriggerState {
            internal StateEnable7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9420}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001198}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001198}, arg2: 0)) {
                    return new StateActivate7424(context);
                }

                if (context.GetUserCount(boxId: 9420) != 4) {
                    return new StateSensor7424(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7424 : TriggerState {
            internal StateActivate7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8420}, visible: true);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001198}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) != 4) {
                    return new StateSensor7424(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7424(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7424 : TriggerState {
            internal StateDelay7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001214}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) != 4) {
                    return new StateSensor7424(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001214}, arg2: 0)) {
                    return new StateDeActivate7424(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7424 : TriggerState {
            internal StateDeActivate7424(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7424(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7425 : TriggerState {
            internal StateSensor7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 1);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetInteractObject(interactIds: new []{10001198, 10001214}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) == 5) {
                    return new StateSafeGreen7425(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7425 : TriggerState {
            internal StateSafeGreen7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7420, key: "Color42", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) == 5) {
                    return new StateCheckSameUserTag7425(context);
                }

                if (context.GetUserCount(boxId: 9420) != 5) {
                    return new StateSensor7425(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7425 : TriggerState {
            internal StateCheckSameUserTag7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9420) && context.GetUserCount(boxId: 9420) == 5) {
                    return new StateEnable7425(context);
                }

                if (context.GetUserCount(boxId: 9420) != 5) {
                    return new StateSensor7425(context);
                }

                if (!context.CheckSameUserTag(boxId: 9420)) {
                    return new StateSafeGreen7425(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7425 : TriggerState {
            internal StateEnable7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9420}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001198}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001198}, arg2: 0)) {
                    return new StateActivate7425(context);
                }

                if (context.GetUserCount(boxId: 9420) != 5) {
                    return new StateSensor7425(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7425 : TriggerState {
            internal StateActivate7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8420}, visible: true);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001198}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) != 5) {
                    return new StateSensor7425(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7425(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7425 : TriggerState {
            internal StateDelay7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001214}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9420) != 5) {
                    return new StateSensor7425(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001214}, arg2: 0)) {
                    return new StateDeActivate7425(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7425 : TriggerState {
            internal StateDeActivate7425(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7425(context);
                }

                if (context.GetUserValue(key: "Barrier42") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8421, 8422, 8423, 8424, 8425, 8426}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8420}, visible: false);
                context.SetInteractObject(interactIds: new []{10001198, 10001214}, state: 0);
                context.SetUserValue(key: "Barrier42", value: 0);
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

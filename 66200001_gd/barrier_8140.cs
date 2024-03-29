namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8140 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetInteractObject(interactIds: new []{10001188, 10001204}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Barrier14") == 1) {
                    return new StateSensor7141(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 2) {
                    return new StateSensor7142(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 3) {
                    return new StateSensor7143(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 4) {
                    return new StateSensor7144(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 5) {
                    return new StateSensor7145(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7141 : TriggerState {
            internal StateSensor7141(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) == 1) {
                    return new StateActivate7141(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7141 : TriggerState {
            internal StateActivate7141(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) != 1) {
                    return new StateSensor7141(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7142 : TriggerState {
            internal StateSensor7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 1);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetInteractObject(interactIds: new []{10001188, 10001204}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) == 2) {
                    return new StateSafeGreen7142(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7142 : TriggerState {
            internal StateSafeGreen7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) == 2) {
                    return new StateCheckSameUserTag7142(context);
                }

                if (context.GetUserCount(boxId: 9140) != 2) {
                    return new StateSensor7142(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7142 : TriggerState {
            internal StateCheckSameUserTag7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9140) && context.GetUserCount(boxId: 9140) == 2) {
                    return new StateEnable7142(context);
                }

                if (context.GetUserCount(boxId: 9140) != 2) {
                    return new StateSensor7142(context);
                }

                if (!context.CheckSameUserTag(boxId: 9140)) {
                    return new StateSafeGreen7142(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7142 : TriggerState {
            internal StateEnable7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9140}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001188}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001188}, arg2: 0)) {
                    return new StateActivate7142(context);
                }

                if (context.GetUserCount(boxId: 9140) != 2) {
                    return new StateSensor7142(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7142 : TriggerState {
            internal StateActivate7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8140}, visible: true);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001188}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) != 2) {
                    return new StateSensor7142(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7142(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7142 : TriggerState {
            internal StateDelay7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001204}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) != 2) {
                    return new StateSensor7142(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001204}, arg2: 0)) {
                    return new StateDeActivate7142(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7142 : TriggerState {
            internal StateDeActivate7142(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7142(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7143 : TriggerState {
            internal StateSensor7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 1);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetInteractObject(interactIds: new []{10001188, 10001204}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) == 3) {
                    return new StateSafeGreen7143(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7143 : TriggerState {
            internal StateSafeGreen7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) == 3) {
                    return new StateCheckSameUserTag7143(context);
                }

                if (context.GetUserCount(boxId: 9140) != 3) {
                    return new StateSensor7143(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7143 : TriggerState {
            internal StateCheckSameUserTag7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9140) && context.GetUserCount(boxId: 9140) == 3) {
                    return new StateEnable7143(context);
                }

                if (!context.CheckSameUserTag(boxId: 9140)) {
                    return new StateSafeGreen7143(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7143 : TriggerState {
            internal StateEnable7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9140}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001188}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001188}, arg2: 0)) {
                    return new StateActivate7143(context);
                }

                if (context.GetUserCount(boxId: 9140) != 3) {
                    return new StateSensor7143(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7143 : TriggerState {
            internal StateActivate7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8140}, visible: true);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001188}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) != 3) {
                    return new StateSensor7143(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7143(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7143 : TriggerState {
            internal StateDelay7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001204}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) != 3) {
                    return new StateSensor7143(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001204}, arg2: 0)) {
                    return new StateDeActivate7143(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7143 : TriggerState {
            internal StateDeActivate7143(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7143(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7144 : TriggerState {
            internal StateSensor7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 1);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetInteractObject(interactIds: new []{10001188, 10001204}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) == 4) {
                    return new StateSafeGreen7144(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7144 : TriggerState {
            internal StateSafeGreen7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) == 4) {
                    return new StateCheckSameUserTag7144(context);
                }

                if (context.GetUserCount(boxId: 9140) != 4) {
                    return new StateSensor7144(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7144 : TriggerState {
            internal StateCheckSameUserTag7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9140) && context.GetUserCount(boxId: 9140) == 4) {
                    return new StateEnable7144(context);
                }

                if (context.GetUserCount(boxId: 9140) != 4) {
                    return new StateSensor7144(context);
                }

                if (!context.CheckSameUserTag(boxId: 9140)) {
                    return new StateSafeGreen7144(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7144 : TriggerState {
            internal StateEnable7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9140}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001188}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001188}, arg2: 0)) {
                    return new StateActivate7144(context);
                }

                if (context.GetUserCount(boxId: 9140) != 4) {
                    return new StateSensor7144(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7144 : TriggerState {
            internal StateActivate7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8140}, visible: true);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001188}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) != 4) {
                    return new StateSensor7144(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7144(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7144 : TriggerState {
            internal StateDelay7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001204}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) != 4) {
                    return new StateSensor7144(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001204}, arg2: 0)) {
                    return new StateDeActivate7144(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7144 : TriggerState {
            internal StateDeActivate7144(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7144(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7145 : TriggerState {
            internal StateSensor7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 1);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetInteractObject(interactIds: new []{10001188, 10001204}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) == 5) {
                    return new StateSafeGreen7145(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7145 : TriggerState {
            internal StateSafeGreen7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7140, key: "Color14", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) == 5) {
                    return new StateCheckSameUserTag7145(context);
                }

                if (context.GetUserCount(boxId: 9140) != 5) {
                    return new StateSensor7145(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7145 : TriggerState {
            internal StateCheckSameUserTag7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9140) && context.GetUserCount(boxId: 9140) == 5) {
                    return new StateEnable7145(context);
                }

                if (context.GetUserCount(boxId: 9140) != 5) {
                    return new StateSensor7145(context);
                }

                if (!context.CheckSameUserTag(boxId: 9140)) {
                    return new StateSafeGreen7145(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7145 : TriggerState {
            internal StateEnable7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9140}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001188}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001188}, arg2: 0)) {
                    return new StateActivate7145(context);
                }

                if (context.GetUserCount(boxId: 9140) != 5) {
                    return new StateSensor7145(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7145 : TriggerState {
            internal StateActivate7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8140}, visible: true);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001188}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) != 5) {
                    return new StateSensor7145(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7145(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7145 : TriggerState {
            internal StateDelay7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001204}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9140) != 5) {
                    return new StateSensor7145(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001204}, arg2: 0)) {
                    return new StateDeActivate7145(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7145 : TriggerState {
            internal StateDeActivate7145(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7145(context);
                }

                if (context.GetUserValue(key: "Barrier14") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8141, 8142, 8143, 8144}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8140}, visible: false);
                context.SetInteractObject(interactIds: new []{10001188, 10001204}, state: 0);
                context.SetUserValue(key: "Barrier14", value: 0);
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

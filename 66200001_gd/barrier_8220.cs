namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8220 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10001190, 10001206}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Barrier22") == 1) {
                    return new StateSensor7221(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 2) {
                    return new StateSensor7222(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 3) {
                    return new StateSensor7223(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 4) {
                    return new StateSensor7224(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 5) {
                    return new StateSensor7225(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7221 : TriggerState {
            internal StateSensor7221(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 1) {
                    return new StateActivate7221(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7221 : TriggerState {
            internal StateActivate7221(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 1) {
                    return new StateSensor7221(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7222 : TriggerState {
            internal StateSensor7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10001190, 10001206}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 2) {
                    return new StateSafeGreen7222(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7222 : TriggerState {
            internal StateSafeGreen7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 2) {
                    return new StateCheckSameUserTag7222(context);
                }

                if (context.GetUserCount(boxId: 9220) != 2) {
                    return new StateSensor7222(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7222 : TriggerState {
            internal StateCheckSameUserTag7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9220) && context.GetUserCount(boxId: 9220) == 2) {
                    return new StateEnable7222(context);
                }

                if (context.GetUserCount(boxId: 9220) != 2) {
                    return new StateSensor7222(context);
                }

                if (!context.CheckSameUserTag(boxId: 9220)) {
                    return new StateSafeGreen7222(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7222 : TriggerState {
            internal StateEnable7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001190}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001190}, arg2: 0)) {
                    return new StateActivate7222(context);
                }

                if (context.GetUserCount(boxId: 9220) != 2) {
                    return new StateSensor7222(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7222 : TriggerState {
            internal StateActivate7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001190}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 2) {
                    return new StateSensor7222(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7222(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7222 : TriggerState {
            internal StateDelay7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001206}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 2) {
                    return new StateSensor7222(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001206}, arg2: 0)) {
                    return new StateDeActivate7222(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7222 : TriggerState {
            internal StateDeActivate7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7222(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7223 : TriggerState {
            internal StateSensor7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10001190, 10001206}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 3) {
                    return new StateSafeGreen7223(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7223 : TriggerState {
            internal StateSafeGreen7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 3) {
                    return new StateCheckSameUserTag7223(context);
                }

                if (context.GetUserCount(boxId: 9220) != 3) {
                    return new StateSensor7223(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7223 : TriggerState {
            internal StateCheckSameUserTag7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9220) && context.GetUserCount(boxId: 9220) == 3) {
                    return new StateEnable7223(context);
                }

                if (context.GetUserCount(boxId: 9220) != 3) {
                    return new StateSensor7223(context);
                }

                if (!context.CheckSameUserTag(boxId: 9220)) {
                    return new StateSafeGreen7223(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7223 : TriggerState {
            internal StateEnable7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001190}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001190}, arg2: 0)) {
                    return new StateActivate7223(context);
                }

                if (context.GetUserCount(boxId: 9220) != 3) {
                    return new StateSensor7223(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7223 : TriggerState {
            internal StateActivate7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001190}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 3) {
                    return new StateSensor7223(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7223(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7223 : TriggerState {
            internal StateDelay7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001206}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 3) {
                    return new StateSensor7223(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001206}, arg2: 0)) {
                    return new StateDeActivate7223(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7223 : TriggerState {
            internal StateDeActivate7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7223(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7224 : TriggerState {
            internal StateSensor7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10001190, 10001206}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 4) {
                    return new StateSafeGreen7224(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7224 : TriggerState {
            internal StateSafeGreen7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 4) {
                    return new StateCheckSameUserTag7224(context);
                }

                if (context.GetUserCount(boxId: 9220) != 4) {
                    return new StateSensor7224(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7224 : TriggerState {
            internal StateCheckSameUserTag7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9220) && context.GetUserCount(boxId: 9220) == 4) {
                    return new StateEnable7224(context);
                }

                if (context.GetUserCount(boxId: 9220) != 4) {
                    return new StateSensor7224(context);
                }

                if (!context.CheckSameUserTag(boxId: 9220)) {
                    return new StateSafeGreen7224(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7224 : TriggerState {
            internal StateEnable7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001190}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001190}, arg2: 0)) {
                    return new StateActivate7224(context);
                }

                if (context.GetUserCount(boxId: 9220) != 4) {
                    return new StateSensor7224(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7224 : TriggerState {
            internal StateActivate7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001190}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 4) {
                    return new StateSensor7224(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7224(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7224 : TriggerState {
            internal StateDelay7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001206}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 4) {
                    return new StateSensor7224(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001206}, arg2: 0)) {
                    return new StateDeActivate7224(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7224 : TriggerState {
            internal StateDeActivate7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7224(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7225 : TriggerState {
            internal StateSensor7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 1);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10001190, 10001206}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 5) {
                    return new StateSafeGreen7225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7225 : TriggerState {
            internal StateSafeGreen7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 5) {
                    return new StateCheckSameUserTag7225(context);
                }

                if (context.GetUserCount(boxId: 9220) != 5) {
                    return new StateSensor7225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7225 : TriggerState {
            internal StateCheckSameUserTag7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckSameUserTag(boxId: 9220) && context.GetUserCount(boxId: 9220) == 5) {
                    return new StateEnable7225(context);
                }

                if (context.GetUserCount(boxId: 9220) != 5) {
                    return new StateSensor7225(context);
                }

                if (!context.CheckSameUserTag(boxId: 9220)) {
                    return new StateSafeGreen7225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7225 : TriggerState {
            internal StateEnable7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10001190}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001190}, arg2: 0)) {
                    return new StateActivate7225(context);
                }

                if (context.GetUserCount(boxId: 9220) != 5) {
                    return new StateSensor7225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7225 : TriggerState {
            internal StateActivate7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001190}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 5) {
                    return new StateSensor7225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7225(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7225 : TriggerState {
            internal StateDelay7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001206}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 5) {
                    return new StateSensor7225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001206}, arg2: 0)) {
                    return new StateDeActivate7225(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7225 : TriggerState {
            internal StateDeActivate7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10001190, 10001206}, state: 0);
                context.SetUserValue(key: "Barrier22", value: 0);
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

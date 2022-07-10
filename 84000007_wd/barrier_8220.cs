namespace Maple2.Trigger._84000007_wd {
    public static class _barrier_8220 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 2);
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

                if (context.GetUserValue(key: "Barrier22") == 7) {
                    return new StateSensor7227(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 8) {
                    return new StateSensor7228(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 9) {
                    return new StateSensor7229(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 6) {
                    return new StateSensor7226(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 15) {
                    return new StateSensor72215(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 20) {
                    return new StateSensor72220(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 25) {
                    return new StateSensor72225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 30) {
                    return new StateSensor72230(context);
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
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
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
                    return new StateEnable7222(context);
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

        private class StateEnable7222 : TriggerState {
            internal StateEnable7222(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
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
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 2) {
                    return new StateSensor7222(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
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
                    return new StateEnable7223(context);
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

        private class StateEnable7223 : TriggerState {
            internal StateEnable7223(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
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
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 3) {
                    return new StateSensor7223(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
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
                    return new StateEnable7224(context);
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

        private class StateEnable7224 : TriggerState {
            internal StateEnable7224(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
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
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 4) {
                    return new StateSensor7224(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
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
                    return new StateEnable7225(context);
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

        private class StateEnable7225 : TriggerState {
            internal StateEnable7225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
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
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 5) {
                    return new StateSensor7225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
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

        private class StateSensor7227 : TriggerState {
            internal StateSensor7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 7) {
                    return new StateSafeGreen7227(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7227 : TriggerState {
            internal StateSafeGreen7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 7) {
                    return new StateEnable7227(context);
                }

                if (context.GetUserCount(boxId: 9220) != 7) {
                    return new StateSensor7227(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7227 : TriggerState {
            internal StateEnable7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
                    return new StateActivate7227(context);
                }

                if (context.GetUserCount(boxId: 9220) != 7) {
                    return new StateSensor7227(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7227 : TriggerState {
            internal StateActivate7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 7) {
                    return new StateSensor7227(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7227(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7227 : TriggerState {
            internal StateDelay7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 7) {
                    return new StateSensor7227(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
                    return new StateDeActivate7227(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7227 : TriggerState {
            internal StateDeActivate7227(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7227(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7228 : TriggerState {
            internal StateSensor7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 8) {
                    return new StateSafeGreen7228(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7228 : TriggerState {
            internal StateSafeGreen7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 8) {
                    return new StateEnable7228(context);
                }

                if (context.GetUserCount(boxId: 9220) != 8) {
                    return new StateSensor7228(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7228 : TriggerState {
            internal StateEnable7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
                    return new StateActivate7228(context);
                }

                if (context.GetUserCount(boxId: 9220) != 8) {
                    return new StateSensor7228(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7228 : TriggerState {
            internal StateActivate7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 8) {
                    return new StateSensor7228(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7228(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7228 : TriggerState {
            internal StateDelay7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 8) {
                    return new StateSensor7228(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
                    return new StateDeActivate7228(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7228 : TriggerState {
            internal StateDeActivate7228(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7228(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7229 : TriggerState {
            internal StateSensor7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 9) {
                    return new StateSafeGreen7229(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7229 : TriggerState {
            internal StateSafeGreen7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 9) {
                    return new StateEnable7229(context);
                }

                if (context.GetUserCount(boxId: 9220) != 9) {
                    return new StateSensor7229(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7229 : TriggerState {
            internal StateEnable7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
                    return new StateActivate7229(context);
                }

                if (context.GetUserCount(boxId: 9220) != 9) {
                    return new StateSensor7229(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7229 : TriggerState {
            internal StateActivate7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 9) {
                    return new StateSensor7229(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7229(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7229 : TriggerState {
            internal StateDelay7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 9) {
                    return new StateSensor7229(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
                    return new StateDeActivate7229(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7229 : TriggerState {
            internal StateDeActivate7229(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7229(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor7226 : TriggerState {
            internal StateSensor7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 10) {
                    return new StateSafeGreen7226(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7226 : TriggerState {
            internal StateSafeGreen7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 10) {
                    return new StateEnable7226(context);
                }

                if (context.GetUserCount(boxId: 9220) != 10) {
                    return new StateSensor7226(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable7226 : TriggerState {
            internal StateEnable7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
                    return new StateActivate7226(context);
                }

                if (context.GetUserCount(boxId: 9220) != 10) {
                    return new StateSensor7226(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate7226 : TriggerState {
            internal StateActivate7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 10) {
                    return new StateSensor7226(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay7226(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay7226 : TriggerState {
            internal StateDelay7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 10) {
                    return new StateSensor7226(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
                    return new StateDeActivate7226(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7226 : TriggerState {
            internal StateDeActivate7226(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor7226(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor72215 : TriggerState {
            internal StateSensor72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 15) {
                    return new StateSafeGreen72215(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72215 : TriggerState {
            internal StateSafeGreen72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 15) {
                    return new StateEnable72215(context);
                }

                if (context.GetUserCount(boxId: 9220) != 15) {
                    return new StateSensor72215(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable72215 : TriggerState {
            internal StateEnable72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
                    return new StateActivate72215(context);
                }

                if (context.GetUserCount(boxId: 9220) != 15) {
                    return new StateSensor72215(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate72215 : TriggerState {
            internal StateActivate72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 15) {
                    return new StateSensor72215(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay72215(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay72215 : TriggerState {
            internal StateDelay72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 15) {
                    return new StateSensor72215(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
                    return new StateDeActivate72215(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72215 : TriggerState {
            internal StateDeActivate72215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor72215(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor72220 : TriggerState {
            internal StateSensor72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 20) {
                    return new StateSafeGreen72220(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72220 : TriggerState {
            internal StateSafeGreen72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 20) {
                    return new StateEnable72220(context);
                }

                if (context.GetUserCount(boxId: 9220) != 20) {
                    return new StateSensor72220(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable72220 : TriggerState {
            internal StateEnable72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
                    return new StateActivate72220(context);
                }

                if (context.GetUserCount(boxId: 9220) != 20) {
                    return new StateSensor72220(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate72220 : TriggerState {
            internal StateActivate72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 20) {
                    return new StateSensor72220(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay72220(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay72220 : TriggerState {
            internal StateDelay72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 20) {
                    return new StateSensor72220(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
                    return new StateDeActivate72220(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72220 : TriggerState {
            internal StateDeActivate72220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor72220(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor72225 : TriggerState {
            internal StateSensor72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 25) {
                    return new StateSafeGreen72225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72225 : TriggerState {
            internal StateSafeGreen72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 25) {
                    return new StateEnable72225(context);
                }

                if (context.GetUserCount(boxId: 9220) != 25) {
                    return new StateSensor72225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable72225 : TriggerState {
            internal StateEnable72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
                    return new StateActivate72225(context);
                }

                if (context.GetUserCount(boxId: 9220) != 25) {
                    return new StateSensor72225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate72225 : TriggerState {
            internal StateActivate72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 25) {
                    return new StateSensor72225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay72225(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay72225 : TriggerState {
            internal StateDelay72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 25) {
                    return new StateSensor72225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
                    return new StateDeActivate72225(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72225 : TriggerState {
            internal StateDeActivate72225(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor72225(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSensor72230 : TriggerState {
            internal StateSensor72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 3);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 30) {
                    return new StateSafeGreen72230(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen72230 : TriggerState {
            internal StateSafeGreen72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7220, key: "Color22", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) == 30) {
                    return new StateEnable72230(context);
                }

                if (context.GetUserCount(boxId: 9220) != 30) {
                    return new StateSensor72230(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnable72230 : TriggerState {
            internal StateEnable72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(boxIds: new []{9220}, sound: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(interactIds: new []{10000943}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000943}, arg2: 0)) {
                    return new StateActivate72230(context);
                }

                if (context.GetUserCount(boxId: 9220) != 30) {
                    return new StateSensor72230(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivate72230 : TriggerState {
            internal StateActivate72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: true);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000943}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 30) {
                    return new StateSensor72230(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDelay72230(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay72230 : TriggerState {
            internal StateDelay72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000959}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9220) != 30) {
                    return new StateSensor72230(context);
                }

                if (context.GetUserValue(key: "Barrier22") == 10) {
                    return new StateReset(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10000959}, arg2: 0)) {
                    return new StateDeActivate72230(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeActivate72230 : TriggerState {
            internal StateDeActivate72230(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8220}, visible: false);
                context.SetMesh(triggerIds: new []{8221, 8222, 8223, 8224, 8225, 8226, 8227, 8228}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSensor72230(context);
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
                context.SetInteractObject(interactIds: new []{10000943, 10000959}, state: 0);
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

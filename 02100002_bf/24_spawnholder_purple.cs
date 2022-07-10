namespace Maple2.Trigger._02100002_bf {
    public static class _24_spawnholder_purple {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ActivateHolder", value: 0);
                context.SetUserValue(key: "DungeonQuit", value: 0);
                context.SetInteractObject(interactIds: new []{10001254}, state: 2);
                context.SetInteractObject(interactIds: new []{10001255}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ActivateHolder") == 1) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawnStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawnStart : TriggerState {
            internal StateSpawnStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001255}, state: 1);
                context.SetInteractObject(interactIds: new []{10001254}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001255}, arg2: 0)) {
                    return new StateStopDelay(context);
                }

                if (context.GetUserValue(key: "DungeonQuit") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopDelay : TriggerState {
            internal StateStopDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 104, key: "SpawnHold", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawnStop(context);
                }

                if (context.GetUserValue(key: "DungeonQuit") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawnStop : TriggerState {
            internal StateSpawnStop(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001255}, state: 2);
                context.SetInteractObject(interactIds: new []{10001254}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001254}, arg2: 0)) {
                    return new StateStartDelay(context);
                }

                if (context.GetUserValue(key: "DungeonQuit") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDelay : TriggerState {
            internal StateStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 104, key: "SpawnHold", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSpawnStart(context);
                }

                if (context.GetUserValue(key: "DungeonQuit") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001254}, state: 2);
                context.SetInteractObject(interactIds: new []{10001255}, state: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

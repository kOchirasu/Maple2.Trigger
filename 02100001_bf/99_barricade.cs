namespace Maple2.Trigger._02100001_bf {
    public static class _99_barricade {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CageDoorOpen", value: 0);
                context.SetUserValue(key: "MissionStart", value: 0);
                context.SetUserValue(key: "MissionComplete", value: 0);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CageDoorOpen") == 1) {
                    return new StateCageDoorOpenDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCageDoorOpenDelay : TriggerState {
            internal StateCageDoorOpenDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCageDoorOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCageDoorOpen : TriggerState {
            internal StateCageDoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Open");
                context.SetMesh(triggerIds: new []{3100}, visible: false, arg3: 300, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MissionStart") == 1) {
                    return new StateCountDown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCountDown : TriggerState {
            internal StateCountDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$02100001_BF__99_BARRICADE__0$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateShutDown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShutDown : TriggerState {
            internal StateShutDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetUserValue(triggerId: 5, key: "GiveBuffSlowly", value: 1);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{3100}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MissionComplete") == 1) {
                    return new StateRelease(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRelease : TriggerState {
            internal StateRelease(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Open");
                context.SetMesh(triggerIds: new []{3100}, visible: false, arg3: 300, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

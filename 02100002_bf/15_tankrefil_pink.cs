namespace Maple2.Trigger._02100002_bf {
    public static class _15_tankrefil_pink {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ActivateTank", value: 0);
                context.SetUserValue(key: "DungeonQuit", value: 0);
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Interaction_tankpink_A01_100");
                context.SetActor(triggerId: 4105, visible: true, initialSequence: "Interaction_tankpink_A01_100");
                context.SetEffect(triggerIds: new []{5305, 5405, 5505}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ActivateTank") == 1) {
                    return new StateGauge100(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge100 : TriggerState {
            internal StateGauge100(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 105, key: "Gauge", value: 100);
                context.SetTimer(timerId: "100100", seconds: 15, autoRemove: true);
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Interaction_tankpink_A01_100");
                context.SetActor(triggerId: 4105, visible: true, initialSequence: "Interaction_tankpink_A01_100");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100100")) {
                    return new StateGauge75(context);
                }

                if (context.DetectLiftableObject(boxIds: new []{2005}, itemId: 30000887)) {
                    return new StateGauge100_Refil(context);
                }

                if (context.GetUserValue(key: "DungeonQuit") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge100_Refil : TriggerState {
            internal StateGauge100_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5305, 5405, 5505}, visible: true);
                context.ResetTimer(timerId: "100100");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGauge100(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge75 : TriggerState {
            internal StateGauge75(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 105, key: "Gauge", value: 75);
                context.ResetTimer(timerId: "100100");
                context.SetTimer(timerId: "10075", seconds: 15, autoRemove: true);
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Interaction_tankpink_A01_75");
                context.SetActor(triggerId: 4105, visible: true, initialSequence: "Interaction_tankpink_A01_75");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10075")) {
                    return new StateGauge50(context);
                }

                if (context.DetectLiftableObject(boxIds: new []{2005}, itemId: 30000887)) {
                    return new StateGauge75_Refil(context);
                }

                if (context.GetUserValue(key: "DungeonQuit") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge75_Refil : TriggerState {
            internal StateGauge75_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5305, 5405, 5505}, visible: true);
                context.ResetTimer(timerId: "10075");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGauge100(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge50 : TriggerState {
            internal StateGauge50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 105, key: "Gauge", value: 50);
                context.ResetTimer(timerId: "10075");
                context.SetTimer(timerId: "10050", seconds: 15, autoRemove: true);
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Interaction_tankpink_A01_50");
                context.SetActor(triggerId: 4105, visible: true, initialSequence: "Interaction_tankpink_A01_50");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10050")) {
                    return new StateGauge25(context);
                }

                if (context.DetectLiftableObject(boxIds: new []{2005}, itemId: 30000887)) {
                    return new StateGauge50_Refil(context);
                }

                if (context.GetUserValue(key: "DungeonQuit") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge50_Refil : TriggerState {
            internal StateGauge50_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5305, 5405, 5505}, visible: true);
                context.ResetTimer(timerId: "10050");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGauge75(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge25 : TriggerState {
            internal StateGauge25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 105, key: "Gauge", value: 25);
                context.ResetTimer(timerId: "10050");
                context.SetTimer(timerId: "10025", seconds: 15, autoRemove: true);
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Interaction_tankpink_A01_25");
                context.SetActor(triggerId: 4105, visible: true, initialSequence: "Interaction_tankpink_A01_25");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10025")) {
                    return new StateGauge1(context);
                }

                if (context.DetectLiftableObject(boxIds: new []{2005}, itemId: 30000887)) {
                    return new StateGauge25_Refil(context);
                }

                if (context.GetUserValue(key: "DungeonQuit") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge25_Refil : TriggerState {
            internal StateGauge25_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5305, 5405, 5505}, visible: true);
                context.ResetTimer(timerId: "10025");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGauge50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge1 : TriggerState {
            internal StateGauge1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "10025");
                context.SetUserValue(triggerId: 105, key: "Gauge", value: 1);
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Interaction_tankpink_A01_1");
                context.SetActor(triggerId: 4105, visible: true, initialSequence: "Interaction_tankpink_A01_1");
            }

            public override TriggerState? Execute() {
                if (context.DetectLiftableObject(boxIds: new []{2005}, itemId: 30000887)) {
                    return new StateGauge1_Refil(context);
                }

                if (context.GetUserValue(key: "DungeonQuit") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge1_Refil : TriggerState {
            internal StateGauge1_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5305, 5405, 5505}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGauge25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 105, key: "StopSpawn", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

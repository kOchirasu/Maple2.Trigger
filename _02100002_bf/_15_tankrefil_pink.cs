using System;

namespace Maple2.Trigger._02100002_bf {
    public static class _15_tankrefil_pink {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ActivateTank", value: 0);
                context.SetUserValue(key: "DungeonQuit", value: 0);
                context.SetActor(arg1: 4005, arg2: true, arg3: "Interaction_tankpink_A01_100");
                context.SetActor(arg1: 4105, arg2: true, arg3: "Interaction_tankpink_A01_100");
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5405}, arg2: false);
                context.SetEffect(arg1: new int[] {5505}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "ActivateTank", value: 1)) {
                    context.State = new StateGauge100(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge100 : TriggerState {
            internal StateGauge100(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 105, key: "Gauge", value: 100);
                context.SetTimer(arg1: "100100", arg2: 15, arg3: true);
                context.SetActor(arg1: 4005, arg2: true, arg3: "Interaction_tankpink_A01_100");
                context.SetActor(arg1: 4105, arg2: true, arg3: "Interaction_tankpink_A01_100");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100100")) {
                    context.State = new StateGauge75(context);
                    return;
                }

                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2005}, itemID: 30000887)) {
                    context.State = new StateGauge100_Refil(context);
                    return;
                }

                if (context.UserValue(key: "DungeonQuit", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge100_Refil : TriggerState {
            internal StateGauge100_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5305}, arg2: true);
                context.SetEffect(arg1: new int[] {5405}, arg2: true);
                context.SetEffect(arg1: new int[] {5505}, arg2: true);
                context.ResetTimer(arg1: "100100");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGauge100(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge75 : TriggerState {
            internal StateGauge75(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 105, key: "Gauge", value: 75);
                context.ResetTimer(arg1: "100100");
                context.SetTimer(arg1: "10075", arg2: 15, arg3: true);
                context.SetActor(arg1: 4005, arg2: true, arg3: "Interaction_tankpink_A01_75");
                context.SetActor(arg1: 4105, arg2: true, arg3: "Interaction_tankpink_A01_75");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10075")) {
                    context.State = new StateGauge50(context);
                    return;
                }

                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2005}, itemID: 30000887)) {
                    context.State = new StateGauge75_Refil(context);
                    return;
                }

                if (context.UserValue(key: "DungeonQuit", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge75_Refil : TriggerState {
            internal StateGauge75_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5305}, arg2: true);
                context.SetEffect(arg1: new int[] {5405}, arg2: true);
                context.SetEffect(arg1: new int[] {5505}, arg2: true);
                context.ResetTimer(arg1: "10075");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGauge100(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge50 : TriggerState {
            internal StateGauge50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 105, key: "Gauge", value: 50);
                context.ResetTimer(arg1: "10075");
                context.SetTimer(arg1: "10050", arg2: 15, arg3: true);
                context.SetActor(arg1: 4005, arg2: true, arg3: "Interaction_tankpink_A01_50");
                context.SetActor(arg1: 4105, arg2: true, arg3: "Interaction_tankpink_A01_50");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10050")) {
                    context.State = new StateGauge25(context);
                    return;
                }

                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2005}, itemID: 30000887)) {
                    context.State = new StateGauge50_Refil(context);
                    return;
                }

                if (context.UserValue(key: "DungeonQuit", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge50_Refil : TriggerState {
            internal StateGauge50_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5305}, arg2: true);
                context.SetEffect(arg1: new int[] {5405}, arg2: true);
                context.SetEffect(arg1: new int[] {5505}, arg2: true);
                context.ResetTimer(arg1: "10050");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGauge75(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge25 : TriggerState {
            internal StateGauge25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 105, key: "Gauge", value: 25);
                context.ResetTimer(arg1: "10050");
                context.SetTimer(arg1: "10025", arg2: 15, arg3: true);
                context.SetActor(arg1: 4005, arg2: true, arg3: "Interaction_tankpink_A01_25");
                context.SetActor(arg1: 4105, arg2: true, arg3: "Interaction_tankpink_A01_25");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10025")) {
                    context.State = new StateGauge1(context);
                    return;
                }

                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2005}, itemID: 30000887)) {
                    context.State = new StateGauge25_Refil(context);
                    return;
                }

                if (context.UserValue(key: "DungeonQuit", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge25_Refil : TriggerState {
            internal StateGauge25_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5305}, arg2: true);
                context.SetEffect(arg1: new int[] {5405}, arg2: true);
                context.SetEffect(arg1: new int[] {5505}, arg2: true);
                context.ResetTimer(arg1: "10025");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGauge50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge1 : TriggerState {
            internal StateGauge1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "10025");
                context.SetUserValue(triggerID: 105, key: "Gauge", value: 1);
                context.SetActor(arg1: 4005, arg2: true, arg3: "Interaction_tankpink_A01_1");
                context.SetActor(arg1: 4105, arg2: true, arg3: "Interaction_tankpink_A01_1");
            }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2005}, itemID: 30000887)) {
                    context.State = new StateGauge1_Refil(context);
                    return;
                }

                if (context.UserValue(key: "DungeonQuit", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge1_Refil : TriggerState {
            internal StateGauge1_Refil(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5305}, arg2: true);
                context.SetEffect(arg1: new int[] {5405}, arg2: true);
                context.SetEffect(arg1: new int[] {5505}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGauge25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 105, key: "StopSpawn", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
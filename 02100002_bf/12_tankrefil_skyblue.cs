namespace Maple2.Trigger._02100002_bf {
    public static class _12_tankrefil_skyblue {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ActivateTank", value: 0);
                context.SetUserValue(key: "DungeonQuit", value: 0);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Interaction_tankskyblue_A01_100");
                context.SetActor(arg1: 4102, arg2: true, arg3: "Interaction_tankskyblue_A01_100");
                context.SetEffect(arg1: new[] {5302, 5402, 5502}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetUserValue(triggerId: 102, key: "Gauge", value: 100);
                context.SetTimer(id: "100100", arg2: 15, arg3: true);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Interaction_tankskyblue_A01_100");
                context.SetActor(arg1: 4102, arg2: true, arg3: "Interaction_tankskyblue_A01_100");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "100100")) {
                    return new StateGauge75(context);
                }

                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000885)) {
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
                context.SetEffect(arg1: new[] {5302, 5402, 5502}, arg2: true);
                context.ResetTimer(id: "100100");
            }

            public override TriggerState Execute() {
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
                context.SetUserValue(triggerId: 102, key: "Gauge", value: 75);
                context.ResetTimer(id: "100100");
                context.SetTimer(id: "10075", arg2: 15, arg3: true);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Interaction_tankskyblue_A01_75");
                context.SetActor(arg1: 4102, arg2: true, arg3: "Interaction_tankskyblue_A01_75");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10075")) {
                    return new StateGauge50(context);
                }

                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000885)) {
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
                context.SetEffect(arg1: new[] {5302, 5402, 5502}, arg2: true);
                context.ResetTimer(id: "10075");
            }

            public override TriggerState Execute() {
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
                context.SetUserValue(triggerId: 102, key: "Gauge", value: 50);
                context.ResetTimer(id: "10075");
                context.SetTimer(id: "10050", arg2: 15, arg3: true);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Interaction_tankskyblue_A01_50");
                context.SetActor(arg1: 4102, arg2: true, arg3: "Interaction_tankskyblue_A01_50");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10050")) {
                    return new StateGauge25(context);
                }

                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000885)) {
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
                context.SetEffect(arg1: new[] {5302, 5402, 5502}, arg2: true);
                context.ResetTimer(id: "10050");
            }

            public override TriggerState Execute() {
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
                context.SetUserValue(triggerId: 102, key: "Gauge", value: 25);
                context.ResetTimer(id: "10050");
                context.SetTimer(id: "10025", arg2: 15, arg3: true);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Interaction_tankskyblue_A01_25");
                context.SetActor(arg1: 4102, arg2: true, arg3: "Interaction_tankskyblue_A01_25");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10025")) {
                    return new StateGauge1(context);
                }

                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000885)) {
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
                context.SetEffect(arg1: new[] {5302, 5402, 5502}, arg2: true);
                context.ResetTimer(id: "10025");
            }

            public override TriggerState Execute() {
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
                context.ResetTimer(id: "10025");
                context.SetUserValue(triggerId: 102, key: "Gauge", value: 1);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Interaction_tankskyblue_A01_1");
                context.SetActor(arg1: 4102, arg2: true, arg3: "Interaction_tankskyblue_A01_1");
            }

            public override TriggerState Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000885)) {
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
                context.SetEffect(arg1: new[] {5302, 5402, 5502}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetUserValue(triggerId: 102, key: "StopSpawn", value: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
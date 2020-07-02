namespace Maple2.Trigger._02100002_bf {
    public static class _103_mobspawn_orange {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Gauge", value: 0);
                context.SetUserValue(key: "StopSpawn", value: 0);
                context.SetUserValue(key: "SpawnHold", value: 0);
                context.DestroyMonster(arg1: new[] {30100, 30075, 30050, 30025, 30001, 31001, 31002, 31003});
                context.SetEffect(arg1: new[] {5103, 5203}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Gauge") == 100) {
                    return new StateGauge100_Normal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge100_Normal : TriggerState {
            internal StateGauge100_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.CreateMonster(arg1: new[] {30100}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 75) {
                    return new StateGauge75_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge75_Normal : TriggerState {
            internal StateGauge75_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.CreateMonster(arg1: new[] {30075}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 100) {
                    return new StateGauge100_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 50) {
                    return new StateGauge50_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge50_Normal : TriggerState {
            internal StateGauge50_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.CreateMonster(arg1: new[] {30050}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 75) {
                    return new StateGauge75_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 25) {
                    return new StateGauge25_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge25_Normal : TriggerState {
            internal StateGauge25_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.CreateMonster(arg1: new[] {30025}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 50) {
                    return new StateGauge50_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 1) {
                    return new StateGauge1_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge1_Normal : TriggerState {
            internal StateGauge1_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.CreateMonster(arg1: new[] {30001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGauge_SpawnRamdom(context);
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    return new StateSpawnHold(context);
                }

                if (context.GetUserValue(key: "Gauge") == 25) {
                    return new StateGauge25_Normal(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawnHold : TriggerState {
            internal StateSpawnHold(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SpawnHold") == 0) {
                    return new StateBackToGaugeState(context);
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGauge_SpawnRamdom : TriggerState {
            internal StateGauge_SpawnRamdom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 100f, desc: "Normal")) {
                    return new StateSpawn_Normal(context);
                }

                if (context.RandomCondition(arg1: 5f, desc: "Eater")) {
                    return new StateSpawn_Eater(context);
                }

                if (context.RandomCondition(arg1: 10f, desc: "Runner")) {
                    return new StateSpawn_Runner(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Normal : TriggerState {
            internal StateSpawn_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateBackToGaugeState(context);
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Eater : TriggerState {
            internal StateSpawn_Eater(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5203}, arg2: true);
                context.CreateMonster(arg1: new[] {31001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateBackToGaugeState(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Runner : TriggerState {
            internal StateSpawn_Runner(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5203}, arg2: true);
                context.CreateMonster(arg1: new[] {31002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateBackToGaugeState(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBackToGaugeState : TriggerState {
            internal StateBackToGaugeState(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Gauge") == 100) {
                    return new StateGauge100_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 75) {
                    return new StateGauge75_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 50) {
                    return new StateGauge50_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 25) {
                    return new StateGauge25_Normal(context);
                }

                if (context.GetUserValue(key: "Gauge") == 1) {
                    return new StateGauge1_Normal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {30100, 30075, 30050, 30025, 30001, 31001, 31002, 31003});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
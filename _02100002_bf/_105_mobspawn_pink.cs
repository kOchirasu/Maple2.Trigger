namespace Maple2.Trigger._02100002_bf {
    public static class _105_mobspawn_pink {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Gauge", value: 0);
                context.SetUserValue(key: "StopSpawn", value: 0);
                context.SetUserValue(key: "SpawnHold", value: 0);
                context.DestroyMonster(arg1: new[] {50100, 50075, 50050, 50025, 50001, 51001, 51002, 51003});
                context.SetEffect(arg1: new[] {5105}, arg2: false);
                context.SetEffect(arg1: new[] {5205}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Gauge") == 100) {
                    context.State = new StateGauge100_Normal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge100_Normal : TriggerState {
            internal StateGauge100_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5105}, arg2: true);
                context.CreateMonster(arg1: new[] {50100}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateGauge_SpawnRamdom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    context.State = new StateSpawnHold(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 75) {
                    context.State = new StateGauge75_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge75_Normal : TriggerState {
            internal StateGauge75_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5105}, arg2: true);
                context.CreateMonster(arg1: new[] {50075}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateGauge_SpawnRamdom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    context.State = new StateSpawnHold(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 100) {
                    context.State = new StateGauge100_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 50) {
                    context.State = new StateGauge50_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge50_Normal : TriggerState {
            internal StateGauge50_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5105}, arg2: true);
                context.CreateMonster(arg1: new[] {50050}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateGauge_SpawnRamdom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    context.State = new StateSpawnHold(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 75) {
                    context.State = new StateGauge75_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 25) {
                    context.State = new StateGauge25_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge25_Normal : TriggerState {
            internal StateGauge25_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5105}, arg2: true);
                context.CreateMonster(arg1: new[] {50025}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateGauge_SpawnRamdom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    context.State = new StateSpawnHold(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 50) {
                    context.State = new StateGauge50_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 1) {
                    context.State = new StateGauge1_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge1_Normal : TriggerState {
            internal StateGauge1_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5105}, arg2: true);
                context.CreateMonster(arg1: new[] {50001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateGauge_SpawnRamdom(context);
                    return;
                }

                if (context.GetUserValue(key: "SpawnHold") == 1) {
                    context.State = new StateSpawnHold(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 25) {
                    context.State = new StateGauge25_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawnHold : TriggerState {
            internal StateSpawnHold(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SpawnHold") == 0) {
                    context.State = new StateBackToGaugeState(context);
                    return;
                }

                if (context.GetUserValue(key: "StopSpawn") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGauge_SpawnRamdom : TriggerState {
            internal StateGauge_SpawnRamdom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 100f, desc: "Normal")) {
                    context.State = new StateSpawn_Normal(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f, desc: "Eater")) {
                    context.State = new StateSpawn_Eater(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f, desc: "Runner")) {
                    context.State = new StateSpawn_Runner(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Normal : TriggerState {
            internal StateSpawn_Normal(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateBackToGaugeState(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Eater : TriggerState {
            internal StateSpawn_Eater(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5205}, arg2: true);
                context.CreateMonster(arg1: new[] {51001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateBackToGaugeState(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSpawn_Runner : TriggerState {
            internal StateSpawn_Runner(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5205}, arg2: true);
                context.CreateMonster(arg1: new[] {51002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateBackToGaugeState(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBackToGaugeState : TriggerState {
            internal StateBackToGaugeState(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Gauge") == 100) {
                    context.State = new StateGauge100_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 75) {
                    context.State = new StateGauge75_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 50) {
                    context.State = new StateGauge50_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 25) {
                    context.State = new StateGauge25_Normal(context);
                    return;
                }

                if (context.GetUserValue(key: "Gauge") == 1) {
                    context.State = new StateGauge1_Normal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {50100, 50075, 50050, 50025, 50001, 51001, 51002, 51003});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._82000012_survival {
    public static class _05_rarebox {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxOnCount", value: 0);
                context.SetUserValue(key: "RareBoxOff", value: 0);
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RareBoxOnCount") == 1) {
                    context.State = new StateDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 178000)) {
                    context.State = new StateBoxOnRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "RareBoxOff") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoxOnRandom : TriggerState {
            internal StateBoxOnRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateStartToTower01to10(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateStartToTower11to20(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateStartToTower21to30(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateStartToTower31to40(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartToTower01to10 : TriggerState {
            internal StateStartToTower01to10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTower01to10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartToTower11to20 : TriggerState {
            internal StateStartToTower11to20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 11);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTower11to20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartToTower21to30 : TriggerState {
            internal StateStartToTower21to30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 21);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTower21to30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartToTower31to40 : TriggerState {
            internal StateStartToTower31to40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 31);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTower31to40(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTower01to10 : TriggerState {
            internal StateTower01to10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000000, 10000001, 10000002, 10000003, 10000004, 10000005, 10000006, 10000007, 10000008, 10000009}, isStart: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RareBoxStartTowerNumber") == 11) {
                    context.State = new StateBoxOn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTower11to20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTower11to20 : TriggerState {
            internal StateTower11to20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000010, 10000011, 10000012, 10000013, 10000014, 10000015, 10000016, 10000017, 10000018, 10000019}, isStart: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RareBoxStartTowerNumber") == 21) {
                    context.State = new StateBoxOn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTower21to30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTower21to30 : TriggerState {
            internal StateTower21to30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000020, 10000021, 10000022, 10000023, 10000024, 10000025, 10000026, 10000027, 10000028, 10000029}, isStart: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RareBoxStartTowerNumber") == 31) {
                    context.State = new StateBoxOn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTower31to40(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTower31to40 : TriggerState {
            internal StateTower31to40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000030, 10000031, 10000032, 10000033, 10000034, 10000035, 10000036, 10000037, 10000038, 10000039}, isStart: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RareBoxStartTowerNumber") == 1) {
                    context.State = new StateBoxOn(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTower01to10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoxOn : TriggerState {
            internal StateBoxOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 5000, script: "$82000012_survival__05_RAREBOX__0$");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RareBoxOff") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {10000000, 10000001, 10000002, 10000003, 10000004, 10000005, 10000006, 10000007, 10000008, 10000009, 10000010, 10000011, 10000012, 10000013, 10000014, 10000015, 10000016, 10000017, 10000018, 10000019, 10000020, 10000021, 10000022, 10000023, 10000024, 10000025, 10000026, 10000027, 10000028, 10000029, 10000030, 10000031, 10000032, 10000033, 10000034, 10000035, 10000036, 10000037, 10000038, 10000039}, isStart: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
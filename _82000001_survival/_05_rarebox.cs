using System;

namespace Maple2.Trigger._82000001_survival {
    public static class _05_rarebox {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000165, 10000166, 10000167, 10000168, 10000169, 10000170, 10000171, 10000172, 10000173,
                        10000174, 10000175, 10000176, 10000177, 10000178, 10000179, 10000180, 10000181, 10000182,
                        10000183, 10000184, 10000185, 10000186, 10000187, 10000188, 10000189, 10000190, 10000191,
                        10000192, 10000193, 10000194, 10000195, 10000196, 10000197, 10000198, 10000199, 10000200,
                        10000201, 10000202, 10000203, 10000204
                    }, isStart: "false");
                context.SetUserValue(key: "RareBoxOnCount", value: 0);
                context.SetUserValue(key: "RareBoxOff", value: 0);
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "RareBoxOnCount", value: 1)) {
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

                if (context.UserValue(key: "RareBoxOff", value: 1)) {
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
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000165, 10000166, 10000167, 10000168, 10000169, 10000170, 10000171, 10000172, 10000173,
                        10000174
                    }, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "RareBoxStartTowerNumber", value: 11)) {
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
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000175, 10000176, 10000177, 10000178, 10000179, 10000180, 10000181, 10000182, 10000183,
                        10000184
                    }, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "RareBoxStartTowerNumber", value: 21)) {
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
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000185, 10000186, 10000187, 10000188, 10000189, 10000190, 10000191, 10000192, 10000193,
                        10000194
                    }, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "RareBoxStartTowerNumber", value: 31)) {
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
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000195, 10000196, 10000197, 10000198, 10000199, 10000200, 10000201, 10000202, 10000203,
                        10000204
                    }, isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "RareBoxStartTowerNumber", value: 1)) {
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
                context.SideNpcTalk(npcID: 23500110, illust: "Mushking_normal", duration: 5000,
                    script: "$82000000_survival__05_RAREBOX__0$");
            }

            public override void Execute() {
                if (context.UserValue(key: "RareBoxOff", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000165, 10000166, 10000167, 10000168, 10000169, 10000170, 10000171, 10000172, 10000173,
                        10000174, 10000175, 10000176, 10000177, 10000178, 10000179, 10000180, 10000181, 10000182,
                        10000183, 10000184, 10000185, 10000186, 10000187, 10000188, 10000189, 10000190, 10000191,
                        10000192, 10000193, 10000194, 10000195, 10000196, 10000197, 10000198, 10000199, 10000200,
                        10000201, 10000202, 10000203, 10000204
                    }, isStart: "false");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._82000003_survival {
    public static class _05_rarebox {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000342, 10000343, 10000344, 10000345, 10000346, 10000347, 10000348, 10000349, 10000350, 10000351, 10000352, 10000353, 10000354, 10000355, 10000356, 10000357, 10000358, 10000359, 10000360, 10000361, 10000362, 10000363, 10000364, 10000365, 10000366, 10000367, 10000368, 10000369, 10000370, 10000371, 10000372, 10000373, 10000374, 10000375, 10000376, 10000377, 10000378, 10000379, 10000380, 10000381}, isStart: false);
                context.SetUserValue(key: "RareBoxOnCount", value: 0);
                context.SetUserValue(key: "RareBoxOff", value: 0);
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RareBoxOnCount") == 1) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 178000)) {
                    return new StateBoxOnRandom(context);
                }

                if (context.GetUserValue(key: "RareBoxOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoxOnRandom : TriggerState {
            internal StateBoxOnRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25f)) {
                    return new StateStartToTower01to10(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateStartToTower11to20(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateStartToTower21to30(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateStartToTower31to40(context);
                }

                if (context.GetUserValue(key: "RareBoxOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartToTower01to10 : TriggerState {
            internal StateStartToTower01to10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateTower01to10(context);
            }

            public override void OnExit() { }
        }

        private class StateStartToTower11to20 : TriggerState {
            internal StateStartToTower11to20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 11);
            }

            public override TriggerState? Execute() {
                return new StateTower11to20(context);
            }

            public override void OnExit() { }
        }

        private class StateStartToTower21to30 : TriggerState {
            internal StateStartToTower21to30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 21);
            }

            public override TriggerState? Execute() {
                return new StateTower21to30(context);
            }

            public override void OnExit() { }
        }

        private class StateStartToTower31to40 : TriggerState {
            internal StateStartToTower31to40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RareBoxStartTowerNumber", value: 31);
            }

            public override TriggerState? Execute() {
                return new StateTower31to40(context);
            }

            public override void OnExit() { }
        }

        private class StateTower01to10 : TriggerState {
            internal StateTower01to10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000342, 10000343, 10000344, 10000345, 10000346, 10000347, 10000348, 10000349, 10000350, 10000351}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RareBoxStartTowerNumber") == 11) {
                    return new StateBoxOn(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateTower11to20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTower11to20 : TriggerState {
            internal StateTower11to20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000352, 10000353, 10000354, 10000355, 10000356, 10000357, 10000358, 10000359, 10000360, 10000361}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RareBoxStartTowerNumber") == 21) {
                    return new StateBoxOn(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateTower21to30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTower21to30 : TriggerState {
            internal StateTower21to30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000362, 10000363, 10000364, 10000365, 10000366, 10000367, 10000368, 10000369, 10000370, 10000371}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RareBoxStartTowerNumber") == 31) {
                    return new StateBoxOn(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateTower31to40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTower31to40 : TriggerState {
            internal StateTower31to40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000372, 10000373, 10000374, 10000375, 10000376, 10000377, 10000378, 10000379, 10000380, 10000381}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RareBoxStartTowerNumber") == 1) {
                    return new StateBoxOn(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateTower01to10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoxOn : TriggerState {
            internal StateBoxOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 5000, script: "$82000002_survival__05_RAREBOX__0$");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RareBoxOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{10000342, 10000343, 10000344, 10000345, 10000346, 10000347, 10000348, 10000349, 10000350, 10000351, 10000352, 10000353, 10000354, 10000355, 10000356, 10000357, 10000358, 10000359, 10000360, 10000361, 10000362, 10000363, 10000364, 10000365, 10000366, 10000367, 10000368, 10000369, 10000370, 10000371, 10000372, 10000373, 10000374, 10000375, 10000376, 10000377, 10000378, 10000379, 10000380, 10000381}, isStart: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

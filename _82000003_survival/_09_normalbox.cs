using System;

namespace Maple2.Trigger._82000003_survival {
    public static class _09_normalbox {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000382, 10000383, 10000384, 10000385, 10000386, 10000387, 10000388, 10000389, 10000390,
                        10000391, 10000392, 10000393, 10000394, 10000395, 10000396, 10000397, 10000398, 10000399,
                        10000400, 10000401, 10000402, 10000403, 10000404, 10000405, 10000406, 10000407, 10000408,
                        10000409, 10000410, 10000411, 10000412, 10000413, 10000414, 10000415, 10000416, 10000417,
                        10000418, 10000419, 10000420, 10000421, 10000422, 10000423, 10000424, 10000425, 10000426,
                        10000427, 10000428, 10000429, 10000430, 10000431, 10000432, 10000433, 10000434, 10000435
                    }, isStart: "true");
                context.StartCombineSpawn(
                    groupId: new int[]
                        {10000440, 10000442, 10000444, 10000445, 10000446, 10000448, 10000449, 10000451, 10000452},
                    isStart: "true");
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000454, 10000455, 10000456, 10000457, 10000458, 10000459, 10000460, 10000461, 10000462,
                        10000463, 10000464, 10000465, 10000466, 10000467, 10000468, 10000469, 10000470, 10000471,
                        10000472, 10000473, 10000474, 10000475, 10000476, 10000477, 10000478, 10000479, 10000480,
                        10000481, 10000482, 10000483, 10000484, 10000485, 10000486, 10000487, 10000488, 10000489,
                        10000490, 10000491, 10000492, 10000493, 10000494, 10000495, 10000496, 10000497, 10000498,
                        10000499, 10000500, 10000501, 10000502, 10000503, 10000504, 10000505, 10000506
                    }, isStart: "true");
                context.SetUserValue(key: "NormaBoxOnCount", value: 0);
                context.SetUserValue(key: "NormaBoxOff", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "NormaBoxOnCount", value: 1)) {
                    context.State = new StateDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new int[]
                        {10000436, 10000437, 10000438, 10000439, 10000441, 10000443, 10000447, 10000450, 10000453},
                    isStart: "true");
            }

            public override void Execute() {
                if (context.UserValue(key: "NormaBoxOff", value: 1)) {
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
                        10000382, 10000383, 10000384, 10000385, 10000386, 10000387, 10000388, 10000389, 10000390,
                        10000391, 10000392, 10000393, 10000394, 10000395, 10000396, 10000397, 10000398, 10000399,
                        10000400, 10000401, 10000402, 10000403, 10000404, 10000405, 10000406, 10000407, 10000408,
                        10000409, 10000410, 10000411, 10000412, 10000413, 10000414, 10000415, 10000416, 10000417,
                        10000418, 10000419, 10000420, 10000421, 10000422, 10000423, 10000424, 10000425, 10000426,
                        10000427, 10000428, 10000429, 10000430, 10000431, 10000432, 10000433, 10000434, 10000435,
                        10000436, 10000437, 10000438, 10000439, 10000440, 10000441, 10000442, 10000443, 10000444,
                        10000445, 10000446, 10000447, 10000448, 10000449, 10000450, 10000451, 10000452, 10000453,
                        10000454, 10000455, 10000456, 10000457, 10000458, 10000459, 10000460, 10000461, 10000462,
                        10000463, 10000464, 10000465, 10000466, 10000467, 10000468, 10000469, 10000470, 10000471,
                        10000472, 10000473, 10000474, 10000475, 10000476, 10000477, 10000478, 10000479, 10000480,
                        10000481, 10000482, 10000483, 10000484, 10000485, 10000486, 10000487, 10000488, 10000489,
                        10000490, 10000491, 10000492, 10000493, 10000494, 10000495, 10000496, 10000497, 10000498,
                        10000499, 10000500, 10000501, 10000502, 10000503, 10000504, 10000505, 10000506
                    }, isStart: "false");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
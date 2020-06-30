using System;

namespace Maple2.Trigger._82000006_survival {
    public static class _09_normalbox {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000040, 10000041, 10000042, 10000043, 10000044, 10000045, 10000046, 10000047, 10000048,
                        10000049, 10000050, 10000051, 10000052, 10000053, 10000054, 10000055, 10000056, 10000057,
                        10000058, 10000059, 10000060, 10000061, 10000062, 10000063, 10000064, 10000065, 10000066,
                        10000067, 10000068, 10000069, 10000070, 10000071, 10000072, 10000073, 10000074, 10000075,
                        10000076, 10000077, 10000078, 10000079, 10000080, 10000081, 10000082, 10000083, 10000084,
                        10000085, 10000086, 10000087, 10000088, 10000089, 10000090, 10000091, 10000092, 10000093
                    }, isStart: "true");
                context.StartCombineSpawn(
                    groupId: new int[]
                        {10000098, 10000100, 10000102, 10000103, 10000104, 10000106, 10000107, 10000109, 10000110},
                    isStart: "true");
                context.StartCombineSpawn(
                    groupId: new int[] {
                        10000112, 10000113, 10000114, 10000115, 10000116, 10000117, 10000118, 10000119, 10000120,
                        10000121, 10000122, 10000123, 10000124, 10000125, 10000126, 10000127, 10000128, 10000129,
                        10000130, 10000131, 10000132, 10000133, 10000134, 10000135, 10000136, 10000137, 10000138,
                        10000139, 10000140, 10000141, 10000142, 10000143, 10000144, 10000145, 10000146, 10000147,
                        10000148, 10000149, 10000150, 10000151, 10000152, 10000153, 10000154, 10000155, 10000156,
                        10000157, 10000158, 10000159, 10000160, 10000161, 10000162, 10000163, 10000164
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
                        {10000094, 10000095, 10000096, 10000097, 10000099, 10000101, 10000105, 10000108, 10000111},
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
                        10000040, 10000041, 10000042, 10000043, 10000044, 10000045, 10000046, 10000047, 10000048,
                        10000049, 10000050, 10000051, 10000052, 10000053, 10000054, 10000055, 10000056, 10000057,
                        10000058, 10000059, 10000060, 10000061, 10000062, 10000063, 10000064, 10000065, 10000066,
                        10000067, 10000068, 10000069, 10000070, 10000071, 10000072, 10000073, 10000074, 10000075,
                        10000076, 10000077, 10000078, 10000079, 10000080, 10000081, 10000082, 10000083, 10000084,
                        10000085, 10000086, 10000087, 10000088, 10000089, 10000090, 10000091, 10000092, 10000093,
                        10000094, 10000095, 10000096, 10000097, 10000098, 10000099, 10000100, 10000101, 10000102,
                        10000103, 10000104, 10000105, 10000106, 10000107, 10000108, 10000109, 10000110, 10000111,
                        10000112, 10000113, 10000114, 10000115, 10000116, 10000117, 10000118, 10000119, 10000120,
                        10000121, 10000122, 10000123, 10000124, 10000125, 10000126, 10000127, 10000128, 10000129,
                        10000130, 10000131, 10000132, 10000133, 10000134, 10000135, 10000136, 10000137, 10000138,
                        10000139, 10000140, 10000141, 10000142, 10000143, 10000144, 10000145, 10000146, 10000147,
                        10000148, 10000149, 10000150, 10000151, 10000152, 10000153, 10000154, 10000155, 10000156,
                        10000157, 10000158, 10000159, 10000160, 10000161, 10000162, 10000163, 10000164
                    }, isStart: "true");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
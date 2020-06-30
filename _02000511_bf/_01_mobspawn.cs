using System;

namespace Maple2.Trigger._02000511_bf {
    public static class _01_mobspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {
                    101, 102, 103, 104, 105, 106, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124, 125, 126, 201, 202,
                    203, 204, 205, 206, 207, 211, 212, 213, 214, 215, 216, 221, 222, 223, 224, 225, 226, 301, 302, 303,
                    304, 305, 306, 307, 311, 312, 313, 314, 315, 316, 321, 322, 323, 324, 325, 326, 401, 402, 403, 404,
                    405, 406, 407, 408, 411, 412, 413, 414, 415, 416, 421, 422, 423, 424, 425, 426, 501, 502, 503, 504,
                    505, 506, 507, 508, 509, 511, 512, 513, 514, 515, 516, 521, 522, 523, 524, 525, 526
                });
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetMesh(
                    arg1: new int[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4001, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4002, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4003, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4004, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 4005, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101, 3110, 3111}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3102, 3120, 3121}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3103, 3130, 3131}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3104, 3140, 3141}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3105, 3150, 3151}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5110, 5111, 5112, 5113}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5210, 5211, 5212, 5213}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5310, 5311, 5312, 5313}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5410, 5411, 5412, 5413}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5510, 5511, 5512, 5513, 5514, 5515}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMeshAnimation(arg1: new int[] {5110, 5111, 5112, 5113}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {5210, 5211, 5212, 5213}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {5310, 5311, 5312, 5313}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {5410, 5411, 5412, 5413}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new int[] {5510, 5511, 5512, 5513, 5514, 5515}, arg2: true, arg3: 0,
                    arg4: 0);
                context.SetAgent(arg1: "8100,8101,8102,8103,8104,8105,8106,8107,8108", arg2: true);
                context.SetAgent(arg1: "8200,8201,8202,8203,8204,8205,8206,8207,8208,8209,8210,8211,8212", arg2: true);
                context.SetAgent(arg1: "8300.8301.8302.8303.8304.8305.8306.8307.8308.8309.8310.8311.8312", arg2: true);
                context.SetAgent(arg1: "8400.8401.8402.8403.8404.8405.8406.8407.8408.8409.8410.8411.8412", arg2: true);
                context.SetAgent(arg1: "8500.8501.8502.8503.8504.8505.8506.8507.8508.8509.8510.8511.8512", arg2: true);
                context.SetAgent(arg1: "8600.8601.8602.8603.8604.8605.8606.8607.8608.8609.8610.8611.8612", arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002, 5100, 5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5003, 5200, 5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5004, 5300, 5301}, arg2: false);
                context.SetEffect(arg1: new int[] {5005, 5400, 5401}, arg2: false);
                context.SetEffect(arg1: new int[] {5006, 5500, 5501}, arg2: false);
                context.SetEffect(arg1: new int[] {5007, 5008, 5009}, arg2: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateDungeonStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new StateStageEnter(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStageEnter : TriggerState {
            internal StateStageEnter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateStage01MobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage01MobSpawn : TriggerState {
            internal StateStage01MobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[]
                        {101, 102, 103, 104, 105, 106, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124, 125, 126},
                    arg2: false);
                context.SetAgent(arg1: "8100,8101,8102,8103,8104,8105,8106,8107,8108", arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {101, 102, 103, 104, 105, 106, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124, 125, 126})) {
                    context.State = new StateStage01DoorOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage01DoorOpen : TriggerState {
            internal StateStage01DoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4001, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3101, 3110, 3111}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5110, 5111, 5112, 5113}, arg2: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(arg1: new int[] {5110, 5111, 5112, 5113}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5002, 5100, 5101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateStage02MobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage02MobSpawn : TriggerState {
            internal StateStage02MobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[]
                        {201, 202, 203, 204, 205, 206, 207, 211, 212, 213, 214, 215, 216, 221, 222, 223, 224, 225, 226},
                    arg2: false);
                context.SetAgent(arg1: "8200,8201,8202,8203,8204,8205,8206,8207,8208,8209,8210,8211,8212", arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {201, 202, 203, 204, 205, 206, 207, 211, 212, 213, 214, 215, 216, 221, 222, 223, 224, 225, 226})) {
                    context.State = new StateStage02DoorOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage02DoorOpen : TriggerState {
            internal StateStage02DoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3102, 3120, 3121}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5210, 5211, 5212, 5213}, arg2: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(arg1: new int[] {5210, 5211, 5212, 5213}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5003, 5200, 5201}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateStage03MobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage03MobSpawn : TriggerState {
            internal StateStage03MobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[]
                        {301, 302, 303, 304, 305, 306, 307, 311, 312, 313, 314, 315, 316, 321, 322, 323, 324, 325, 326},
                    arg2: false);
                context.SetAgent(arg1: "8300.8301.8302.8303.8304.8305.8306.8307.8308.8309.8310.8311.8312", arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {301, 302, 303, 304, 305, 306, 307, 311, 312, 313, 314, 315, 316, 321, 322, 323, 324, 325, 326})) {
                    context.State = new StateStage03DoorOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage03DoorOpen : TriggerState {
            internal StateStage03DoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4003, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3103, 3130, 3131}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5310, 5311, 5312, 5313}, arg2: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(arg1: new int[] {5310, 5311, 5312, 5313}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5004, 5300, 5301}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateStage04MobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage04MobSpawn : TriggerState {
            internal StateStage04MobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[] {
                        401, 402, 403, 404, 405, 406, 407, 408, 411, 412, 413, 414, 415, 416, 421, 422, 423, 424, 425,
                        426
                    }, arg2: false);
                context.SetAgent(arg1: "8400.8401.8402.8403.8404.8405.8406.8407.8408.8409.8410.8411.8412", arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    401, 402, 403, 404, 405, 406, 407, 408, 411, 412, 413, 414, 415, 416, 421, 422, 423, 424, 425, 426
                })) {
                    context.State = new StateStage04DoorOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage04DoorOpen : TriggerState {
            internal StateStage04DoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4004, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3104, 3140, 3141}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5410, 5411, 5412, 5413}, arg2: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(arg1: new int[] {5410, 5411, 5412, 5413}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new int[] {5005, 5400, 5401}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateStage05MobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage05MobSpawn : TriggerState {
            internal StateStage05MobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(
                    arg1: new int[] {
                        501, 502, 503, 504, 505, 506, 507, 508, 509, 511, 512, 513, 514, 515, 516, 521, 522, 523, 524,
                        525, 526
                    }, arg2: false);
                context.SetAgent(arg1: "8500.8501.8502.8503.8504.8505.8506.8507.8508.8509.8510.8511.8512", arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    501, 502, 503, 504, 505, 506, 507, 508, 509, 511, 512, 513, 514, 515, 516, 521, 522, 523, 524, 525,
                    526
                })) {
                    context.State = new StateStage05DoorOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStage05DoorOpen : TriggerState {
            internal StateStage05DoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4005, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {3105, 3150, 3151}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {5510, 5511, 5512, 5513, 5514, 5515}, arg2: false, arg3: 500, arg4: 0,
                    arg5: 5f);
                context.SetMeshAnimation(arg1: new int[] {5510, 5511, 5512, 5513, 5514, 5515}, arg2: false, arg3: 0,
                    arg4: 0);
                context.SetEffect(arg1: new int[] {5006, 5500, 5501}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBossStagePortalOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossStagePortalOpen : TriggerState {
            internal StateBossStagePortalOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8600.8601.8602.8603.8604.8605.8606.8607.8608.8609.8610.8611.8612", arg2: false);
                context.SetEffect(arg1: new int[] {5007, 5008, 5009}, arg2: true);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: false);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
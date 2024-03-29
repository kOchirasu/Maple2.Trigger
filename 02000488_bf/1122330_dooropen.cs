namespace Maple2.Trigger._02000488_bf {
    public static class _1122330_dooropen {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 111, 112, 113, 114, 115, 116, 121, 122, 123, 124, 125, 126, 201, 202, 203, 204, 205, 206, 207, 211, 212, 213, 214, 215, 216, 221, 222, 223, 224, 225, 226, 301, 302, 303, 304, 305, 306, 307, 311, 312, 313, 314, 315, 316, 321, 322, 323, 324, 325, 326, 401, 402, 403, 404, 405, 406, 407, 408, 411, 412, 413, 414, 415, 416, 421, 422, 423, 424, 425, 426, 501, 502, 503, 504, 505, 506, 507, 508, 509, 511, 512, 513, 514, 515, 516, 521, 522, 523, 524, 525, 526});
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4001, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4003, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4004, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{3100, 3101, 3110, 3111, 3102, 3120, 3121, 3103, 3130, 3131, 3104, 3140, 3141, 3105, 3150, 3151, 5110, 5111, 5112, 5113, 5210, 5211, 5212, 5213, 5310, 5311, 5312, 5313, 5410, 5411, 5412, 5413, 5510, 5511, 5512, 5513, 5514, 5515}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{5110, 5111, 5112, 5113, 5210, 5211, 5212, 5213, 5310, 5311, 5312, 5313, 5410, 5411, 5412, 5413, 5510, 5511, 5512, 5513, 5514, 5515}, visible: true, arg3: 0, arg4: 0);
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8200, 8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212, 8300, 8301, 8302, 8303, 8304, 8305, 8306, 8307, 8308, 8309, 8310, 8311, 8312, 8400, 8401, 8402, 8403, 8404, 8405, 8406, 8407, 8408, 8409, 8410, 8411, 8412, 8500, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8511, 8512, 8600, 8601, 8602, 8603, 8604, 8605, 8606, 8607, 8608, 8609, 8610, 8611, 8612}, visible: true);
                context.SetEffect(triggerIds: new []{5001, 5002, 5100, 5101, 5003, 5200, 5201, 5004, 5300, 5301, 5005, 5400, 5401, 5006, 5500, 5501, 5007, 5008, 5009}, visible: false);
                context.SetUserValue(key: "StageClear01", value: 0);
                context.SetUserValue(key: "StageClear02", value: 0);
                context.SetUserValue(key: "StageClear03", value: 0);
                context.SetUserValue(key: "StageClear04", value: 0);
                context.SetUserValue(key: "StageClear05", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDungeonStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateStageEnter(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStageEnter : TriggerState {
            internal StateStageEnter(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108}, visible: false);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3100}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StageClear01") == 1) {
                    return new StateStageClear01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStageClear01 : TriggerState {
            internal StateStageClear01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8200, 8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212}, visible: false);
                context.SetActor(triggerId: 4001, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3101, 3110, 3111}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{5110, 5111, 5112, 5113}, visible: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(triggerIds: new []{5110, 5111, 5112, 5113}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5002, 5100, 5101}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StageClear02") == 1) {
                    return new StateStageClear02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStageClear02 : TriggerState {
            internal StateStageClear02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8300, 8301, 8302, 8303, 8304, 8305, 8306, 8307, 8308, 8309, 8310, 8311, 8312}, visible: false);
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3102, 3120, 3121}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{5210, 5211, 5212, 5213}, visible: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(triggerIds: new []{5210, 5211, 5212, 5213}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5003, 5200, 5201}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StageClear03") == 1) {
                    return new StateStageClear03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStageClear03 : TriggerState {
            internal StateStageClear03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8400, 8401, 8402, 8403, 8404, 8405, 8406, 8407, 8408, 8409, 8410, 8411, 8412}, visible: false);
                context.SetActor(triggerId: 4003, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3103, 3130, 3131}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{5310, 5311, 5312, 5313}, visible: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(triggerIds: new []{5310, 5311, 5312, 5313}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5004, 5300, 5301}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StageClear04") == 1) {
                    return new StateStageClear04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStageClear04 : TriggerState {
            internal StateStageClear04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8500, 8501, 8502, 8503, 8504, 8505, 8506, 8507, 8508, 8509, 8510, 8511, 8512}, visible: false);
                context.SetActor(triggerId: 4004, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3104, 3140, 3141}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{5410, 5411, 5412, 5413}, visible: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(triggerIds: new []{5410, 5411, 5412, 5413}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5005, 5400, 5401}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StageClear05") == 1) {
                    return new StateStageClear05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStageClear05 : TriggerState {
            internal StateStageClear05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8600, 8601, 8602, 8603, 8604, 8605, 8606, 8607, 8608, 8609, 8610, 8611, 8612}, visible: false);
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{3105, 3150, 3151}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{5510, 5511, 5512, 5513, 5514, 5515}, visible: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(triggerIds: new []{5510, 5511, 5512, 5513, 5514, 5515}, visible: false, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5006, 5500, 5501}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossStagePortalOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossStagePortalOpen : TriggerState {
            internal StateBossStagePortalOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8600, 8601, 8602, 8603, 8604, 8605, 8606, 8607, 8608, 8609, 8610, 8611, 8612}, visible: false);
                context.SetEffect(triggerIds: new []{5007, 5008, 5009}, visible: true);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

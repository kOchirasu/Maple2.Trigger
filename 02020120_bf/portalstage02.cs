namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage02 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage02", value: 0);
                context.SetPortal(portalId: 2101, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2201, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2301, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3101, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3102, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3103, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3104, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3201, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3202, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3203, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3301, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3302, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3303, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3304, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3305, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3306, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4101, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4102, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4201, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4202, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4301, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4302, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5101, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5102, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5201, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5202, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5203, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5204, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5205, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5206, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5301, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5302, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5303, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5304, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5401, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6101, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6201, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6301, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6302, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6303, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6304, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateStage2_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_시작 : TriggerState {
            internal StateStage2_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Stage02") == 11) {
                    return new StateStage2_왼쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage02") == 21) {
                    return new StateStage2_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage02") == 31) {
                    return new StateStage2_오른쪽진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_왼쪽진행 : TriggerState {
            internal StateStage2_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2101, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_가운데진행 : TriggerState {
            internal StateStage2_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2201, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_오른쪽진행 : TriggerState {
            internal StateStage2_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2301, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State혹시모를_Dungeon리셋신호_Wait : TriggerState {
            internal State혹시모를_Dungeon리셋신호_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage05 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage05", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateStage5_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_시작 : TriggerState {
            internal StateStage5_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Stage05") == 11) {
                    return new StateStage5_왼쪽_왼쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 21) {
                    return new StateStage5_왼쪽가운데_왼쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 22) {
                    return new StateStage5_왼쪽가운데_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 31) {
                    return new StateStage5_오른쪽가운데_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 32) {
                    return new StateStage5_오른쪽가운데_오른쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage05") == 41) {
                    return new StateStage5_오른쪽_오른쪽진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_왼쪽_왼쪽진행 : TriggerState {
            internal StateStage5_왼쪽_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5101, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5102, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_왼쪽가운데_왼쪽진행 : TriggerState {
            internal StateStage5_왼쪽가운데_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5201, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5202, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5203, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_왼쪽가운데_가운데진행 : TriggerState {
            internal StateStage5_왼쪽가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5204, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5205, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5206, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_오른쪽가운데_가운데진행 : TriggerState {
            internal StateStage5_오른쪽가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5301, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5302, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_오른쪽가운데_오른쪽진행 : TriggerState {
            internal StateStage5_오른쪽가운데_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5303, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5304, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage5_오른쪽_오른쪽진행 : TriggerState {
            internal StateStage5_오른쪽_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5401, visible: true, enabled: true, minimapVisible: true);
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

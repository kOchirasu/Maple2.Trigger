namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage03 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage03", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateStage3_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_시작 : TriggerState {
            internal StateStage3_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Stage03") == 11) {
                    return new StateStage3_왼쪽_왼쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage03") == 12) {
                    return new StateStage3_왼쪽_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage03") == 21) {
                    return new StateStage3_가운데_왼쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage03") == 22) {
                    return new StateStage3_가운데_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage03") == 23) {
                    return new StateStage3_가운데_오른쪽진행(context);
                }

                if (context.GetUserValue(key: "Stage03") == 31) {
                    return new StateStage3_오른쪽_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage03") == 32) {
                    return new StateStage3_오른쪽_오른쪽진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_왼쪽_왼쪽진행 : TriggerState {
            internal StateStage3_왼쪽_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3101, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3102, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_왼쪽_가운데진행 : TriggerState {
            internal StateStage3_왼쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3103, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3104, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_가운데_왼쪽진행 : TriggerState {
            internal StateStage3_가운데_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3201, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_가운데_가운데진행 : TriggerState {
            internal StateStage3_가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3202, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_가운데_오른쪽진행 : TriggerState {
            internal StateStage3_가운데_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3203, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_오른쪽_가운데진행 : TriggerState {
            internal StateStage3_오른쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3301, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3302, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3303, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_오른쪽_오른쪽진행 : TriggerState {
            internal StateStage3_오른쪽_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 3304, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3305, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 3306, visible: true, enabled: true, minimapVisible: true);
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

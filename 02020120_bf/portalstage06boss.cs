namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage06boss {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage06", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateStage6_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage6_시작 : TriggerState {
            internal StateStage6_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Stage06") == 11) {
                    return new StateStage6_왼쪽_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage06") == 21) {
                    return new StateStage6_가운데_가운데진행(context);
                }

                if (context.GetUserValue(key: "Stage06") == 31) {
                    return new StateStage6_오른쪽_가운데진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage6_왼쪽_가운데진행 : TriggerState {
            internal StateStage6_왼쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6101, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage6_가운데_가운데진행 : TriggerState {
            internal StateStage6_가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6201, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_Dungeon리셋신호_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage6_오른쪽_가운데진행 : TriggerState {
            internal StateStage6_오른쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6301, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6302, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6303, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6304, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
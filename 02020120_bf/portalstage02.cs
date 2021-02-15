namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage02 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage02", value: 0);
                context.SetPortal(arg1: 2101, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2201, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2301, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3101, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3102, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3103, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3104, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3201, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3202, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3203, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3301, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3302, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3303, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3304, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3305, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3306, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4101, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4102, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4201, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4202, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4301, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4302, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5101, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5102, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5201, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5202, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5203, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5204, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5205, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5206, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5301, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5302, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5303, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5304, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5401, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6101, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6201, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6301, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6302, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6303, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6304, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateStage2_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage2_시작 : TriggerState {
            internal StateStage2_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 2101, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 2201, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 2301, arg2: true, arg3: true, arg4: true);
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
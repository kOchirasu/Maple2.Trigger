namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage03 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage03", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateStage3_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_시작 : TriggerState {
            internal StateStage3_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 3101, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3102, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_왼쪽_가운데진행 : TriggerState {
            internal StateStage3_왼쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3103, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3104, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_가운데_왼쪽진행 : TriggerState {
            internal StateStage3_가운데_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3201, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_가운데_가운데진행 : TriggerState {
            internal StateStage3_가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3202, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_가운데_오른쪽진행 : TriggerState {
            internal StateStage3_가운데_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3203, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_오른쪽_가운데진행 : TriggerState {
            internal StateStage3_오른쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3302, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3303, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStage3_오른쪽_오른쪽진행 : TriggerState {
            internal StateStage3_오른쪽_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3304, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3305, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3306, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State혹시모를_던전리셋신호_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State혹시모를_던전리셋신호_대기 : TriggerState {
            internal State혹시모를_던전리셋신호_대기(ITriggerContext context) : base(context) { }

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
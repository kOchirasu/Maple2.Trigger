using System;

namespace Maple2.Trigger._02020120_bf {
    public static class _portalstage03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "Stage03", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
                    context.State = new State스테이지3_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지3_시작 : TriggerState {
            internal State스테이지3_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Stage03", value: 11)) {
                    context.State = new State스테이지3_왼쪽_왼쪽진행(context);
                    return;
                }

                if (context.UserValue(key: "Stage03", value: 12)) {
                    context.State = new State스테이지3_왼쪽_가운데진행(context);
                    return;
                }

                if (context.UserValue(key: "Stage03", value: 21)) {
                    context.State = new State스테이지3_가운데_왼쪽진행(context);
                    return;
                }

                if (context.UserValue(key: "Stage03", value: 22)) {
                    context.State = new State스테이지3_가운데_가운데진행(context);
                    return;
                }

                if (context.UserValue(key: "Stage03", value: 23)) {
                    context.State = new State스테이지3_가운데_오른쪽진행(context);
                    return;
                }

                if (context.UserValue(key: "Stage03", value: 31)) {
                    context.State = new State스테이지3_오른쪽_가운데진행(context);
                    return;
                }

                if (context.UserValue(key: "Stage03", value: 32)) {
                    context.State = new State스테이지3_오른쪽_오른쪽진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지3_왼쪽_왼쪽진행 : TriggerState {
            internal State스테이지3_왼쪽_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3101, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3102, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지3_왼쪽_가운데진행 : TriggerState {
            internal State스테이지3_왼쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3103, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3104, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지3_가운데_왼쪽진행 : TriggerState {
            internal State스테이지3_가운데_왼쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3201, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지3_가운데_가운데진행 : TriggerState {
            internal State스테이지3_가운데_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3202, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지3_가운데_오른쪽진행 : TriggerState {
            internal State스테이지3_가운데_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3203, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지3_오른쪽_가운데진행 : TriggerState {
            internal State스테이지3_오른쪽_가운데진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3301, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3302, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3303, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스테이지3_오른쪽_오른쪽진행 : TriggerState {
            internal State스테이지3_오른쪽_오른쪽진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3304, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3305, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3306, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State혹시모를_던전리셋신호_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State혹시모를_던전리셋신호_대기 : TriggerState {
            internal State혹시모를_던전리셋신호_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "DungeonReset", value: 1)) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
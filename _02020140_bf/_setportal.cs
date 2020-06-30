using System;

namespace Maple2.Trigger._02020140_bf {
    public static class _setportal {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State전투체크(context);

        private class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State대기99(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기99 : TriggerState {
            internal State대기99(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 118, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 128, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 138, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 218, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 228, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 238, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 318, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 328, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 338, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 428, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new State포탈생성(context);
                    return;
                }

                if (context.UserValue(key: "SetLight", value: 1)) {
                    context.State = new State포탈생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈생성 : TriggerState {
            internal State포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 118, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 128, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 138, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 218, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 228, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 238, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 318, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 328, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 338, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 428, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
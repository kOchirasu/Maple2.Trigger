using System;

namespace Maple2.Trigger._02020142_bf {
    public static class _timecheck {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State던전시간체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전시간체크 : TriggerState {
            internal State던전시간체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 41, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 42, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 43, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 44, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 45, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 46, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 47, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 48, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 49, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.DungeonTimeOut()) {
                    context.State = new State던전실패(context);
                    return;
                }

                if (context.DungeonCheckState(checkState: "Fail")) {
                    context.State = new State던전실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DestroyMonster(arg1: new int[] {-1});
                context.SetPortal(arg1: 41, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 42, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 43, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 44, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 45, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 46, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 47, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 48, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 49, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonFail();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
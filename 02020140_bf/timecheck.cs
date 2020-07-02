namespace Maple2.Trigger._02020140_bf {
    public static class _timecheck {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State던전시간체크(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.DungeonTimeOut()) {
                    return new State던전실패(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전실패 : TriggerState {
            internal State던전실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 41, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 42, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 43, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 44, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 45, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 46, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 47, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 48, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 49, arg2: true, arg3: true, arg4: true);
                context.SetSound(arg1: 140140, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
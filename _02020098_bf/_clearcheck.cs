namespace Maple2.Trigger._02020098_bf {
    public static class _clearcheck {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10})) {
                    return new StateClearSuccess유무체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClearSuccess유무체크시작 : TriggerState {
            internal StateClearSuccess유무체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossDead") == 1) {
                    return new State연출Delay(context);
                }

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

        private class State연출Delay : TriggerState {
            internal State연출Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg3: "BalrogMagicBursterKritiasClear");
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetMesh(arg1: new[] {301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
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
                context.SetMesh(arg1: new[] {301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new[] {-1});
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
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
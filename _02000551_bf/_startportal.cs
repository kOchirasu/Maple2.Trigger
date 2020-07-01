namespace Maple2.Trigger._02000551_bf {
    public static class _startportal {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State기본셋팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State기본셋팅 : TriggerState {
            internal State기본셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {8101, 8102, 8103, 8104, 8105}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State포탈활성화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탈활성화 : TriggerState {
            internal State포탈활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
                context.DungeonEnableGiveUp(isEnable: true);
                context.SetEventUI(arg1: 1, arg2: "$02020140_BF__BARRICADE__0$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.DungeonTimeOut()) {
                    return new State던전실패종료(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패종료(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new State포탈감추기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탈감추기 : TriggerState {
            internal State포탈감추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.DungeonTimeOut()) {
                    return new State던전실패종료(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new State던전실패종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전실패종료 : TriggerState {
            internal State던전실패종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
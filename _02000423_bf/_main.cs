namespace Maple2.Trigger._02000423_bf {
    public static class _main {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State기본셋팅시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본셋팅시작 : TriggerState {
            internal State기본셋팅시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "PortalHidden") == 1) {
                    context.State = new State보스사냥후포탈생성(context);
                    return;
                }

                if (context.NpcDetected(arg1: 101, arg2: new[] {100})) {
                    context.State = new State포탈감추기(context);
                    return;
                }

                if (!context.NpcDetected(arg1: 101, arg2: new[] {100})) {
                    context.State = new State디폴트포탈생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State디폴트포탈생성 : TriggerState {
            internal State디폴트포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 9, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 14, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State포탈다시체크대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스사냥후포탈생성 : TriggerState {
            internal State보스사냥후포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 9, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 14, arg2: true, arg3: true, arg4: true);
                context.SetUserValue(key: "PortalHidden", value: 0);
                context.ShowGuideSummary(entityId: 20043001, textId: 20043001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State포탈다시체크대기이전(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20043001);
            }
        }

        private class State포탈감추기 : TriggerState {
            internal State포탈감추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 14, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State포탈다시체크대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈다시체크대기이전 : TriggerState {
            internal State포탈다시체크대기이전(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈다시체크대기 : TriggerState {
            internal State포탈다시체크대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
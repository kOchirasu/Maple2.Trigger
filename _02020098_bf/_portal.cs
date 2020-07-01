using System;

namespace Maple2.Trigger._02020098_bf {
    public static class _portal {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "BossOnePhaseEnd", value: 0);
                context.SetPortal(arg1: 40, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 50, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {10})) {
                    context.State = new State포탈체크시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈체크시작 : TriggerState {
            internal State포탈체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State포탈체크대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈체크대기중 : TriggerState {
            internal State포탈체크대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "BossOnePhaseEnd", value: 1)) {
                    context.State = new State순간이동포탈OFF(context);
                    return;
                }

                if (context.UserValue(key: "BossDead", value: 1)) {
                    context.State = new State나가기포탈생성잠시대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State순간이동포탈OFF : TriggerState {
            internal State순간이동포탈OFF(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 40, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 50, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "BossOnePhaseEnd", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State포탈체크대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State나가기포탈생성잠시대기 : TriggerState {
            internal State나가기포탈생성잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    context.State = new State나가기포탈생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State나가기포탈생성 : TriggerState {
            internal State나가기포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "PhasePortar", value: 0)) {
                    context.State = new State졸구간만포탈생성(context);
                    return;
                }

                if (context.UserValue(key: "PhasePortar", value: 1)) {
                    context.State = new State1페이지전투판포탈생성(context);
                    return;
                }

                if (context.UserValue(key: "PhasePortar", value: 2)) {
                    context.State = new State2페이지전투판포탈생성(context);
                    return;
                }

                if (context.UserValue(key: "PhasePortar", value: 3)) {
                    context.State = new State3페이지전투판포탈생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State졸구간만포탈생성 : TriggerState {
            internal State졸구간만포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State트리거종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1페이지전투판포탈생성 : TriggerState {
            internal State1페이지전투판포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State트리거종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2페이지전투판포탈생성 : TriggerState {
            internal State2페이지전투판포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State트리거종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3페이지전투판포탈생성 : TriggerState {
            internal State3페이지전투판포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State트리거종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거종료 : TriggerState {
            internal State트리거종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
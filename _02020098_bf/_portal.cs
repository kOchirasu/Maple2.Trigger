namespace Maple2.Trigger._02020098_bf {
    public static class _portal {
        public class State시작대기중 : TriggerState {
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

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10})) {
                    return new State포탈체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탈체크시작 : TriggerState {
            internal State포탈체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State포탈체크대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탈체크대기중 : TriggerState {
            internal State포탈체크대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossOnePhaseEnd") == 1) {
                    return new State순간이동포탈OFF(context);
                }

                if (context.GetUserValue(key: "BossDead") == 1) {
                    return new State나가기포탈생성잠시대기(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State포탈체크대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나가기포탈생성잠시대기 : TriggerState {
            internal State나가기포탈생성잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    return new State나가기포탈생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나가기포탈생성 : TriggerState {
            internal State나가기포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PhasePortar") == 0) {
                    return new State졸구간만포탈생성(context);
                }

                if (context.GetUserValue(key: "PhasePortar") == 1) {
                    return new State1페이지전투판포탈생성(context);
                }

                if (context.GetUserValue(key: "PhasePortar") == 2) {
                    return new State2페이지전투판포탈생성(context);
                }

                if (context.GetUserValue(key: "PhasePortar") == 3) {
                    return new State3페이지전투판포탈생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸구간만포탈생성 : TriggerState {
            internal State졸구간만포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State트리거종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1페이지전투판포탈생성 : TriggerState {
            internal State1페이지전투판포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State트리거종료(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State트리거종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3페이지전투판포탈생성 : TriggerState {
            internal State3페이지전투판포탈생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State트리거종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트리거종료 : TriggerState {
            internal State트리거종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
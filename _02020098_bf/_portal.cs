namespace Maple2.Trigger._02020098_bf {
    public static class _portal {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

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
                    return new StatePortal체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal체크시작 : TriggerState {
            internal StatePortal체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortal체크대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal체크대기중 : TriggerState {
            internal StatePortal체크대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossOnePhaseEnd") == 1) {
                    return new StateTeleportationPortalOFF(context);
                }

                if (context.GetUserValue(key: "BossDead") == 1) {
                    return new State나가기PortalCreationWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTeleportationPortalOFF : TriggerState {
            internal StateTeleportationPortalOFF(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 40, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 50, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "BossOnePhaseEnd", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortal체크대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나가기PortalCreationWait : TriggerState {
            internal State나가기PortalCreationWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    return new State나가기PortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나가기PortalCreation : TriggerState {
            internal State나가기PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PhasePortar") == 0) {
                    return new State졸구간만PortalCreation(context);
                }

                if (context.GetUserValue(key: "PhasePortar") == 1) {
                    return new State1페이지전투판PortalCreation(context);
                }

                if (context.GetUserValue(key: "PhasePortar") == 2) {
                    return new State2페이지전투판PortalCreation(context);
                }

                if (context.GetUserValue(key: "PhasePortar") == 3) {
                    return new State3페이지전투판PortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸구간만PortalCreation : TriggerState {
            internal State졸구간만PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrigger종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1페이지전투판PortalCreation : TriggerState {
            internal State1페이지전투판PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrigger종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2페이지전투판PortalCreation : TriggerState {
            internal State2페이지전투판PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrigger종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3페이지전투판PortalCreation : TriggerState {
            internal State3페이지전투판PortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTrigger종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger종료 : TriggerState {
            internal StateTrigger종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
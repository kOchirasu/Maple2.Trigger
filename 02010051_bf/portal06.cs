namespace Maple2.Trigger._02010051_bf {
    public static class _portal06 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {900}, arg2: false);
                context.SetMesh(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1511, 1512, 1513}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {914}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000914}, arg2: 0);
                context.SetMesh(arg1: new[] {1601, 1602, 1603, 1604, 1605, 1606}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {6000, 6001, 6002, 6003, 6005}, arg2: false);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State입장Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State입장Delay01 : TriggerState {
            internal State입장Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State대화SetupCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화SetupCinematic01 : TriggerState {
            internal State대화SetupCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                return new StateCinematic대화01(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematic대화01 : TriggerState {
            internal StateCinematic대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001319, arg3: "$02010051_BF__PORTAL06__0$", arg4: 3);
                context.SetSkip(state: new StateCinematic대화02Wait(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateCinematic대화02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic대화02Wait : TriggerState {
            internal StateCinematic대화02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateCinematic대화02(context);
            }

            public override void OnExit() { }
        }

        private class StateCinematic대화02 : TriggerState {
            internal StateCinematic대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001319, arg3: "$02010051_BF__PORTAL06__1$", arg4: 3);
                context.SetSkip(state: new State대화StopCinematic01(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State대화StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화StopCinematic01 : TriggerState {
            internal State대화StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new State문열기01(context);
            }

            public override void OnExit() { }
        }

        private class State문열기01 : TriggerState {
            internal State문열기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 1);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.SetEffect(arg1: new[] {6005}, arg2: true);
                context.SetMesh(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {1511, 1512, 1513}, arg2: true, arg3: 1, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State유저입장01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저입장01 : TriggerState {
            internal State유저입장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new StateGuidePrepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuidePrepare : TriggerState {
            internal StateGuidePrepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 7);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new StateGuide시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide시작 : TriggerState {
            internal StateGuide시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105101, textId: 20105101, duration: 4000);
                context.SetInteractObject(arg1: new[] {10000914}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000914}, arg2: 0)) {
                    return new StatePortalEnable01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable01 : TriggerState {
            internal StatePortalEnable01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 1);
                context.SetEffect(arg1: new[] {914, 6000}, arg2: true);
                context.SetMesh(arg1: new[] {1601, 1602, 1603, 1604, 1605, 1606}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new StatePortalEnable02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable02 : TriggerState {
            internal StatePortalEnable02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 11, arg2: true, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000835}, arg2: 0)) {
                    return new StatePortalDisable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalDisable : TriggerState {
            internal StatePortalDisable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {1601, 1602, 1603, 1604, 1605, 1606}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetEffect(arg1: new[] {6000, 6005}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
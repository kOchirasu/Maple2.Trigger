namespace Maple2.Trigger._80000015_bonus {
    public static class _skill_09 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{720, 721, 722, 723, 724, 725}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSkill01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill01 : TriggerState {
            internal StateSkill01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{720}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateSkill02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill02 : TriggerState {
            internal StateSkill02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{721}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateSkill03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill03 : TriggerState {
            internal StateSkill03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{722}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateSkill04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill04 : TriggerState {
            internal StateSkill04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{723}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateSkill05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill05 : TriggerState {
            internal StateSkill05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{724}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateSkill06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill06 : TriggerState {
            internal StateSkill06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{725}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

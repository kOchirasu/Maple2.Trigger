namespace Maple2.Trigger._99999911 {
    public static class _fail {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 1, arg3: 702);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new StateFail_random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFail_random : TriggerState {
            internal StateFail_random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    return new StateFail_01(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateFail_02(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateFail_03(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new StateFail_04(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new StateFail_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFail_01 : TriggerState {
            internal StateFail_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 1, arg3: 702);
            }

            public override TriggerState Execute() {
                return new StateIdle(context);
            }

            public override void OnExit() { }
        }

        private class StateFail_02 : TriggerState {
            internal StateFail_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 2, arg3: 702);
            }

            public override TriggerState Execute() {
                return new StateIdle(context);
            }

            public override void OnExit() { }
        }

        private class StateFail_03 : TriggerState {
            internal StateFail_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 3, arg3: 702);
            }

            public override TriggerState Execute() {
                return new StateIdle(context);
            }

            public override void OnExit() { }
        }

        private class StateFail_04 : TriggerState {
            internal StateFail_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 4, arg3: 702);
            }

            public override TriggerState Execute() {
                return new StateIdle(context);
            }

            public override void OnExit() { }
        }

        private class StateFail_05 : TriggerState {
            internal StateFail_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 5, arg3: 702);
            }

            public override TriggerState Execute() {
                return new StateIdle(context);
            }

            public override void OnExit() { }
        }
    }
}
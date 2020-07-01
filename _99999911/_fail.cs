namespace Maple2.Trigger._99999911 {
    public static class _fail {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 1, arg3: 702);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new Statefail_random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefail_random : TriggerState {
            internal Statefail_random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    return new Statefail_01(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new Statefail_02(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new Statefail_03(context);
                }

                if (context.RandomCondition(arg1: 1f)) {
                    return new Statefail_04(context);
                }

                if (context.RandomCondition(arg1: 5f)) {
                    return new Statefail_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefail_01 : TriggerState {
            internal Statefail_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 1, arg3: 702);
            }

            public override TriggerState Execute() {
                return new Stateidle(context);
            }

            public override void OnExit() { }
        }

        private class Statefail_02 : TriggerState {
            internal Statefail_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 2, arg3: 702);
            }

            public override TriggerState Execute() {
                return new Stateidle(context);
            }

            public override void OnExit() { }
        }

        private class Statefail_03 : TriggerState {
            internal Statefail_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 3, arg3: 702);
            }

            public override TriggerState Execute() {
                return new Stateidle(context);
            }

            public override void OnExit() { }
        }

        private class Statefail_04 : TriggerState {
            internal Statefail_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 4, arg3: 702);
            }

            public override TriggerState Execute() {
                return new Stateidle(context);
            }

            public override void OnExit() { }
        }

        private class Statefail_05 : TriggerState {
            internal Statefail_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 5, arg3: 702);
            }

            public override TriggerState Execute() {
                return new Stateidle(context);
            }

            public override void OnExit() { }
        }
    }
}
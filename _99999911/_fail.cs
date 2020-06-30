using System;

namespace Maple2.Trigger._99999911 {
    public static class _fail {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 1, arg3: 702);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 702, arg2: 1)) {
                    context.State = new Statefail_random(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefail_random : TriggerState {
            internal Statefail_random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Statefail_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Statefail_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Statefail_03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new Statefail_04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 5f)) {
                    context.State = new Statefail_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefail_01 : TriggerState {
            internal Statefail_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 1, arg3: 702);
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefail_02 : TriggerState {
            internal Statefail_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 2, arg3: 702);
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefail_03 : TriggerState {
            internal Statefail_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 3, arg3: 702);
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefail_04 : TriggerState {
            internal Statefail_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 4, arg3: 702);
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefail_05 : TriggerState {
            internal Statefail_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999911, arg2: 5, arg3: 702);
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
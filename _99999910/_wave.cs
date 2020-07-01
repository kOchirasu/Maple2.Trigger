namespace Maple2.Trigger._99999910 {
    public static class _wave {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    // return new Stateready(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterandom : TriggerState {
            internal Staterandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 12f)) {
                    return new Statepattern_a_01(context);
                }

                if (context.RandomCondition(arg1: 12f)) {
                    return new Statepattern_b_01(context);
                }

                if (context.RandomCondition(arg1: 12f)) {
                    return new Statepattern_c_01(context);
                }

                if (context.RandomCondition(arg1: 12f)) {
                    return new Statepattern_d_01(context);
                }

                if (context.RandomCondition(arg1: 6f)) {
                    return new Statepattern_e_01(context);
                }

                if (context.RandomCondition(arg1: 6f)) {
                    return new Statepattern_f_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_a_01 : TriggerState {
            internal Statepattern_a_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_a_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_a_02 : TriggerState {
            internal Statepattern_a_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_a_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_a_03 : TriggerState {
            internal Statepattern_a_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_a_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_a_04 : TriggerState {
            internal Statepattern_a_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new Stateready(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_b_01 : TriggerState {
            internal Statepattern_b_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_b_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_b_02 : TriggerState {
            internal Statepattern_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_b_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_b_03 : TriggerState {
            internal Statepattern_b_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_b_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_b_04 : TriggerState {
            internal Statepattern_b_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new Stateready(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_c_01 : TriggerState {
            internal Statepattern_c_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_c_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_c_02 : TriggerState {
            internal Statepattern_c_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_c_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_c_03 : TriggerState {
            internal Statepattern_c_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_c_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_c_04 : TriggerState {
            internal Statepattern_c_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new Stateready(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_d_01 : TriggerState {
            internal Statepattern_d_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_d_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_d_02 : TriggerState {
            internal Statepattern_d_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_d_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_d_03 : TriggerState {
            internal Statepattern_d_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_d_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_d_04 : TriggerState {
            internal Statepattern_d_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new Stateready(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_e_01 : TriggerState {
            internal Statepattern_e_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_e_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_e_02 : TriggerState {
            internal Statepattern_e_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_e_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_e_03 : TriggerState {
            internal Statepattern_e_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_e_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_e_04 : TriggerState {
            internal Statepattern_e_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new Stateready(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_f_01 : TriggerState {
            internal Statepattern_f_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_f_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_f_02 : TriggerState {
            internal Statepattern_f_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_f_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_f_03 : TriggerState {
            internal Statepattern_f_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statepattern_f_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statepattern_f_04 : TriggerState {
            internal Statepattern_f_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new Stateready(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
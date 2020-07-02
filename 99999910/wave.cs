namespace Maple2.Trigger._99999910 {
    public static class _wave {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    // return new StateReady(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandom : TriggerState {
            internal StateRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 12f)) {
                    return new StatePattern_a_01(context);
                }

                if (context.RandomCondition(arg1: 12f)) {
                    return new StatePattern_b_01(context);
                }

                if (context.RandomCondition(arg1: 12f)) {
                    return new StatePattern_c_01(context);
                }

                if (context.RandomCondition(arg1: 12f)) {
                    return new StatePattern_d_01(context);
                }

                if (context.RandomCondition(arg1: 6f)) {
                    return new StatePattern_e_01(context);
                }

                if (context.RandomCondition(arg1: 6f)) {
                    return new StatePattern_f_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_a_01 : TriggerState {
            internal StatePattern_a_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_a_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_a_02 : TriggerState {
            internal StatePattern_a_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_a_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_a_03 : TriggerState {
            internal StatePattern_a_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_a_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_a_04 : TriggerState {
            internal StatePattern_a_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new StateReady(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_b_01 : TriggerState {
            internal StatePattern_b_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_b_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_b_02 : TriggerState {
            internal StatePattern_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_b_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_b_03 : TriggerState {
            internal StatePattern_b_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_b_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_b_04 : TriggerState {
            internal StatePattern_b_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new StateReady(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_c_01 : TriggerState {
            internal StatePattern_c_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_c_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_c_02 : TriggerState {
            internal StatePattern_c_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_c_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_c_03 : TriggerState {
            internal StatePattern_c_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_c_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_c_04 : TriggerState {
            internal StatePattern_c_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new StateReady(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_d_01 : TriggerState {
            internal StatePattern_d_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_d_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_d_02 : TriggerState {
            internal StatePattern_d_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_d_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_d_03 : TriggerState {
            internal StatePattern_d_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_d_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_d_04 : TriggerState {
            internal StatePattern_d_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new StateReady(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_e_01 : TriggerState {
            internal StatePattern_e_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_e_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_e_02 : TriggerState {
            internal StatePattern_e_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_e_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_e_03 : TriggerState {
            internal StatePattern_e_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_e_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_e_04 : TriggerState {
            internal StatePattern_e_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new StateReady(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_f_01 : TriggerState {
            internal StatePattern_f_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_f_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_f_02 : TriggerState {
            internal StatePattern_f_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_f_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_f_03 : TriggerState {
            internal StatePattern_f_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePattern_f_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern_f_04 : TriggerState {
            internal StatePattern_f_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    // return new StateReady(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
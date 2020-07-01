namespace Maple2.Trigger._02000471_bf {
    public static class _respawn {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 1) {
                    return new Staterespawn_timer1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn_timer1 : TriggerState {
            internal Staterespawn_timer1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "respawntimer1", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new Stateend(context);
                }

                if (context.TimeExpired(arg1: "respawntimer1")) {
                    return new Staterespawn1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn1 : TriggerState {
            internal Staterespawn1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "respawntimer1");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new Stateend(context);
                }

                if (!context.MonsterDead(arg1: new[] {1999})) {
                    return new Staterespawn_timer2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn_timer2 : TriggerState {
            internal Staterespawn_timer2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "respawntimer2", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new Stateend(context);
                }

                if (context.TimeExpired(arg1: "respawntimer2")) {
                    return new Staterespawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn2 : TriggerState {
            internal Staterespawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "respawntimer2");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new Stateend(context);
                }

                if (!context.MonsterDead(arg1: new[] {1999})) {
                    return new Staterespawn_timer3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn_timer3 : TriggerState {
            internal Staterespawn_timer3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "respawntimer3", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new Stateend(context);
                }

                if (context.TimeExpired(arg1: "respawntimer3")) {
                    return new Staterespawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn3 : TriggerState {
            internal Staterespawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "respawntimer3");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new Stateend(context);
                }

                if (!context.MonsterDead(arg1: new[] {1999})) {
                    return new Staterespawn_timer4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn_timer4 : TriggerState {
            internal Staterespawn_timer4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "respawntimer4", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new Stateend(context);
                }

                if (context.TimeExpired(arg1: "respawntimer4")) {
                    return new Staterespawn4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn4 : TriggerState {
            internal Staterespawn4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "respawntimer4");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new Stateend(context);
                }

                if (!context.MonsterDead(arg1: new[] {1999})) {
                    return new Staterespawn_timer5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn_timer5 : TriggerState {
            internal Staterespawn_timer5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "respawntimer5", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new Stateend(context);
                }

                if (context.TimeExpired(arg1: "respawntimer5")) {
                    return new Staterespawn5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterespawn5 : TriggerState {
            internal Staterespawn5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "respawntimer5");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                return new Stateend(context);
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
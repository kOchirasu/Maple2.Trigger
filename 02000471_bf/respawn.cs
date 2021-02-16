namespace Maple2.Trigger._02000471_bf {
    public static class _respawn {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 1) {
                    return new StateRespawn_timer1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn_timer1 : TriggerState {
            internal StateRespawn_timer1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "respawntimer1", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "respawntimer1")) {
                    return new StateRespawn1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn1 : TriggerState {
            internal StateRespawn1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "respawntimer1");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (!context.MonsterDead(arg1: new[] {1999})) {
                    return new StateRespawn_timer2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn_timer2 : TriggerState {
            internal StateRespawn_timer2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "respawntimer2", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "respawntimer2")) {
                    return new StateRespawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn2 : TriggerState {
            internal StateRespawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "respawntimer2");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (!context.MonsterDead(arg1: new[] {1999})) {
                    return new StateRespawn_timer3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn_timer3 : TriggerState {
            internal StateRespawn_timer3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "respawntimer3", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "respawntimer3")) {
                    return new StateRespawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn3 : TriggerState {
            internal StateRespawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "respawntimer3");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (!context.MonsterDead(arg1: new[] {1999})) {
                    return new StateRespawn_timer4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn_timer4 : TriggerState {
            internal StateRespawn_timer4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "respawntimer4", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "respawntimer4")) {
                    return new StateRespawn4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn4 : TriggerState {
            internal StateRespawn4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "respawntimer4");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (!context.MonsterDead(arg1: new[] {1999})) {
                    return new StateRespawn_timer5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn_timer5 : TriggerState {
            internal StateRespawn_timer5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "respawntimer5", arg2: 120, arg3: true, arg4: false, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "respawntimer5")) {
                    return new StateRespawn5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn5 : TriggerState {
            internal StateRespawn5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(id: "respawntimer5");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
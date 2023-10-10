namespace Maple2.Trigger._02000471_bf {
    public static class _respawn {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetTimer(timerId: "respawntimer1", seconds: 120, autoRemove: true, display: false, vOffset: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "respawntimer1")) {
                    return new StateRespawn1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn1 : TriggerState {
            internal StateRespawn1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "respawntimer1");
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (!context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateRespawn_timer2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn_timer2 : TriggerState {
            internal StateRespawn_timer2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "respawntimer2", seconds: 120, autoRemove: true, display: false, vOffset: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "respawntimer2")) {
                    return new StateRespawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn2 : TriggerState {
            internal StateRespawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "respawntimer2");
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (!context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateRespawn_timer3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn_timer3 : TriggerState {
            internal StateRespawn_timer3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "respawntimer3", seconds: 120, autoRemove: true, display: false, vOffset: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "respawntimer3")) {
                    return new StateRespawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn3 : TriggerState {
            internal StateRespawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "respawntimer3");
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (!context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateRespawn_timer4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn_timer4 : TriggerState {
            internal StateRespawn_timer4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "respawntimer4", seconds: 120, autoRemove: true, display: false, vOffset: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "respawntimer4")) {
                    return new StateRespawn4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn4 : TriggerState {
            internal StateRespawn4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "respawntimer4");
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (!context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateRespawn_timer5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn_timer5 : TriggerState {
            internal StateRespawn_timer5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "respawntimer5", seconds: 120, autoRemove: true, display: false, vOffset: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "respawntimer5")) {
                    return new StateRespawn5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRespawn5 : TriggerState {
            internal StateRespawn5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "respawntimer5");
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 306}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
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

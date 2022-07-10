namespace Maple2.Trigger._02020110_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    return new State1번방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번방 : TriggerState {
            internal State1번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 120}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 120})) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    return new State2번방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2번방 : TriggerState {
            internal State2번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102, 103, 104, 105, 106, 107}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102, 103, 104, 105, 106, 107})) {
                    context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                    return new State3번방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3번방 : TriggerState {
            internal State3번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{108, 109, 110, 111, 112, 113}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{108, 109, 110, 111, 112, 113})) {
                    context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                    return new State4번방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번방 : TriggerState {
            internal State4번방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{114, 115, 116, 117, 118, 119}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{114, 115, 116, 117, 118, 119})) {
                    return new StateNext블록이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNext블록이동 : TriggerState {
            internal StateNext블록이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

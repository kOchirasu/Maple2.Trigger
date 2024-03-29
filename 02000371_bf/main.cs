namespace Maple2.Trigger._02000371_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new State카오스레이드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State카오스레이드 : TriggerState {
            internal State카오스레이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2101})) {
                    return new State2초Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2초Wait : TriggerState {
            internal State2초Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDungeonClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonClear : TriggerState {
            internal StateDungeonClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePortalEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable : TriggerState {
            internal StatePortalEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
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

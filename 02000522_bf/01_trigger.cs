namespace Maple2.Trigger._02000522_bf {
    public static class _01_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{201})) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{301})) {
                    return new StateClear처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear처리 : TriggerState {
            internal StateClear처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.DungeonClear();
                    return new StateEnd처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd처리 : TriggerState {
            internal StateEnd처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

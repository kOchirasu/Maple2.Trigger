namespace Maple2.Trigger._02000409_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{999, 99, 90, 91, 92, 93, 94}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new StateEndDelay(context);
                }

                if (context.DungeonTimeOut()) {
                    return new StateDungeonFailure(context);
                }

                if (context.GetDungeonState() == "Fail") {
                    return new StateDungeonFailure(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9999998, key: "BattleEnd", value: 1);
                context.SetMesh(triggerIds: new []{3002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.DungeonClear();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFailure : TriggerState {
            internal StateDungeonFailure(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{-1});
                context.SetUserValue(triggerId: 9999998, key: "BattleEnd", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    context.DungeonFail();
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(enable: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

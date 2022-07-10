namespace Maple2.Trigger._02000488_bf {
    public static class _99_bossspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{999});
                context.SetPortal(portalId: 40, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{3160, 3161, 3162, 3163, 3164}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{5610, 5611, 5612}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{5610, 5611, 5612}, visible: true, arg3: 0, arg4: 0);
                context.SetEffect(triggerIds: new []{5010, 5600}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{999}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{999})) {
                    return new StateBossDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossDead : TriggerState {
            internal StateBossDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{999});
                context.SetEffect(triggerIds: new []{5600}, visible: true);
                context.SetMesh(triggerIds: new []{5610, 5611, 5612}, visible: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(triggerIds: new []{5610, 5611, 5612}, visible: false, arg3: 0, arg4: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBridgeApp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBridgeApp : TriggerState {
            internal StateBridgeApp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3160, 3161, 3162, 3163, 3164}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212}, visible: true, arg3: 0, arg4: 100, arg5: 2f);
                context.SetEffect(triggerIds: new []{5010}, visible: true);
            }

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
                context.SetPortal(portalId: 40, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

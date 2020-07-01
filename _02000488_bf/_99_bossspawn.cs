namespace Maple2.Trigger._02000488_bf {
    public static class _99_bossspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {999});
                context.SetPortal(arg1: 40, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {3160, 3161, 3162, 3163, 3164}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {5610, 5611, 5612}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {5610, 5611, 5612}, arg2: true, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5010, 5600}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {999}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    return new StateBossDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossDead : TriggerState {
            internal StateBossDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {999});
                context.SetEffect(arg1: new[] {5600}, arg2: true);
                context.SetMesh(arg1: new[] {5610, 5611, 5612}, arg2: false, arg3: 500, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(arg1: new[] {5610, 5611, 5612}, arg2: false, arg3: 0, arg4: 0);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {3160, 3161, 3162, 3163, 3164}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212}, arg2: true, arg3: 0, arg4: 100, arg5: 2f);
                context.SetEffect(arg1: new[] {5010}, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 40, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
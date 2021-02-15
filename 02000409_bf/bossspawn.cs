namespace Maple2.Trigger._02000409_bf {
    public static class _bossspawn {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {999, 99, 90, 91, 92, 93, 94}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
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
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
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
                context.DestroyMonster(arg1: new[] {-1});
                context.SetUserValue(triggerId: 9999998, key: "BattleEnd", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
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
                context.DungeonEnableGiveUp(isEnable: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
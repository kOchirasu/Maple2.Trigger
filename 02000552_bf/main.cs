namespace Maple2.Trigger._02000552_bf {
    public static class _main {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateDefaultSetting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefaultSetting : TriggerState {
            internal StateDefaultSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetUserValue(key: "NextPortal", value: 0);
                context.SetUserValue(key: "SmallRemove", value: 0);
                context.SetUserValue(key: "VacuumMessage", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State난이도체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State난이도체크 : TriggerState {
            internal State난이도체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonId() == 23050003) {
                    return new StateEasyDifficultyBossSpawn(context);
                }

                if (context.GetDungeonId() == 23051003) {
                    return new StateHardDifficultyBossSpawn(context);
                }

                if (context.WaitTick(waitTick: 1100)) {
                    return new StateHardDifficultyBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHardDifficultyBossSpawn : TriggerState {
            internal StateHardDifficultyBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateBossCombat(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEasyDifficultyBossSpawn : TriggerState {
            internal StateEasyDifficultyBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateBossCombat(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombat : TriggerState {
            internal StateBossCombat(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SmallRemove") == 1) {
                    return new State작아짐Remove(context);
                }

                if (context.GetUserValue(key: "VacuumMessage") == 1) {
                    return new StateDisplayGuide(context);
                }

                if (context.GetUserValue(key: "NextPortal") == 1) {
                    return new StateNextMovePortalSpawn(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
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

        private class StateDisplayGuide : TriggerState {
            internal StateDisplayGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 29200008, textId: 29200008, duration: 6200);
                context.SetUserValue(key: "VacuumMessage", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new StateBossCombat(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State작아짐Remove : TriggerState {
            internal State작아짐Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {702}, arg2: 50001556, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {701}, arg2: 50001556, arg3: 1, arg4: false, arg5: false);
                context.SetUserValue(key: "SmallRemove", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBossCombat(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextMovePortalSpawn : TriggerState {
            internal StateNextMovePortalSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: true);
                context.AddBuff(arg1: new[] {702}, arg2: 50001556, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {701}, arg2: 50001556, arg3: 1, arg4: false, arg5: false);
                context.SetUserValue(key: "NextPortal", value: 0);
                context.SetUserValue(key: "SmallRemove", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new StateBossCombat(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonFailure : TriggerState {
            internal StateDungeonFailure(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.DungeonFail();
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonEnableGiveUp(isEnable: false);
                context.AddBuff(arg1: new[] {701}, arg2: 50000266, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {702}, arg2: 50000266, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 50000266, arg3: 1, arg4: false, arg5: false);
                context.AddBuff(arg1: new[] {702}, arg2: 50000266, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateClear처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear처리 : TriggerState {
            internal StateClear처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.DestroyMonster(arg1: new[] {-1});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 13, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
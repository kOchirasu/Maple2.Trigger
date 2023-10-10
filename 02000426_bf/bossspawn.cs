namespace Maple2.Trigger._02000426_bf {
    public static class _bossspawn {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3002}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "ZakumBodyAppearance", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new StateDungeonBossSpawnByDifficulty(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonBossSpawnByDifficulty : TriggerState {
            internal StateDungeonBossSpawnByDifficulty(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonId() == 23040003) {
                    return new State어려운난이도BossSpawn(context);
                }

                if (context.GetDungeonId() == 23041003) {
                    return new StateEasyDifficultyBossSpawn(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State어려운난이도BossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어려운난이도BossSpawn : TriggerState {
            internal State어려운난이도BossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEasyDifficultyBossSpawn : TriggerState {
            internal StateEasyDifficultyBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ZakumBodyAppearance") == 1) {
                    return new State자쿰몸체Spawn(context);
                }

                if (context.GetUserValue(key: "ZakumDungeonEnd") == 1) {
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

        private class State자쿰몸체Spawn : TriggerState {
            internal State자쿰몸체Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "ZakumBodyAppearance", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonId() == 23040003) {
                    return new State어려운난이도_자쿰몸Spawn(context);
                }

                if (context.GetDungeonId() == 23041003) {
                    return new StateEasyDifficulty_자쿰몸Spawn(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State어려운난이도_자쿰몸Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어려운난이도_자쿰몸Spawn : TriggerState {
            internal State어려운난이도_자쿰몸Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2011}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEasyDifficulty_자쿰몸Spawn : TriggerState {
            internal StateEasyDifficulty_자쿰몸Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2012}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndDelay : TriggerState {
            internal StateEndDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.SetAchievement(type: "trigger", code: "ZakumKritiasClear");
                context.SetUserValue(triggerId: 999103, key: "BattleEnd", value: 1);
                context.SetUserValue(triggerId: 999102, key: "BattleEnd2", value: 1);
                context.SetUserValue(triggerId: 999108, key: "BattleEnd2", value: 1);
                context.SetUserValue(triggerId: 999109, key: "BattleEnd2", value: 1);
                context.SetMesh(triggerIds: new []{3002, 3003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.RemoveBuff(boxId: 199, skillId: 50005300);
                context.RemoveBuff(boxId: 199, skillId: 50005301);
                context.RemoveBuff(boxId: 199, skillId: 50001450);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.SetUserValue(triggerId: 999103, key: "BattleEnd", value: 1);
                context.SetMesh(triggerIds: new []{3002, 3003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.RemoveBuff(boxId: 199, skillId: 50005300);
                context.RemoveBuff(boxId: 199, skillId: 50005301);
                context.RemoveBuff(boxId: 199, skillId: 50001450);
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
                context.DungeonEnableGiveUp(enabled: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

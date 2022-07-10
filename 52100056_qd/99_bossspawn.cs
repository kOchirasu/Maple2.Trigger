namespace Maple2.Trigger._52100056_qd {
    public static class _99_bossspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateRoomCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateDungeonInit(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuestDungeonInit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonInit : TriggerState {
            internal StateDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{900, 901}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestDungeonInit : TriggerState {
            internal StateQuestDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{910, 911}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{910, 911})) {
                    return new StateQuestClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle01 : TriggerState {
            internal StateBossBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 100, key: "CheckDualKill", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900, 901})) {
                    return new StateBossBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossBattle02 : TriggerState {
            internal StateBossBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{900, 901});
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "Madracan02");
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "Madracan_Q02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestClear : TriggerState {
            internal StateQuestClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "Madracan_Q02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.MoveUser(mapId: 02000402, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

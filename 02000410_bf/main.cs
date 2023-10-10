namespace Maple2.Trigger._02000410_bf {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6010, 6011}, visible: true, arg3: 1, arg4: 1);
                context.SetMesh(triggerIds: new []{6000, 6001, 6002, 6003, 6004, 6005}, visible: false);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new StateBattleStart_InfernoWarship(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart_InfernoWarship : TriggerState {
            internal StateBattleStart_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.DungeonSetLapTime(id: 1, lapTime: 420000);
                context.DungeonSetLapTime(id: 2, lapTime: 720000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State첫번째Phase_InfernoWarship(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째Phase_InfernoWarship : TriggerState {
            internal State첫번째Phase_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SecondPhase") == 1) {
                    return new State두번째Phase_InfernoWarship(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Phase_InfernoWarship : TriggerState {
            internal State두번째Phase_InfernoWarship(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6010, 6011, 6012, 6013, 6014, 6015, 6016}, visible: false, arg3: 0, arg4: 0, arg5: 0.5f);
                context.DungeonMissionComplete(feature: "DungeonRankBalance_01", missionId: 24090007);
                context.DungeonMissionComplete(feature: "DungeonRankBalance_02", missionId: 24090017);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ThirdPhase") == 1) {
                    return new State세번째Phase_인페르녹Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째Phase_인페르녹Spawn : TriggerState {
            internal State세번째Phase_인페르녹Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMoveLapTimeToNow(id: 1);
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
                context.SetSound(triggerId: 8410, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BalrogMagicBursterBattlePhase") == 1) {
                    return new State인페르녹전투시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State인페르녹전투시작 : TriggerState {
            internal State인페르녹전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Phase", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetDungeonPlayTime() == 720) {
                    return new State네번째Phase_인페르녹광폭화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째Phase_인페르녹광폭화 : TriggerState {
            internal State네번째Phase_인페르녹광폭화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Phase", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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

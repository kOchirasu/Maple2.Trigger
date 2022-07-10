namespace Maple2.Trigger._82000002_survival {
    public static class _12_relicmob_skyblue {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209});
                context.SetUserValue(key: "RelicMobSpawn", value: 0);
                context.SetUserValue(key: "RelicMobRemove", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobSpawn") == 1) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateMobSpawnRandom(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawnRandom : TriggerState {
            internal StateMobSpawnRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn01(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn02(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn03(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn04(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn05(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn06(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn07(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn08(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn09(context);
                }

                if (context.RandomCondition(rate: 10f)) {
                    return new StateMobSpawn10(context);
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1200}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1200})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn02 : TriggerState {
            internal StateMobSpawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1201})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn03 : TriggerState {
            internal StateMobSpawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1202}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1202})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn04 : TriggerState {
            internal StateMobSpawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1203})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn05 : TriggerState {
            internal StateMobSpawn05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1204}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1204})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn06 : TriggerState {
            internal StateMobSpawn06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1205}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1205})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn07 : TriggerState {
            internal StateMobSpawn07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1206}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1206})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn08 : TriggerState {
            internal StateMobSpawn08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1207}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1207})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn09 : TriggerState {
            internal StateMobSpawn09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1208}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1208})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn10 : TriggerState {
            internal StateMobSpawn10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1209}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1209})) {
                    return new StateNotice(context);
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNotice : TriggerState {
            internal StateNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 16, key: "RelicMobSkyblueDie", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1200, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

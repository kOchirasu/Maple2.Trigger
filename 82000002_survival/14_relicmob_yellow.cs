namespace Maple2.Trigger._82000002_survival {
    public static class _14_relicmob_yellow {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409});
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
                if (context.RandomCondition(rate: 10)) {
                    return new StateMobSpawn01(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateMobSpawn02(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateMobSpawn03(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateMobSpawn04(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateMobSpawn05(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateMobSpawn06(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateMobSpawn07(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateMobSpawn08(context);
                }

                if (context.RandomCondition(rate: 10)) {
                    return new StateMobSpawn09(context);
                }

                if (context.RandomCondition(rate: 10)) {
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
                context.CreateMonster(spawnIds: new []{1400}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1400})) {
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
                context.CreateMonster(spawnIds: new []{1401}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1401})) {
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
                context.CreateMonster(spawnIds: new []{1402}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1402})) {
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
                context.CreateMonster(spawnIds: new []{1403}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1403})) {
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
                context.CreateMonster(spawnIds: new []{1404}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1404})) {
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
                context.CreateMonster(spawnIds: new []{1405}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1405})) {
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
                context.CreateMonster(spawnIds: new []{1406}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1406})) {
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
                context.CreateMonster(spawnIds: new []{1407}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1407})) {
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
                context.CreateMonster(spawnIds: new []{1408}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1408})) {
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
                context.CreateMonster(spawnIds: new []{1409}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1409})) {
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
                context.SetUserValue(triggerId: 16, key: "RelicMobYellowDie", value: 1);
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
                context.DestroyMonster(spawnIds: new []{1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

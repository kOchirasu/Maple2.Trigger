namespace Maple2.Trigger._82000003_survival {
    public static class _15_relicmob_grey {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1500, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509});
                context.SetUserValue(key: "RelicMobSpawn", value: 0);
                context.SetUserValue(key: "RelicMobRemove", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RelicMobSpawn") == 1) {
                    context.State = new StateDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateMobSpawnRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawnRandom : TriggerState {
            internal StateMobSpawnRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn06(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn07(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn08(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn09(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StateMobSpawn10(context);
                    return;
                }

                if (context.GetUserValue(key: "ExtraEventOff") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn01 : TriggerState {
            internal StateMobSpawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1500}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1500})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn02 : TriggerState {
            internal StateMobSpawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1501}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1501})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn03 : TriggerState {
            internal StateMobSpawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1502}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1502})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn04 : TriggerState {
            internal StateMobSpawn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1503}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1503})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn05 : TriggerState {
            internal StateMobSpawn05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1504}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1504})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn06 : TriggerState {
            internal StateMobSpawn06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1505}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1505})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn07 : TriggerState {
            internal StateMobSpawn07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1506}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1506})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn08 : TriggerState {
            internal StateMobSpawn08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1507}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1507})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn09 : TriggerState {
            internal StateMobSpawn09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1508})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn10 : TriggerState {
            internal StateMobSpawn10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1509}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1509})) {
                    context.State = new StateNotice(context);
                    return;
                }

                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNotice : TriggerState {
            internal StateNotice(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 16, key: "RelicMobGreyDie", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RelicMobRemove") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1500, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
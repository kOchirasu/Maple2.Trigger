namespace Maple2.Trigger._02020141_bf {
    public static class _mobspawn06 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateBossSpawn때까지Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn때까지Wait : TriggerState {
            internal StateBossSpawn때까지Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateTrigger영역체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger영역체크시작 : TriggerState {
            internal StateTrigger영역체크시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸MonsterRemove작업(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State졸MonsterRemove작업(context);
                }

                if (context.UserDetected(boxIds: new []{10600})) {
                    return new State졸MonsterSpawnWaiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸MonsterSpawnWaiting : TriggerState {
            internal State졸MonsterSpawnWaiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTrigger영역안플레이어Final체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger영역안플레이어Final체크 : TriggerState {
            internal StateTrigger영역안플레이어Final체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸MonsterRemove작업(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State졸MonsterRemove작업(context);
                }

                if (context.UserDetected(boxIds: new []{10600})) {
                    return new State졸MonsterSpawn하기(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateTrigger영역체크시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸MonsterSpawn하기 : TriggerState {
            internal State졸MonsterSpawn하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{10601, 10602, 10603, 10604}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTrigger영역에계속있는지체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger영역에계속있는지체크 : TriggerState {
            internal StateTrigger영역에계속있는지체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸MonsterRemove작업(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State졸MonsterRemove작업(context);
                }

                if (context.UserDetected(boxIds: new []{10600})) {
                    return new State졸Monster리젠단계시작(context);
                }

                if (!context.UserDetected(boxIds: new []{10600})) {
                    return new State졸MonsterRemove작동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸Monster리젠단계시작 : TriggerState {
            internal State졸Monster리젠단계시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10600})) {
                    return new State졸Monster리젠Waiting(context);
                }

                if (!context.UserDetected(boxIds: new []{10600})) {
                    return new State졸MonsterRemove작동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸Monster리젠Waiting : TriggerState {
            internal State졸Monster리젠Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸MonsterRemove작업(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State졸MonsterRemove작업(context);
                }

                if (!context.UserDetected(boxIds: new []{10600})) {
                    return new State졸MonsterRemove작동Wait(context);
                }

                if (context.WaitTick(waitTick: 15000)) {
                    return new State졸Monster리젠YesNo(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸Monster리젠YesNo : TriggerState {
            internal State졸Monster리젠YesNo(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new State졸MonsterRemove작업(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State졸MonsterRemove작업(context);
                }

                if (context.UserDetected(boxIds: new []{10600})) {
                    return new State졸MonsterSpawn하기(context);
                }

                if (!context.UserDetected(boxIds: new []{10600})) {
                    return new State졸MonsterRemove작동Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸MonsterRemove작동Wait : TriggerState {
            internal State졸MonsterRemove작동Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10600})) {
                    return new StateTrigger영역에계속있는지체크(context);
                }

                if (context.WaitTick(waitTick: 7000)) {
                    return new State졸MonsterRemove작업(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State졸MonsterRemove작업 : TriggerState {
            internal State졸MonsterRemove작업(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{10601, 10602, 10603, 10604});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MobSpawnStop") == 4) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateTrigger영역체크시작(context);
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

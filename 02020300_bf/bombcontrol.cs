namespace Maple2.Trigger._02020300_bf {
    public static class _bombcontrol {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "RandomBombEnd", value: 0);
                context.StartCombineSpawn(groupId: new []{516}, isStart: false);
                context.StartCombineSpawn(groupId: new []{517}, isStart: false);
                context.StartCombineSpawn(groupId: new []{518}, isStart: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "RandomBomb") == 1) {
                    return new State포탑Creation_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑Creation_1 : TriggerState {
            internal State포탑Creation_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{152}, arg2: true);
                context.StartCombineSpawn(groupId: new []{518}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{152})) {
                    return new State포탑Creation_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑Creation_2 : TriggerState {
            internal State포탑Creation_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{516}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State포탑Creation_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑Creation_3 : TriggerState {
            internal State포탑Creation_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{517}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{151, 152, 153, 154, 155, 156, 157, 158, 159})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "RandomBombEnd", value: 1);
                context.StartCombineSpawn(groupId: new []{516}, isStart: false);
                context.StartCombineSpawn(groupId: new []{517}, isStart: false);
                context.StartCombineSpawn(groupId: new []{518}, isStart: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

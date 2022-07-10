namespace Maple2.Trigger._02020061_bf {
    public static class _boss_monsterspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{482}, isStart: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MonsterSpawn") == 1) {
                    return new State스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰 : TriggerState {
            internal State스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{482}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MonsterSpawn") == 0) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{482}, isStart: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02100000_bf {
    public static class _spawn {
        public class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MonsterSpawn") == 1) {
                    return new State끝_1(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {81003, 810031, 810032}, arg2: true);
            }
        }

        private class State끝_1 : TriggerState {
            internal State끝_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {82001})) {
                    // return new State성공(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {-1});
            }
        }
    }
}
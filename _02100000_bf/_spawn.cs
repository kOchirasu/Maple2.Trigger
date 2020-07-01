namespace Maple2.Trigger._02100000_bf {
    public static class _spawn {
        public class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "MonsterSpawn") == 1) {
                    context.State = new State끝_1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {81003}, arg2: true);
                context.CreateMonster(arg1: new[] {810031}, arg2: true);
                context.CreateMonster(arg1: new[] {810032}, arg2: true);
            }
        }

        private class State끝_1 : TriggerState {
            internal State끝_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {82001})) {
                    // context.State = new State성공(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {-1});
            }
        }
    }
}
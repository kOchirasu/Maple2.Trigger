namespace Maple2.Trigger._02000187_bf {
    public static class _trigger_01 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {20001281}, arg3: new byte[] {2})) {
                    return new State몹리젠(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹리젠 : TriggerState {
            internal State몹리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205, 206})) {
                    return new State쿨타임(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쿨타임 : TriggerState {
            internal State쿨타임(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State시작대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
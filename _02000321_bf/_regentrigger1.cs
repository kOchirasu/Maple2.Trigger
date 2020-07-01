namespace Maple2.Trigger._02000321_bf {
    public static class _regentrigger1 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 101, arg2: new[] {900})) { }
            }

            public override void OnExit() { }
        }

        private class State웜리젠91 : TriggerState {
            internal State웜리젠91(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {3, 4});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {3, 4})) {
                    context.State = new State웜리젠91쿨타임(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웜리젠91쿨타임 : TriggerState {
            internal State웜리젠91쿨타임(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "9");
                context.SetTimer(arg1: "9", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.ResetTimer(arg1: "9");
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
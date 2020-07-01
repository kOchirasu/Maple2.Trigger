namespace Maple2.Trigger._52020019_qd {
    public static class _eone {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60200010},
                    arg3: new byte[] {1})) {
                    context.State = new StateTalk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalk : TriggerState {
            internal StateTalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "무엄하군요! 저리 가세요!", duration: 3000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateIdle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
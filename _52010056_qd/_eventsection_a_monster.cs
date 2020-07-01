namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_a_monster {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2002})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 201, msg: "$52010056_QD__EventSection_A_Monster__0$", duration: 2800, delayTick: 0);
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
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
                context.AddBalloonTalk(spawnPointId: 201, msg: "$52010056_QD__EventSection_A_Monster__0$",
                    duration: 2800, delayTick: 0);
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.CreateMonster(arg1: new[] {202}, arg2: true);
                context.CreateMonster(arg1: new[] {203}, arg2: true);
                context.CreateMonster(arg1: new[] {204}, arg2: true);
                context.CreateMonster(arg1: new[] {205}, arg2: true);
                context.CreateMonster(arg1: new[] {206}, arg2: true);
                context.CreateMonster(arg1: new[] {207}, arg2: true);
                context.CreateMonster(arg1: new[] {208}, arg2: true);
                context.CreateMonster(arg1: new[] {209}, arg2: true);
                context.CreateMonster(arg1: new[] {210}, arg2: true);
                context.CreateMonster(arg1: new[] {211}, arg2: true);
                context.CreateMonster(arg1: new[] {212}, arg2: true);
                context.CreateMonster(arg1: new[] {213}, arg2: true);
                context.CreateMonster(arg1: new[] {214}, arg2: true);
                context.CreateMonster(arg1: new[] {215}, arg2: true);
                context.CreateMonster(arg1: new[] {216}, arg2: true);
                context.CreateMonster(arg1: new[] {217}, arg2: true);
                context.CreateMonster(arg1: new[] {218}, arg2: true);
                context.CreateMonster(arg1: new[] {219}, arg2: true);
                context.CreateMonster(arg1: new[] {220}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
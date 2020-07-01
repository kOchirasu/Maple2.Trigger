using System;

namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_a_monster {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2002})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 201, msg: "$52010056_QD__EventSection_A_Monster__0$",
                    duration: 2800, delayTick: 0);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.CreateMonster(arg1: new int[] {203}, arg2: true);
                context.CreateMonster(arg1: new int[] {204}, arg2: true);
                context.CreateMonster(arg1: new int[] {205}, arg2: true);
                context.CreateMonster(arg1: new int[] {206}, arg2: true);
                context.CreateMonster(arg1: new int[] {207}, arg2: true);
                context.CreateMonster(arg1: new int[] {208}, arg2: true);
                context.CreateMonster(arg1: new int[] {209}, arg2: true);
                context.CreateMonster(arg1: new int[] {210}, arg2: true);
                context.CreateMonster(arg1: new int[] {211}, arg2: true);
                context.CreateMonster(arg1: new int[] {212}, arg2: true);
                context.CreateMonster(arg1: new int[] {213}, arg2: true);
                context.CreateMonster(arg1: new int[] {214}, arg2: true);
                context.CreateMonster(arg1: new int[] {215}, arg2: true);
                context.CreateMonster(arg1: new int[] {216}, arg2: true);
                context.CreateMonster(arg1: new int[] {217}, arg2: true);
                context.CreateMonster(arg1: new int[] {218}, arg2: true);
                context.CreateMonster(arg1: new int[] {219}, arg2: true);
                context.CreateMonster(arg1: new int[] {220}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
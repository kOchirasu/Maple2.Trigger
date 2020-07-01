namespace Maple2.Trigger._52000076_qd {
    public static class _fog {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000813}, arg2: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 136, arg2: new[] {2006})) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1098});
                context.SetEffect(arg1: new[] {600}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000813}, arg2: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1098})) {
                    context.State = new State포그(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포그 : TriggerState {
            internal State포그(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000813}, arg2: 1);
                context.ShowGuideSummary(entityId: 20003494, textId: 20003494);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000813}, arg2: 0)) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20003494);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000813}, arg2: 0);
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
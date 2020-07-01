namespace Maple2.Trigger._81000003_item {
    public static class _wait {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "60", arg2: 175, arg3: true, arg4: false); // wait.xml 시작 타이머 설정
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {402})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "ME_001_Wait_00");
                context.SetEffect(arg1: new[] {610}, arg2: true);
                context.ShowGuideSummary(entityId: 26100001, textId: 26100001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기2(context);
                    return;
                }

                if (context.TimeExpired(arg1: "60")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 26100001);
            }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "ME_001_Wait_00");
                context.ShowGuideSummary(entityId: 26100002, textId: 26100002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "60")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 26100002);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
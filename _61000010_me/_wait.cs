using System;

namespace Maple2.Trigger._61000010_me {
    public static class _wait {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "60", arg2: 60, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
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
                context.ShowGuideSummary(entityID: 26100001, textID: 26100001);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 101, arg2: 20)) {
                    context.State = new State종료(context);
                    return;
                }

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
                context.HideGuideSummary(entityID: 26100001);
            }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "ME_001_Wait_00");
                context.ShowGuideSummary(entityID: 26100002, textID: 26100002);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 101, arg2: 20)) {
                    context.State = new State종료(context);
                    return;
                }

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
                context.HideGuideSummary(entityID: 26100002);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 999101, key: "GameStart", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
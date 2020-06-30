using System;

namespace Maple2.Trigger._52000014_qd {
    public static class _obstruct_4300 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {4300}, arg2: false);
                context.SetEffect(arg1: new int[] {430}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new State발동준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발동준비 : TriggerState {
            internal State발동준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State발동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발동 : TriggerState {
            internal State발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 3);
                context.SetSkill(arg1: new int[] {4300}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 1);
                context.SetSkill(arg1: new int[] {4300}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State발동준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
using System;

namespace Maple2.Trigger._02000523_bf {
    public static class _regentrigger1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 101, arg2: new int[] {900})) {
                    context.State = new State웜리젠91(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웜리젠91 : TriggerState {
            internal State웜리젠91(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {3, 4});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {3, 4})) {
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
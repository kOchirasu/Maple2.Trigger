using System;

namespace Maple2.Trigger._02000331_bf {
    public static class _qcomplete {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "clearafter", value: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9032}, arg2: new int[] {10003065},
                    arg3: new byte[] {2})) {
                    context.State = new State완료npc리젠(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료npc리젠 : TriggerState {
            internal State완료npc리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {112});
            }

            public override void Execute() {
                if (context.UserValue(key: "clearafter", value: 1)) {
                    context.State = new State완료npc킬(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료npc킬 : TriggerState {
            internal State완료npc킬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {112});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
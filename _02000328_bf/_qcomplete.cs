namespace Maple2.Trigger._02000328_bf {
    public static class _qcomplete {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "clearafter", value: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {999999}, arg2: new[] {10003061},
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
                context.CreateMonster(arg1: new[] {2002});
            }

            public override void Execute() {
                if (context.GetUserValue(key: "clearafter") == 1) {
                    context.State = new State완료npc킬(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료npc킬 : TriggerState {
            internal State완료npc킬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2002});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
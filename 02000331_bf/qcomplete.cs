namespace Maple2.Trigger._02000331_bf {
    public static class _qcomplete {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "clearafter", value: 0);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9032}, arg2: new[] {10003065}, arg3: new byte[] {2})) {
                    return new State완료npc리젠(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료npc리젠 : TriggerState {
            internal State완료npc리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {112});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "clearafter") == 1) {
                    return new State완료npc킬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료npc킬 : TriggerState {
            internal State완료npc킬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {112});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
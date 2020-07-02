namespace Maple2.Trigger._02020101_bf {
    public static class _debuff {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Debuff") == 1) {
                    return new State디Buff시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디Buff시작 : TriggerState {
            internal State디Buff시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900002, key: "Debuff", value: 0);
                context.AddBuff(arg1: new[] {1004}, arg2: 70002122, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Debuff") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900002, key: "Debuff", value: 0);
                context.RemoveBuff(arg1: 1004, arg2: 70002122, arg3: true);
                context.AddBuff(arg1: new[] {1004}, arg2: 70002123, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Debuff") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
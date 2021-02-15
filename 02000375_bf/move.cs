namespace Maple2.Trigger._02000375_bf {
    public static class _move {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023}, arg2: true);
                context.SetBreakable(arg1: new[] {7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001024}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001024}, arg2: 0)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000375_BF__move__0$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    return new StateLever삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever삭제 : TriggerState {
            internal StateLever삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023}, arg2: false);
                context.SetBreakable(arg1: new[] {7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001024}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleEnd") == 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02000207_bf {
    public static class _trigger_01 {
        public class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(
                    arg1: new[] {
                        7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016,
                        7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032,
                        7033, 7034, 7035, 7036, 7037, 7038, 7039
                    }, arg2: false);
                context.SetInteractObject(arg1: new[] {10000063}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000063}, arg2: 0)) {
                    context.SetBreakable(
                        arg1: new[] {
                            7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015,
                            7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030,
                            7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039
                        }, arg2: true);
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
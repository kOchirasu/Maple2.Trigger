using System;

namespace Maple2.Trigger._02010052_bf {
    public static class _xray_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        20400, 20401, 20402, 20403, 20404, 20405, 20406, 20407, 20408, 20409, 20410, 20411, 20412,
                        20413, 20414, 20415, 20416, 20417, 20418, 20419, 20420, 20421, 20422, 20423, 20424, 20425,
                        20426, 20427, 20428, 20429, 20430
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 706, arg2: 1)) {
                    context.State = new Statexray(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statexray : TriggerState {
            internal Statexray(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        20400, 20401, 20402, 20403, 20404, 20405, 20406, 20407, 20408, 20409, 20410, 20411, 20412,
                        20413, 20414, 20415, 20416, 20417, 20418, 20419, 20420, 20421, 20422, 20423, 20424, 20425,
                        20426, 20427, 20428, 20429, 20430
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override void Execute() {
                if (!context.CountUsers(arg1: 706, arg2: 1)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
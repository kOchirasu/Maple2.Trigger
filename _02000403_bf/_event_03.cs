using System;

namespace Maple2.Trigger._02000403_bf {
    public static class _event_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {171}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "704")) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 704, arg2: "trigger", arg3: "Hauntedmansion");
                context.MoveNpc(arg1: 171, arg2: "MS2PatrolData_2139");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReady_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {171});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
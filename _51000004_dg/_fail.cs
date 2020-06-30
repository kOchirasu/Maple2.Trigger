using System;

namespace Maple2.Trigger._51000004_dg {
    public static class _fail {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stategameset(context);

        private class Stategameset : TriggerState {
            internal Stategameset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8011, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Fail", value: 1)) {
                    context.State = new StateFail_condition(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFail_condition : TriggerState {
            internal StateFail_condition(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9001")) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Result_01");
                context.WriteLog(arg1: "PinkBeanThreeTwoOne_log", arg2: 9001, arg3: "char_event", arg5: "gameover");
                context.SetTimer(arg1: "10", arg2: 10, arg4: true);
                context.CameraSelectPath(arg1: new int[] {8011, 8010}, arg2: false);
                context.ArcadeThreeTwoOne(type: "EndGame");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
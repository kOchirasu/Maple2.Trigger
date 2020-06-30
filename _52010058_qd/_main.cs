using System;

namespace Maple2.Trigger._52010058_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9010, arg2: 2)) {
                    context.State = new State성공연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State성공연출시작 : TriggerState {
            internal State성공연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\WorldInvasionScene6.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new Statequit02(context);
                    return;
                }

                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new Statequit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequit02 : TriggerState {
            internal Statequit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
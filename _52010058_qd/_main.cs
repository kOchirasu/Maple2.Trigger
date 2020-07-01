namespace Maple2.Trigger._52010058_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9010) == 2) {
                    return new State성공연출시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State성공연출시작 : TriggerState {
            internal State성공연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\WorldInvasionScene6.usm", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new Statequit02(context);
                }

                if (context.WaitTick(waitTick: 9000)) {
                    return new Statequit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statequit02 : TriggerState {
            internal Statequit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422, arg2: 3);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
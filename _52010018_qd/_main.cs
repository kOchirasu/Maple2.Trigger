namespace Maple2.Trigger._52010018_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852}, arg3: new byte[] {1})) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1002, 1003, 1004, 1006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_A");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_A");
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006_A");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1002})) {
                    context.State = new State둔바대사01(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {1003})) {
                    context.State = new State둔바대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바대사01 : TriggerState {
            internal State둔바대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001217, arg3: "$52010018_QD__MAIN__0$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State에레브대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에레브대사01 : TriggerState {
            internal State에레브대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010018_QD__MAIN__1$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State미카대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카대사01 : TriggerState {
            internal State미카대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010018_QD__MAIN__2$", arg4: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State미카이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미카이동01 : TriggerState {
            internal State미카이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006_B");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {1006})) {
                    context.State = new State동영상재생대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동영상재생대기 : TriggerState {
            internal State동영상재생대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State동영상재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동영상재생 : TriggerState {
            internal State동영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "awaken.swf", movieId: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State동영상종료대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동영상종료대기 : TriggerState {
            internal State동영상종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State업적발생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State업적발생 : TriggerState {
            internal State업적발생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "ChangeMika");
                context.DestroyMonster(arg1: new[] {1006});
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
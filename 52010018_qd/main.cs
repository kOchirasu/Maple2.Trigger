namespace Maple2.Trigger._52010018_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {10002852}, arg3: new byte[] {1})) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {1002, 1003, 1004, 1006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002_A");
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003_A");
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData_1004_A");
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006_A");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {1002})) {
                    return new State둔바Script01(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {1003})) {
                    return new State둔바Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State둔바Script01 : TriggerState {
            internal State둔바Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001217, arg3: "$52010018_QD__MAIN__0$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State에레브Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script01 : TriggerState {
            internal State에레브Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010018_QD__MAIN__1$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State미카Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script01 : TriggerState {
            internal State미카Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010018_QD__MAIN__2$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State미카이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카이동01 : TriggerState {
            internal State미카이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
                context.MoveNpc(arg1: 1006, arg2: "MS2PatrolData_1006_B");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {1006})) {
                    return new State동영상재생Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동영상재생Wait : TriggerState {
            internal State동영상재생Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State동영상재생(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State동영상종료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동영상종료Wait : TriggerState {
            internal State동영상종료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAchievement(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAchievement : TriggerState {
            internal StateAchievement(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "ChangeMika");
                context.DestroyMonster(arg1: new[] {1006});
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
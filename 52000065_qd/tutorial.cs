namespace Maple2.Trigger._52000065_qd {
    public static class _tutorial {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1000, 2000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 20, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 30, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 40, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 50, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 60, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 70, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 80, arg2: false, arg3: false, arg4: false);
                context.CreateWidget(arg1: "Guide");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State영상Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상Prepare_01 : TriggerState {
            internal State영상Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상재생_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생_01 : TriggerState {
            internal State영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\Common_Opening.usm", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State영상완료_01(context);
                }

                if (context.WaitTick(waitTick: 190000)) {
                    return new State영상완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상완료_01 : TriggerState {
            internal State영상완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "251")) {
                    return new StateMonster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1000, 2000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.GuideEvent(eventId: 260);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001}, arg2: 90)) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.StartTutorial();
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 110)) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.StartTutorial();
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 100)) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.StartTutorial();
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 1)) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.StartTutorial();
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 10)) {
                    context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 20)) {
                    context.SetPortal(arg1: 20, arg2: true, arg3: true, arg4: true);
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 30)) {
                    context.SetPortal(arg1: 30, arg2: true, arg3: true, arg4: true);
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 40)) {
                    context.SetPortal(arg1: 40, arg2: true, arg3: true, arg4: true);
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 50)) {
                    context.SetPortal(arg1: 50, arg2: true, arg3: true, arg4: true);
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 60)) {
                    context.SetPortal(arg1: 60, arg2: true, arg3: true, arg4: true);
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 70)) {
                    context.SetPortal(arg1: 70, arg2: true, arg3: true, arg4: true);
                }

                if (context.UserDetected(arg1: new[] {9001}, arg2: 80)) {
                    context.SetPortal(arg1: 80, arg2: true, arg3: true, arg4: true);
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
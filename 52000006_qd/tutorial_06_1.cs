namespace Maple2.Trigger._52000006_qd {
    public static class _tutorial_06_1 {
        public class State엔터Waiting : TriggerState {
            internal State엔터Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new StateCinematic세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic세팅 : TriggerState {
            internal StateCinematic세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StatePCScript1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript1 : TriggerState {
            internal StatePCScript1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 2);
                context.SetCinematicUI(type: 3, script: "$52000006_QD__TUTORIAL_06_1__0$");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State양Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State양Spawn : TriggerState {
            internal State양Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 2);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.SetCinematicUI(type: 3, script: "$52000006_QD__TUTORIAL_06_1__1$");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State양이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State양이동 : TriggerState {
            internal State양이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 4);
                context.MoveNpc(arg1: 201, arg2: "PatrolData_Sheep_01");
                context.SetCinematicUI(type: 3, script: "$52000006_QD__TUTORIAL_06_1__2$");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic : TriggerState {
            internal StateEndCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.CameraSelect(arg1: 302, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52000006_qd {
    public static class _tutorial_06_1 {
        public class State엔터대기중 : TriggerState {
            internal State엔터대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new State연출세팅(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출세팅 : TriggerState {
            internal State연출세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StatePC대사1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대사1 : TriggerState {
            internal StatePC대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetProductionUI(arg1: 3, arg2: "$52000006_QD__TUTORIAL_06_1__0$");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State양Appear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State양Appear : TriggerState {
            internal State양Appear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.SetProductionUI(arg1: 3, arg2: "$52000006_QD__TUTORIAL_06_1__1$");
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
                context.SetTimer(arg1: "1", arg2: 4);
                context.MoveNpc(arg1: 201, arg2: "PatrolData_Sheep_01");
                context.SetProductionUI(arg1: 3, arg2: "$52000006_QD__TUTORIAL_06_1__2$");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State연출끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출끝 : TriggerState {
            internal State연출끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.CameraSelect(arg1: 302, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
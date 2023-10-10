namespace Maple2.Trigger._52000014_qd {
    public static class _meteo_7100 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{7100, 7101, 7102, 7103, 7104, 7105, 7106, 7107, 7108, 7109}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateStartDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDelay01 : TriggerState {
            internal StateStartDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "201", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "201")) {
                    return new StateRandomCreation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomCreation01 : TriggerState {
            internal StateRandomCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StatePattern01Creation01(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StatePattern02Creation01(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StatePattern03Creation01(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StatePattern04Creation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01Creation01 : TriggerState {
            internal StatePattern01Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetMesh(triggerIds: new []{7101}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StatePattern01낙하01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01낙하01 : TriggerState {
            internal StatePattern01낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 1);
                context.SetMesh(triggerIds: new []{7101}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StatePattern01Creation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01Creation02 : TriggerState {
            internal StatePattern01Creation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 1);
                context.SetMesh(triggerIds: new []{7105}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StatePattern01낙하02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01낙하02 : TriggerState {
            internal StatePattern01낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 1);
                context.SetMesh(triggerIds: new []{7105}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StatePattern01Creation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01Creation03 : TriggerState {
            internal StatePattern01Creation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 1);
                context.SetMesh(triggerIds: new []{7107}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StatePattern01낙하03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01낙하03 : TriggerState {
            internal StatePattern01낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 1);
                context.SetMesh(triggerIds: new []{7107}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateDelayRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02Creation01 : TriggerState {
            internal StatePattern02Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 1);
                context.SetMesh(triggerIds: new []{7108}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "11")) {
                    return new StatePattern02낙하01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02낙하01 : TriggerState {
            internal StatePattern02낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "12", seconds: 1);
                context.SetMesh(triggerIds: new []{7108}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "12")) {
                    return new StatePattern02Creation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02Creation02 : TriggerState {
            internal StatePattern02Creation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "13", seconds: 1);
                context.SetMesh(triggerIds: new []{7104}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "13")) {
                    return new StatePattern02낙하02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02낙하02 : TriggerState {
            internal StatePattern02낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "14", seconds: 1);
                context.SetMesh(triggerIds: new []{7104}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "14")) {
                    return new StatePattern02Creation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02Creation03 : TriggerState {
            internal StatePattern02Creation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "15", seconds: 1);
                context.SetMesh(triggerIds: new []{7102}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new StatePattern02낙하03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02낙하03 : TriggerState {
            internal StatePattern02낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "16", seconds: 1);
                context.SetMesh(triggerIds: new []{7102}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "16")) {
                    return new StateDelayRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03Creation01 : TriggerState {
            internal StatePattern03Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "21", seconds: 1);
                context.SetMesh(triggerIds: new []{7109}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "21")) {
                    return new StatePattern03낙하01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03낙하01 : TriggerState {
            internal StatePattern03낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 1);
                context.SetMesh(triggerIds: new []{7109}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "22")) {
                    return new StatePattern03Creation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03Creation02 : TriggerState {
            internal StatePattern03Creation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "23", seconds: 1);
                context.SetMesh(triggerIds: new []{7103}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "23")) {
                    return new StatePattern03낙하02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03낙하02 : TriggerState {
            internal StatePattern03낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "24", seconds: 1);
                context.SetMesh(triggerIds: new []{7103}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "24")) {
                    return new StatePattern03Creation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03Creation03 : TriggerState {
            internal StatePattern03Creation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "25", seconds: 1);
                context.SetMesh(triggerIds: new []{7104}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "25")) {
                    return new StatePattern03낙하03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03낙하03 : TriggerState {
            internal StatePattern03낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "26", seconds: 1);
                context.SetMesh(triggerIds: new []{7104}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "26")) {
                    return new StatePattern03Creation04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03Creation04 : TriggerState {
            internal StatePattern03Creation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "27", seconds: 1);
                context.SetMesh(triggerIds: new []{7106}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "27")) {
                    return new StatePattern03낙하04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03낙하04 : TriggerState {
            internal StatePattern03낙하04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "28", seconds: 1);
                context.SetMesh(triggerIds: new []{7106}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "28")) {
                    return new StateDelayRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04Creation01 : TriggerState {
            internal StatePattern04Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "31", seconds: 1);
                context.SetMesh(triggerIds: new []{7102}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "31")) {
                    return new StatePattern04낙하01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04낙하01 : TriggerState {
            internal StatePattern04낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "32", seconds: 1);
                context.SetMesh(triggerIds: new []{7102}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "32")) {
                    return new StatePattern04Creation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04Creation02 : TriggerState {
            internal StatePattern04Creation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "33", seconds: 1);
                context.SetMesh(triggerIds: new []{7107}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "33")) {
                    return new StatePattern04낙하02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04낙하02 : TriggerState {
            internal StatePattern04낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "34", seconds: 1);
                context.SetMesh(triggerIds: new []{7107}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "34")) {
                    return new StatePattern04Creation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04Creation03 : TriggerState {
            internal StatePattern04Creation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "35", seconds: 1);
                context.SetMesh(triggerIds: new []{7103}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "35")) {
                    return new StatePattern04낙하03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04낙하03 : TriggerState {
            internal StatePattern04낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "36", seconds: 1);
                context.SetMesh(triggerIds: new []{7103}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "36")) {
                    return new StatePattern04Creation04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04Creation04 : TriggerState {
            internal StatePattern04Creation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "37", seconds: 1);
                context.SetMesh(triggerIds: new []{7108}, visible: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "37")) {
                    return new StatePattern04낙하04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04낙하04 : TriggerState {
            internal StatePattern04낙하04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "38", seconds: 1);
                context.SetMesh(triggerIds: new []{7108}, visible: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "38")) {
                    return new StateDelayRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelayRandom01 : TriggerState {
            internal StateDelayRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateDelay01(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateDelay02(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateDelay03(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateDelay04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "100", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "101", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "101")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "102", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "102")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay04 : TriggerState {
            internal StateDelay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "103", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "103")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "200", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "200")) {
                    return new StateRandomCreation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

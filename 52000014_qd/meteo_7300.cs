namespace Maple2.Trigger._52000014_qd {
    public static class _meteo_7300 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7300, 7301, 7302, 7303, 7304, 7305, 7306, 7307, 7308, 7309}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateStartDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartDelay01 : TriggerState {
            internal StateStartDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "201", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "201")) {
                    return new StateRandomCreation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRandomCreation01 : TriggerState {
            internal StateRandomCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern01Creation01(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern02Creation01(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern03Creation01(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StatePattern04Creation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01Creation01 : TriggerState {
            internal StatePattern01Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
                context.SetMesh(arg1: new[] {7301}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StatePattern01낙하01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01낙하01 : TriggerState {
            internal StatePattern01낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 1);
                context.SetMesh(arg1: new[] {7301}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StatePattern01Creation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01Creation02 : TriggerState {
            internal StatePattern01Creation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 1);
                context.SetMesh(arg1: new[] {7305}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StatePattern01낙하02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01낙하02 : TriggerState {
            internal StatePattern01낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "4", arg2: 1);
                context.SetMesh(arg1: new[] {7305}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StatePattern01Creation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01Creation03 : TriggerState {
            internal StatePattern01Creation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 1);
                context.SetMesh(arg1: new[] {7307}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StatePattern01낙하03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern01낙하03 : TriggerState {
            internal StatePattern01낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "6", arg2: 1);
                context.SetMesh(arg1: new[] {7307}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new StateDelayRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02Creation01 : TriggerState {
            internal StatePattern02Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "11", arg2: 1);
                context.SetMesh(arg1: new[] {7308}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new StatePattern02낙하01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02낙하01 : TriggerState {
            internal StatePattern02낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "12", arg2: 1);
                context.SetMesh(arg1: new[] {7308}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new StatePattern02Creation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02Creation02 : TriggerState {
            internal StatePattern02Creation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "13", arg2: 1);
                context.SetMesh(arg1: new[] {7304}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    return new StatePattern02낙하02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02낙하02 : TriggerState {
            internal StatePattern02낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "14", arg2: 1);
                context.SetMesh(arg1: new[] {7304}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    return new StatePattern02Creation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02Creation03 : TriggerState {
            internal StatePattern02Creation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "15", arg2: 1);
                context.SetMesh(arg1: new[] {7302}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new StatePattern02낙하03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern02낙하03 : TriggerState {
            internal StatePattern02낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "16", arg2: 1);
                context.SetMesh(arg1: new[] {7302}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "16")) {
                    return new StateDelayRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03Creation01 : TriggerState {
            internal StatePattern03Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "21", arg2: 1);
                context.SetMesh(arg1: new[] {7309}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    return new StatePattern03낙하01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03낙하01 : TriggerState {
            internal StatePattern03낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "22", arg2: 1);
                context.SetMesh(arg1: new[] {7309}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    return new StatePattern03Creation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03Creation02 : TriggerState {
            internal StatePattern03Creation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "23", arg2: 1);
                context.SetMesh(arg1: new[] {7303}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    return new StatePattern03낙하02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03낙하02 : TriggerState {
            internal StatePattern03낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "24", arg2: 1);
                context.SetMesh(arg1: new[] {7303}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "24")) {
                    return new StatePattern03Creation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03Creation03 : TriggerState {
            internal StatePattern03Creation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "25", arg2: 1);
                context.SetMesh(arg1: new[] {7304}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    return new StatePattern03낙하03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03낙하03 : TriggerState {
            internal StatePattern03낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "26", arg2: 1);
                context.SetMesh(arg1: new[] {7304}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "26")) {
                    return new StatePattern03Creation04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03Creation04 : TriggerState {
            internal StatePattern03Creation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "27", arg2: 1);
                context.SetMesh(arg1: new[] {7306}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "27")) {
                    return new StatePattern03낙하04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern03낙하04 : TriggerState {
            internal StatePattern03낙하04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "28", arg2: 1);
                context.SetMesh(arg1: new[] {7306}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "28")) {
                    return new StateDelayRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04Creation01 : TriggerState {
            internal StatePattern04Creation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "31", arg2: 1);
                context.SetMesh(arg1: new[] {7302}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    return new StatePattern04낙하01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04낙하01 : TriggerState {
            internal StatePattern04낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "32", arg2: 1);
                context.SetMesh(arg1: new[] {7302}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "32")) {
                    return new StatePattern04Creation02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04Creation02 : TriggerState {
            internal StatePattern04Creation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "33", arg2: 1);
                context.SetMesh(arg1: new[] {7307}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "33")) {
                    return new StatePattern04낙하02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04낙하02 : TriggerState {
            internal StatePattern04낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "34", arg2: 1);
                context.SetMesh(arg1: new[] {7307}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "34")) {
                    return new StatePattern04Creation03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04Creation03 : TriggerState {
            internal StatePattern04Creation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "35", arg2: 1);
                context.SetMesh(arg1: new[] {7303}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    return new StatePattern04낙하03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04낙하03 : TriggerState {
            internal StatePattern04낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "36", arg2: 1);
                context.SetMesh(arg1: new[] {7303}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "36")) {
                    return new StatePattern04Creation04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04Creation04 : TriggerState {
            internal StatePattern04Creation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "37", arg2: 1);
                context.SetMesh(arg1: new[] {7308}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "37")) {
                    return new StatePattern04낙하04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePattern04낙하04 : TriggerState {
            internal StatePattern04낙하04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "38", arg2: 1);
                context.SetMesh(arg1: new[] {7308}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "38")) {
                    return new StateDelayRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelayRandom01 : TriggerState {
            internal StateDelayRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateDelay01(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateDelay02(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateDelay03(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateDelay04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "100", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "100")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "101", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "101")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "102", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "102")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay04 : TriggerState {
            internal StateDelay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "103", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "103")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "200", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "200")) {
                    return new StateRandomCreation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52000014_qd {
    public static class _meteo_7000 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7000, 7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new State랜덤생성01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤생성01 : TriggerState {
            internal State랜덤생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴01생성01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴02생성01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴03생성01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State패턴04생성01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01생성01 : TriggerState {
            internal State패턴01생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetMesh(arg1: new[] {7000}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State패턴01낙하01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01낙하01 : TriggerState {
            internal State패턴01낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 1);
                context.SetMesh(arg1: new[] {7000}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State패턴01생성02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01생성02 : TriggerState {
            internal State패턴01생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 1);
                context.SetMesh(arg1: new[] {7002}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State패턴01낙하02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01낙하02 : TriggerState {
            internal State패턴01낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 1);
                context.SetMesh(arg1: new[] {7002}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State패턴01생성03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01생성03 : TriggerState {
            internal State패턴01생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 1);
                context.SetMesh(arg1: new[] {7007}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State패턴01낙하03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴01낙하03 : TriggerState {
            internal State패턴01낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 1);
                context.SetMesh(arg1: new[] {7007}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State딜레이랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02생성01 : TriggerState {
            internal State패턴02생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 1);
                context.SetMesh(arg1: new[] {7002}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State패턴02낙하01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02낙하01 : TriggerState {
            internal State패턴02낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 1);
                context.SetMesh(arg1: new[] {7002}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State패턴02생성02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02생성02 : TriggerState {
            internal State패턴02생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 1);
                context.SetMesh(arg1: new[] {7004}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    context.State = new State패턴02낙하02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02낙하02 : TriggerState {
            internal State패턴02낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 1);
                context.SetMesh(arg1: new[] {7004}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    context.State = new State패턴02생성03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02생성03 : TriggerState {
            internal State패턴02생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "15", arg2: 1);
                context.SetMesh(arg1: new[] {7008}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State패턴02낙하03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴02낙하03 : TriggerState {
            internal State패턴02낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "16", arg2: 1);
                context.SetMesh(arg1: new[] {7008}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "16")) {
                    context.State = new State딜레이랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03생성01 : TriggerState {
            internal State패턴03생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "21", arg2: 1);
                context.SetMesh(arg1: new[] {7009}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "21")) {
                    context.State = new State패턴03낙하01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03낙하01 : TriggerState {
            internal State패턴03낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 1);
                context.SetMesh(arg1: new[] {7009}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "22")) {
                    context.State = new State패턴03생성02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03생성02 : TriggerState {
            internal State패턴03생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "23", arg2: 1);
                context.SetMesh(arg1: new[] {7006}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "23")) {
                    context.State = new State패턴03낙하02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03낙하02 : TriggerState {
            internal State패턴03낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "24", arg2: 1);
                context.SetMesh(arg1: new[] {7006}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "24")) {
                    context.State = new State패턴03생성03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03생성03 : TriggerState {
            internal State패턴03생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 1);
                context.SetMesh(arg1: new[] {7003}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    context.State = new State패턴03낙하03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03낙하03 : TriggerState {
            internal State패턴03낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "26", arg2: 1);
                context.SetMesh(arg1: new[] {7003}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "26")) {
                    context.State = new State패턴03생성04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03생성04 : TriggerState {
            internal State패턴03생성04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "27", arg2: 1);
                context.SetMesh(arg1: new[] {7008}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "27")) {
                    context.State = new State패턴03낙하04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴03낙하04 : TriggerState {
            internal State패턴03낙하04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "28", arg2: 1);
                context.SetMesh(arg1: new[] {7008}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "28")) {
                    context.State = new State딜레이랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04생성01 : TriggerState {
            internal State패턴04생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 1);
                context.SetMesh(arg1: new[] {7001}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    context.State = new State패턴04낙하01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04낙하01 : TriggerState {
            internal State패턴04낙하01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "32", arg2: 1);
                context.SetMesh(arg1: new[] {7001}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "32")) {
                    context.State = new State패턴04생성02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04생성02 : TriggerState {
            internal State패턴04생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "33", arg2: 1);
                context.SetMesh(arg1: new[] {7005}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "33")) {
                    context.State = new State패턴04낙하02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04낙하02 : TriggerState {
            internal State패턴04낙하02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "34", arg2: 1);
                context.SetMesh(arg1: new[] {7005}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "34")) {
                    context.State = new State패턴04생성03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04생성03 : TriggerState {
            internal State패턴04생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 1);
                context.SetMesh(arg1: new[] {7008}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    context.State = new State패턴04낙하03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04낙하03 : TriggerState {
            internal State패턴04낙하03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "36", arg2: 1);
                context.SetMesh(arg1: new[] {7008}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "36")) {
                    context.State = new State패턴04생성04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04생성04 : TriggerState {
            internal State패턴04생성04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "37", arg2: 1);
                context.SetMesh(arg1: new[] {7009}, arg2: true, arg3: 0, arg4: 0, arg5: 1000f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "37")) {
                    context.State = new State패턴04낙하04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State패턴04낙하04 : TriggerState {
            internal State패턴04낙하04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "38", arg2: 1);
                context.SetMesh(arg1: new[] {7009}, arg2: false, arg3: 0, arg4: 0, arg5: 500f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "38")) {
                    context.State = new State딜레이랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이랜덤01 : TriggerState {
            internal State딜레이랜덤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State딜레이01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State딜레이02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State딜레이03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State딜레이04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이01 : TriggerState {
            internal State딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "100", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "100")) {
                    context.State = new State초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이02 : TriggerState {
            internal State딜레이02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "101", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "101")) {
                    context.State = new State초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이03 : TriggerState {
            internal State딜레이03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "102", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "102")) {
                    context.State = new State초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이04 : TriggerState {
            internal State딜레이04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "103", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "103")) {
                    context.State = new State초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "200", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "200")) {
                    context.State = new State랜덤생성01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
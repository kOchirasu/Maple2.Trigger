namespace Maple2.Trigger._02000086_bf {
    public static class _03_wave {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000159}, arg2: 1);
                context.SetEffect(
                    arg1: new[] {
                        301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319,
                        320, 321, 322, 323, 324, 325, 326
                    }, arg2: false);
                context.SetMesh(
                    arg1: new[] {
                        201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219,
                        220, 221, 222, 223, 224, 225, 226
                    }, arg2: false);
                context.SetActor(arg1: 501, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 502, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 503, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 504, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 505, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 506, arg2: true, arg3: "Closed");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000159}, arg2: 0)) {
                    context.State = new State딜레이1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이1 : TriggerState {
            internal State딜레이1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(
                    arg1: new[] {
                        301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319,
                        320, 321, 322, 323, 324, 325, 326
                    }, arg2: true);
                context.SetMesh(
                    arg1: new[] {
                        201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219,
                        220, 221, 222, 223, 224, 225, 226
                    }, arg2: true);
                context.SetTimer(arg1: "3", arg2: 2);
                context.SetActor(arg1: 501, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 502, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 503, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 504, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 505, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 506, arg2: true, arg3: "Opened");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State웨이브1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브1 : TriggerState {
            internal State웨이브1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000086_BF__03_WAVE__0$", arg3: 3000, arg4: "401");
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_601");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_602");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_603");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_604");
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_605");
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_606");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104, 105, 106})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이2 : TriggerState {
            internal State딜레이2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State웨이브2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브2 : TriggerState {
            internal State웨이브2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_601");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_602");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_603");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_604");
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_605");
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_606");
                context.SetTimer(arg1: "3", arg2: 120);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104, 105, 106})) {
                    context.State = new State딜레이4(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이3 : TriggerState {
            internal State딜레이3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State웨이브3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브3 : TriggerState {
            internal State웨이브3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000086_BF__03_WAVE__1$", arg3: 3000, arg4: "401");
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106}, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_601");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_602");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_603");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_604");
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_605");
                context.MoveNpc(arg1: 106, arg2: "MS2PatrolData_606");
                context.SetTimer(arg1: "3", arg2: 120);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104, 105, 106})) {
                    context.State = new State딜레이4(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이4 : TriggerState {
            internal State딜레이4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State딜레이5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이5 : TriggerState {
            internal State딜레이5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000159}, arg2: 1);
                context.SetEffect(
                    arg1: new[] {
                        301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319,
                        320, 321, 322, 323, 324, 325, 326
                    }, arg2: false);
                context.SetMesh(
                    arg1: new[] {
                        201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219,
                        220, 221, 222, 223, 224, 225, 226
                    }, arg2: false);
                context.SetActor(arg1: 501, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 502, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 503, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 504, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 505, arg2: true, arg3: "Closed");
                context.SetActor(arg1: 506, arg2: true, arg3: "Closed");
                context.SetTimer(arg1: "3", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State딜레이6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이6 : TriggerState {
            internal State딜레이6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
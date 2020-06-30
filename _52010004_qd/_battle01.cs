using System;

namespace Maple2.Trigger._52010004_qd {
    public static class _battle01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "10000", arg2: false);
                context.SetAgent(arg1: "10001", arg2: false);
                context.SetAgent(arg1: "10002", arg2: false);
                context.SetAgent(arg1: "10003", arg2: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetMesh(arg1: new int[] {7000, 7001, 7002, 7003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {10002800},
                    arg3: new byte[] {2})) {
                    context.State = new State둔바교체01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바교체01 : TriggerState {
            internal State둔바교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetMesh(arg1: new int[] {7000, 7001, 7002, 7003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State둔바연출준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바연출준비01 : TriggerState {
            internal State둔바연출준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State둔바대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바대화01 : TriggerState {
            internal State둔바대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11001217, arg3: "$52010004_QD__BATTLE01__0$", arg4: 2);
                context.SetSkip(arg1: "둔바대화02대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State둔바대화02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바대화02대기 : TriggerState {
            internal State둔바대화02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State둔바대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바대화02 : TriggerState {
            internal State둔바대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11001217, arg3: "$52010004_QD__BATTLE01__1$", arg4: 2);
                context.SetSkip(arg1: "둔바대화03대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State둔바대화03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바대화03대기 : TriggerState {
            internal State둔바대화03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State둔바대화03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바대화03 : TriggerState {
            internal State둔바대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 2);
                context.SetConversation(arg1: 2, arg2: 11001217, arg3: "$52010004_QD__BATTLE01__2$", arg4: 2);
                context.SetSkip(arg1: "둔바연출종료01");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State둔바연출종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바연출종료01 : TriggerState {
            internal State둔바연출종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetTimer(arg1: "13", arg2: 1);
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    context.State = new State전투준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투준비01 : TriggerState {
            internal State전투준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 1);
                context.SetAgent(arg1: "10000", arg2: true);
                context.SetAgent(arg1: "10001", arg2: true);
                context.SetAgent(arg1: "10002", arg2: true);
                context.SetAgent(arg1: "10003", arg2: true);
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State전투중01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투중01 : TriggerState {
            internal State전투중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52010004, arg2: 50, arg3: 9000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201})) {
                    context.State = new State둔바교체대기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바교체대기02 : TriggerState {
            internal State둔바교체대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {7000, 7001, 7002, 7003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "30", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State둔바교체02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State둔바교체02 : TriggerState {
            internal State둔바교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201});
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
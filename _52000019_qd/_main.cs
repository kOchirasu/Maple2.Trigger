namespace Maple2.Trigger._52000019_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetEffect(arg1: new[] {603}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    context.State = new State시작대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {60001012},
                    arg3: new byte[] {1})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2002});
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__0$", arg4: 5);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001A");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 101, arg2: new[] {2001})) {
                    context.State = new State첫번째구덩이도착(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째구덩이도착 : TriggerState {
            internal State첫번째구덩이도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__1$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State첫번째구덩이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째구덩이 : TriggerState {
            internal State첫번째구덩이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__2$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State첫번째꿈틀이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꿈틀이 : TriggerState {
            internal State첫번째꿈틀이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__3$", arg4: 3);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001B");
                context.CreateMonster(arg1: new[] {1001}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1001})) {
                    context.State = new State첫번째구덩이완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째구덩이완료 : TriggerState {
            internal State첫번째구덩이완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__4$", arg4: 3);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001C");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {2001})) {
                    context.State = new State두번째구덩이시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째구덩이시작 : TriggerState {
            internal State두번째구덩이시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__5$", arg4: 5);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001D");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 103, arg2: new[] {2001})) {
                    context.State = new State두번째구덩이도착(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째구덩이도착 : TriggerState {
            internal State두번째구덩이도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__6$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State두번째구덩이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째구덩이 : TriggerState {
            internal State두번째구덩이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__7$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State두번째꿈틀이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꿈틀이 : TriggerState {
            internal State두번째꿈틀이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__8$", arg4: 3);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001E");
                context.CreateMonster(arg1: new[] {1002}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1002})) {
                    context.State = new State두번째구덩이완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째구덩이완료 : TriggerState {
            internal State두번째구덩이완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__9$", arg4: 3);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001F");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new[] {2001})) {
                    context.State = new State세번째구덩이시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째구덩이시작 : TriggerState {
            internal State세번째구덩이시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__10$", arg4: 5);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001G");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 105, arg2: new[] {2001})) {
                    context.State = new State세번째구덩이도착(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째구덩이도착 : TriggerState {
            internal State세번째구덩이도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__11$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State세번째구덩이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째구덩이 : TriggerState {
            internal State세번째구덩이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__12$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State세번째꿈틀이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째꿈틀이 : TriggerState {
            internal State세번째꿈틀이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001H");
                context.CreateMonster(arg1: new[] {1003}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1003})) {
                    context.State = new State세번째구덩이완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째구덩이완료 : TriggerState {
            internal State세번째구덩이완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000019_QD__MAIN__13$", arg4: 5);
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_2001G");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.CreateMonster(arg1: new[] {2003}, arg2: false);
                    context.DestroyMonster(arg1: new[] {2001});
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
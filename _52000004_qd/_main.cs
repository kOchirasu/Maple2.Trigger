namespace Maple2.Trigger._52000004_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602}, arg2: false);
                context.DestroyMonster(arg1: new[] {2001, 2099, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016});
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    context.State = new State던전시작(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전시작 : TriggerState {
            internal State던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State1차목표(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차목표 : TriggerState {
            internal State1차목표(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$52000004_QD__MAIN__0$");
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State카메라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동 : TriggerState {
            internal State카메라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.CameraSelectPath(arg1: new[] {301}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    context.State = new State피자들기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피자들기 : TriggerState {
            internal State피자들기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.ShowGuideSummary(entityId: 25200401, textId: 25200401);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State엘리트스폰대기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200401);
            }
        }

        private class State엘리트스폰대기 : TriggerState {
            internal State엘리트스폰대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State엘리트스폰(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리트스폰 : TriggerState {
            internal State엘리트스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200402, textId: 25200402);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$52000004_QD__MAIN__3$", arg4: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State벽해제(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200402);
            }
        }

        private class State벽해제 : TriggerState {
            internal State벽해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    context.State = new StateNPC등장(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC등장 : TriggerState {
            internal StateNPC등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.CreateMonster(arg1: new[] {2099}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 2099, arg3: "$52000004_QD__MAIN__4$", arg4: 3);
                context.MoveNpc(arg1: 2099, arg2: "MS2PatrolData_2099");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State미션성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State미션성공 : TriggerState {
            internal State미션성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10001852}, arg3: new byte[] {2})) {
                    context.SetEventUI(arg1: 7, arg2: "$52000004_QD__MAIN__5$", arg3: 3000, arg4: "0");
                    context.State = new State포털생성(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {10001851}, arg3: new byte[] {2})) {
                    context.SetEventUI(arg1: 7, arg2: "$52000004_QD__MAIN__6$", arg3: 3000, arg4: "0");
                    context.State = new State포털생성(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State포털생성(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털생성 : TriggerState {
            internal State포털생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                    context.ShowGuideSummary(entityId: 25200403, textId: 25200403);
                    context.State = new State종료대기(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료대기 : TriggerState {
            internal State종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.MoveUser(arg1: 02000166, arg2: 30, arg3: 199);
                    context.State = new State종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {199})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25200403);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2001, 2099, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016});
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
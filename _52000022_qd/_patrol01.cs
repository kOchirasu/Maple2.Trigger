namespace Maple2.Trigger._52000022_qd {
    public static class _patrol01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.CreateMonster(arg1: new[] {211}, arg2: false);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60001041},
                    arg3: new byte[] {1})) {
                    context.State = new State연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비 : TriggerState {
            internal State연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.DestroyMonster(arg1: new[] {111});
                context.DestroyMonster(arg1: new[] {211});
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State말풍선연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선연출01 : TriggerState {
            internal State말풍선연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000022_QD__PATROL01__0$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State말풍선연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선연출02 : TriggerState {
            internal State말풍선연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000022_QD__PATROL01__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State말풍선연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선연출03 : TriggerState {
            internal State말풍선연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000022_QD__PATROL01__2$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State이슈라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라이동 : TriggerState {
            internal State이슈라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State추격대원이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추격대원이동 : TriggerState {
            internal State추격대원이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000022_QD__PATROL01__3$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State말풍선연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선연출04 : TriggerState {
            internal State말풍선연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000022_QD__PATROL01__4$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State말풍선연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선연출05 : TriggerState {
            internal State말풍선연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000022_QD__PATROL01__5$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101_B");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State말풍선연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선연출06 : TriggerState {
            internal State말풍선연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000022_QD__PATROL01__6$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State감옥이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State감옥이펙트 : TriggerState {
            internal State감옥이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State말풍선연출07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선연출07 : TriggerState {
            internal State말풍선연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000022_QD__PATROL01__7$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201_B");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State말풍선연출08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선연출08 : TriggerState {
            internal State말풍선연출08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000022_QD__PATROL01__8$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State몹소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몹소환 : TriggerState {
            internal State몹소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000022_QD__PATROL01__9$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000022_QD__PATROL01__10$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new[] {1001}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1001})) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.DestroyMonster(arg1: new[] {101});
                context.DestroyMonster(arg1: new[] {201});
                context.CreateMonster(arg1: new[] {111}, arg2: false);
                context.CreateMonster(arg1: new[] {211}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
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
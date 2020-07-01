namespace Maple2.Trigger._52000187_qd {
    public static class _tutorial {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CreateWidget(arg1: "Guide");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {90001})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {90002})) {
                    context.State = new State환영(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State환영 : TriggerState {
            internal State환영(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetQuestAccept(questId: 90000008);
                context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000,
                    script: "$52000187_QD__TUTORIAL__0$");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {11000071}, arg2: 0)) {
                    context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000,
                        script: "$52000187_QD__TUTORIAL__1$");
                    context.SetQuestComplete(questId: 90000008);
                    context.State = new State머쉬킹대화1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State머쉬킹대화1 : TriggerState {
            internal State머쉬킹대화1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {99999}, arg2: new[] {90000007},
                    arg3: new byte[] {1})) {
                    context.State = new State머쉬킹대화2(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {99999}, arg2: new[] {90000007},
                    arg3: new byte[] {2})) {
                    context.State = new State머쉬킹대화2(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {99999}, arg2: new[] {90000007},
                    arg3: new byte[] {3})) {
                    context.State = new State머쉬킹대화2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State머쉬킹대화2 : TriggerState {
            internal State머쉬킹대화2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {90003})) {
                    context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000,
                        script: "$52000187_QD__TUTORIAL__2$");
                    context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_lazy_1");
                    context.State = new State머쉬킹대화3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State머쉬킹대화3 : TriggerState {
            internal State머쉬킹대화3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {90004})) {
                    context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000,
                        script: "$52000187_QD__TUTORIAL__3$");
                    context.State = new State머쉬킹대화4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State머쉬킹대화4 : TriggerState {
            internal State머쉬킹대화4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {90005})) {
                    context.State = new State모쿰소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State모쿰소환 : TriggerState {
            internal State모쿰소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000187_QD__TUTORIAL__4$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State모쿰이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State모쿰이동 : TriggerState {
            internal State모쿰이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_mokum_0");
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000187_QD__TUTORIAL__5$");
                context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000,
                    script: "$52000187_QD__TUTORIAL__6$");
                context.AddBuff(arg1: new[] {99999}, arg2: 71000077, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "551")) {
                    context.CreateMonster(arg1: new[] {101}, arg2: false);
                    context.State = new State모쿰대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State모쿰대사1 : TriggerState {
            internal State모쿰대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_mokum_1");
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000187_QD__TUTORIAL__7$");
                context.DestroyMonster(arg1: new[] {103});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State해제(context);
                    return;
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State모쿰대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State모쿰대사2 : TriggerState {
            internal State모쿰대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000187_QD__TUTORIAL__8$");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State해제(context);
                    return;
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State모쿰대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_mokum_2");
                context.GuideEvent(eventId: 560);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {99999}, arg2: new[] {90000007},
                    arg3: new byte[] {3})) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
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
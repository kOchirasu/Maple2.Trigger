using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000187_qd {
    public static class _tutorial {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.CreateWidget(type: WidgetType.Guide);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {90001})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {90002})) {
                    return new State환영(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State환영 : TriggerState {
            internal State환영(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetQuestAccept(questId: 90000008);
                context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000, script: "$52000187_QD__TUTORIAL__0$");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {11000071}, arg2: 0)) {
                    context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000, script: "$52000187_QD__TUTORIAL__1$");
                    context.SetQuestComplete(questId: 90000008);
                    return new State머쉬킹대화1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State머쉬킹대화1 : TriggerState {
            internal State머쉬킹대화1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {99999}, arg2: new[] {90000007}, arg3: new byte[] {1})) {
                    return new State머쉬킹대화2(context);
                }

                if (context.QuestUserDetected(arg1: new[] {99999}, arg2: new[] {90000007}, arg3: new byte[] {2})) {
                    return new State머쉬킹대화2(context);
                }

                if (context.QuestUserDetected(arg1: new[] {99999}, arg2: new[] {90000007}, arg3: new byte[] {3})) {
                    return new State머쉬킹대화2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State머쉬킹대화2 : TriggerState {
            internal State머쉬킹대화2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {90003})) {
                    context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000, script: "$52000187_QD__TUTORIAL__2$");
                    context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_lazy_1");
                    return new State머쉬킹대화3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State머쉬킹대화3 : TriggerState {
            internal State머쉬킹대화3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {90004})) {
                    context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000, script: "$52000187_QD__TUTORIAL__3$");
                    return new State머쉬킹대화4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State머쉬킹대화4 : TriggerState {
            internal State머쉬킹대화4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {90005})) {
                    return new State모쿰소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State모쿰소환 : TriggerState {
            internal State모쿰소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000187_QD__TUTORIAL__4$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State모쿰이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State모쿰이동 : TriggerState {
            internal State모쿰이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_mokum_0");
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000187_QD__TUTORIAL__5$");
                context.SideNpcTalk(npcId: 29000403, illust: "Mushking_normal", duration: 4000, script: "$52000187_QD__TUTORIAL__6$");
                context.AddBuff(arg1: new[] {99999}, arg2: 71000077, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(type: WidgetType.Guide, arg2: "IsTriggerEvent", arg3: "551")) {
                    context.CreateMonster(arg1: new[] {101}, arg2: false);
                    return new State모쿰Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State모쿰Script1 : TriggerState {
            internal State모쿰Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_mokum_1");
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000187_QD__TUTORIAL__7$");
                context.DestroyMonster(arg1: new[] {103});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State해제(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new State모쿰Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State모쿰Script2 : TriggerState {
            internal State모쿰Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000187_QD__TUTORIAL__8$");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State해제(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new State모쿰Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_mokum_2");
                context.GuideEvent(eventId: 560);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {99999}, arg2: new[] {90000007}, arg3: new byte[] {3})) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52000019_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
                context.SetEffect(triggerIds: new []{601, 602, 603}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{100})) {
                    return new StateBeginWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{60001012}, questStates: new byte[]{1})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{2002});
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__0$", arg4: 5);
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 101, spawnIds: new []{2001})) {
                    return new State첫번째구덩이도착(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째구덩이도착 : TriggerState {
            internal State첫번째구덩이도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__1$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State첫번째구덩이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째구덩이 : TriggerState {
            internal State첫번째구덩이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__2$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State첫번째꿈틀이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꿈틀이 : TriggerState {
            internal State첫번째꿈틀이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__3$", arg4: 3);
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001B");
                context.CreateMonster(spawnIds: new []{1001}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1001})) {
                    return new State첫번째구덩이완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째구덩이완료 : TriggerState {
            internal State첫번째구덩이완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__4$", arg4: 3);
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001C");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{2001})) {
                    return new State두번째구덩이시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째구덩이시작 : TriggerState {
            internal State두번째구덩이시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__5$", arg4: 5);
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001D");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 103, spawnIds: new []{2001})) {
                    return new State두번째구덩이도착(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째구덩이도착 : TriggerState {
            internal State두번째구덩이도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__6$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State두번째구덩이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째구덩이 : TriggerState {
            internal State두번째구덩이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__7$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State두번째꿈틀이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꿈틀이 : TriggerState {
            internal State두번째꿈틀이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__8$", arg4: 3);
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001E");
                context.CreateMonster(spawnIds: new []{1002}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new State두번째구덩이완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째구덩이완료 : TriggerState {
            internal State두번째구덩이완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__9$", arg4: 3);
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001F");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 104, spawnIds: new []{2001})) {
                    return new State세번째구덩이시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째구덩이시작 : TriggerState {
            internal State세번째구덩이시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__10$", arg4: 5);
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001G");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 105, spawnIds: new []{2001})) {
                    return new State세번째구덩이도착(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째구덩이도착 : TriggerState {
            internal State세번째구덩이도착(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__11$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State세번째구덩이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째구덩이 : TriggerState {
            internal State세번째구덩이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__12$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new State세번째꿈틀이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째꿈틀이 : TriggerState {
            internal State세번째꿈틀이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001H");
                context.CreateMonster(spawnIds: new []{1003}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1003})) {
                    return new State세번째구덩이완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째구덩이완료 : TriggerState {
            internal State세번째구덩이완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetConversation(type: 1, spawnId: 2001, script: "$52000019_QD__MAIN__13$", arg4: 5);
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_2001G");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.CreateMonster(spawnIds: new []{2003}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{2001});
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

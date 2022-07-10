using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000533_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{901, 3000, 3001, 3002, 3003}, visible: true);
                context.SetInteractObject(interactIds: new []{10003144}, state: 0);
                context.SetPortal(portalId: 2, visible: false);
                context.SetEffect(triggerIds: new []{7000}, visible: false);
                context.CreateMonster(spawnIds: new []{603, 604, 605, 606}, arg2: true);
                context.MoveNpc(spawnId: 603, patrolName: "MS2PatrolData_5003");
                context.MoveNpc(spawnId: 604, patrolName: "MS2PatrolData_5004");
                context.MoveNpc(spawnId: 605, patrolName: "MS2PatrolData_5005");
                context.MoveNpc(spawnId: 606, patrolName: "MS2PatrolData_5006");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701}, jobCode: 0)) {
                    return new State출입문부시기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State출입문부시기 : TriggerState {
            internal State출입문부시기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 3000, script: "$02000533_BF__MAIN__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State출입문부시기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State출입문부시기2 : TriggerState {
            internal State출입문부시기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000533_BF__MAIN__1$", duration: 3000);
                context.CreateMonster(spawnIds: new []{508}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{508})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7000}, visible: true);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003}, visible: false);
                context.CreateMonster(spawnIds: new []{501, 502}, arg2: true);
                context.AddBalloonTalk(spawnId: 501, msg: "$02000533_BF__MAIN__2$", duration: 3500, delayTick: 0);
                context.SideNpcTalk(npcId: 21450001, illust: "Mafia1_normal", duration: 4000, script: "$02000533_BF__MAIN__3$");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{704}, jobCode: 0)) {
                    return new State3층으로22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3층으로22 : TriggerState {
            internal State3층으로22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{503, 5503}, arg2: true);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000533_BF__MAIN__4$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State3층으로3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3층으로3 : TriggerState {
            internal State3층으로3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{504, 5504, 505, 506, 509}, arg2: true);
                context.AddBalloonTalk(spawnId: 5504, msg: "$02000533_BF__MAIN__5$", duration: 3500, delayTick: 2000);
                context.AddBalloonTalk(spawnId: 505, msg: "$02000533_BF__MAIN__6$", duration: 3500, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{501, 502, 503, 504, 5503, 5504, 505, 506, 509})) {
                    return new State다죽이면(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다죽이면 : TriggerState {
            internal State다죽이면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10003144}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10003144}, arg2: 0)) {
                    return new State문열기시도(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기시도 : TriggerState {
            internal State문열기시도(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State문열기게임(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기게임 : TriggerState {
            internal State문열기게임(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000533_BF__MAIN__7$");
                context.SetUserValue(key: "GameLogicEnd", value: 999);
                context.WidgetAction(type: WidgetType.Round, name: "InitWidgetRound");
                context.SetUserValue(triggerId: 9002, key: "GameLogicStart", value: 999);
                context.LockMyPc(isLock: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State문열기시작2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열기시작2 : TriggerState {
            internal State문열기시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000533_BF__MAIN__8$", duration: 4000);
                context.LockMyPc(isLock: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetUserValue(triggerId: 9002, key: "GameLogicStart", value: 1);
                    return new State게임로직종료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임로직종료Wait : TriggerState {
            internal State게임로직종료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GameLogicEnd") == 1) {
                    return new State게임로직종료및Success(context);
                }

                if (context.GetUserValue(key: "GameLogicEnd") == 2) {
                    return new State게임로직종료및실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및Success : TriggerState {
            internal State게임로직종료및Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new State게임로직종료(context);
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및실패 : TriggerState {
            internal State게임로직종료및실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new State실패게임로직종료(context);
            }

            public override void OnExit() { }
        }

        private class State게임로직종료 : TriggerState {
            internal State게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000533_BF__MAIN__9$", duration: 3000);
                context.LockMyPc(isLock: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동하자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패게임로직종료 : TriggerState {
            internal State실패게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000533_BF__MAIN__10$", duration: 3000);
                context.LockMyPc(isLock: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State문손으로부시기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문손으로부시기 : TriggerState {
            internal State문손으로부시기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.LockMyPc(isLock: false);
                context.AddCinematicTalk(npcId: 0, script: "$02000533_BF__MAIN__11$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State문부시기안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문부시기안내 : TriggerState {
            internal State문부시기안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEventUI(arg1: 1, script: "$02000533_BF__MAIN__12$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{507})) {
                    return new State문을부시고이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문을부시고이동 : TriggerState {
            internal State문을부시고이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000533_BF__MAIN__13$");
                context.CreateMonster(spawnIds: new []{507}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{507})) {
                    return new State문을부시고이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문을부시고이동2 : TriggerState {
            internal State문을부시고이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{901}, visible: false, arg3: 1);
                context.SetPortal(portalId: 2, visible: true);
                context.LockMyPc(isLock: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State이동하자(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동하자 : TriggerState {
            internal State이동하자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004639, illust: "Jay_normal", duration: 4000, script: "$02000533_BF__MAIN__14$");
                context.SetMesh(triggerIds: new []{901}, visible: false, arg3: 1);
                context.SetPortal(portalId: 2, visible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.LockMyPc(isLock: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

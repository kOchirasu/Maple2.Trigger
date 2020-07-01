using System;

namespace Maple2.Trigger._02000533_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {901}, arg2: true);
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10003144}, arg2: 0);
                context.SetPortal(arg1: 2, arg2: false);
                context.SetEffect(arg1: new int[] {7000}, arg2: false);
                context.CreateMonster(arg1: new int[] {603, 604, 605, 606}, arg2: true);
                context.MoveNpc(arg1: 603, arg2: "MS2PatrolData_5003");
                context.MoveNpc(arg1: 604, arg2: "MS2PatrolData_5004");
                context.MoveNpc(arg1: 605, arg2: "MS2PatrolData_5005");
                context.MoveNpc(arg1: 606, arg2: "MS2PatrolData_5006");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {701}, arg2: 0)) {
                    context.State = new State출입문부시기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State출입문부시기 : TriggerState {
            internal State출입문부시기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false);
                context.SideNpcTalk(npcID: 11004639, illust: "Jay_normal", duration: 3000,
                    script: "$02000533_BF__MAIN__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State출입문부시기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State출입문부시기2 : TriggerState {
            internal State출입문부시기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000533_BF__MAIN__1$", arg3: new int[] {3000});
                context.CreateMonster(arg1: new int[] {508}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {508})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7000}, arg2: true);
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003}, arg2: false);
                context.CreateMonster(arg1: new int[] {501, 502}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 501, msg: "$02000533_BF__MAIN__2$", duration: 3500, delayTick: 0);
                context.SideNpcTalk(npcID: 21450001, illust: "Mafia1_normal", duration: 4000,
                    script: "$02000533_BF__MAIN__3$");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {704}, arg2: 0)) {
                    context.State = new State3층으로22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3층으로22 : TriggerState {
            internal State3층으로22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {503, 5503}, arg2: true);
                context.SideNpcTalk(npcID: 11004639, illust: "Jay_normal", duration: 4000,
                    script: "$02000533_BF__MAIN__4$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State3층으로3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3층으로3 : TriggerState {
            internal State3층으로3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {504, 5504, 505, 506, 509}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 5504, msg: "$02000533_BF__MAIN__5$", duration: 3500,
                    delayTick: 2000);
                context.AddBalloonTalk(spawnPointID: 505, msg: "$02000533_BF__MAIN__6$", duration: 3500,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {501, 502, 503, 504, 5503, 5504, 505, 506, 509})) {
                    context.State = new State다죽이면(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다죽이면 : TriggerState {
            internal State다죽이면(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10003144}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10003144}, arg2: 0)) {
                    context.State = new State문열기시도(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기시도 : TriggerState {
            internal State문열기시도(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State문열기게임(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기게임 : TriggerState {
            internal State문열기게임(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SideNpcTalk(npcID: 11004639, illust: "Jay_normal", duration: 4000,
                    script: "$02000533_BF__MAIN__7$");
                context.SetUserValue(key: "GameLogicEnd", value: 999);
                context.WidgetAction(arg1: "Round", arg2: "InitWidgetRound");
                context.SetUserValue(triggerID: 9002, key: "GameLogicStart", value: 999);
                context.LockMyPc(isLock: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State문열기시작2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열기시작2 : TriggerState {
            internal State문열기시작2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000533_BF__MAIN__8$", arg3: new int[] {4000});
                context.LockMyPc(isLock: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetUserValue(triggerID: 9002, key: "GameLogicStart", value: 1);
                    context.State = new State게임로직종료대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임로직종료대기 : TriggerState {
            internal State게임로직종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "GameLogicEnd", value: 1)) {
                    context.State = new State게임로직종료및성공(context);
                    return;
                }

                if (context.UserValue(key: "GameLogicEnd", value: 2)) {
                    context.State = new State게임로직종료및실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및성공 : TriggerState {
            internal State게임로직종료및성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State게임로직종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임로직종료및실패 : TriggerState {
            internal State게임로직종료및실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State실패게임로직종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임로직종료 : TriggerState {
            internal State게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000533_BF__MAIN__9$", arg3: new int[] {3000});
                context.LockMyPc(isLock: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이동하자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패게임로직종료 : TriggerState {
            internal State실패게임로직종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000533_BF__MAIN__10$", arg3: new int[] {3000});
                context.LockMyPc(isLock: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State문손으로부시기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문손으로부시기 : TriggerState {
            internal State문손으로부시기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.LockMyPc(isLock: false);
                context.AddCinematicTalk(npcID: 0, msg: "$02000533_BF__MAIN__11$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State문부시기안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문부시기안내 : TriggerState {
            internal State문부시기안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEventUI(arg1: 1, arg2: "$02000533_BF__MAIN__12$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {507})) {
                    context.State = new State문을부시고이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문을부시고이동 : TriggerState {
            internal State문을부시고이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004639, illust: "Jay_normal", duration: 4000,
                    script: "$02000533_BF__MAIN__13$");
                context.CreateMonster(arg1: new int[] {507}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {507})) {
                    context.State = new State문을부시고이동2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문을부시고이동2 : TriggerState {
            internal State문을부시고이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {901}, arg2: false, arg3: 1);
                context.SetPortal(arg1: 2, arg2: true);
                context.LockMyPc(isLock: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이동하자(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동하자 : TriggerState {
            internal State이동하자(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcID: 11004639, illust: "Jay_normal", duration: 4000,
                    script: "$02000533_BF__MAIN__14$");
                context.SetMesh(arg1: new int[] {901}, arg2: false, arg3: 1);
                context.SetPortal(arg1: 2, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.LockMyPc(isLock: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
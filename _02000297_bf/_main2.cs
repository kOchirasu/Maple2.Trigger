using System;

namespace Maple2.Trigger._02000297_bf {
    public static class _main2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003, 1004}, arg2: false);
                context.DestroyMonster(arg1: new int[] {1005});
                context.DestroyMonster(arg1: new int[] {1006});
                context.DestroyMonster(arg1: new int[] {1007});
                context.SetMesh(arg1: new int[] {107}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31000, 31001, 31002, 31003, 31004, 31005}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {107}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 888888, arg2: true);
                context.MoveNpc(arg1: 1004, arg2: "MS2PatrolData1");
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State레논01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논01 : TriggerState {
            internal State레논01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000297_BF__MAIN2__0$", arg4: 2);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State벨라01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라01 : TriggerState {
            internal State벨라01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000297_BF__MAIN2__1$", arg4: 3);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000297_BF__MAIN2__2$", arg4: 3);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9925)) {
                    context.State = new State벨라02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라02 : TriggerState {
            internal State벨라02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData3");
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State레논02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레논02 : TriggerState {
            internal State레논02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000297_BF__MAIN2__3$", arg4: 2);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State레논03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 4);
            }
        }

        private class State레논03 : TriggerState {
            internal State레논03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1004});
                context.DestroyMonster(arg1: new int[] {1001});
                context.CreateMonster(arg1: new int[] {1005}, arg2: false);
                context.CreateMonster(arg1: new int[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State블랙01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙01 : TriggerState {
            internal State블랙01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData0");
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000297_BF__MAIN2__4$", arg4: 2);
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000297_BF__MAIN2__5$", arg4: 2);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000297_BF__MAIN2__6$", arg4: 3);
                context.SetSkip(arg1: "연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State카메라복귀(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라복귀 : TriggerState {
            internal State카메라복귀(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1002});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 888888, arg2: false);
                context.SetMesh(arg1: new int[] {107}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {31000, 31001, 31002, 31003, 31004, 31005}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {6200}, arg2: false);
                context.DestroyMonster(arg1: new int[] {1003});
                context.DestroyMonster(arg1: new int[] {1002});
                context.DestroyMonster(arg1: new int[] {1001});
                context.DestroyMonster(arg1: new int[] {1004});
                context.CreateMonster(arg1: new int[] {1005}, arg2: false);
                context.CreateMonster(arg1: new int[] {1006}, arg2: true);
                context.CreateMonster(arg1: new int[] {1008}, arg2: false);
                context.SetUserValue(triggerID: 999991, key: "BattleStart", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {6200})) {
                    context.State = new State엔딩연출1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출1 : TriggerState {
            internal State엔딩연출1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {31000, 31001, 31002, 31003, 31004, 31005}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State엔딩연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출 : TriggerState {
            internal State엔딩연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 888888, arg2: true);
                context.DestroyMonster(arg1: new int[] {1006});
                context.CreateMonster(arg1: new int[] {1007}, arg2: false);
                context.MoveNpc(arg1: 1007, arg2: "MS2PatrolData5");
                context.SetSkip(arg1: "연출종료2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State블랙03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State블랙03 : TriggerState {
            internal State블랙03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000297_BF__MAIN2__7$", arg4: 3);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$02000297_BF__MAIN2__8$", arg4: 3);
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000297_BF__MAIN2__9$", arg4: 3);
                context.SetSkip(arg1: "연출종료2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11101)) {
                    context.State = new State연출종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료2 : TriggerState {
            internal State연출종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
                context.CameraSelect(arg1: 888888, arg2: false);
                context.DestroyMonster(arg1: new int[] {1005});
                context.DestroyMonster(arg1: new int[] {1008});
                context.DestroyMonster(arg1: new int[] {1007});
                context.SetAchievement(arg1: 9001, arg2: "trigger", arg3: "ClearKatramusSecond");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
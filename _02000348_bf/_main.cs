using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000348_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 34808, key: "cage_01", value: 0);
                context.SetUserValue(triggerID: 34805, key: "cage_02", value: 0);
                context.SetUserValue(triggerID: 34806, key: "cage_03", value: 0);
                context.SetUserValue(triggerID: 34807, key: "cage_04", value: 0);
                context.SetMesh(arg1: new int[] {2001, 2002}, arg2: true, arg3: 1, arg4: 1);
                context.RemoveBuff(arg1: 60002, arg2: 99910040);
                context.RemoveBuff(arg1: 60002, arg2: 70000106);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new int[] {10000789}, arg2: 0);
                context.SetMesh(arg1: new int[] {6010}, arg2: true);
                context.SetMesh(arg1: new int[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 60001, arg2: 1)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statetouchfield(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statetouchfield : TriggerState {
            internal Statetouchfield(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {2001, 2002}, arg2: false, arg3: 0, arg4: 200);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 702, arg2: 1)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveRandomUser(arg1: 02000348, arg2: 99, arg3: 702, arg4: 1);
                context.MoveRandomUser(arg1: 02000348, arg2: 98, arg3: 60005, arg4: 1);
                context.MoveRandomUser(arg1: 02000348, arg2: 97, arg3: 60005, arg4: 1);
                context.MoveRandomUser(arg1: 02000348, arg2: 96, arg3: 60005, arg4: 1);
                context.CameraSelectPath(arg1: new int[] {8801, 8802}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_01 : TriggerState {
            internal Statestart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8802, 8803}, arg2: 0);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000348_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000348_BF__MAIN__1$", arg4: 3);
                context.SetSkip(arg1: "start_game");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000348_BF__MAIN__2$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000348_BF__MAIN__3$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_03 : TriggerState {
            internal Statestart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000348_BF__MAIN__4$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000348_BF__MAIN__5$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_04 : TriggerState {
            internal Statestart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000348_BF__MAIN__6$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000348_BF__MAIN__7$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_05 : TriggerState {
            internal Statestart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {702}, arg2: 70000106, arg3: 1);
                context.CameraSelectPath(arg1: new int[] {8804, 8805, 8806, 8807}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_06 : TriggerState {
            internal Statestart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000348_BF__MAIN__8$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_07 : TriggerState {
            internal Statestart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000348_BF__MAIN__9$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_game(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game : TriggerState {
            internal Statestart_game(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {702}, arg2: 70000106, arg3: 1);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelectPath(arg1: new int[] {8808}, arg2: 1);
                context.ShowCountUI(text: "$02000348_BF__MAIN__10$", stage: 0, count: 3);
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_game_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_01 : TriggerState {
            internal Statestart_game_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003446, textID: 20003446, durationTime: 5000);
                context.SetEventUI(arg1: 1, arg2: "$02000348_BF__MAIN__11$", arg3: new int[] {3000});
                context.CreateMonster(arg1: new int[] {201, 202, 203, 204, 211, 212, 213, 214}, arg2: true);
                context.SetUserValue(triggerID: 34808, key: "cage_01", value: 1);
                context.SetUserValue(triggerID: 34805, key: "cage_02", value: 1);
                context.SetUserValue(triggerID: 34806, key: "cage_03", value: 1);
                context.SetUserValue(triggerID: 34807, key: "cage_04", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {211, 212, 213, 214})) {
                    context.State = new Statestart_game_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_02 : TriggerState {
            internal Statestart_game_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_game_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_03 : TriggerState {
            internal Statestart_game_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003442, textID: 20003442, durationTime: 5000);
                context.CreateMonster(arg1: new int[] {231, 232}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000348_BF__MAIN__12$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_game_03_a(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_03_a : TriggerState {
            internal Statestart_game_03_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {233, 234}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {231, 232, 233, 234})) {
                    context.State = new Statestart_game_03_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_03_b : TriggerState {
            internal Statestart_game_03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8811, 8810}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000348_BF__MAIN__13$", arg3: new int[] {3000});
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.SetSkill(arg1: new int[] {7702}, arg2: true);
                context.SetSkill(arg1: new int[] {7703}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statestart_game_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_05 : TriggerState {
            internal Statestart_game_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000348_BF__MAIN__14$", arg3: new int[] {3000});
                context.CreateMonster(arg1: new int[] {101, 205, 206, 207, 208}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new Statestart_game_06(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {205, 206, 207, 208});
            }
        }

        private class Statestart_game_06 : TriggerState {
            internal Statestart_game_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어 : TriggerState {
            internal State클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.RemoveBuff(arg1: 60002, arg2: 99910040);
                context.RemoveBuff(arg1: 60002, arg2: 70000106);
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetMesh(arg1: new int[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: true,
                    arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new int[] {6010}, arg2: false, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000789}, arg2: 1);
                context.SetTimer(arg1: "5", arg2: 5);
                context.CameraSelectPath(arg1: new int[] {8801, 8803}, arg2: 0);
                context.SetSkip(arg1: "클리어_03");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State클리어_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어_02 : TriggerState {
            internal State클리어_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000348_BF__MAIN__15$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000348_BF__MAIN__16$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State클리어_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어_03 : TriggerState {
            internal State클리어_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000348_BF__MAIN__17$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State클리어_04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {102});
            }
        }

        private class State클리어_04 : TriggerState {
            internal State클리어_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varID: 1, value: true);
                context.ShowGuideSummary(entityID: 110, textID: 40009);
                context.CameraSelectPath(arg1: new int[] {8808}, arg2: 1);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
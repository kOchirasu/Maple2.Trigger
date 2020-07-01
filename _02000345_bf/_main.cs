using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000345_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001, 2002}, arg2: true, arg3: 1, arg4: 1);
                context.RemoveBuff(arg1: 60002, arg2: 99910040);
                context.RemoveBuff(arg1: 60002, arg2: 70000106);
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.SetMesh(arg1: new[] {6010}, arg2: true);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    context.State = new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_game_01(context);
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
                context.SetMesh(arg1: new[] {2001, 2002}, arg2: false, arg3: 0, arg4: 200);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
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
                context.MoveRandomUser(arg1: 02000345, arg2: 99, arg3: 702, arg4: 1);
                context.MoveRandomUser(arg1: 02000345, arg2: 98, arg3: 60005, arg4: 1);
                context.MoveRandomUser(arg1: 02000345, arg2: 97, arg3: 60005, arg4: 1);
                context.MoveRandomUser(arg1: 02000345, arg2: 96, arg3: 60005, arg4: 1);
                context.CameraSelectPath(arg1: new[] {8801, 8802}, arg2: false);
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
                context.CameraSelectPath(arg1: new[] {8802, 8803}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000345_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000345_BF__MAIN__1$", arg4: 3);
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
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000345_BF__MAIN__2$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000345_BF__MAIN__3$", arg4: 3);
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
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000345_BF__MAIN__4$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000345_BF__MAIN__5$", arg4: 3);
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
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000345_BF__MAIN__6$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000345_BF__MAIN__7$", arg4: 3);
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
                context.AddBuff(arg1: new[] {702}, arg2: 70000106, arg3: 1);
                context.CameraSelectPath(arg1: new[] {8804, 8805, 8806, 8807}, arg2: false);
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
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000345_BF__MAIN__8$", arg4: 3);
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
                context.SetConversation(arg1: 2, arg2: 11001376, arg3: "$02000345_BF__MAIN__9$", arg4: 3);
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelectPath(arg1: new[] {8808}, arg2: true);
                context.ShowCountUI(text: "$02000345_BF__MAIN__10$", stage: 0, count: 3);
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
                context.SetEventUI(arg1: 1, arg2: "$02000345_BF__MAIN__11$", arg3: 3000);
                context.CreateMonster(arg1: new[] {189}, arg2: true, arg3: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_game_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_02 : TriggerState {
            internal Statestart_game_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8809, 8810}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart_game_02_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_02_b : TriggerState {
            internal Statestart_game_02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 189, arg3: "$02000345_BF__MAIN__12$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001890, arg3: "$02000345_BF__MAIN__13$", arg4: 3);
            }

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
                context.SetConversation(arg1: 1, arg2: 189, arg3: "$02000345_BF__MAIN__14$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001890, arg3: "$02000345_BF__MAIN__15$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_game_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_04 : TriggerState {
            internal Statestart_game_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 189, arg3: "$02000345_BF__MAIN__16$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001890, arg3: "$02000345_BF__MAIN__17$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new Statestart_game_05(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelectPath(arg1: new[] {8808}, arg2: true);
            }
        }

        private class Statestart_game_05 : TriggerState {
            internal Statestart_game_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000345_BF__MAIN__18$", arg3: 3000);
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210}, arg2: true, arg3: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210})) {
                    context.State = new Statestart_game_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_06 : TriggerState {
            internal Statestart_game_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305, 306, 307}, arg2: true, arg3: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {301, 302, 303, 304, 305, 306, 307})) {
                    context.State = new Statestart_game_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_game_07 : TriggerState {
            internal Statestart_game_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401, 402, 403, 404, 405, 406}, arg2: true, arg3: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State대기_01 : TriggerState {
            internal State대기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new[] {10000791}, arg2: 0);
                context.SetMesh(arg1: new[] {6001, 6010}, arg2: true);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: false);
                context.SetLadder(arg1: 9001, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 9002, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 9003, arg2: false, arg3: false, arg4: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    context.State = new State대기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기_02 : TriggerState {
            internal State대기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기_03 : TriggerState {
            internal State대기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    context.State = new State오브젝티브_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝티브_01 : TriggerState {
            internal State오브젝티브_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000345_BF__MAIN1__2$", arg3: 10000);
                context.SetTimer(arg1: "10", arg2: 10, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State오브젝티브_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝티브_02 : TriggerState {
            internal State오브젝티브_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: true);
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000345_BF__MAIN1__0$");
                context.SetTimer(arg1: "5", arg2: 5, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State시작_01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class State시작_01 : TriggerState {
            internal State시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$02000345_BF__MAIN1__3$", stage: 0, count: 3);
                context.SetTimer(arg1: "3", arg2: 3, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_02 : TriggerState {
            internal State시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 9001, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 9002, arg2: true, arg3: true, arg4: 0);
                context.SetLadder(arg1: 9003, arg2: true, arg3: true, arg4: 0);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State클리어(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State클리어 : TriggerState {
            internal State클리어(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetEventUI(arg1: 7, arg2: "$02000345_BF__MAIN1__1$", arg3: 3000);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: true, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {6010}, arg2: false, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000791}, arg2: 1);
                context.SetTimer(arg1: "5", arg2: 5);
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
                context.ShowGuideSummary(entityId: 110, textId: 40009);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
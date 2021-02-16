using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000348_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 34808, key: "cage_01", value: 0);
                context.SetUserValue(triggerId: 34805, key: "cage_02", value: 0);
                context.SetUserValue(triggerId: 34806, key: "cage_03", value: 0);
                context.SetUserValue(triggerId: 34807, key: "cage_04", value: 0);
                context.SetMesh(arg1: new[] {2001, 2002}, arg2: true, arg3: 1, arg4: 1);
                context.RemoveBuff(arg1: 60002, arg2: 99910040);
                context.RemoveBuff(arg1: 60002, arg2: 70000106);
                context.CreateMonster(arg1: new[] {102}, arg2: true);
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(arg1: new[] {10000789}, arg2: 0);
                context.SetMesh(arg1: new[] {6010}, arg2: true);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTouchfield(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTouchfield : TriggerState {
            internal StateTouchfield(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001, 2002}, arg2: false, arg3: 0, arg4: 200);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveRandomUser(arg1: 02000348, arg2: 99, arg3: 702, arg4: 1);
                context.MoveRandomUser(arg1: 02000348, arg2: 98, arg3: 60005, arg4: 1);
                context.MoveRandomUser(arg1: 02000348, arg2: 97, arg3: 60005, arg4: 1);
                context.MoveRandomUser(arg1: 02000348, arg2: 96, arg3: 60005, arg4: 1);
                context.CameraSelectPath(pathIds: new[] {8801, 8802}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8802, 8803}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 102, script: "$02000348_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, script: "$02000348_BF__MAIN__1$", arg4: 3);
                context.SetSkip(state: new StateStart_game(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$02000348_BF__MAIN__2$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, script: "$02000348_BF__MAIN__3$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$02000348_BF__MAIN__4$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, script: "$02000348_BF__MAIN__5$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$02000348_BF__MAIN__6$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, script: "$02000348_BF__MAIN__7$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {702}, arg2: 70000106, arg3: 1);
                context.CameraSelectPath(pathIds: new[] {8804, 8805, 8806, 8807}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001376, script: "$02000348_BF__MAIN__8$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001376, script: "$02000348_BF__MAIN__9$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_game(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game : TriggerState {
            internal StateStart_game(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {702}, arg2: 70000106, arg3: 1);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelectPath(pathIds: new[] {8808}, arg2: true);
                context.ShowCountUI(text: "$02000348_BF__MAIN__10$", stage: 0, count: 3);
                context.SetTimer(id: "3", arg2: 3, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_game_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_01 : TriggerState {
            internal StateStart_game_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003446, textId: 20003446, duration: 5000);
                context.SetEventUI(arg1: 1, script: "$02000348_BF__MAIN__11$", arg3: 3000);
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 211, 212, 213, 214}, arg2: true);
                context.SetUserValue(triggerId: 34808, key: "cage_01", value: 1);
                context.SetUserValue(triggerId: 34805, key: "cage_02", value: 1);
                context.SetUserValue(triggerId: 34806, key: "cage_03", value: 1);
                context.SetUserValue(triggerId: 34807, key: "cage_04", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {211, 212, 213, 214})) {
                    return new StateStart_game_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_02 : TriggerState {
            internal StateStart_game_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_game_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_03 : TriggerState {
            internal StateStart_game_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003442, textId: 20003442, duration: 5000);
                context.CreateMonster(arg1: new[] {231, 232}, arg2: true);
                context.SetEventUI(arg1: 1, script: "$02000348_BF__MAIN__12$", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_game_03_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_03_a : TriggerState {
            internal StateStart_game_03_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {233, 234}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {231, 232, 233, 234})) {
                    return new StateStart_game_03_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_03_b : TriggerState {
            internal StateStart_game_03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8811, 8810}, arg2: true);
                context.SetEventUI(arg1: 1, script: "$02000348_BF__MAIN__13$", arg3: 3000);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetSkill(arg1: new[] {7702, 7703}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_game_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_05 : TriggerState {
            internal StateStart_game_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000348_BF__MAIN__14$", arg3: 3000);
                context.CreateMonster(arg1: new[] {101, 205, 206, 207, 208}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateStart_game_06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {205, 206, 207, 208});
            }
        }

        private class StateStart_game_06 : TriggerState {
            internal StateStart_game_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.RemoveBuff(arg1: 60002, arg2: 99910040);
                context.RemoveBuff(arg1: 60002, arg2: 70000106);
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: true, arg4: 0, arg5: 10f);
                context.SetMesh(arg1: new[] {6010}, arg2: false, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000789}, arg2: 1);
                context.SetTimer(id: "5", arg2: 5);
                context.CameraSelectPath(pathIds: new[] {8801, 8803}, arg2: false);
                context.SetSkip(state: new StateClear_03(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateClear_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear_02 : TriggerState {
            internal StateClear_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$02000348_BF__MAIN__15$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001376, script: "$02000348_BF__MAIN__16$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateClear_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear_03 : TriggerState {
            internal StateClear_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$02000348_BF__MAIN__17$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateClear_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {102});
            }
        }

        private class StateClear_04 : TriggerState {
            internal StateClear_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetDungeonVariable(varId: 1, value: true);
                context.ShowGuideSummary(entityId: 110, textId: 40009);
                context.CameraSelectPath(pathIds: new[] {8808}, arg2: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
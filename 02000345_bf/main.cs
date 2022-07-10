using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000345_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2001, 2002}, visible: true, arg3: 1, arg4: 1);
                context.RemoveBuff(boxId: 60002, skillId: 99910040);
                context.RemoveBuff(boxId: 60002, skillId: 70000106);
                context.CreateMonster(spawnIds: new []{102}, arg2: true);
                context.SetMesh(triggerIds: new []{6010}, visible: true);
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_game_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetMesh(triggerIds: new []{2001, 2002}, visible: false, arg3: 0, arg4: 200);
            }

            public override TriggerState? Execute() {
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
                context.MoveRandomUser(mapId: 02000345, portalId: 99, triggerId: 702, count: 1);
                context.MoveRandomUser(mapId: 02000345, portalId: 98, triggerId: 60005, count: 1);
                context.MoveRandomUser(mapId: 02000345, portalId: 97, triggerId: 60005, count: 1);
                context.MoveRandomUser(mapId: 02000345, portalId: 96, triggerId: 60005, count: 1);
                context.CameraSelectPath(pathIds: new []{8801, 8802}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelectPath(pathIds: new []{8802, 8803}, returnView: false);
                context.SetConversation(type: 1, spawnId: 102, script: "$02000345_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001376, script: "$02000345_BF__MAIN__1$", arg4: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 102, script: "$02000345_BF__MAIN__2$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001376, script: "$02000345_BF__MAIN__3$", arg4: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 102, script: "$02000345_BF__MAIN__4$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001376, script: "$02000345_BF__MAIN__5$", arg4: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 102, script: "$02000345_BF__MAIN__6$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001376, script: "$02000345_BF__MAIN__7$", arg4: 3);
            }

            public override TriggerState? Execute() {
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
                context.AddBuff(boxIds: new []{702}, skillId: 70000106, level: 1);
                context.CameraSelectPath(pathIds: new []{8804, 8805, 8806, 8807}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 2, spawnId: 11001376, script: "$02000345_BF__MAIN__8$", arg4: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 2, spawnId: 11001376, script: "$02000345_BF__MAIN__9$", arg4: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelectPath(pathIds: new []{8808}, returnView: true);
                context.ShowCountUI(text: "$02000345_BF__MAIN__10$", stage: 0, count: 3);
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000345_BF__MAIN__11$", duration: 3000);
                context.CreateMonster(spawnIds: new []{189}, arg2: true, arg3: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_game_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_02 : TriggerState {
            internal StateStart_game_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8809, 8810}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_game_02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_02_b : TriggerState {
            internal StateStart_game_02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 189, script: "$02000345_BF__MAIN__12$", arg4: 2, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001890, script: "$02000345_BF__MAIN__13$", arg4: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 189, script: "$02000345_BF__MAIN__14$", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001890, script: "$02000345_BF__MAIN__15$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_game_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_04 : TriggerState {
            internal StateStart_game_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 189, script: "$02000345_BF__MAIN__16$", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001890, script: "$02000345_BF__MAIN__17$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateStart_game_05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelectPath(pathIds: new []{8808}, returnView: true);
            }
        }

        private class StateStart_game_05 : TriggerState {
            internal StateStart_game_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000345_BF__MAIN__18$", duration: 3000);
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210}, arg2: true, arg3: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210})) {
                    return new StateStart_game_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_06 : TriggerState {
            internal StateStart_game_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301, 302, 303, 304, 305, 306, 307}, arg2: true, arg3: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{301, 302, 303, 304, 305, 306, 307})) {
                    return new StateStart_game_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_game_07 : TriggerState {
            internal StateStart_game_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{401, 402, 403, 404, 405, 406}, arg2: true, arg3: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 4, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000791}, state: 0);
                context.SetMesh(triggerIds: new []{6001, 6010}, visible: true);
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, visible: false);
                context.SetLadder(triggerId: 9001, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 9002, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 9003, visible: false, animationEffect: false, animationDelay: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_03 : TriggerState {
            internal StateWait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    return new StateObjective_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateObjective_01 : TriggerState {
            internal StateObjective_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000345_BF__MAIN1__2$", duration: 10000);
                context.SetTimer(timerId: "10", seconds: 10, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateObjective_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateObjective_02 : TriggerState {
            internal StateObjective_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: true);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000345_BF__MAIN1__0$");
                context.SetTimer(timerId: "5", seconds: 5, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateStartClear_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateStartClear_01 : TriggerState {
            internal StateStartClear_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "$02000345_BF__MAIN1__3$", stage: 0, count: 3);
                context.SetTimer(timerId: "3", seconds: 3, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateStartClear_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartClear_02 : TriggerState {
            internal StateStartClear_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 9001, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 9002, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 9003, visible: true, animationEffect: true, animationDelay: 0);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
                context.SetEventUI(arg1: 7, script: "$02000345_BF__MAIN1__1$", duration: 3000);
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, visible: true, arg4: 0, arg5: 10f);
                context.SetMesh(triggerIds: new []{6010}, visible: false, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000791}, state: 1);
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateClear_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear_02 : TriggerState {
            internal StateClear_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40009);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

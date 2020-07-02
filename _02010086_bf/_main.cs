using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02010086_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105}, arg2: true);
                context.SetLadder(arg1: 1011, arg2: false, arg3: true);
                context.SetLadder(arg1: 1012, arg2: false, arg3: true);
                context.SetLadder(arg1: 1013, arg2: false, arg3: true);
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209}, arg2: true);
                context.SetMesh(arg1: new[] {29991, 29992, 29993, 29994, 29995, 29996, 29997, 29998, 29999}, arg2: false);
                context.SetEffect(arg1: new[] {7010, 7011, 7012}, arg2: true);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 992, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 993, isEnable: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "시작_03");
                context.CameraSelectPath(arg1: new[] {80001, 80002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {80003}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02010086_BF__MAIN__0$", arg3: 3000);
                context.SetActor(arg1: 1001, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {1002}, arg2: false, arg4: 0, arg5: 10f);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new State전투_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_01 : TriggerState {
            internal State전투_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {999}, arg2: true);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104, 105})) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
                context.SetActor(arg1: 1003, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 5001, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5002, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetMesh(arg1: new[] {1004}, arg2: false, arg4: 0, arg5: 10f);
                context.SetEffect(arg1: new[] {7020}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new State전투_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_02 : TriggerState {
            internal State전투_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {111, 112, 113, 114, 115, 116, 117, 118, 119}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {111, 112, 113, 114, 115, 116, 117, 118, 119})) {
                    return new State관문_02_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 1011, arg2: true, arg3: true);
                context.SetLadder(arg1: 1012, arg2: true, arg3: true);
                context.SetLadder(arg1: 1013, arg2: true, arg3: true);
                context.SetActor(arg1: 5003, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5004, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5005, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.SetEffect(arg1: new[] {7021}, arg2: false);
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 704) == 1) {
                    return new State전투_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_03 : TriggerState {
            internal State전투_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 125, 126, 127, 128, 129, 994}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {121, 122, 123, 124, 125, 126, 127, 128, 129})) {
                    return new State관문_03_개방(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new State전투_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000896}, arg2: 1);
                context.DestroyMonster(arg1: new[] {994});
            }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 991, isEnable: true);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 705) == 1) {
                    return new State전투_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_04 : TriggerState {
            internal State전투_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {131, 132, 133, 134, 135, 136, 137, 138, 139}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {131, 132, 133, 134, 135, 136, 137, 138, 139})) {
                    return new State관문_04_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_04_개방 : TriggerState {
            internal State관문_04_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 5006, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5007, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 1006, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {1007}, arg2: false, arg4: 0, arg5: 10f);
                context.SetEffect(arg1: new[] {7022}, arg2: false);
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 706) == 1) {
                    return new State전투_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_05 : TriggerState {
            internal State전투_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 1009, arg2: true, arg3: "Opened");
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {141, 142, 143, 144, 145, 146, 147, 148, 149}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {141, 142, 143, 144, 145, 146, 147, 148, 149})) {
                    return new State관문_05_개방(context);
                }

                if (context.GetUserCount(boxId: 707) == 1) {
                    return new State전투_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_05_개방 : TriggerState {
            internal State관문_05_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 992, isEnable: true);
                context.SetActor(arg1: 5008, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 5009, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 707) == 1) {
                    return new State전투_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_06 : TriggerState {
            internal State전투_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {151, 152, 153, 154, 155, 156, 157, 158, 159}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {151, 152, 153, 154, 155, 156, 157, 158, 159})) {
                    return new State관문_06_개방_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_06_개방 : TriggerState {
            internal State관문_06_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001, 2002, 2003}, arg2: false, arg4: 300, arg5: 10f);
                context.SetMesh(arg1: new[] {2011, 2012, 2013}, arg2: true, arg4: 300, arg5: 10f);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State관문_06_개방_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_06_개방_02 : TriggerState {
            internal State관문_06_개방_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {161, 162, 163, 164, 165, 166, 167, 168, 169}, arg2: true);
                context.SetMesh(arg1: new[] {2014, 2015, 2016}, arg2: false, arg4: 30, arg5: 0f);
                context.SetMesh(arg1: new[] {2011, 2012, 2013}, arg2: false, arg4: 0, arg5: 10f);
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 708) == 1) {
                    return new State전투_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투_07 : TriggerState {
            internal State전투_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(arg1: new[] {171, 172, 173, 174, 175, 176, 177, 178, 179}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {171, 172, 173, 174, 175, 176, 177, 178, 179})) {
                    return new State관문_07_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_07_개방 : TriggerState {
            internal State관문_07_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 992, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 993, isEnable: true);
                context.SetMesh(arg1: new[] {2021, 2022, 2023}, arg2: false, arg4: 0, arg5: 0f);
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209})) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000897}, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02020300_bf {
    public static class _main_copy {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105}, arg2: true);
                context.SetLadder(triggerId: 1011, visible: false, animationEffect: true);
                context.SetLadder(triggerId: 1012, visible: false, animationEffect: true);
                context.SetLadder(triggerId: 1013, visible: false, animationEffect: true);
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209}, arg2: true);
                context.SetMesh(triggerIds: new []{29991, 29992, 29993, 29994, 29995, 29996, 29997, 29998, 29999}, visible: false);
                context.SetEffect(triggerIds: new []{7010, 7011, 7012}, visible: true);
                context.EnableSpawnPointPc(spawnId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 992, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 993, isEnable: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StateStart_03(context));
                context.CameraSelectPath(pathIds: new []{80001, 80002}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{80003}, returnView: true);
                context.SetEventUI(arg1: 1, script: "$02010086_BF__MAIN__0$", duration: 3000);
                context.SetActor(triggerId: 1001, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{1002}, visible: false, arg4: 0, arg5: 10f);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{999}, arg2: true);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 104, 105})) {
                    return new State관문_01_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_01_개방 : TriggerState {
            internal State관문_01_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
                context.SetActor(triggerId: 1003, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 5001, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5002, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetMesh(triggerIds: new []{1004}, visible: false, arg4: 0, arg5: 10f);
                context.SetEffect(triggerIds: new []{7020}, visible: false);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{111, 112, 113, 114, 115, 116, 117, 118, 119}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111, 112, 113, 114, 115, 116, 117, 118, 119})) {
                    return new State관문_02_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_02_개방 : TriggerState {
            internal State관문_02_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 1011, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 1012, visible: true, animationEffect: true);
                context.SetLadder(triggerId: 1013, visible: true, animationEffect: true);
                context.SetActor(triggerId: 5003, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5004, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5005, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.SetEffect(triggerIds: new []{7021}, visible: false);
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{121, 122, 123, 124, 125, 126, 127, 128, 129, 994}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{121, 122, 123, 124, 125, 126, 127, 128, 129})) {
                    return new State관문_03_개방(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new State전투_04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000896}, state: 1);
                context.DestroyMonster(spawnIds: new []{994});
            }
        }

        private class State관문_03_개방 : TriggerState {
            internal State관문_03_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 991, isEnable: true);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{131, 132, 133, 134, 135, 136, 137, 138, 139}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{131, 132, 133, 134, 135, 136, 137, 138, 139})) {
                    return new State관문_04_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_04_개방 : TriggerState {
            internal State관문_04_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 5006, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5007, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1006, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{1007}, visible: false, arg4: 0, arg5: 10f);
                context.SetEffect(triggerIds: new []{7022}, visible: false);
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 1009, visible: true, initialSequence: "Opened");
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{141, 142, 143, 144, 145, 146, 147, 148, 149}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{141, 142, 143, 144, 145, 146, 147, 148, 149})) {
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
                context.EnableSpawnPointPc(spawnId: 991, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 992, isEnable: true);
                context.SetActor(triggerId: 5008, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 5009, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{151, 152, 153, 154, 155, 156, 157, 158, 159}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{151, 152, 153, 154, 155, 156, 157, 158, 159})) {
                    return new State관문_06_개방_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_06_개방 : TriggerState {
            internal State관문_06_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2001, 2002, 2003}, visible: false, arg4: 300, arg5: 10f);
                context.SetMesh(triggerIds: new []{2011, 2012, 2013}, visible: true, arg4: 300, arg5: 10f);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State관문_06_개방_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_06_개방_02 : TriggerState {
            internal State관문_06_개방_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{161, 162, 163, 164, 165, 166, 167, 168, 169}, arg2: true);
                context.SetMesh(triggerIds: new []{2014, 2015, 2016}, visible: false, arg4: 30, arg5: 0f);
                context.SetMesh(triggerIds: new []{2011, 2012, 2013}, visible: false, arg4: 0, arg5: 10f);
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.CreateMonster(spawnIds: new []{171, 172, 173, 174, 175, 176, 177, 178, 179}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{171, 172, 173, 174, 175, 176, 177, 178, 179})) {
                    return new State관문_07_개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State관문_07_개방 : TriggerState {
            internal State관문_07_개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 992, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 993, isEnable: true);
                context.SetMesh(triggerIds: new []{2021, 2022, 2023}, visible: false, arg4: 0, arg5: 0f);
                context.ShowGuideSummary(entityId: 106, textId: 20003362, duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209})) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000897}, state: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

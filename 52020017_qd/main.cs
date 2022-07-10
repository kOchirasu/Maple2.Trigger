using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020017_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200115}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 301, 302}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{60200115}, questStates: new byte[]{1})) {
                    return new StateObject_Off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateObject_Off : TriggerState {
            internal StateObject_Off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: default);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetInteractObject(interactIds: new []{10001282}, state: 0);
                context.AddBalloonTalk(spawnId: 0, msg: "!", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEvent_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start : TriggerState {
            internal StateEvent_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003624, script: "아아…. 드디어 극의 주인공을 찾은 것 같네.", duration: 2800, align: Align.Left);
                context.SetSceneSkip(arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_A_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_01 : TriggerState {
            internal StateEvent_A_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "!?", duration: 1800, illustId: "0", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_A_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_02 : TriggerState {
            internal StateEvent_A_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003624, script: "그래. 바로 너. 네가 주인공이야.", duration: 2800, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_A_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_03 : TriggerState {
            internal StateEvent_A_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11003624, script: "참, 주인공 역할을 말해주지 않았구나.", duration: 2800, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_A_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_04 : TriggerState {
            internal StateEvent_A_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003624, script: "이 극의 주인공 역할은 말이야.", duration: 1800, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_A_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_05 : TriggerState {
            internal StateEvent_A_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.AddCinematicTalk(npcId: 11003624, script: "여기서 죽는 거야.", duration: 2800, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_A_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_06 : TriggerState {
            internal StateEvent_A_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003624, script: "자, 그럼 극을 시작해볼까?", duration: 2800, illustId: "RobotMaidBrownHair_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_A_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_Skip_01 : TriggerState {
            internal StateEvent_A_Skip_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_A_Skip_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_Skip_02 : TriggerState {
            internal StateEvent_A_Skip_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3001");
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_A_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_End : TriggerState {
            internal StateEvent_A_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAmbientLight(color: new Vector3(1f, 1f, 1f));
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddBalloonTalk(spawnId: 0, msg: "!", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle_A_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_A_Ready : TriggerState {
            internal StateBattle_A_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_A : TriggerState {
            internal StateBattle_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 201, addSpawnId: 601);
                context.ChangeMonster(removeSpawnId: 202, addSpawnId: 602);
                context.ChangeMonster(removeSpawnId: 203, addSpawnId: 603);
                context.ChangeMonster(removeSpawnId: 204, addSpawnId: 604);
                context.ChangeMonster(removeSpawnId: 205, addSpawnId: 605);
                context.ChangeMonster(removeSpawnId: 206, addSpawnId: 606);
                context.ChangeMonster(removeSpawnId: 207, addSpawnId: 607);
                context.ChangeMonster(removeSpawnId: 208, addSpawnId: 608);
                context.ChangeMonster(removeSpawnId: 209, addSpawnId: 609);
                context.ChangeMonster(removeSpawnId: 210, addSpawnId: 610);
                context.ChangeMonster(removeSpawnId: 211, addSpawnId: 611);
                context.ChangeMonster(removeSpawnId: 212, addSpawnId: 612);
                context.ChangeMonster(removeSpawnId: 213, addSpawnId: 613);
                context.ChangeMonster(removeSpawnId: 214, addSpawnId: 614);
                context.ChangeMonster(removeSpawnId: 215, addSpawnId: 615);
                context.ChangeMonster(removeSpawnId: 216, addSpawnId: 616);
                context.ChangeMonster(removeSpawnId: 217, addSpawnId: 617);
                context.ChangeMonster(removeSpawnId: 218, addSpawnId: 618);
                context.ChangeMonster(removeSpawnId: 219, addSpawnId: 619);
                context.ChangeMonster(removeSpawnId: 220, addSpawnId: 620);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620})) {
                    return new StateBattle_B_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_B_Ready : TriggerState {
            internal StateBattle_B_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_B : TriggerState {
            internal StateBattle_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 301, addSpawnId: 701);
                context.ChangeMonster(removeSpawnId: 302, addSpawnId: 702);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{701, 702})) {
                    return new StateBattle_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_End : TriggerState {
            internal StateBattle_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(color: new Vector3(1f, 1f, 1f));
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.DestroyMonster(spawnIds: new []{101});
                context.SetInteractObject(interactIds: new []{10001282}, state: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

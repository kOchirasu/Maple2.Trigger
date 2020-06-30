using System;
using System.Numerics;

namespace Maple2.Trigger._52020017_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200115},
                    arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.CreateMonster(arg1: new int[] {203}, arg2: true);
                context.CreateMonster(arg1: new int[] {204}, arg2: true);
                context.CreateMonster(arg1: new int[] {205}, arg2: true);
                context.CreateMonster(arg1: new int[] {206}, arg2: true);
                context.CreateMonster(arg1: new int[] {207}, arg2: true);
                context.CreateMonster(arg1: new int[] {208}, arg2: true);
                context.CreateMonster(arg1: new int[] {209}, arg2: true);
                context.CreateMonster(arg1: new int[] {210}, arg2: true);
                context.CreateMonster(arg1: new int[] {211}, arg2: true);
                context.CreateMonster(arg1: new int[] {212}, arg2: true);
                context.CreateMonster(arg1: new int[] {213}, arg2: true);
                context.CreateMonster(arg1: new int[] {214}, arg2: true);
                context.CreateMonster(arg1: new int[] {215}, arg2: true);
                context.CreateMonster(arg1: new int[] {216}, arg2: true);
                context.CreateMonster(arg1: new int[] {217}, arg2: true);
                context.CreateMonster(arg1: new int[] {218}, arg2: true);
                context.CreateMonster(arg1: new int[] {219}, arg2: true);
                context.CreateMonster(arg1: new int[] {220}, arg2: true);
                context.CreateMonster(arg1: new int[] {301}, arg2: true);
                context.CreateMonster(arg1: new int[] {302}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {60200115},
                    arg3: new byte[] {1})) {
                    context.State = new StateObject_Off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateObject_Off : TriggerState {
            internal StateObject_Off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(0f, 0f, 0f));
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10001282}, arg2: 0);
                context.AddBalloonTalk(spawnPointID: 0, msg: "!", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateEvent_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_Start : TriggerState {
            internal StateEvent_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11003624, msg: "아아…. 드디어 극의 주인공을 찾은 것 같네.", duration: 2800,
                    align: "left");
                context.SetSceneSkip(arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_A_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_01 : TriggerState {
            internal StateEvent_A_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.AddCinematicTalk(npcID: 0, msg: "!?", duration: 1800, illustID: "0", align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_A_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_02 : TriggerState {
            internal StateEvent_A_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002, 4003}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003624, msg: "그래. 바로 너. 네가 주인공이야.", duration: 2800, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_A_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_03 : TriggerState {
            internal StateEvent_A_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcID: 11003624, msg: "참, 주인공 역할을 말해주지 않았구나.", duration: 2800, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_A_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_04 : TriggerState {
            internal StateEvent_A_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003624, msg: "이 극의 주인공 역할은 말이야.", duration: 1800, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_A_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_05 : TriggerState {
            internal StateEvent_A_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003624, msg: "여기서 죽는 거야.", duration: 2800, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_A_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_06 : TriggerState {
            internal StateEvent_A_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11003624, msg: "자, 그럼 극을 시작해볼까?", duration: 2800,
                    illustID: "RobotMaidBrownHair_normal", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_A_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_Skip_01 : TriggerState {
            internal StateEvent_A_Skip_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_A_Skip_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_Skip_02 : TriggerState {
            internal StateEvent_A_Skip_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_A_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_End : TriggerState {
            internal StateEvent_A_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAmbientLight(arg1: new Vector3(1f, 1f, 1f));
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddBalloonTalk(spawnPointID: 0, msg: "!", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBattle_A_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_A_Ready : TriggerState {
            internal StateBattle_A_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBattle_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_A : TriggerState {
            internal StateBattle_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 201, arg2: 601);
                context.ChangeMonster(arg1: 202, arg2: 602);
                context.ChangeMonster(arg1: 203, arg2: 603);
                context.ChangeMonster(arg1: 204, arg2: 604);
                context.ChangeMonster(arg1: 205, arg2: 605);
                context.ChangeMonster(arg1: 206, arg2: 606);
                context.ChangeMonster(arg1: 207, arg2: 607);
                context.ChangeMonster(arg1: 208, arg2: 608);
                context.ChangeMonster(arg1: 209, arg2: 609);
                context.ChangeMonster(arg1: 210, arg2: 610);
                context.ChangeMonster(arg1: 211, arg2: 611);
                context.ChangeMonster(arg1: 212, arg2: 612);
                context.ChangeMonster(arg1: 213, arg2: 613);
                context.ChangeMonster(arg1: 214, arg2: 614);
                context.ChangeMonster(arg1: 215, arg2: 615);
                context.ChangeMonster(arg1: 216, arg2: 616);
                context.ChangeMonster(arg1: 217, arg2: 617);
                context.ChangeMonster(arg1: 218, arg2: 618);
                context.ChangeMonster(arg1: 219, arg2: 619);
                context.ChangeMonster(arg1: 220, arg2: 620);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620
                })) {
                    context.State = new StateBattle_B_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_B_Ready : TriggerState {
            internal StateBattle_B_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBattle_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_B : TriggerState {
            internal StateBattle_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 301, arg2: 701);
                context.ChangeMonster(arg1: 302, arg2: 702);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {701, 702})) {
                    context.State = new StateBattle_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_End : TriggerState {
            internal StateBattle_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(1f, 1f, 1f));
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101});
                context.SetInteractObject(arg1: new int[] {10001282}, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
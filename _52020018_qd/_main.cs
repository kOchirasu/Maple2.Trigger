using System;

namespace Maple2.Trigger._52020018_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/Eff_Fog_room.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200150},
                    arg3: new byte[] {1})) {
                    context.State = new Stateready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60200150},
                    arg3: new byte[] {2})) {
                    context.State = new StateBattle_End(context);
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
                context.SetProductionUI(arg1: 4);
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
                context.CreateMonster(arg1: new int[] {104}, arg2: true);
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
                context.CreateMonster(arg1: new int[] {106}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.MoveUser(arg1: 52020018, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateEventScene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_01 : TriggerState {
            internal StateEventScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "일부러 그런게 아니야.......");
                context.SetSceneSkip(arg1: "EventScene_end", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_02 : TriggerState {
            internal StateEventScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11003723, msg: "오호……. 핑계라도 대고 싶으신 겁니까?", duration: 3000,
                    illustID: "Nelf_normal", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_03 : TriggerState {
            internal StateEventScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003724, msg: "실망입니다. $MyPCName$님.", duration: 3000,
                    illustID: "Jordy_normal", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_04 : TriggerState {
            internal StateEventScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003724, msg: "그렇게 믿고 의지했는데…….", duration: 3000,
                    illustID: "Jordy_normal", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_05 : TriggerState {
            internal StateEventScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003724, msg: "절 버리고 가셨으니 평생 $MyPCName$님을 저주 할 겁니다.", duration: 3000,
                    illustID: "Jordy_normal", align: "Center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_06 : TriggerState {
            internal StateEventScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 0, msg: "아니야... 아니라고...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_07(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class StateEventScene_07 : TriggerState {
            internal StateEventScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 102, msg: "저주다! 저주!", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnPointID: 103, msg: "평생 저주 할거다!", duration: 2000, delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 104, msg: "죽어.", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnPointID: 105, msg: "우리하고 평생 여기 있자.", duration: 2000, delayTick: 1500);
                context.AddBalloonTalk(spawnPointID: 0, msg: "이건 사실이 아니야!!!", duration: 2000, delayTick: 3000);
                context.SetPcEmotionLoop(arg1: "Emotion_Failure_Idle_A", arg2: 3000f);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEventScene_end(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEventScene_end : TriggerState {
            internal StateEventScene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/Eff_Fog_room.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBattle_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_Ready : TriggerState {
            internal StateBattle_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {103});
                context.DestroyMonster(arg1: new int[] {104});
                context.DestroyMonster(arg1: new int[] {105});
                context.DestroyMonster(arg1: new int[] {106});
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.CreateMonster(arg1: new int[] {203}, arg2: true);
                context.CreateMonster(arg1: new int[] {204}, arg2: true);
                context.CreateMonster(arg1: new int[] {205}, arg2: true);
                context.CreateMonster(arg1: new int[] {206}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle : TriggerState {
            internal StateBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "마리오네트들을 처치하고 이곳을 빠져나가자.", arg3: new int[] {2000}, arg4: "0");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201, 202, 203, 204, 205, 206})) {
                    context.State = new StateBattle_End(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle_End : TriggerState {
            internal StateBattle_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg2: "trigger", arg3: "NightmareTroy");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
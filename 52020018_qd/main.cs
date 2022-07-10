using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020018_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/Eff_Fog_room.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200150}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200150}, questStates: new byte[]{2})) {
                    return new StateBattle_End(context);
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
                context.SetCinematicUI(type: 4);
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.MoveUser(mapId: 52020018, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEventScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_01 : TriggerState {
            internal StateEventScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "일부러 그런게 아니야.......");
                context.SetSceneSkip(state: new StateEventScene_end(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_02 : TriggerState {
            internal StateEventScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003723, script: "오호……. 핑계라도 대고 싶으신 겁니까?", duration: 3000, illustId: "Nelf_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_03 : TriggerState {
            internal StateEventScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003724, script: "실망입니다. $MyPCName$님.", duration: 3000, illustId: "Jordy_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_04 : TriggerState {
            internal StateEventScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003724, script: "그렇게 믿고 의지했는데…….", duration: 3000, illustId: "Jordy_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_05 : TriggerState {
            internal StateEventScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003724, script: "절 버리고 가셨으니 평생 $MyPCName$님을 저주 할 겁니다.", duration: 3000, illustId: "Jordy_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_06 : TriggerState {
            internal StateEventScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "아니야... 아니라고...", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_07(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class StateEventScene_07 : TriggerState {
            internal StateEventScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 102, msg: "저주다! 저주!", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 103, msg: "평생 저주 할거다!", duration: 2000, delayTick: 500);
                context.AddBalloonTalk(spawnId: 104, msg: "죽어.", duration: 2000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 105, msg: "우리하고 평생 여기 있자.", duration: 2000, delayTick: 1500);
                context.AddBalloonTalk(spawnId: 0, msg: "이건 사실이 아니야!!!", duration: 2000, delayTick: 3000);
                context.SetPcEmotionLoop(sequenceName: "Emotion_Failure_Idle_A", duration: 3000f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_end : TriggerState {
            internal StateEventScene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/Eff_Fog_room.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattle_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_Ready : TriggerState {
            internal StateBattle_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105, 106});
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle : TriggerState {
            internal StateBattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "마리오네트들을 처치하고 이곳을 빠져나가자.", duration: 2000, boxId: 0);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204, 205, 206})) {
                    return new StateBattle_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_End : TriggerState {
            internal StateBattle_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(type: "trigger", code: "NightmareTroy");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

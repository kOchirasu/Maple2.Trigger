using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020019_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.SetSound(triggerId: 7001, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200010}, questStates: new byte[]{1})) {
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
                context.SetCinematicUI(type: 4);
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: true);
                context.MoveUser(mapId: 52020019, portalId: 6001);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_Work_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_Work_01 : TriggerState {
            internal StateCamera_Work_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.SetSceneSkip(arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShowCaption(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShowCaption : TriggerState {
            internal StateShowCaption(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$map:52020019$", script: "$npcName:11003614$의 두 번째 시험장.", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 2000, scale: 1.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera_Work_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_Work_02 : TriggerState {
            internal StateCamera_Work_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_01 : TriggerState {
            internal StateEventScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003614, script: "자, 시작하세요.", duration: 3000);
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
                context.MoveUserPath(patrolName: "MS2PatrolData_3001");
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
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 11003598, script: "오호.... 제법 기합을 넣을 줄 아시는군요.", duration: 2500, illustId: "Michael_normal", align: Align.Right);
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
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003598, script: "그럼 시작하기전에....", duration: 2500, illustId: "Michael_normal", align: Align.Right);
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
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003598, script: "정식으로 제 소개를 하죠.", duration: 2500, illustId: "Michael_normal", align: Align.Right);
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003598, script: "제 이름은 $npcName:11003598$.", duration: 2500, illustId: "Michael_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_07 : TriggerState {
            internal StateEventScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003598, script: "크리티아스 제 3기사. 몽환의 $npcName:11003598$입니다.", duration: 3000, illustId: "Michael_normal", align: Align.Center);
                context.ShowCaption(type: CaptionType.Name, title: "$npcName:11003598$", script: "몽환의 기사", align: Align.Center | Align.Left, offsetRateX: 0.05f, offsetRateY: 0.15f, duration: 3000, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateEventScene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_08 : TriggerState {
            internal StateEventScene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEventScene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_09 : TriggerState {
            internal StateEventScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Bore_A"});
                context.AddBalloonTalk(spawnId: 0, msg: "!!!", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_10 : TriggerState {
            internal StateEventScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Emotion_B");
                context.AddCinematicTalk(npcId: 11003598, script: "자, 그럼 당신의 실력을 확인해보도록 하죠.", duration: 3000, illustId: "Michael_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateWhite(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWhite : TriggerState {
            internal StateWhite(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattle_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_Ready : TriggerState {
            internal StateBattle_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_white.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateBattle_Stop(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_Stop : TriggerState {
            internal StateBattle_Stop(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "그만!", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBattle_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_End : TriggerState {
            internal StateBattle_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEventScene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_11 : TriggerState {
            internal StateEventScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003614, script: "그만 하세요.", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_12 : TriggerState {
            internal StateEventScene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003598, script: "이런, 이제 막 재미있어지려는 참이었는데 아쉽군요.", duration: 2500, illustId: "Michael_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_13 : TriggerState {
            internal StateEventScene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003598, script: "뭐, 다음 기회라는 것도 있으니 이번엔 여기까지만 하겠습니다.", duration: 2500, illustId: "Michael_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_14 : TriggerState {
            internal StateEventScene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003614, script: ".......", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_15 : TriggerState {
            internal StateEventScene_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003614, script: "돌아가죠. $npcName:11003598$.", duration: 2500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventScene_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventScene_16 : TriggerState {
            internal StateEventScene_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003598, script: "네. 분부대로.", duration: 2500, illustId: "Michael_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestComplete(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete : TriggerState {
            internal StateQuestComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(type: "trigger", code: "ForgottenrRoad");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWarp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02020006, portalId: 6002);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200010}, questStates: new byte[]{1})) {
                    return new StateQuestComplete(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

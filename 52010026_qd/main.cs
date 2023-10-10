using System.Numerics;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010026_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.SetEffect(triggerIds: new []{201, 221, 5001, 5002, 5003, 5004, 5005, 5101, 5201}, visible: false);
                context.SetSound(triggerId: 7001, enabled: true);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 6, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 7, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 8, enabled: false, path: @"BG\Common\ScreenMask\Eff_FlickEye.nif");
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 102, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 103, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 201, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 202, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 301, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 997, enabled: false, path: @"BG/sound/Eff_BossRegen_01.xml");
                context.SetOnetimeEffect(id: 998, enabled: false, path: @"BG/sound/Eff_DevilPortal_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001})) {
                    return new StateBlack(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlack : TriggerState {
            internal StateBlack(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52010026, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.CreateMonster(spawnIds: new []{1001}, arg2: false, arg3: 0);
                context.CreateMonster(spawnIds: new []{601, 602, 603}, arg2: false, arg3: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic_깨어난PC(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_깨어난PC : TriggerState {
            internal StateStartCinematic_깨어난PC(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionLoop(sequenceName: "Sit_Ground_Idle_A", duration: 29000f);
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_disappoint");
                context.SetSceneSkip(state: new State두번째Cinematic_ready(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartCinematic_PCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_PCScript01 : TriggerState {
            internal StateStartCinematic_PCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_disappoint");
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__0$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__1$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStartCinematic_조디Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic_조디Script01 : TriggerState {
            internal StateStartCinematic_조디Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.FaceEmotion(spawnId: 1001, emotionName: "Trigger_Talk_A");
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__3$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__4$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateFirstCinematic_PCScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstCinematic_PCScript02 : TriggerState {
            internal StateFirstCinematic_PCScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_panic");
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__5$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__6$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateFirstCinematic_조디Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstCinematic_조디Script02 : TriggerState {
            internal StateFirstCinematic_조디Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 1001, emotionName: "Trigger_Talk03_A");
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__7$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__8$", duration: 3000);
                context.FaceEmotion(spawnId: 1001, emotionName: "Trigger_Talk02_A");
                context.AddCinematicTalk(npcId: 11003344, illustId: "Peach_normal", script: "$52010026_QD__MAIN__9$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__10$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateFirstCinematic_PCScript03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstCinematic_PCScript03 : TriggerState {
            internal StateFirstCinematic_PCScript03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_serious");
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__11$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFirstCinematic_조디Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstCinematic_조디Script03 : TriggerState {
            internal StateFirstCinematic_조디Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 1001, emotionName: "Trigger_Talk01_A");
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__12$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__13$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateFirstCinematic_PCScript04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstCinematic_PCScript04 : TriggerState {
            internal StateFirstCinematic_PCScript04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_serious");
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__14$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State조디_Camera01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조디_Camera01 : TriggerState {
            internal State조디_Camera01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFirstCinematic_조디Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstCinematic_조디Script04 : TriggerState {
            internal StateFirstCinematic_조디Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.FaceEmotion(spawnId: 1001, emotionName: "Trigger_Idle02_A");
                context.SetNpcEmotionLoop(spawnId: 1001, sequenceName: "Trigger_Idle_A", duration: 10000f);
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__15$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFirstCinematic_조디Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstCinematic_조디Script05 : TriggerState {
            internal StateFirstCinematic_조디Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
                context.SetOnetimeEffect(id: 301, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__16$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__17$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateFirstCinematic_PCScript05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.VisibleMyPc(visible: true);
            }
        }

        private class StateFirstCinematic_PCScript05 : TriggerState {
            internal StateFirstCinematic_PCScript05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_serious");
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__18$", duration: 3000);
                context.SetNpcEmotionLoop(spawnId: 1001, sequenceName: "Trigger_Idle_A", duration: 10000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State조디_Camera02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조디_Camera02 : TriggerState {
            internal State조디_Camera02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFirstCinematic_조디Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstCinematic_조디Script06 : TriggerState {
            internal StateFirstCinematic_조디Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.FaceEmotion(spawnId: 1001, emotionName: "Idle_A");
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 1000f);
                context.AddCinematicTalk(npcId: 11003344, script: "$52010026_QD__MAIN__19$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__20$", duration: 3000);
                context.SetEventUI(arg1: 1, script: "$52010026_QD__MAIN__21$", duration: 8000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State두번째Cinematic_ready(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetSound(triggerId: 7001, enabled: false);
                context.SetSceneSkip();
            }
        }

        private class State두번째Cinematic_ready : TriggerState {
            internal State두번째Cinematic_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: true);
                context.SetPcEmotionLoop(sequenceName: "Sit_Ground_Idle_A", duration: 100f);
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2101})) {
                    return new State두번째Cinematic_black(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_black : TriggerState {
            internal State두번째Cinematic_black(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4501}, returnView: false);
                context.CreateMonster(spawnIds: new []{1000}, arg2: false, arg3: 30000);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: true);
                context.CreateMonster(spawnIds: new []{101}, arg2: false, arg3: 0);
                context.CreateMonster(spawnIds: new []{102}, arg2: false, arg3: 0);
                context.SetNpcEmotionLoop(spawnId: 1000, sequenceName: "Down_Idle_A", duration: 70000f);
                context.SetSceneSkip(state: new State두번째Cinematic_피치전투01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째Cinematic_피치발견01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_피치발견01 : TriggerState {
            internal State두번째Cinematic_피치발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 201, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003343, script: "$52010026_QD__MAIN__22$", duration: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째Cinematic_피치발견02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_피치발견02 : TriggerState {
            internal State두번째Cinematic_피치발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 201, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddBalloonTalk(spawnId: 0, msg: "$52010026_QD__MAIN__47$", duration: 1000, delayTick: 0);
                context.CameraSelectPath(pathIds: new []{4501, 4502}, returnView: false);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째Cinematic_피치전투01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_피치전투01 : TriggerState {
            internal State두번째Cinematic_피치전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddBalloonTalk(spawnId: 1000, msg: "$52010026_QD__MAIN__24$", duration: 1000, delayTick: 0);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52010026_QD__MAIN__25$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째Cinematic_피치전투02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_피치전투02 : TriggerState {
            internal State두번째Cinematic_피치전투02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102})) {
                    return new State두번째Cinematic_Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_Delay01 : TriggerState {
            internal State두번째Cinematic_Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.AddBalloonTalk(spawnId: 1000, msg: "$52010026_QD__MAIN__26$", duration: 2000, delayTick: 1000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State두번째Cinematic_피치전투03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_피치전투03 : TriggerState {
            internal State두번째Cinematic_피치전투03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 1000, msg: "$52010026_QD__MAIN__27$", duration: 2000, delayTick: 0);
                context.SetOnetimeEffect(id: 202, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(triggerIds: new []{5003, 5004, 5005}, visible: true);
                context.CreateMonster(spawnIds: new []{103}, arg2: false, arg3: 0);
                context.CreateMonster(spawnIds: new []{104}, arg2: false, arg3: 0);
                context.CreateMonster(spawnIds: new []{105}, arg2: false, arg3: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{103, 104, 105})) {
                    return new State두번째Cinematic_Delay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_Delay02 : TriggerState {
            internal State두번째Cinematic_Delay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 202, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(triggerIds: new []{5003, 5004, 5005}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째Cinematic_PCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_PCScript01 : TriggerState {
            internal State두번째Cinematic_PCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__28$", duration: 3000);
                context.SetSceneSkip(state: new StateSkip(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State두번째Cinematic_잠시쉬기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip : TriggerState {
            internal StateSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 4);
                context.CreateMonster(spawnIds: new []{111}, arg2: false, arg3: 6000);
                context.CreateMonster(spawnIds: new []{112}, arg2: false, arg3: 6000);
                context.CreateMonster(spawnIds: new []{113}, arg2: false, arg3: 6000);
                context.CreateMonster(spawnIds: new []{114}, arg2: false, arg3: 6000);
                context.CreateMonster(spawnIds: new []{115}, arg2: false, arg3: 6000);
                context.CreateMonster(spawnIds: new []{121}, arg2: false, arg3: 5000);
                context.CreateMonster(spawnIds: new []{122}, arg2: false, arg3: 5000);
                context.CreateMonster(spawnIds: new []{123}, arg2: false, arg3: 5000);
                context.CreateMonster(spawnIds: new []{124}, arg2: false, arg3: 5000);
                context.CreateMonster(spawnIds: new []{125}, arg2: false, arg3: 5000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세번째Cinematic_Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째Cinematic_잠시쉬기 : TriggerState {
            internal State두번째Cinematic_잠시쉬기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003343, illustId: "Peach_normal", align: Align.Left, script: "$52010026_QD__MAIN__29$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003343, script: "$52010026_QD__MAIN__30$", duration: 2000);
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__48$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State세번째Cinematic_포털개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째Cinematic_포털개방 : TriggerState {
            internal State세번째Cinematic_포털개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4201}, returnView: false);
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetAmbientLight(color: new Vector3(128f, 128f, 128f));
                context.SetEffect(triggerIds: new []{201}, visible: true);
                context.SetOnetimeEffect(id: 998, enabled: true, path: @"BG/sound/Eff_DevilPortal_01.xml");
                context.CreateMonster(spawnIds: new []{111}, arg2: false, arg3: 6000);
                context.CreateMonster(spawnIds: new []{112}, arg2: false, arg3: 6000);
                context.CreateMonster(spawnIds: new []{113}, arg2: false, arg3: 6000);
                context.CreateMonster(spawnIds: new []{114}, arg2: false, arg3: 6000);
                context.CreateMonster(spawnIds: new []{115}, arg2: false, arg3: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세번째Cinematic_포털개방02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째Cinematic_포털개방02 : TriggerState {
            internal State세번째Cinematic_포털개방02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4301}, returnView: false);
                context.SetOnetimeEffect(id: 102, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(triggerIds: new []{211}, visible: true);
                context.CreateMonster(spawnIds: new []{121}, arg2: false, arg3: 5000);
                context.CreateMonster(spawnIds: new []{122}, arg2: false, arg3: 5000);
                context.CreateMonster(spawnIds: new []{123}, arg2: false, arg3: 5000);
                context.CreateMonster(spawnIds: new []{124}, arg2: false, arg3: 5000);
                context.CreateMonster(spawnIds: new []{125}, arg2: false, arg3: 5000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세번째Cinematic_Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째Cinematic_Script01 : TriggerState {
            internal State세번째Cinematic_Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 102, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.AddBalloonTalk(spawnId: 0, msg: "$52010026_QD__MAIN__32$", duration: 2000, delayTick: 0);
                context.SetNpcEmotionSequence(spawnId: 1000, sequenceName: "ChatUP_A");
                context.AddBalloonTalk(spawnId: 1000, msg: "$52010026_QD__MAIN__33$", duration: 2000, delayTick: 2000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52010026_QD__MAIN__34$", duration: 2000, boxId: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State피치탈출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피치탈출 : TriggerState {
            internal State피치탈출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 1000, patrolName: "MS2PatrolData_3002");
                context.AddBalloonTalk(spawnId: 1000, msg: "$52010026_QD__MAIN__42$", duration: 2000, delayTick: 0);
                context.AddBuff(boxIds: new []{2101}, skillId: 70000123, level: 1, arg4: false, arg5: false);
                context.SetEffect(triggerIds: new []{5101}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111, 112, 113, 114, 115, 121, 122, 123, 124, 125})) {
                    return new State세번째Cinematic_Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째Cinematic_Script02 : TriggerState {
            internal State세번째Cinematic_Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{201, 221}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 998, enabled: false, path: @"BG/sound/Eff_DevilPortal_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세번째Cinematic_Script02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째Cinematic_Script02_1 : TriggerState {
            internal State세번째Cinematic_Script02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_a(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__35$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003343, script: "$52010026_QD__MAIN__36$", duration: 2000);
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__49$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State다섯번째Cinematic_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯번째Cinematic_ready : TriggerState {
            internal State다섯번째Cinematic_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 7, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4402}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다섯번째Cinematic_EliteMonster(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_a : TriggerState {
            internal StateSkip_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CreateMonster(spawnIds: new []{131}, arg2: true, arg3: 0);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State다섯번째Cinematic_EliteMonster대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯번째Cinematic_EliteMonster : TriggerState {
            internal State다섯번째Cinematic_EliteMonster(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 1000, sequenceName: "Trigger_Hurt_A", duration: 28000f);
                context.CameraSelectPath(pathIds: new []{4401}, returnView: false);
                context.SetOnetimeEffect(id: 7, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52010026, portalId: 6002);
                context.SetOnetimeEffect(id: 103, enabled: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 997, enabled: true, path: @"BG/sound/Eff_BossRegen_01.xml");
                context.CreateMonster(spawnIds: new []{131}, arg2: true, arg3: 0);
                context.ShowCaption(type: CaptionType.Name, scale: 2.3f, title: "$52010026_QD__MAIN__50$", script: "$52010026_QD__MAIN__51$", align: Align.Center | Align.Left, offsetRateX: -0.15f, duration: 4000);
                context.SetOnetimeEffect(id: 103, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State다섯번째Cinematic_EliteMonster대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯번째Cinematic_EliteMonster대사 : TriggerState {
            internal State다섯번째Cinematic_EliteMonster대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52010026_QD__MAIN__38$", duration: 2000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State다섯번째Cinematic_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯번째Cinematic_전투 : TriggerState {
            internal State다섯번째Cinematic_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 997, enabled: false, path: @"BG/sound/Eff_BossRegen_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{131})) {
                    return new State다섯번째Cinematic_마지막(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯번째Cinematic_마지막 : TriggerState {
            internal State다섯번째Cinematic_마지막(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 6, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StateWarp(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State다섯번째Cinematic_대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯번째Cinematic_대화02 : TriggerState {
            internal State다섯번째Cinematic_대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.FaceEmotion(spawnId: 0, emotionName: "Trigger_disappoint");
                context.SetPcEmotionLoop(sequenceName: "Down_B", duration: 18000f);
                context.SetOnetimeEffect(id: 6, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{5201}, visible: true);
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__43$", duration: 3000);
                context.AddCinematicTalk(npcId: 0, script: "$52010026_QD__MAIN__44$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State다섯번째Cinematic_암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯번째Cinematic_암전 : TriggerState {
            internal State다섯번째Cinematic_암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 7, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다섯번째Cinematic_의문의목소리암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯번째Cinematic_의문의목소리암전 : TriggerState {
            internal State다섯번째Cinematic_의문의목소리암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003145, script: "$52010026_QD__MAIN__45$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003145, script: "$52010026_QD__MAIN__46$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateWarp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp : TriggerState {
            internal StateWarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000042, portalId: 10);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

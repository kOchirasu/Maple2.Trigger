using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000119_qd {
    public static class _main2 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2002}, questIds: new []{60100060}, questStates: new byte[]{1})) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{105, 106});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006}, returnView: false);
                context.DestroyMonster(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929});
                context.CreateMonster(spawnIds: new []{105, 106}, arg2: true);
                context.MoveUser(mapId: 52000119, portalId: 6002);
                context.SetSceneSkip(state: new StateFadeout_01(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006, 4007}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUserPath(patrolName: "MS2PatrolData_3002");
                context.FaceEmotion(spawnId: 0, emotionName: "Object_React_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007, 4008}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Sit_Down_A", duration: 6000f);
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003187, script: "$52000119_QD__MAIN2__0$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008, 4013, 4014, 4015}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003187, script: "$52000119_QD__MAIN2__1$", duration: 3000, align: Align.Left);
                context.SetConversation(type: 1, spawnId: 105, script: "$52000119_QD__MAIN2__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Talk_A");
                context.SetNpcEmotionSequence(spawnId: 105, sequenceName: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003187, script: "$52000119_QD__MAIN2__3$", duration: 3000, align: Align.Left);
                context.SetConversation(type: 1, spawnId: 105, script: "$52000119_QD__MAIN2__4$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003187, script: "$52000119_QD__MAIN2__5$", duration: 4989, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003187, script: "$52000119_QD__MAIN2__6$", duration: 8254, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 106, sequenceName: "Damg_B");
                context.AddCinematicTalk(npcId: 11003171, script: "$52000119_QD__MAIN2__7$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7001, arg2: true);
                context.SetNpcEmotionSequence(spawnId: 106, sequenceName: "Attack_02_A");
                context.AddCinematicTalk(npcId: 11003171, script: "$52000119_QD__MAIN2__8$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_08 : TriggerState {
            internal StateScene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4016}, returnView: false);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetNpcEmotionLoop(spawnId: 106, sequenceName: "Attack_Idle_A", duration: 8000f);
                context.AddCinematicTalk(npcId: 11003171, script: "$52000119_QD__MAIN2__9$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_09 : TriggerState {
            internal StateScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4016, 4017, 4018}, returnView: false);
                context.FaceEmotion(spawnId: 0, emotionName: "Object_React_A");
                context.AddCinematicTalk(npcId: 11003171, script: "$52000119_QD__MAIN2__10$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_10 : TriggerState {
            internal StateScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4018}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 106, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003171, script: "$52000119_QD__MAIN2__11$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_11 : TriggerState {
            internal StateScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4019}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 106, sequenceName: "Attack_02_C");
                context.AddCinematicTalk(npcId: 11003171, script: "$52000119_QD__MAIN2__12$", duration: 3000, align: Align.Left);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFadeout_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_01 : TriggerState {
            internal StateFadeout_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSound(triggerId: 7001, arg2: false);
                context.SetSound(triggerId: 7002, arg2: true);
                context.SetEffect(triggerIds: new []{5002}, visible: false);
                context.DestroyMonster(spawnIds: new []{106});
                context.CreateMonster(spawnIds: new []{998}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadein_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein_01 : TriggerState {
            internal StateFadein_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMsg(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMsg : TriggerState {
            internal StateMsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52000119_QD__MAIN2__13$", duration: 3000, boxId: 0);
                context.AddBalloonTalk(spawnId: 997, msg: "$52000119_QD__MAIN2__14$", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{998})) {
                    return new StateFadeout_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_02 : TriggerState {
            internal StateFadeout_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7002, arg2: false);
                context.DestroyMonster(spawnIds: new []{998});
                context.SetAchievement(type: "trigger", code: "jordysave2");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

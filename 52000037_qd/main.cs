using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000037_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: false, initialSequence: "Dead_A");
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Ending_Chord_01.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60100125}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60100125, 60100126, 60100127, 60100128, 60100129, 60100130, 60100131, 60100132, 60100133, 60100134, 60100135}, questStates: new byte[]{2})) {
                    return new StateNpcspawn_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60100135}, questStates: new byte[]{3})) {
                    return new StateNpcspawn_03(context);
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
                context.SetSound(triggerId: 7001, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWaitng(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitng : TriggerState {
            internal StateWaitng(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.MoveUser(mapId: 52000037, portalId: 1);
                context.CreateMonster(spawnIds: new []{604, 602}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartscene(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartscene : TriggerState {
            internal StateStartscene(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4001, 4002, 4003, 4004, 4005, 4006, 4007}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2101");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 602, patrolName: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 11003202, illustId: "Jordy_normal", script: "$52000037_QD__MAIN__0$", duration: 3000, align: Align.Right);
                context.SetSceneSkip(state: new StateFadeout(context), arg2: "exit");
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
                context.MoveNpc(spawnId: 604, patrolName: "MS2PatrolData_3004");
                context.AddCinematicTalk(npcId: 11003204, script: "$52000037_QD__MAIN__1$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003202, illustId: "Jordy_normal", script: "$52000037_QD__MAIN__2$", duration: 4000, align: Align.Right);
                context.SetNpcEmotionSequence(spawnId: 602, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003204, script: "$52000037_QD__MAIN__3$", duration: 2000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 602, sequenceName: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003202, illustId: "Jordy_normal", script: "$52000037_QD__MAIN__4$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 604, sequenceName: "Bore_C");
                context.AddCinematicTalk(npcId: 11003204, script: "$52000037_QD__MAIN__5$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 602, sequenceName: "Dead_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3735)) {
                    return new StateScene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_08 : TriggerState {
            internal StateScene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 602, patrolName: "MS2PatrolData_3003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_09 : TriggerState {
            internal StateScene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_10 : TriggerState {
            internal StateScene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_11 : TriggerState {
            internal StateScene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_12 : TriggerState {
            internal StateScene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateScene_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_13 : TriggerState {
            internal StateScene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4009}, returnView: false);
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateScene_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_14 : TriggerState {
            internal StateScene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_15 : TriggerState {
            internal StateScene_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 602, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003202, illustId: "Jordy_normal", script: "$52000037_QD__MAIN__6$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_16 : TriggerState {
            internal StateScene_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 604, sequenceName: "Bore_C");
                context.AddCinematicTalk(npcId: 11003204, script: "$52000037_QD__MAIN__7$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEndready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndready : TriggerState {
            internal StateEndready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{602, 604});
                context.CreateMonster(spawnIds: new []{601, 603}, arg2: true);
                context.CameraReset(interpolationTime: 0f);
                context.SetSound(triggerId: 7001, arg2: false);
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "nelfmissing");
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcspawn_02 : TriggerState {
            internal StateNpcspawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{601, 602, 603, 604});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNpcspawn_02_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcspawn_02_A : TriggerState {
            internal StateNpcspawn_02_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{603, 601}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcspawn_03 : TriggerState {
            internal StateNpcspawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{601, 602, 603, 604});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

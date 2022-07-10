using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000119_qd {
    public static class _main {
        public class StateIntro : TriggerState {
            internal StateIntro(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920}, arg2: true);
                context.CreateMonster(spawnIds: new []{921, 922, 923, 924, 925, 926, 927, 928, 929, 104, 105}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60100030}, questStates: new byte[]{1})) {
                    return new StateFadeout_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_01 : TriggerState {
            internal StateFadeout_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{104, 105});
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: true);
                context.CameraSelectPath(pathIds: new []{4010, 4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFadein_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein_01 : TriggerState {
            internal StateFadein_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Sit_Down_A", duration: 900000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEventscene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventscene_01 : TriggerState {
            internal StateEventscene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003169, illustId: "Jordy_normal", script: "$52000119_QD__MAIN__0$", duration: 3000, align: Align.Left);
                context.SetSceneSkip(state: new StateFadeout_02(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventscene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventscene_02 : TriggerState {
            internal StateEventscene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
                context.SetConversation(type: 2, spawnId: 11000173, script: "$52000119_QD__MAIN__1$", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11000173, script: "$52000119_QD__MAIN__2$", arg4: 3, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEventscene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventscene_03 : TriggerState {
            internal StateEventscene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4003}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk");
                context.SetConversation(type: 2, spawnId: 11000173, script: "$52000119_QD__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventscene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventscene_04 : TriggerState {
            internal StateEventscene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Damg_B");
                context.SetConversation(type: 2, spawnId: 11003171, script: "$52000119_QD__MAIN__4$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEventscene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventscene_05 : TriggerState {
            internal StateEventscene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Bore_A");
                context.SetConversation(type: 2, spawnId: 11000173, script: "$52000119_QD__MAIN__5$", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11000173, script: "$52000119_QD__MAIN__6$", arg4: 3, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEventscene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventscene_06 : TriggerState {
            internal StateEventscene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Bore_A");
                context.SetConversation(type: 2, spawnId: 11003171, script: "$52000119_QD__MAIN__7$", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11003171, script: "$52000119_QD__MAIN__8$", arg4: 3, arg5: 3);
                context.SetConversation(type: 1, spawnId: 102, script: "$52000119_QD__MAIN__9$", arg4: 2, arg5: 4);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateFadeout_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_02 : TriggerState {
            internal StateFadeout_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEventscene_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEventscene_end : TriggerState {
            internal StateEventscene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 3);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52000119_QD__MAIN__10$", duration: 1000, boxId: 0);
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateHintmsg(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHintmsg : TriggerState {
            internal StateHintmsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.SetConversation(type: 2, spawnId: 0, script: "$52000119_QD__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePlay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlay : TriggerState {
            internal StatePlay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2002})) {
                    return new StateFadeout_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_03 : TriggerState {
            internal StateFadeout_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915, 916, 917, 918, 919, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 101, 102, 103});
                context.CreateMonster(spawnIds: new []{104, 105, 106}, arg2: true);
                context.MoveUser(mapId: 52000119, portalId: 6002);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFadein_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein_03 : TriggerState {
            internal StateFadein_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(patrolName: "MS2PatrolData_3003");
                context.AddBalloonTalk(spawnId: 0, msg: "$52000119_QD__MAIN__12$", duration: 2000, delayTick: 0);
                context.SetSceneSkip(state: new StateFadeout_04(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossscene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossscene_01 : TriggerState {
            internal StateBossscene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7001, arg2: true);
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Sit_Down_A", duration: 150000f);
                context.SetConversation(type: 2, spawnId: 11003187, script: "$52000119_QD__MAIN__13$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossscene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossscene_02 : TriggerState {
            internal StateBossscene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Bore_A");
                context.SetConversation(type: 2, spawnId: 11003187, script: "$52000119_QD__MAIN__14$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossscene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossscene_03 : TriggerState {
            internal StateBossscene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4011}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11003187, script: "$52000119_QD__MAIN__15$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 105, script: "$52000119_QD__MAIN__16$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBossscene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossscene_04 : TriggerState {
            internal StateBossscene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4013, 4014, 4015}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Bore_A");
                context.SetConversation(type: 2, spawnId: 11003187, script: "$52000119_QD__MAIN__17$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBossscene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossscene_05 : TriggerState {
            internal StateBossscene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 104, sequenceName: "Talk_A");
                context.FaceEmotion(spawnId: 0, emotionName: "Object_React_A");
                context.SetConversation(type: 2, spawnId: 11003187, script: "$52000119_QD__MAIN__18$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossscene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossscene_06 : TriggerState {
            internal StateBossscene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4010}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_3004");
                context.SetNpcEmotionSequence(spawnId: 106, sequenceName: "Attack_01_C");
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_3001");
                context.FaceEmotion(spawnId: 0, emotionName: "Object_React_A");
                context.SetConversation(type: 2, spawnId: 11003171, script: "$52000119_QD__MAIN__19$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossscene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossscene_07 : TriggerState {
            internal StateBossscene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 106, sequenceName: "Bore_A");
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 4000f);
                context.FaceEmotion(spawnId: 0, emotionName: "Object_React_A");
                context.SetConversation(type: 2, spawnId: 11003171, script: "$52000119_QD__MAIN__20$", arg4: 3, arg5: 0);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFadeout_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_04 : TriggerState {
            internal StateFadeout_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7001, arg2: false);
                context.SetSound(triggerId: 7002, arg2: true);
                context.DestroyMonster(spawnIds: new []{106});
                context.CreateMonster(spawnIds: new []{997}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadein_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein_04 : TriggerState {
            internal StateFadein_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.AddBalloonTalk(spawnId: 997, msg: "$52000119_QD__MAIN__21$", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBossmsg(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossmsg : TriggerState {
            internal StateBossmsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52000119_QD__MAIN__22$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{997})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7002, arg2: false);
                context.AddBalloonTalk(spawnId: 104, msg: "$52000119_QD__MAIN__23$", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFadeout_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_05 : TriggerState {
            internal StateFadeout_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{997});
                context.SetAchievement(type: "trigger", code: "jordysave");
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

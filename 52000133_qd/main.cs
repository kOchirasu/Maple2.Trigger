using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000133_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 111, 112});
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuestConditionCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestConditionCheck : TriggerState {
            internal StateQuestConditionCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001599}, questStates: new byte[]{3})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001599}, questStates: new byte[]{2})) {
                    return new State예민한아노스(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001599}, questStates: new byte[]{1})) {
                    return new State예민한아노스(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001598}, questStates: new byte[]{3})) {
                    return new State예민한아노스(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001598}, questStates: new byte[]{2})) {
                    return new State예민한아노스_SetupCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001584}, questStates: new byte[]{2})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001584}, questStates: new byte[]{1})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001583}, questStates: new byte[]{3})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001583}, questStates: new byte[]{2})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001583}, questStates: new byte[]{1})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001582}, questStates: new byte[]{3})) {
                    return new State케이틀린첫만남(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001582}, questStates: new byte[]{2})) {
                    return new State케이틀린첫만남_StartCinematic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001582}, questStates: new byte[]{1})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001581}, questStates: new byte[]{3})) {
                    return new State빈집(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린첫만남 : TriggerState {
            internal State케이틀린첫만남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101});
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린첫만남_StartCinematic : TriggerState {
            internal State케이틀린첫만남_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.CreateMonster(spawnIds: new []{101});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000133, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State전경스케치01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치01 : TriggerState {
            internal State전경스케치01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State전경스케치02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치02 : TriggerState {
            internal State전경스케치02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000133_QD__MAIN__0$", duration: 2000, align: Align.Left);
                context.SetSceneSkip(state: new State케이틀린첫만남_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경스케치03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치03 : TriggerState {
            internal State전경스케치03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경스케치04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치04 : TriggerState {
            internal State전경스케치04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003254, illustId: "Caitlyn_normal", script: "$52000133_QD__MAIN__1$", duration: 3000, align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State전경스케치05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치05 : TriggerState {
            internal State전경스케치05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.AddBalloonTalk(spawnId: 101, msg: "$52000133_QD__MAIN__2$", duration: 3000, delayTick: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Bore_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전경스케치06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치06 : TriggerState {
            internal State전경스케치06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8010}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전경스케치07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경스케치07 : TriggerState {
            internal State전경스케치07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Name, title: "$52000133_QD__MAIN__3$", script: "$52000133_QD__MAIN__4$", align: Align.Center | Align.Right, offsetRateX: -0.05f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Bore_B", duration: 4000f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린첫만남_스킵완료 : TriggerState {
            internal State케이틀린첫만남_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52000133, portalId: 12);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예민한아노스 : TriggerState {
            internal State예민한아노스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111, 113});
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예민한아노스_SetupCinematic : TriggerState {
            internal State예민한아노스_SetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000133, portalId: 11);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State예민한아노스_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예민한아노스_StartCinematic : TriggerState {
            internal State예민한아노스_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8100}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State케이틀린Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script01 : TriggerState {
            internal State케이틀린Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8101}, returnView: false);
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", script: "$52000133_QD__MAIN__5$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Bore_A", duration: 4600f);
                context.MoveUserPath(patrolName: "2_MS2PatrolData_PC01");
                context.SetSceneSkip(state: new State예민한아노스_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript01 : TriggerState {
            internal StatePCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8120}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000133_QD__MAIN__6$", duration: 3000);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 2000f);
                context.MoveUserPath(patrolName: "2_MS2PatrolData_PC02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script02 : TriggerState {
            internal State케이틀린Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", script: "$52000133_QD__MAIN__7$", duration: 3000, align: Align.Right);
                context.MoveNpc(spawnId: 111, patrolName: "2_MS2PatrolData_Katelyn01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript02 : TriggerState {
            internal StatePCScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000133_QD__MAIN__8$", duration: 3000, align: Align.Right);
                context.MoveUserPath(patrolName: "2_MS2PatrolData_PC03");
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 2000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script03 : TriggerState {
            internal State케이틀린Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8110}, returnView: false);
                context.CreateMonster(spawnIds: new []{112});
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", script: "$52000133_QD__MAIN__9$", duration: 4000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Talk_A", duration: 8200f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아노스걸어나옴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스걸어나옴 : TriggerState {
            internal State아노스걸어나옴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8140}, returnView: false);
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", script: "$52000133_QD__MAIN__10$", duration: 3000, align: Align.Left);
                context.MoveNpc(spawnId: 112, patrolName: "2_MS2PatrolData_Anos01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script01 : TriggerState {
            internal State아노스Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", script: "$52000133_QD__MAIN__11$", duration: 3000, align: Align.Left);
                context.MoveNpc(spawnId: 111, patrolName: "2_MS2PatrolData_Katelyn02");
                context.SetNpcEmotionLoop(spawnId: 112, sequenceName: "Talk_A", duration: 3600f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript03 : TriggerState {
            internal StatePCScript03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000133_QD__MAIN__12$", align: Align.Center, duration: 3000);
                context.SetPcEmotionLoop(sequenceName: "Emotion_Hello_A", duration: 2000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script02 : TriggerState {
            internal State아노스Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", script: "$52000133_QD__MAIN__13$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 112, sequenceName: "ChatUp_A", duration: 7000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript04 : TriggerState {
            internal StatePCScript04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8131}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000133_QD__MAIN__14$", duration: 3000, align: Align.Right);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Surprise_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script03 : TriggerState {
            internal State아노스Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", script: "$52000133_QD__MAIN__15$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 112, sequenceName: "Bore_A", duration: 8100f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script04 : TriggerState {
            internal State케이틀린Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8132}, returnView: false);
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", script: "$52000133_QD__MAIN__16$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Talk_A", duration: 12000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script04 : TriggerState {
            internal State아노스Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", script: "$52000133_QD__MAIN__17$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 112, sequenceName: "Bore_B", duration: 9500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script05 : TriggerState {
            internal State아노스Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8133}, returnView: false);
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_normal", script: "$52000133_QD__MAIN__18$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 112, sequenceName: "Talk_A", duration: 6300f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script05 : TriggerState {
            internal State케이틀린Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", script: "$52000133_QD__MAIN__19$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Bore_B", duration: 7900f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Script06 : TriggerState {
            internal State케이틀린Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003258, illustId: "Caitlyn_normal", script: "$52000133_QD__MAIN__20$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Talk_A", duration: 6800f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script06 : TriggerState {
            internal State아노스Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8140}, returnView: false);
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_serious", script: "$52000133_QD__MAIN__21$", duration: 3000, align: Align.Left);
                context.SetNpcEmotionLoop(spawnId: 112, sequenceName: "Bore_A", duration: 5800f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script07 : TriggerState {
            internal State아노스Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8140}, returnView: false);
                context.AddCinematicTalk(npcId: 11003259, illustId: "Anos_serious", script: "$52000133_QD__MAIN__22$", duration: 3000, align: Align.Left);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예민한아노스_스킵완료 : TriggerState {
            internal State예민한아노스_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.CreateMonster(spawnIds: new []{113});
                context.DestroyMonster(spawnIds: new []{112});
                context.MoveUser(mapId: 52000133, portalId: 13);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State빈집 : TriggerState {
            internal State빈집(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000132_qd {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102});
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

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001584}, questStates: new byte[]{2})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001584}, questStates: new byte[]{1})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001583}, questStates: new byte[]{3})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001583}, questStates: new byte[]{2})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001583}, questStates: new byte[]{1})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001582}, questStates: new byte[]{3})) {
                    return new State빈집(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001582}, questStates: new byte[]{2})) {
                    return new State아이들과만남_CinematicWait(context);
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

        private class State아이들과만남_CinematicWait : TriggerState {
            internal State아이들과만남_CinematicWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102});
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000132, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아이들과만남_StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이들과만남_StartCinematic : TriggerState {
            internal State아이들과만남_StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC00");
                context.SetSceneSkip(state: new State아이들과인사_스킵완료(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리안인사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리안인사01 : TriggerState {
            internal State리안인사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003253, illustId: "0", script: "$52000132_QD__MAIN__0$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Bore_B", duration: 4000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메린인사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린인사01 : TriggerState {
            internal State메린인사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__1$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Bore_B", duration: 6000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC인사01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC인사01 : TriggerState {
            internal StatePC인사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000132_QD__MAIN__2$", duration: 3000, align: Align.Right);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 3000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State리안Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리안Script01 : TriggerState {
            internal State리안Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003253, illustId: "0", script: "$52000132_QD__MAIN__3$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메린Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린Script01 : TriggerState {
            internal State메린Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__4$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Bore_C", duration: 7000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State리안Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리안Script02 : TriggerState {
            internal State리안Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003253, illustId: "0", script: "$52000132_QD__MAIN__5$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Bore_A", duration: 3000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
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
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000132_QD__MAIN__6$", duration: 3000, align: Align.Right);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 1000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State리안Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리안Script03 : TriggerState {
            internal State리안Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003253, illustId: "0", script: "$52000132_QD__MAIN__7$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 6000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메린Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린Script02 : TriggerState {
            internal State메린Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__8$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4500f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아이들이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이들이동01 : TriggerState {
            internal State아이들이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_boy01");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_girl01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State유저이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동01 : TriggerState {
            internal State유저이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_PC01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State리안Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리안Script04 : TriggerState {
            internal State리안Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003253, illustId: "0", script: "$52000132_QD__MAIN__9$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 7000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메린Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린Script03 : TriggerState {
            internal State메린Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__10$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 13000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State리안Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리안Script05 : TriggerState {
            internal State리안Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003253, illustId: "0", script: "$52000132_QD__MAIN__11$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 4300f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아이들이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이들이동02 : TriggerState {
            internal State아이들이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_boy02");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_girl02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State유저이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동02 : TriggerState {
            internal State유저이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_PC02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State메린Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린Script04 : TriggerState {
            internal State메린Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__12$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 8900f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메린Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린Script05 : TriggerState {
            internal State메린Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__13$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4700f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
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
                context.AddCinematicTalk(npcId: 0, illustId: "0", script: "$52000132_QD__MAIN__14$", duration: 3000, align: Align.Right);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 2000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State리안Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리안Script06 : TriggerState {
            internal State리안Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003253, illustId: "0", script: "$52000132_QD__MAIN__15$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3200f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메린Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린Script06 : TriggerState {
            internal State메린Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__16$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 2000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아이들이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이들이동03 : TriggerState {
            internal State아이들이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_boy03");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_girl03");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State유저이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동03 : TriggerState {
            internal State유저이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_PC03");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State메린Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린Script07 : TriggerState {
            internal State메린Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__17$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 7400f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State리안Script07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리안Script07 : TriggerState {
            internal State리안Script07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003253, illustId: "0", script: "$52000132_QD__MAIN__18$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3700f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메린Script08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린Script08 : TriggerState {
            internal State메린Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__19$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 2000f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아이들이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이들이동04 : TriggerState {
            internal State아이들이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_boy04");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_girl04");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC04");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리안Script08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리안Script08 : TriggerState {
            internal State리안Script08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
                context.AddCinematicTalk(npcId: 11003253, illustId: "0", script: "$52000132_QD__MAIN__20$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3200f);
                context.SetSkip(state: new State아이들과인사_스킵완료(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State메린Script09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메린Script09 : TriggerState {
            internal State메린Script09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003252, illustId: "0", script: "$52000132_QD__MAIN__21$", duration: 3000, align: Align.Right);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아이들달림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이들달림 : TriggerState {
            internal State아이들달림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_boy_run");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_girl_run");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC05");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아이들과인사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이들과인사 : TriggerState {
            internal State아이들과인사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_PC06");
                context.SetPcEmotionSequence(sequenceNames: new []{"Hello_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State방정리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방정리 : TriggerState {
            internal State방정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.MoveUserPath(patrolName: "MS2PatrolData_PC06");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State유저맵이동_StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저맵이동_StopCinematic : TriggerState {
            internal State유저맵이동_StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 3.0f);
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.MoveUser(mapId: 52000132, portalId: 3);
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
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이들과인사_스킵완료 : TriggerState {
            internal State아이들과인사_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 3.0f);
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.MoveUser(mapId: 52000132, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 3.0f);
                context.MoveUser(mapId: 52000133, portalId: 1);
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

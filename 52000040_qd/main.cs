using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000040_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{1})) {
                    context.HideGuideSummary(entityId: 20020020);
                    return new StateReady_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{2})) {
                    return new StateStart_22(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001445}, questStates: new byte[]{3})) {
                    return new StateEnd_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001445}, questStates: new byte[]{2})) {
                    return new StateSb_ready_b_13(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001445}, questStates: new byte[]{1})) {
                    return new StateSb_ready_b_12(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001444}, questStates: new byte[]{3})) {
                    return new StateSb_ready_b_12(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001444}, questStates: new byte[]{2})) {
                    context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                    context.HideGuideSummary(entityId: 20020020);
                    return new StateSb_ready_b_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001443}, questStates: new byte[]{3})) {
                    context.AddBuff(boxIds: new []{701}, skillId: 70000096, level: 1);
                    context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                    context.HideGuideSummary(entityId: 20020020);
                    return new StateSb_ready_04(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001442}, questStates: new byte[]{3})) {
                    return new StateSb_ready_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001442}, questStates: new byte[]{2})) {
                    return new StateSb_ready_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_01 : TriggerState {
            internal StateSb_ready_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{145}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001443}, questStates: new byte[]{2})) {
                    context.AddBuff(boxIds: new []{701}, skillId: 70000096, level: 1);
                    context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                    context.HideGuideSummary(entityId: 20020020);
                    return new StateSb_ready_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_02 : TriggerState {
            internal StateSb_ready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Cut_BeyondLink_CCTV.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateSb_ready_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_03 : TriggerState {
            internal StateSb_ready_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{144, 145}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001443}, questStates: new byte[]{3})) {
                    return new StateSb_ready_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_04 : TriggerState {
            internal StateSb_ready_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
                context.ShowGuideSummary(entityId: 40010, textId: 40010);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    context.AddBuff(boxIds: new []{701}, skillId: 70000094, level: 1);
                    context.HideGuideSummary(entityId: 40010);
                    return new StateSb_ready_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_05 : TriggerState {
            internal StateSb_ready_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSb_ready_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_06 : TriggerState {
            internal StateSb_ready_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Push_A", duration: 5000f);
                context.AddBuff(boxIds: new []{701}, skillId: 70000095, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSb_ready_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_07 : TriggerState {
            internal StateSb_ready_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.AddBuff(boxIds: new []{701}, skillId: 70000096, level: 1);
                    return new StateSb_ready_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_08 : TriggerState {
            internal StateSb_ready_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000017, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_02 : TriggerState {
            internal StateSb_ready_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000040, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSb_ready_b_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_03 : TriggerState {
            internal StateSb_ready_b_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{221, 222, 223}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{7001, 7002, 7003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateSb_ready_b_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_04 : TriggerState {
            internal StateSb_ready_b_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7100}, returnView: false);
                context.MoveNpc(spawnId: 221, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 222, patrolName: "MS2PatrolData_2102");
                context.MoveNpc(spawnId: 223, patrolName: "MS2PatrolData_2103");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSb_ready_b_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_06 : TriggerState {
            internal StateSb_ready_b_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001726, script: "$52000040_QD__MAIN__26$", arg4: 4);
                context.SetSkip(state: new StateSb_ready_b_07_skip(context));
                context.SetNpcEmotionLoop(spawnId: 221, sequenceName: "Talk_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateSb_ready_b_07_skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_07_skip : TriggerState {
            internal StateSb_ready_b_07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateSb_ready_b_07(context);
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_07 : TriggerState {
            internal StateSb_ready_b_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001728, script: "$52000040_QD__MAIN__27$", arg4: 4);
                context.SetSkip(state: new StateSb_ready_b_08_skip(context));
                context.SetNpcEmotionLoop(spawnId: 222, sequenceName: "Talk_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateSb_ready_b_08_skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_08_skip : TriggerState {
            internal StateSb_ready_b_08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateSb_ready_b_08(context);
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_08 : TriggerState {
            internal StateSb_ready_b_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001726, script: "$52000040_QD__MAIN__28$", arg4: 4);
                context.SetSkip(state: new StateSb_ready_b_09_skip(context));
                context.SetNpcEmotionLoop(spawnId: 221, sequenceName: "Talk_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateSb_ready_b_09_skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_09_skip : TriggerState {
            internal StateSb_ready_b_09_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateSb_ready_b_09(context);
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_09 : TriggerState {
            internal StateSb_ready_b_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001724, script: "$52000040_QD__MAIN__29$", arg4: 4);
                context.SetSkip(state: new StateSb_ready_b_10_skip(context));
                context.SetNpcEmotionLoop(spawnId: 223, sequenceName: "Talk_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateSb_ready_b_10_skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_10_skip : TriggerState {
            internal StateSb_ready_b_10_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateSb_ready_b_10(context);
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_10 : TriggerState {
            internal StateSb_ready_b_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{145}, arg2: true);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.CameraSelectPath(pathIds: new []{7010}, returnView: true);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSb_ready_b_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_11 : TriggerState {
            internal StateSb_ready_b_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_12 : TriggerState {
            internal StateSb_ready_b_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{145, 221, 222, 223}, arg2: true);
                context.MoveNpc(spawnId: 221, patrolName: "MS2PatrolData_2101");
                context.MoveNpc(spawnId: 222, patrolName: "MS2PatrolData_2102");
                context.MoveNpc(spawnId: 223, patrolName: "MS2PatrolData_2103");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_13 : TriggerState {
            internal StateSb_ready_b_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{145}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_end : TriggerState {
            internal StateSb_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2001");
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{7001, 7002, 7003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReady_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_03 : TriggerState {
            internal StateReady_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000040_QD__MAIN__0$", arg4: 5);
                context.SetSkip(state: new StateReady_04_skip(context));
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Idle_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReady_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_04_skip : TriggerState {
            internal StateReady_04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateReady_04(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_04 : TriggerState {
            internal StateReady_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000040_QD__MAIN__1$", arg4: 5);
                context.SetSkip(state: new StateReady_05_skip(context));
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Idle_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReady_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_05_skip : TriggerState {
            internal StateReady_05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateReady_05(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_05 : TriggerState {
            internal StateReady_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000040_QD__MAIN__2$", arg4: 5);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Idle_A", duration: 5000f);
                context.SetSkip(state: new StateReady_06_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReady_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_06_skip : TriggerState {
            internal StateReady_06_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateReady_06(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_06 : TriggerState {
            internal StateReady_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000040_QD__MAIN__3$", arg4: 5);
                context.SetSkip(state: new StateReady_07_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReady_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_07_skip : TriggerState {
            internal StateReady_07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateReady_07(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_07 : TriggerState {
            internal StateReady_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000040_QD__MAIN__4$", arg4: 5);
                context.SetSkip(state: new StateReady_08_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReady_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_08_skip : TriggerState {
            internal StateReady_08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateReady_08(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_08 : TriggerState {
            internal StateReady_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000040_QD__MAIN__5$", arg4: 5);
                context.SetSkip(state: new StateReady_09_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReady_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_09_skip : TriggerState {
            internal StateReady_09_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateReady_09(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_09 : TriggerState {
            internal StateReady_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000040_QD__MAIN__6$", arg4: 5);
                context.SetSkip(state: new StateReady_10_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReady_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_10_skip : TriggerState {
            internal StateReady_10_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateReady_10(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_10 : TriggerState {
            internal StateReady_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Cut_BeyondLink_CCTV.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__7$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_01_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01_ready : TriggerState {
            internal StateStart_01_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2004");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2003");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7005}, returnView: false);
                context.CreateMonster(spawnIds: new []{103}, arg2: true);
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000040_QD__MAIN__8$", arg4: 5);
                context.SetSkip(state: new StateStart_02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02_skip : TriggerState {
            internal StateStart_02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_03(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000040_QD__MAIN__9$", arg4: 5);
                context.SetSkip(state: new StateStart_03_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03_skip : TriggerState {
            internal StateStart_03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_04(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000040_QD__MAIN__10$", arg4: 4);
                context.SetSkip(state: new StateStart_04_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04_skip : TriggerState {
            internal StateStart_04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_05(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7006, 7007}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__11$", arg4: 5);
                context.SetSkip(state: new StateStart_05_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05_skip : TriggerState {
            internal StateStart_05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_06(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__12$", arg4: 4);
                context.SetSkip(state: new StateStart_06_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_06_skip : TriggerState {
            internal StateStart_06_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_07(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000040_QD__MAIN__13$", arg4: 5);
                context.SetSkip(state: new StateStart_07_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07_skip : TriggerState {
            internal StateStart_07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_08(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7008}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__14$", arg4: 5);
                context.SetSkip(state: new StateStart_08_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_08_skip : TriggerState {
            internal StateStart_08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_09(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000040_QD__MAIN__15$", arg4: 3);
                context.SetSkip(state: new StateStart_09_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_09_skip : TriggerState {
            internal StateStart_09_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_10(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_10 : TriggerState {
            internal StateStart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001545, script: "$52000040_QD__MAIN__16$", arg4: 5);
                context.SetSkip(state: new StateStart_10_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_10_skip : TriggerState {
            internal StateStart_10_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_11(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_11 : TriggerState {
            internal StateStart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__17$", arg4: 4);
                context.SetSkip(state: new StateStart_11_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_11_skip : TriggerState {
            internal StateStart_11_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_12(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_12 : TriggerState {
            internal StateStart_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000040_QD__MAIN__18$", arg4: 3);
                context.SetSkip(state: new StateStart_12_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_12_skip : TriggerState {
            internal StateStart_12_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_13(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_13 : TriggerState {
            internal StateStart_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__19$", arg4: 5);
                context.SetSkip(state: new StateStart_13_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_13_skip : TriggerState {
            internal StateStart_13_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_14(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_14 : TriggerState {
            internal StateStart_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__20$", arg4: 5);
                context.SetSkip(state: new StateStart_14_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_14_skip : TriggerState {
            internal StateStart_14_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_15(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_15 : TriggerState {
            internal StateStart_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__21$", arg4: 5);
                context.SetSkip(state: new StateStart_15_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_15_skip : TriggerState {
            internal StateStart_15_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_16(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_16 : TriggerState {
            internal StateStart_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__22$", arg4: 5);
                context.SetSkip(state: new StateStart_16_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_16_skip : TriggerState {
            internal StateStart_16_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateStart_17(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_17 : TriggerState {
            internal StateStart_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000040_QD__MAIN__23$", arg4: 3);
                context.SetSkip(state: new StateStart_18(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_18 : TriggerState {
            internal StateStart_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2005");
                context.CameraSelectPath(pathIds: new []{7009}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__24$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_19 : TriggerState {
            internal StateStart_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001548, script: "$52000040_QD__MAIN__25$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(spawnIds: new []{103, 102, 101});
                    return new StateStart_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_20 : TriggerState {
            internal StateStart_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{7010}, returnView: true);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetCinematicUI(type: 0);
                    context.CreateMonster(spawnIds: new []{104, 111, 112}, arg2: true);
                    context.SetCinematicUI(type: 2);
                    return new StateStart_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_21 : TriggerState {
            internal StateStart_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20020020, textId: 20020020);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{2})) {
                    context.HideGuideSummary(entityId: 20020020);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_22 : TriggerState {
            internal StateStart_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104, 111, 112}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{2})) {
                    context.HideGuideSummary(entityId: 20020020);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_01 : TriggerState {
            internal StateEnd_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

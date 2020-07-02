namespace Maple2.Trigger._52000040_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002635}, arg3: new byte[] {1})) {
                    context.HideGuideSummary(entityId: 20020020);
                    return new StateReady_02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002635}, arg3: new byte[] {2})) {
                    return new StateStart_22(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001445}, arg3: new byte[] {3})) {
                    return new StateEnd_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001445}, arg3: new byte[] {2})) {
                    return new StateSb_ready_b_13(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001445}, arg3: new byte[] {1})) {
                    return new StateSb_ready_b_12(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001444}, arg3: new byte[] {3})) {
                    return new StateSb_ready_b_12(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001444}, arg3: new byte[] {2})) {
                    context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                    context.HideGuideSummary(entityId: 20020020);
                    return new StateSb_ready_b_02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001443}, arg3: new byte[] {3})) {
                    context.AddBuff(arg1: new[] {701}, arg2: 70000096, arg3: 1);
                    context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                    context.HideGuideSummary(entityId: 20020020);
                    return new StateSb_ready_04(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001442}, arg3: new byte[] {3})) {
                    return new StateSb_ready_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001442}, arg3: new byte[] {2})) {
                    return new StateSb_ready_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_01 : TriggerState {
            internal StateSb_ready_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {145}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001443}, arg3: new byte[] {2})) {
                    context.AddBuff(arg1: new[] {701}, arg2: 70000096, arg3: 1);
                    context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
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
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Cut_BeyondLink_CCTV.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new StateSb_ready_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_03 : TriggerState {
            internal StateSb_ready_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {144, 145}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001443}, arg3: new byte[] {3})) {
                    return new StateSb_ready_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_04 : TriggerState {
            internal StateSb_ready_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.ShowGuideSummary(entityId: 40010, textId: 40010);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201})) {
                    context.AddBuff(arg1: new[] {701}, arg2: 70000094, arg3: 1);
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
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
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
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 5000f);
                context.AddBuff(arg1: new[] {701}, arg2: 70000095, arg3: 1);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.AddBuff(arg1: new[] {701}, arg2: 70000096, arg3: 1);
                    return new StateSb_ready_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_08 : TriggerState {
            internal StateSb_ready_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000017, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_02 : TriggerState {
            internal StateSb_ready_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000040, arg2: 2);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {221, 222, 223}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {7001, 7002, 7003}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {7100}, arg2: false);
                context.MoveNpc(arg1: 221, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 222, arg2: "MS2PatrolData_2102");
                context.MoveNpc(arg1: 223, arg2: "MS2PatrolData_2103");
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11001726, arg3: "$52000040_QD__MAIN__26$", arg4: 4);
                context.SetSkip(arg1: "sb_ready_b_07_skip");
                context.SetNpcEmotionLoop(arg1: 221, arg2: "Talk_A", arg3: 5000f);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateSb_ready_b_07(context);
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_07 : TriggerState {
            internal StateSb_ready_b_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001728, arg3: "$52000040_QD__MAIN__27$", arg4: 4);
                context.SetSkip(arg1: "sb_ready_b_08_skip");
                context.SetNpcEmotionLoop(arg1: 222, arg2: "Talk_A", arg3: 5000f);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateSb_ready_b_08(context);
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_08 : TriggerState {
            internal StateSb_ready_b_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001726, arg3: "$52000040_QD__MAIN__28$", arg4: 4);
                context.SetSkip(arg1: "sb_ready_b_09_skip");
                context.SetNpcEmotionLoop(arg1: 221, arg2: "Talk_A", arg3: 5000f);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateSb_ready_b_09(context);
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_09 : TriggerState {
            internal StateSb_ready_b_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001724, arg3: "$52000040_QD__MAIN__29$", arg4: 4);
                context.SetSkip(arg1: "sb_ready_b_10_skip");
                context.SetNpcEmotionLoop(arg1: 223, arg2: "Talk_A", arg3: 5000f);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateSb_ready_b_10(context);
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_10 : TriggerState {
            internal StateSb_ready_b_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {145}, arg2: true);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.CameraSelectPath(arg1: new[] {7010}, arg2: true);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
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
                context.SetCinematicUI(arg1: 4);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_12 : TriggerState {
            internal StateSb_ready_b_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {145, 221, 222, 223}, arg2: true);
                context.MoveNpc(arg1: 221, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 222, arg2: "MS2PatrolData_2102");
                context.MoveNpc(arg1: 223, arg2: "MS2PatrolData_2103");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_ready_b_13 : TriggerState {
            internal StateSb_ready_b_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {145}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateSb_end : TriggerState {
            internal StateSb_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
                context.CreateMonster(arg1: new[] {101, 102}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {7001, 7002, 7003}, arg2: false);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__0$", arg4: 5);
                context.SetSkip(arg1: "ready_04_skip");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 5000f);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateReady_04(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_04 : TriggerState {
            internal StateReady_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__1$", arg4: 5);
                context.SetSkip(arg1: "ready_05_skip");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 5000f);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateReady_05(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_05 : TriggerState {
            internal StateReady_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__2$", arg4: 5);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 5000f);
                context.SetSkip(arg1: "ready_06_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateReady_06(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_06 : TriggerState {
            internal StateReady_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__3$", arg4: 5);
                context.SetSkip(arg1: "ready_07_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateReady_07(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_07 : TriggerState {
            internal StateReady_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__4$", arg4: 5);
                context.SetSkip(arg1: "ready_08_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateReady_08(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_08 : TriggerState {
            internal StateReady_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__5$", arg4: 5);
                context.SetSkip(arg1: "ready_09_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateReady_09(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_09 : TriggerState {
            internal StateReady_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__6$", arg4: 5);
                context.SetSkip(arg1: "ready_10_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateReady_10(context);
            }

            public override void OnExit() { }
        }

        private class StateReady_10 : TriggerState {
            internal StateReady_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Cut_BeyondLink_CCTV.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__7$", arg4: 3);
            }

            public override TriggerState Execute() {
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
                context.MoveUserPath(arg1: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {7005}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__8$", arg4: 5);
                context.SetSkip(arg1: "start_02_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_03(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__9$", arg4: 5);
                context.SetSkip(arg1: "start_03_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_04(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__10$", arg4: 4);
                context.SetSkip(arg1: "start_04_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_05(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7006, 7007}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__11$", arg4: 5);
                context.SetSkip(arg1: "start_05_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_06(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__12$", arg4: 4);
                context.SetSkip(arg1: "start_06_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_07(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__13$", arg4: 5);
                context.SetSkip(arg1: "start_07_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_08(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7008}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__14$", arg4: 5);
                context.SetSkip(arg1: "start_08_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_09(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__15$", arg4: 3);
                context.SetSkip(arg1: "start_09_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_10(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_10 : TriggerState {
            internal StateStart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__16$", arg4: 5);
                context.SetSkip(arg1: "start_10_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_11(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_11 : TriggerState {
            internal StateStart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__17$", arg4: 4);
                context.SetSkip(arg1: "start_11_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_12(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_12 : TriggerState {
            internal StateStart_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__18$", arg4: 3);
                context.SetSkip(arg1: "start_12_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_13(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_13 : TriggerState {
            internal StateStart_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__19$", arg4: 5);
                context.SetSkip(arg1: "start_13_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_14(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_14 : TriggerState {
            internal StateStart_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__20$", arg4: 5);
                context.SetSkip(arg1: "start_14_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_15(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_15 : TriggerState {
            internal StateStart_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__21$", arg4: 5);
                context.SetSkip(arg1: "start_15_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_16(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_16 : TriggerState {
            internal StateStart_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__22$", arg4: 5);
                context.SetSkip(arg1: "start_16_skip");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateStart_17(context);
            }

            public override void OnExit() { }
        }

        private class StateStart_17 : TriggerState {
            internal StateStart_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__23$", arg4: 3);
                context.SetSkip(arg1: "start_17_skip");
            }

            public override TriggerState Execute() {
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
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2005");
                context.CameraSelectPath(arg1: new[] {7009}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__24$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__25$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(arg1: new[] {103, 102, 101});
                    return new StateStart_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_20 : TriggerState {
            internal StateStart_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7010}, arg2: true);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetCinematicUI(arg1: 0);
                    context.CreateMonster(arg1: new[] {104, 111, 112}, arg2: true);
                    context.SetCinematicUI(arg1: 2);
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

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002635}, arg3: new byte[] {2})) {
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
                context.CreateMonster(arg1: new[] {104, 111, 112}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002635}, arg3: new byte[] {2})) {
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52000040_qd {
    public static class _main {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002635},
                    arg3: new byte[] {1})) {
                    context.HideGuideSummary(entityId: 20020020);
                    context.State = new Stateready_02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002635},
                    arg3: new byte[] {2})) {
                    context.State = new Statestart_22(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001445},
                    arg3: new byte[] {3})) {
                    context.State = new Stateend_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001445},
                    arg3: new byte[] {2})) {
                    context.State = new Statesb_ready_b_13(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001445},
                    arg3: new byte[] {1})) {
                    context.State = new Statesb_ready_b_12(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001444},
                    arg3: new byte[] {3})) {
                    context.State = new Statesb_ready_b_12(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001444},
                    arg3: new byte[] {2})) {
                    context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                    context.HideGuideSummary(entityId: 20020020);
                    context.State = new Statesb_ready_b_02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001443},
                    arg3: new byte[] {3})) {
                    context.AddBuff(arg1: new[] {701}, arg2: 70000096, arg3: 1);
                    context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                    context.HideGuideSummary(entityId: 20020020);
                    context.State = new Statesb_ready_04(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001442},
                    arg3: new byte[] {3})) {
                    context.State = new Statesb_ready_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001442},
                    arg3: new byte[] {2})) {
                    context.State = new Statesb_ready_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_01 : TriggerState {
            internal Statesb_ready_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {145}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001443},
                    arg3: new byte[] {2})) {
                    context.AddBuff(arg1: new[] {701}, arg2: 70000096, arg3: 1);
                    context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                    context.HideGuideSummary(entityId: 20020020);
                    context.State = new Statesb_ready_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_02 : TriggerState {
            internal Statesb_ready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Cut_BeyondLink_CCTV.swf", movieId: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new Statesb_ready_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_03 : TriggerState {
            internal Statesb_ready_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {144}, arg2: true);
                context.CreateMonster(arg1: new[] {145}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001443},
                    arg3: new byte[] {3})) {
                    context.State = new Statesb_ready_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_04 : TriggerState {
            internal Statesb_ready_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.ShowGuideSummary(entityId: 40010, textId: 40010);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201})) {
                    context.AddBuff(arg1: new[] {701}, arg2: 70000094, arg3: 1);
                    context.HideGuideSummary(entityId: 40010);
                    context.State = new Statesb_ready_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_05 : TriggerState {
            internal Statesb_ready_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statesb_ready_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_06 : TriggerState {
            internal Statesb_ready_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 5000f);
                context.AddBuff(arg1: new[] {701}, arg2: 70000095, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statesb_ready_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_07 : TriggerState {
            internal Statesb_ready_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.AddBuff(arg1: new[] {701}, arg2: 70000096, arg3: 1);
                    context.State = new Statesb_ready_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_08 : TriggerState {
            internal Statesb_ready_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000017, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_02 : TriggerState {
            internal Statesb_ready_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000040, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statesb_ready_b_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_03 : TriggerState {
            internal Statesb_ready_b_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {221, 222, 223}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {7001, 7002, 7003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new Statesb_ready_b_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_04 : TriggerState {
            internal Statesb_ready_b_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7100}, arg2: false);
                context.MoveNpc(arg1: 221, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 222, arg2: "MS2PatrolData_2102");
                context.MoveNpc(arg1: 223, arg2: "MS2PatrolData_2103");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statesb_ready_b_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_06 : TriggerState {
            internal Statesb_ready_b_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001726, arg3: "$52000040_QD__MAIN__26$", arg4: 4);
                context.SetSkip(arg1: "sb_ready_b_07_skip");
                context.SetNpcEmotionLoop(arg1: 221, arg2: "Talk_A", arg3: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statesb_ready_b_07_skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_07_skip : TriggerState {
            internal Statesb_ready_b_07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statesb_ready_b_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_07 : TriggerState {
            internal Statesb_ready_b_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001728, arg3: "$52000040_QD__MAIN__27$", arg4: 4);
                context.SetSkip(arg1: "sb_ready_b_08_skip");
                context.SetNpcEmotionLoop(arg1: 222, arg2: "Talk_A", arg3: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statesb_ready_b_08_skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_08_skip : TriggerState {
            internal Statesb_ready_b_08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statesb_ready_b_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_08 : TriggerState {
            internal Statesb_ready_b_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001726, arg3: "$52000040_QD__MAIN__28$", arg4: 4);
                context.SetSkip(arg1: "sb_ready_b_09_skip");
                context.SetNpcEmotionLoop(arg1: 221, arg2: "Talk_A", arg3: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statesb_ready_b_09_skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_09_skip : TriggerState {
            internal Statesb_ready_b_09_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statesb_ready_b_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_09 : TriggerState {
            internal Statesb_ready_b_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001724, arg3: "$52000040_QD__MAIN__29$", arg4: 4);
                context.SetSkip(arg1: "sb_ready_b_10_skip");
                context.SetNpcEmotionLoop(arg1: 223, arg2: "Talk_A", arg3: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statesb_ready_b_10_skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_10_skip : TriggerState {
            internal Statesb_ready_b_10_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statesb_ready_b_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_10 : TriggerState {
            internal Statesb_ready_b_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {145}, arg2: true);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.CameraSelectPath(arg1: new[] {7010}, arg2: true);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statesb_ready_b_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_11 : TriggerState {
            internal Statesb_ready_b_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_12 : TriggerState {
            internal Statesb_ready_b_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {145}, arg2: true);
                context.CreateMonster(arg1: new[] {221, 222, 223}, arg2: true);
                context.MoveNpc(arg1: 221, arg2: "MS2PatrolData_2101");
                context.MoveNpc(arg1: 222, arg2: "MS2PatrolData_2102");
                context.MoveNpc(arg1: 223, arg2: "MS2PatrolData_2103");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statesb_ready_b_13 : TriggerState {
            internal Statesb_ready_b_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {145}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statesb_end : TriggerState {
            internal Statesb_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Stateready_02 : TriggerState {
            internal Stateready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
                context.CreateMonster(arg1: new[] {101, 102}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {7001, 7002, 7003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateready_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_03 : TriggerState {
            internal Stateready_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__0$", arg4: 5);
                context.SetSkip(arg1: "ready_04_skip");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateready_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_04_skip : TriggerState {
            internal Stateready_04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateready_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_04 : TriggerState {
            internal Stateready_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__1$", arg4: 5);
                context.SetSkip(arg1: "ready_05_skip");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 5000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateready_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_05_skip : TriggerState {
            internal Stateready_05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateready_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_05 : TriggerState {
            internal Stateready_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__2$", arg4: 5);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 5000f);
                context.SetSkip(arg1: "ready_06_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateready_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_06_skip : TriggerState {
            internal Stateready_06_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateready_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_06 : TriggerState {
            internal Stateready_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__3$", arg4: 5);
                context.SetSkip(arg1: "ready_07_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateready_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_07_skip : TriggerState {
            internal Stateready_07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateready_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_07 : TriggerState {
            internal Stateready_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__4$", arg4: 5);
                context.SetSkip(arg1: "ready_08_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateready_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_08_skip : TriggerState {
            internal Stateready_08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateready_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_08 : TriggerState {
            internal Stateready_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__5$", arg4: 5);
                context.SetSkip(arg1: "ready_09_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateready_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_09_skip : TriggerState {
            internal Stateready_09_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateready_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_09 : TriggerState {
            internal Stateready_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__6$", arg4: 5);
                context.SetSkip(arg1: "ready_10_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Stateready_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_10_skip : TriggerState {
            internal Stateready_10_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Stateready_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_10 : TriggerState {
            internal Stateready_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Cut_BeyondLink_CCTV.swf", movieId: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new Statestart_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_01 : TriggerState {
            internal Statestart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__7$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_01_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_01_ready : TriggerState {
            internal Statestart_01_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7005}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__8$", arg4: 5);
                context.SetSkip(arg1: "start_02_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02_skip : TriggerState {
            internal Statestart_02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_03 : TriggerState {
            internal Statestart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__9$", arg4: 5);
                context.SetSkip(arg1: "start_03_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_03_skip : TriggerState {
            internal Statestart_03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_04 : TriggerState {
            internal Statestart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__10$", arg4: 4);
                context.SetSkip(arg1: "start_04_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_04_skip : TriggerState {
            internal Statestart_04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_05 : TriggerState {
            internal Statestart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7006, 7007}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__11$", arg4: 5);
                context.SetSkip(arg1: "start_05_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_05_skip : TriggerState {
            internal Statestart_05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_06 : TriggerState {
            internal Statestart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__12$", arg4: 4);
                context.SetSkip(arg1: "start_06_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_06_skip : TriggerState {
            internal Statestart_06_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_07 : TriggerState {
            internal Statestart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__13$", arg4: 5);
                context.SetSkip(arg1: "start_07_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_07_skip : TriggerState {
            internal Statestart_07_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_08 : TriggerState {
            internal Statestart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7008}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__14$", arg4: 5);
                context.SetSkip(arg1: "start_08_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_08_skip : TriggerState {
            internal Statestart_08_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_09 : TriggerState {
            internal Statestart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__15$", arg4: 3);
                context.SetSkip(arg1: "start_09_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_09_skip : TriggerState {
            internal Statestart_09_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_10 : TriggerState {
            internal Statestart_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000040_QD__MAIN__16$", arg4: 5);
                context.SetSkip(arg1: "start_10_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_10_skip : TriggerState {
            internal Statestart_10_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_11 : TriggerState {
            internal Statestart_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__17$", arg4: 4);
                context.SetSkip(arg1: "start_11_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statestart_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_11_skip : TriggerState {
            internal Statestart_11_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_12 : TriggerState {
            internal Statestart_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__18$", arg4: 3);
                context.SetSkip(arg1: "start_12_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_12_skip : TriggerState {
            internal Statestart_12_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_13 : TriggerState {
            internal Statestart_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__19$", arg4: 5);
                context.SetSkip(arg1: "start_13_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_13_skip : TriggerState {
            internal Statestart_13_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_14 : TriggerState {
            internal Statestart_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__20$", arg4: 5);
                context.SetSkip(arg1: "start_14_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_14_skip : TriggerState {
            internal Statestart_14_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_15 : TriggerState {
            internal Statestart_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__21$", arg4: 5);
                context.SetSkip(arg1: "start_15_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_15_skip : TriggerState {
            internal Statestart_15_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_16 : TriggerState {
            internal Statestart_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__22$", arg4: 5);
                context.SetSkip(arg1: "start_16_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_16_skip : TriggerState {
            internal Statestart_16_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new Statestart_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_17 : TriggerState {
            internal Statestart_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000040_QD__MAIN__23$", arg4: 3);
                context.SetSkip(arg1: "start_17_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_18 : TriggerState {
            internal Statestart_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2005");
                context.CameraSelectPath(arg1: new[] {7009}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__24$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_19 : TriggerState {
            internal Statestart_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001548, arg3: "$52000040_QD__MAIN__25$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.DestroyMonster(arg1: new[] {103, 102, 101});
                    context.State = new Statestart_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_20 : TriggerState {
            internal Statestart_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {7010}, arg2: true);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetProductionUI(arg1: 0);
                    context.CreateMonster(arg1: new[] {104, 111, 112}, arg2: true);
                    context.SetProductionUI(arg1: 2);
                    context.State = new Statestart_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_21 : TriggerState {
            internal Statestart_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20020020, textId: 20020020);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002635},
                    arg3: new byte[] {2})) {
                    context.HideGuideSummary(entityId: 20020020);
                    context.State = new Stateend_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_22 : TriggerState {
            internal Statestart_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {104, 111, 112}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002635},
                    arg3: new byte[] {2})) {
                    context.HideGuideSummary(entityId: 20020020);
                    context.State = new Stateend_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend_01 : TriggerState {
            internal Stateend_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
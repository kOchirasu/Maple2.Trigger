namespace Maple2.Trigger._52000097_qd {
    public static class _main {
        public class Statemain : TriggerState {
            internal Statemain(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000097, arg2: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CreateMonster(arg1: new[] {101, 102, 201}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003, 8004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003084, arg3: "$52000097_QD__MAIN__0$", arg4: 5);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8006}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003085, arg3: "$52000097_QD__MAIN__1$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003086, arg3: "$52000097_QD__MAIN__2$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003086, arg3: "$52000097_QD__MAIN__3$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8007}, arg2: false);
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000097_QD__MAIN__4$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000097_QD__MAIN__5$", arg4: 3, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8008}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11003086, arg3: "$52000097_QD__MAIN__6$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003086, arg3: "$52000097_QD__MAIN__7$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_09 : TriggerState {
            internal Statescene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000097_QD__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_10 : TriggerState {
            internal Statescene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003086, arg3: "$52000097_QD__MAIN__9$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statescene_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_11 : TriggerState {
            internal Statescene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Attack_01_E");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_12_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_12_ready : TriggerState {
            internal Statescene_12_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8009}, arg2: false);
                context.SetPcEmotionSequence(arg1: "Emotion_Failure_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_12 : TriggerState {
            internal Statescene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "ProphecyofFall.swf", movieId: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new Statescene_13(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }
        }

        private class Statescene_13 : TriggerState {
            internal Statescene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2001");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000097_QD__MAIN__10$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000097_QD__MAIN__11$", arg4: 2, arg5: 0);
                context.CameraSelectPath(arg1: new[] {8008}, arg2: false);
                context.SetPcEmotionSequence(arg1: "Emotion_Failure_Idle_A");
                context.SetConversation(arg1: 2, arg2: 11003086, arg3: "$52000097_QD__MAIN__12$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_14 : TriggerState {
            internal Statescene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8010}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000097_QD__MAIN__13$", arg4: 3, arg5: 1);
                context.MoveUserPath(arg1: "MS2PatrolData_2003");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_15 : TriggerState {
            internal Statescene_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000097_QD__MAIN__14$", arg4: 4, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000097_QD__MAIN__15$", arg4: 4, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000097_QD__MAIN__16$", arg4: 4, arg5: 8);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new Statescene_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_16 : TriggerState {
            internal Statescene_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003086, arg3: "$52000097_QD__MAIN__17$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_17 : TriggerState {
            internal Statescene_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003086, arg3: "$52000097_QD__MAIN__18$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_18 : TriggerState {
            internal Statescene_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003086, arg3: "$52000097_QD__MAIN__19$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_19 : TriggerState {
            internal Statescene_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_20 : TriggerState {
            internal Statescene_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8011}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2007");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_21 : TriggerState {
            internal Statescene_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.SetConversation(arg1: 2, arg2: 11003085, arg3: "$52000097_QD__MAIN__20$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_22 : TriggerState {
            internal Statescene_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003084, arg3: "$52000097_QD__MAIN__21$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_23 : TriggerState {
            internal Statescene_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2008");
                context.MoveUserPath(arg1: "MS2PatrolData_2009");
                context.SetConversation(arg1: 2, arg2: 11003084, arg3: "$52000097_QD__MAIN__22$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_24 : TriggerState {
            internal Statescene_24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003085, arg3: "$52000097_QD__MAIN__23$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_25 : TriggerState {
            internal Statescene_25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$52000097_QD__MAIN__24$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_26 : TriggerState {
            internal Statescene_26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000068, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
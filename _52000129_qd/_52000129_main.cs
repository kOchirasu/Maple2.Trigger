namespace Maple2.Trigger._52000129_qd {
    public static class _52000129_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104}, arg2: true);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002691}, arg3: new byte[] {1})) {
                    context.State = new State퀘스트진행_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002691}, arg3: new byte[] {2})) {
                    context.State = new State퀘스트완료가능_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002691}, arg3: new byte[] {3})) {
                    context.State = new State페이드아웃_01(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new State잠시대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시대기 : TriggerState {
            internal State잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라이동_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동_01 : TriggerState {
            internal State카메라이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State카메라이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동_02 : TriggerState {
            internal State카메라이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000129_QD__52000129_MAIN__0$", desc: "$52000129_QD__52000129_MAIN__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State카메라리셋_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라리셋_01 : TriggerState {
            internal State카메라리셋_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State계단타고이동_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단타고이동_01 : TriggerState {
            internal State계단타고이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityId: 25201291, textId: 25201291);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    context.State = new State퀘스트받기_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트받기_01 : TriggerState {
            internal State퀘스트받기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201291);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011}, arg2: false);
                context.ShowGuideSummary(entityId: 25201292, textId: 25201292);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002691}, arg3: new byte[] {1})) {
                    context.State = new State퀘스트진행_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트진행_01 : TriggerState {
            internal State퀘스트진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201291);
                context.HideGuideSummary(entityId: 25201292);
                context.ShowGuideSummary(entityId: 25201293, textId: 25201293);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002691}, arg3: new byte[] {2})) {
                    context.State = new State퀘스트완료가능_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트완료가능_01 : TriggerState {
            internal State퀘스트완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201291);
                context.HideGuideSummary(entityId: 25201292);
                context.HideGuideSummary(entityId: 25201293);
                context.ShowGuideSummary(entityId: 25201294, textId: 25201294);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002691}, arg3: new byte[] {3})) {
                    context.State = new State페이드아웃_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃_01 : TriggerState {
            internal State페이드아웃_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201291);
                context.HideGuideSummary(entityId: 25201292);
                context.HideGuideSummary(entityId: 25201293);
                context.HideGuideSummary(entityId: 25201294);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State페이드아웃_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃_02 : TriggerState {
            internal State페이드아웃_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000129, arg2: 99);
                context.CreateMonster(arg1: new[] {105}, arg2: true);
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State페이드인_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드인_01 : TriggerState {
            internal State페이드인_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMaskEff_fadein_1sec.xml");
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.SetSceneSkip(arg1: "마무리", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State감시_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State감시_01 : TriggerState {
            internal State감시_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000129_QD__52000129_MAIN__2$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State감시_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State감시_02 : TriggerState {
            internal State감시_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002, 8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State감시_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State감시_03 : TriggerState {
            internal State감시_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000129_QD__52000129_MAIN__3$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000130, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
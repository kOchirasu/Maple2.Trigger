namespace Maple2.Trigger._52000129_qd {
    public static class _52000129_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104}, arg2: true);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002691}, arg3: new byte[] {1})) {
                    return new StateQuest진행_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002691}, arg3: new byte[] {2})) {
                    return new StateQuest완료가능_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002691}, arg3: new byte[] {3})) {
                    return new StateFadeOut_01(context);
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCamera이동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_01 : TriggerState {
            internal StateCamera이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCamera이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_02 : TriggerState {
            internal StateCamera이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000129_QD__52000129_MAIN__0$", desc: "$52000129_QD__52000129_MAIN__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 4000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCamera리셋_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera리셋_01 : TriggerState {
            internal StateCamera리셋_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State계단타고이동_01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    return new StateQuest받기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest받기_01 : TriggerState {
            internal StateQuest받기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201291);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011}, arg2: false);
                context.ShowGuideSummary(entityId: 25201292, textId: 25201292);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002691}, arg3: new byte[] {1})) {
                    return new StateQuest진행_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest진행_01 : TriggerState {
            internal StateQuest진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201291);
                context.HideGuideSummary(entityId: 25201292);
                context.ShowGuideSummary(entityId: 25201293, textId: 25201293);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002691}, arg3: new byte[] {2})) {
                    return new StateQuest완료가능_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest완료가능_01 : TriggerState {
            internal StateQuest완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201291);
                context.HideGuideSummary(entityId: 25201292);
                context.HideGuideSummary(entityId: 25201293);
                context.ShowGuideSummary(entityId: 25201294, textId: 25201294);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002691}, arg3: new byte[] {3})) {
                    return new StateFadeOut_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut_01 : TriggerState {
            internal StateFadeOut_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25201291);
                context.HideGuideSummary(entityId: 25201292);
                context.HideGuideSummary(entityId: 25201293);
                context.HideGuideSummary(entityId: 25201294);
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFadeOut_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut_02 : TriggerState {
            internal StateFadeOut_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000129, arg2: 99);
                context.CreateMonster(arg1: new[] {105}, arg2: true);
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFadeIn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeIn_01 : TriggerState {
            internal StateFadeIn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMaskEff_fadein_1sec.xml");
                context.SetPcEmotionSequence(arg1: "Talk_A");
                context.SetSceneSkip(arg1: "마무리", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State감시_01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State감시_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감시_02 : TriggerState {
            internal State감시_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002, 8003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State감시_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감시_03 : TriggerState {
            internal State감시_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000129_QD__52000129_MAIN__3$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000130, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52010005_qd {
    public static class _act02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.SetInteractObject(arg1: new[] {10000872}, arg2: 0);
                    context.State = new State퀘스트조건02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트조건02 : TriggerState {
            internal State퀘스트조건02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {10002821}, arg3: new byte[] {2})) {
                    context.State = new StateQ2_미카등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카등장01 : TriggerState {
            internal StateQ2_미카등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateQ2_딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ2_딜레이01 : TriggerState {
            internal StateQ2_딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 2);
                context.CameraSelect(arg1: 3001, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new StateQ2_미카대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화01 : TriggerState {
            internal StateQ2_미카대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010005_QD__ACT02__0$", arg4: 3);
                context.SetSkip(arg1: "Q2_미카대화02대기");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new StateQ2_미카대화02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화02대기 : TriggerState {
            internal StateQ2_미카대화02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateQ2_미카대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화02 : TriggerState {
            internal StateQ2_미카대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 3);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010005_QD__ACT02__1$", arg4: 3);
                context.SetSkip(arg1: "Q2_미카대화종료");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "13")) {
                    context.State = new StateQ2_미카대화종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQ2_미카대화종료 : TriggerState {
            internal StateQ2_미카대화종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CameraSelect(arg1: 3001, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
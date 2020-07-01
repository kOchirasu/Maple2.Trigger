namespace Maple2.Trigger._52000003_qd {
    public static class _katvan_01 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {100}, arg2: new[] {50001743},
                    arg3: new byte[] {1})) {
                    context.State = new State카트반생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카트반생성 : TriggerState {
            internal State카트반생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출시작딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작딜레이 : TriggerState {
            internal State연출시작딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 101, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State대화시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화시작 : TriggerState {
            internal State대화시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000003_QD__KATVAN_01__0$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카트반대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카트반대사1 : TriggerState {
            internal State카트반대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001024, arg3: "$52000003_QD__KATVAN_01__1$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State카트반대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카트반대사2 : TriggerState {
            internal State카트반대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001024, arg3: "$52000003_QD__KATVAN_01__2$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State레논대사1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {102});
            }
        }

        private class State레논대사1 : TriggerState {
            internal State레논대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000064, arg3: "$52000003_QD__KATVAN_01__3$", arg4: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카메라원위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라원위치 : TriggerState {
            internal State카메라원위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카메라원위치_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라원위치_1 : TriggerState {
            internal State카메라원위치_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.CameraReset(interpolationTime: 0.5f);
                context.DestroyMonster(arg1: new[] {102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 100, arg2: "trigger", arg3: "Katvan");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
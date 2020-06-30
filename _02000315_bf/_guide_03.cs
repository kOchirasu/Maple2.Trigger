using System;

namespace Maple2.Trigger._02000315_bf {
    public static class _guide_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetUserValue(key: "CameraWalkEnd", value: 0);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "CameraWalkEnd", value: 1)) {
                    context.State = new StateLoadingDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay02 : TriggerState {
            internal StateLoadingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stBattleGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stBattleGuide : TriggerState {
            internal State1stBattleGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20031501, textID: 20031501, durationTime: 8000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "502")) {
                    context.State = new State1stBridgeGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stBridgeGuide : TriggerState {
            internal State1stBridgeGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20031502, textID: 20031502, durationTime: 5000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "503")) {
                    context.State = new State2ndBattleGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndBattleGuide : TriggerState {
            internal State2ndBattleGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20031501, textID: 20031501, durationTime: 8000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "505")) {
                    context.State = new State2ndBridgeGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndBridgeGuide : TriggerState {
            internal State2ndBridgeGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20031502, textID: 20031502, durationTime: 5000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "506")) {
                    context.State = new State3rdBattleGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdBattleGuide : TriggerState {
            internal State3rdBattleGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20031501, textID: 20031501, durationTime: 8000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "508")) {
                    context.State = new State3rdBridgeGuide(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdBridgeGuide : TriggerState {
            internal State3rdBridgeGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 20031502, textID: 20031502, durationTime: 5000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "402")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20031502);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
using System;

namespace Maple2.Trigger._52100052_qd {
    public static class _05_towall_false {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002085}, arg2: 0);
                context.SetUserValue(key: "ToWallFalse", value: 0);
                context.SetUserValue(key: "AnotherGuide", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "ToWallFalse", value: 1)) {
                    context.State = new StateToWallFalse(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateToWallFalse : TriggerState {
            internal StateToWallFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002085}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002085}, arg2: 0)) {
                    context.State = new StateNoticeDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNoticeDelay : TriggerState {
            internal StateNoticeDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 6, key: "AnotherGuide", value: 1);
                context.SetUserValue(triggerID: 7, key: "AnotherGuide", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNoticeOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNoticeOn : TriggerState {
            internal StateNoticeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20039603, textID: 20039603);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCloseGuide02(context);
                    return;
                }

                if (context.UserValue(key: "AnotherGuide", value: 1)) {
                    context.State = new StateCloseGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCloseGuide01 : TriggerState {
            internal StateCloseGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateCloseGuide02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCloseGuide02 : TriggerState {
            internal StateCloseGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20039603);
                context.SetUserValue(triggerID: 6, key: "AnotherGuide", value: 0);
                context.SetUserValue(triggerID: 7, key: "AnotherGuide", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
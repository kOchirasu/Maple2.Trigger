namespace Maple2.Trigger._02000396_bf {
    public static class _07_totower_false {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001136}, arg2: 0);
                context.SetUserValue(key: "ToTowerFalse", value: 0);
                context.SetUserValue(key: "AnotherGuide", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ToTowerFalse") == 1) {
                    return new StateToTowerFalse(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToTowerFalse : TriggerState {
            internal StateToTowerFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001136}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001136}, arg2: 0)) {
                    return new StateNoticeDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNoticeDelay : TriggerState {
            internal StateNoticeDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 5, key: "AnotherGuide", value: 1);
                context.SetUserValue(triggerId: 6, key: "AnotherGuide", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateNoticeOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNoticeOn : TriggerState {
            internal StateNoticeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039605, textId: 20039605);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCloseGuide02(context);
                }

                if (context.GetUserValue(key: "AnotherGuide") == 1) {
                    return new StateCloseGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCloseGuide01 : TriggerState {
            internal StateCloseGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateCloseGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCloseGuide02 : TriggerState {
            internal StateCloseGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20039605);
                context.SetUserValue(triggerId: 5, key: "AnotherGuide", value: 0);
                context.SetUserValue(triggerId: 6, key: "AnotherGuide", value: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
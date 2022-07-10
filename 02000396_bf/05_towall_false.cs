namespace Maple2.Trigger._02000396_bf {
    public static class _05_towall_false {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001134}, state: 0);
                context.SetUserValue(key: "ToWallFalse", value: 0);
                context.SetUserValue(key: "AnotherGuide", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ToWallFalse") == 1) {
                    return new StateToWallFalse(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateToWallFalse : TriggerState {
            internal StateToWallFalse(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001134}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001134}, arg2: 0)) {
                    return new StateNoticeDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNoticeDelay : TriggerState {
            internal StateNoticeDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 6, key: "AnotherGuide", value: 1);
                context.SetUserValue(triggerId: 7, key: "AnotherGuide", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039603, textId: 20039603);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.HideGuideSummary(entityId: 20039603);
                context.SetUserValue(triggerId: 6, key: "AnotherGuide", value: 0);
                context.SetUserValue(triggerId: 7, key: "AnotherGuide", value: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

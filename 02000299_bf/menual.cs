namespace Maple2.Trigger._02000299_bf {
    public static class _menual {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: false);
                context.SetInteractObject(interactIds: new []{10000490}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000490}, arg2: 0)) {
                    return new State안내시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내시작 : TriggerState {
            internal State안내시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.AddBuff(boxIds: new []{104}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 20003011, textId: 20003011, duration: 2500);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내01 : TriggerState {
            internal State안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.ShowGuideSummary(entityId: 20003012, textId: 20003012, duration: 3000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State안내02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내02 : TriggerState {
            internal State안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.CameraSelect(triggerId: 302, enabled: true);
                context.ShowGuideSummary(entityId: 20003013, textId: 20003013, duration: 3000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State안내03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내03 : TriggerState {
            internal State안내03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.CameraSelect(triggerId: 303, enabled: true);
                context.SetInteractObject(interactIds: new []{10000496, 10000497, 10000498, 10000499}, state: 1);
                context.ShowGuideSummary(entityId: 20003014, textId: 20003014, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State안내04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내04 : TriggerState {
            internal State안내04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{104}, skillId: 70000107, level: 1, arg4: false, arg5: false);
                context.SetInteractObject(interactIds: new []{10000496, 10000497, 10000498, 10000499}, state: 0);
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.CameraSelect(triggerId: 301, enabled: true);
                context.ShowGuideSummary(entityId: 20003015, textId: 20003015, duration: 4000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State안내05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내05 : TriggerState {
            internal State안내05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 104, skillId: 70000107);
                context.SetEffect(triggerIds: new []{604}, visible: true);
                context.CameraSelect(triggerId: 303, enabled: false);
                context.ShowGuideSummary(entityId: 20003016, textId: 20003016, duration: 2000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

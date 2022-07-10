namespace Maple2.Trigger._02010054_bf {
    public static class _guide_01 {
        public class State반응Wait : TriggerState {
            internal State반응Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000856}, arg2: 0)) {
                    return new StateGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide01 : TriggerState {
            internal StateGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105402, textId: 20105402);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.HideGuideSummary(entityId: 20105402);
                    return new State감지Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지Wait : TriggerState {
            internal State감지Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{108})) {
                    return new StateGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide02 : TriggerState {
            internal StateGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StateGuide02스킵(context));
                context.CameraSelect(triggerId: 302, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera이동02 : TriggerState {
            internal StateCamera이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 303, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.CameraSelect(triggerId: 303, enable: false);
                    return new StateGuide02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide02스킵 : TriggerState {
            internal StateGuide02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateGuide02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide02종료 : TriggerState {
            internal StateGuide02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 20105403, textId: 20105403);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000860, 10000861}, arg2: 0)) {
                    context.HideGuideSummary(entityId: 20105403);
                    return new StateGuide03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide03 : TriggerState {
            internal StateGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000858}, arg2: 0)) {
                    return new StateGuide03종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide03종료 : TriggerState {
            internal StateGuide03종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105405, textId: 20105405);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.HideGuideSummary(entityId: 20105405);
                    return new State반응Wait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait02 : TriggerState {
            internal State반응Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{109})) {
                    return new State반응Wait02종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응Wait02종료 : TriggerState {
            internal State반응Wait02종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105403, textId: 20105403);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.HideGuideSummary(entityId: 20105403);
                    return new StateGuide04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide04 : TriggerState {
            internal StateGuide04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000857}, arg2: 0)) {
                    return new StateGuide04종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide04종료 : TriggerState {
            internal StateGuide04종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20105402, textId: 20105402);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.HideGuideSummary(entityId: 20105402);
                    return new State감지Wait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State감지Wait02 : TriggerState {
            internal State감지Wait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{110})) {
                    context.SetEventUI(arg1: 1, script: "$02010054_BF__GUIdE_01__0$", duration: 5000, boxId: 0);
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
                return null;
            }

            public override void OnExit() { }
        }
    }
}

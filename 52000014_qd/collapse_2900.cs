namespace Maple2.Trigger._52000014_qd {
    public static class _collapse_2900 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{2900, 2901, 2902, 2903, 2904, 2905}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{12900, 22900, 12901, 22901, 12902, 22902}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new State로딩Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로딩Delay : TriggerState {
            internal State로딩Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State무너짐01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(timerId: "2", seconds: 2);
                context.SetEffect(triggerIds: new []{12900, 22900}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2900, 2901, 2902, 2903, 2904, 2905}, visible: false, meshCount: 6, arg4: 100, delay: 200);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateCameraCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic01 : TriggerState {
            internal StateCameraCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 2);
                context.CameraSelect(triggerId: 601, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateCameraCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic02 : TriggerState {
            internal StateCameraCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$52000014_QD__COLLAPSE_2900__0$");
                context.SetSkip(state: new StateCameraCinematic03(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateCameraCinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic03 : TriggerState {
            internal StateCameraCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 3);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 601, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State무너짐02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐02 : TriggerState {
            internal State무너짐02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52000014_QD__COLLAPSE_2900__1$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new State무너짐03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐03 : TriggerState {
            internal State무너짐03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 5);
                context.SetEffect(triggerIds: new []{12901, 22901}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State무너짐04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐04 : TriggerState {
            internal State무너짐04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State무너짐05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐05 : TriggerState {
            internal State무너짐05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9003})) {
                    return new State반응안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응안내01 : TriggerState {
            internal State반응안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 4);
                context.SetEffect(triggerIds: new []{12902, 22902}, visible: true);
                context.SetEventUI(arg1: 1, script: "$52000014_QD__COLLAPSE_2900__2$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "20")) {
                    return new State줍기안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State줍기안내01 : TriggerState {
            internal State줍기안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52000014_QD__COLLAPSE_2900__3$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001250}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001251}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001252}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001253}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001254}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001255}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001256}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001257}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001258}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001259}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001370}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001371}, questStates: new byte[]{2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001250}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001251}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001252}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001253}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001254}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001255}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001256}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001257}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001258}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001259}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001370}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9004}, questIds: new []{50001371}, questStates: new byte[]{3})) {
                    return new StatePortalCreation01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation01 : TriggerState {
            internal StatePortalCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12900, 22900, 12901, 22901, 12902, 22902}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

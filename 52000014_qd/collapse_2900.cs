namespace Maple2.Trigger._52000014_qd {
    public static class _collapse_2900 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {2900, 2901, 2902, 2903, 2904, 2905}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {12900, 22900, 12901, 22901, 12902, 22902}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new State로딩Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로딩Delay : TriggerState {
            internal State로딩Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
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
                context.SetTimer(id: "2", arg2: 2);
                context.SetEffect(arg1: new[] {12900, 22900}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2900, 2901, 2902, 2903, 2904, 2905}, arg2: false, arg3: 6, arg4: 100, arg5: 200);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateCameraCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic01 : TriggerState {
            internal StateCameraCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 2);
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateCameraCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic02 : TriggerState {
            internal StateCameraCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "4", arg2: 4);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$52000014_QD__COLLAPSE_2900__0$");
                context.SetSkip(state: new StateCameraCinematic03(context));
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateCameraCinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraCinematic03 : TriggerState {
            internal StateCameraCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 3);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 601, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State무너짐02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐02 : TriggerState {
            internal State무너짐02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52000014_QD__COLLAPSE_2900__1$", arg3: 4000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    return new State무너짐03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐03 : TriggerState {
            internal State무너짐03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 5);
                context.SetEffect(arg1: new[] {12901, 22901}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State무너짐04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐04 : TriggerState {
            internal State무너짐04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State무너짐05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐05 : TriggerState {
            internal State무너짐05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    return new State반응안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응안내01 : TriggerState {
            internal State반응안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "20", arg2: 4);
                context.SetEffect(arg1: new[] {12902, 22902}, arg2: true);
                context.SetEventUI(arg1: 1, script: "$52000014_QD__COLLAPSE_2900__2$", arg3: 4000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    return new State줍기안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State줍기안내01 : TriggerState {
            internal State줍기안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52000014_QD__COLLAPSE_2900__3$", arg3: 4000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001250}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001251}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001252}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001253}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001254}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001255}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001256}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001257}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001258}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001259}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001370}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001371}, arg3: new byte[] {2})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001250}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001251}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001252}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001253}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001254}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001255}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001256}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001257}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001258}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001259}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001370}, arg3: new byte[] {3})) {
                    return new StatePortalCreation01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9004}, arg2: new[] {50001371}, arg3: new byte[] {3})) {
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

            public override TriggerState Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12900, 22900, 12901, 22901, 12902, 22902}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
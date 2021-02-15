namespace Maple2.Trigger._52010067_qd {
    public static class _main {
        public class StateCinematic01 : TriggerState {
            internal StateCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    context.VisibleMyPc(isVisible: false);
                    context.SetCinematicUI(arg1: 1);
                    context.SetEffect(arg1: new[] {9010}, arg2: false);
                    return new StateCinematic브릿지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic브릿지 : TriggerState {
            internal StateCinematic브릿지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {700}, arg2: new[] {20002290}, arg3: new byte[] {2})) {
                    return new State조준씬01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {700}, arg2: new[] {20002290}, arg3: new byte[] {3})) {
                    return new State피격씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조준씬01 : TriggerState {
            internal State조준씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {200}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematic02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic02_b : TriggerState {
            internal StateCinematic02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    return new StateCinematic02_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic02_c : TriggerState {
            internal StateCinematic02_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2000, 2001, 2002, 2003, 2004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    return new StateCinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic03 : TriggerState {
            internal StateCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2005, 2006, 2007, 2008, 2009, 2010, 2011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    return new StateCinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic04 : TriggerState {
            internal StateCinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {2012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic05 : TriggerState {
            internal StateCinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422, arg2: 3);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State피격씬01 : TriggerState {
            internal State피격씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State피격씬01_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피격씬01_a : TriggerState {
            internal State피격씬01_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    return new State피격씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피격씬02 : TriggerState {
            internal State피격씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {9010}, arg2: true);
                context.CameraSelectPath(arg1: new[] {3004, 3005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State피격씬03_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피격씬03_a : TriggerState {
            internal State피격씬03_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3000, 3001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3900)) {
                    return new State피격씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피격씬03 : TriggerState {
            internal State피격씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3002, 3003}, arg2: false);
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.1f, duration: 3.5f, interpolator: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3600)) {
                    return new State피격씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State피격씬04 : TriggerState {
            internal State피격씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422, arg2: 3);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
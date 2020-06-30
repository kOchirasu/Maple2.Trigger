using System;

namespace Maple2.Trigger._52010067_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State연출01(context);

        private class State연출01 : TriggerState {
            internal State연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.VisibleMyPc(isVisible: false);
                    context.SetProductionUI(arg1: 1);
                    context.SetEffect(arg1: new int[] {9010}, arg2: false);
                    context.State = new State연출브릿지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출브릿지 : TriggerState {
            internal State연출브릿지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {700}, arg2: new int[] {20002290},
                    arg3: new byte[] {2})) {
                    context.State = new State조준씬01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {700}, arg2: new int[] {20002290},
                    arg3: new byte[] {3})) {
                    context.State = new State피격씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조준씬01 : TriggerState {
            internal State조준씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출02_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출02_b : TriggerState {
            internal State연출02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    context.State = new State연출02_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출02_c : TriggerState {
            internal State연출02_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000, 2001, 2002, 2003, 2004}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5300)) {
                    context.State = new State연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출03 : TriggerState {
            internal State연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2005, 2006, 2007, 2008, 2009, 2010, 2011}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3200)) {
                    context.State = new State연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출04 : TriggerState {
            internal State연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2012}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출05 : TriggerState {
            internal State연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statequit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequit : TriggerState {
            internal Statequit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State피격씬01 : TriggerState {
            internal State피격씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State피격씬01_a(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피격씬01_a : TriggerState {
            internal State피격씬01_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    context.State = new State피격씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피격씬02 : TriggerState {
            internal State피격씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {9010}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {3004, 3005}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State피격씬03_a(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피격씬03_a : TriggerState {
            internal State피격씬03_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {3000, 3001}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3900)) {
                    context.State = new State피격씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피격씬03 : TriggerState {
            internal State피격씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {3002, 3003}, arg2: 0);
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.1f, duration: 3.5f, interpolator: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3600)) {
                    context.State = new State피격씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피격씬04 : TriggerState {
            internal State피격씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statequit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequit02 : TriggerState {
            internal Statequit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422, arg2: 3);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
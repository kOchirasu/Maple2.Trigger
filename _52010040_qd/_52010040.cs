using System;

namespace Maple2.Trigger._52010040_qd {
    public static class _52010040 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000013},
                    arg3: new byte[] {2})) {
                    context.State = new State도입부연출01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {91000015},
                    arg3: new byte[] {3})) {
                    context.State = new State엔딩연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도입부연출01 : TriggerState {
            internal State도입부연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.CreateMonster(arg1: new int[] {300}, arg2: false);
                context.CreateMonster(arg1: new int[] {301}, arg2: false);
                context.CreateMonster(arg1: new int[] {302}, arg2: false);
                context.CreateMonster(arg1: new int[] {303}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State도입부연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도입부연출02 : TriggerState {
            internal State도입부연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52010040_QD__52010040__0$",
                    desc: "$52010040_QD__52010040__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 7000, scale: 2.5f);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {2000, 2001, 2002}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State도입부연출03_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도입부연출03_b : TriggerState {
            internal State도입부연출03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_blicheCome");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State도입부연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도입부연출03 : TriggerState {
            internal State도입부연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State도입부연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도입부연출04 : TriggerState {
            internal State도입부연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9002")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State엔딩연출01 : TriggerState {
            internal State엔딩연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엔딩연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출02 : TriggerState {
            internal State엔딩연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "quit", arg2: "nextState");
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcID: 11003536, illustID: "Neirin_normal", msg: "$52010040_QD__52010040__2$",
                    duration: 6200, align: "right");
                context.CameraSelectPath(arg1: new int[] {2012, 2013}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_blicheCome");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_bliche_front");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State엔딩연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출03 : TriggerState {
            internal State엔딩연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010040_QD__52010040__3$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State엔딩연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출04 : TriggerState {
            internal State엔딩연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010040_QD__52010040__4$",
                    duration: 5400, align: "right");
                context.CameraSelectPath(arg1: new int[] {2010, 2011, 2014}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State엔딩연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출05 : TriggerState {
            internal State엔딩연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010040_QD__52010040__5$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4100)) {
                    context.State = new State엔딩연출06_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출06_b : TriggerState {
            internal State엔딩연출06_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003533, illustID: "Bliche_normal", msg: "$52010040_QD__52010040__6$",
                    duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State엔딩연출06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출06 : TriggerState {
            internal State엔딩연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State엔딩연출07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엔딩연출07 : TriggerState {
            internal State엔딩연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
    }
}
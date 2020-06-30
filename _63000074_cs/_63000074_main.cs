using System;

namespace Maple2.Trigger._63000074_cs {
    public static class _63000074_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.SetMesh(arg1: new int[] {4001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000370},
                    arg3: new byte[] {2})) {
                    context.State = new Statemoveto63000072(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000370},
                    arg3: new byte[] {1})) {
                    context.State = new StateDiary_ready(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {30000370},
                    arg3: new byte[] {1})) {
                    context.State = new Statescene_fin(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDiary_ready : TriggerState {
            internal StateDiary_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateDiary_set(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDiary_set : TriggerState {
            internal StateDiary_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetMesh(arg1: new int[] {4001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 63000074, arg2: 10);
                context.CameraSelect(arg1: 8000, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateDiary_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDiary_start : TriggerState {
            internal StateDiary_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "sceneskip_1", arg2: "exit");
                context.SetProductionUI(arg1: 9, arg2: "$63000074_CS__63000074_MAIN__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateEvelyn_monologue_00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_00 : TriggerState {
            internal StateEvelyn_monologue_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateEvelyn_monologue_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_01 : TriggerState {
            internal StateEvelyn_monologue_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11004354, msg: "$63000074_CS__63000074_MAIN__1$", duration: 4000,
                    illustID: "Evelyn_normal", align: "center");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateEvelyn_monologue_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_02 : TriggerState {
            internal StateEvelyn_monologue_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004354, msg: "$63000074_CS__63000074_MAIN__2$", duration: 4000,
                    illustID: "Evelyn_sad", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateEvelyn_monologue_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_03 : TriggerState {
            internal StateEvelyn_monologue_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004354, msg: "$63000074_CS__63000074_MAIN__3$", duration: 5000,
                    illustID: "Evelyn_sad", align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEvelyn_monologue_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_04 : TriggerState {
            internal StateEvelyn_monologue_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8005}, arg2: 0);
                context.AddCinematicTalk(npcID: 11004354, msg: "$63000074_CS__63000074_MAIN__4$", duration: 3500);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new Statebobos_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebobos_ready : TriggerState {
            internal Statebobos_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statebobos_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebobos_01 : TriggerState {
            internal Statebobos_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$63000074_CS__63000074_MAIN__5$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statebobos_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebobos_02 : TriggerState {
            internal Statebobos_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$63000074_CS__63000074_MAIN__6$");
                context.SetMesh(arg1: new int[] {4001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Staterednose_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Staterednose_01 : TriggerState {
            internal Staterednose_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: 0);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Staterednose_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Staterednose_02 : TriggerState {
            internal Staterednose_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Staterednose_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesceneskip_1 : TriggerState {
            internal Statesceneskip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Staterednose_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Staterednose_03 : TriggerState {
            internal Staterednose_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "LonelyEvelyn");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statemoveto63000072(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemoveto63000072 : TriggerState {
            internal Statemoveto63000072(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000072, arg2: 11);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statemoveto63000072_2 : TriggerState {
            internal Statemoveto63000072_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000072, arg2: 11);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statescene_fin : TriggerState {
            internal Statescene_fin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._63000074_cs {
    public static class _63000074_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.SetMesh(arg1: new[] {4001, 4002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {30000370}, arg3: new byte[] {2})) {
                    return new Statemoveto63000072(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {30000370}, arg3: new byte[] {1})) {
                    return new StateDiary_ready(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {30000370}, arg3: new byte[] {1})) {
                    return new Statescene_fin(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDiary_set(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDiary_set : TriggerState {
            internal StateDiary_set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetMesh(arg1: new[] {4001, 4002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 63000074, arg2: 10);
                context.CameraSelect(arg1: 8000, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDiary_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDiary_start : TriggerState {
            internal StateDiary_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "sceneskip_1", arg2: "exit");
                context.SetProductionUI(arg1: 9, arg2: "$63000074_CS__63000074_MAIN__0$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateEvelyn_monologue_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_00 : TriggerState {
            internal StateEvelyn_monologue_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEvelyn_monologue_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_01 : TriggerState {
            internal StateEvelyn_monologue_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11004354, msg: "$63000074_CS__63000074_MAIN__1$", duration: 4000, illustId: "Evelyn_normal", align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEvelyn_monologue_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_02 : TriggerState {
            internal StateEvelyn_monologue_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CameraSelectPath(arg1: new[] {8000}, arg2: false);
                context.AddCinematicTalk(npcId: 11004354, msg: "$63000074_CS__63000074_MAIN__2$", duration: 4000, illustId: "Evelyn_sad", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEvelyn_monologue_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_03 : TriggerState {
            internal StateEvelyn_monologue_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.AddCinematicTalk(npcId: 11004354, msg: "$63000074_CS__63000074_MAIN__3$", duration: 5000, illustId: "Evelyn_sad", align: "right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvelyn_monologue_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvelyn_monologue_04 : TriggerState {
            internal StateEvelyn_monologue_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
                context.AddCinematicTalk(npcId: 11004354, msg: "$63000074_CS__63000074_MAIN__4$", duration: 3500);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new Statebobos_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statebobos_ready : TriggerState {
            internal Statebobos_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statebobos_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statebobos_01 : TriggerState {
            internal Statebobos_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$63000074_CS__63000074_MAIN__5$");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statebobos_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statebobos_02 : TriggerState {
            internal Statebobos_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$63000074_CS__63000074_MAIN__6$");
                context.SetMesh(arg1: new[] {4001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new Staterednose_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterednose_01 : TriggerState {
            internal Staterednose_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Staterednose_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterednose_02 : TriggerState {
            internal Staterednose_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new Staterednose_03(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Staterednose_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Staterednose_03 : TriggerState {
            internal Staterednose_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "LonelyEvelyn");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statemoveto63000072(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statemoveto63000072 : TriggerState {
            internal Statemoveto63000072(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000072, arg2: 11);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class Statemoveto63000072_2 : TriggerState {
            internal Statemoveto63000072_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000072, arg2: 11);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_fin : TriggerState {
            internal Statescene_fin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52000046_qd {
    public static class _main_01 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {60100220},
                    arg3: new byte[] {1})) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(arg1: "scene_10", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000046, arg2: 6001);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003215, msg: "$52000046_QD__MAIN_01__0$", duration: 3735,
                    align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003215, msg: "$52000046_QD__MAIN_01__1$", duration: 2000,
                    align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003215, msg: "$52000046_QD__MAIN_01__2$", duration: 2000,
                    align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003215, msg: "$52000046_QD__MAIN_01__3$", duration: 2000,
                    align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000046_QD__MAIN_01__4$", duration: 3000);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statescene_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_09 : TriggerState {
            internal Statescene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_10(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/Eff_jump_Landing.xml");
            }
        }

        private class Statescene_10 : TriggerState {
            internal Statescene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "lenonn");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewarp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp : TriggerState {
            internal Statewarp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000127, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
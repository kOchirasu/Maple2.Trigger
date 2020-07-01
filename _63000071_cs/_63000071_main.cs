using System;

namespace Maple2.Trigger._63000071_cs {
    public static class _63000071_main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestandby(context);

        private class Statestandby : TriggerState {
            internal Statestandby(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new Stateopeningscene_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopeningscene_start : TriggerState {
            internal Stateopeningscene_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: false);
                context.CameraSelectPath(arg1: new int[] {8000, 8001}, arg2: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetSceneSkip(arg1: "openingskip_1", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateopeningscene_1_1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }
        }

        private class Stateopeningscene_1_1 : TriggerState {
            internal Stateopeningscene_1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.AddBalloonTalk(spawnPointID: 101, msg: "$63000071_CS__63000071_MAIN__0$", duration: 2500,
                    delayTick: 1000);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Attack_01_A,Attack_01_B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new Stateopeningscene_1_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopeningscene_1_2 : TriggerState {
            internal Stateopeningscene_1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Attack_Idle_A", arg3: 3500f);
                context.AddBalloonTalk(spawnPointID: 101, msg: "$63000071_CS__63000071_MAIN__1$", duration: 2500,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new Stateopeningscene_1_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopeningscene_1_3 : TriggerState {
            internal Stateopeningscene_1_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Stun_A", arg3: 8000f);
                context.AddBalloonTalk(spawnPointID: 101, msg: "$63000071_CS__63000071_MAIN__2$", duration: 2500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 101, msg: "$63000071_CS__63000071_MAIN__3$", duration: 3500,
                    delayTick: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    context.State = new Stateopeningscene_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: false);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }
        }

        private class Stateopeningscene_2 : TriggerState {
            internal Stateopeningscene_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.AddBalloonTalk(spawnPointID: 102, msg: "$63000071_CS__63000071_MAIN__4$", duration: 2500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 102, msg: "$63000071_CS__63000071_MAIN__5$", duration: 2500,
                    delayTick: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new Stateopeningscene_3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_marien3");
            }
        }

        private class Stateopeningscene_3 : TriggerState {
            internal Stateopeningscene_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11004310, msg: "$63000071_CS__63000071_MAIN__6$", duration: 2500);
                context.AddCinematicTalk(npcID: 11004310, msg: "$63000071_CS__63000071_MAIN__7$", duration: 3000);
                context.AddCinematicTalk(npcID: 11004310, msg: "$63000071_CS__63000071_MAIN__8$", duration: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    context.State = new Stateopeningscene_end(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopeningscene_end : TriggerState {
            internal Stateopeningscene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateBossbattle_ready(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {101, 102});
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
            }
        }

        private class Stateopeningskip_1 : TriggerState {
            internal Stateopeningskip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.DestroyMonster(arg1: new int[] {101, 102});
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBossbattle_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossbattle_ready : TriggerState {
            internal StateBossbattle_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.VisibleMyPc(isVisible: true);
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBossbattle_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBossbattle_start : TriggerState {
            internal StateBossbattle_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201})) {
                    context.State = new Stateendingscene_start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {103, 104}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.SetEffect(arg1: new int[] {5005}, arg2: true);
                context.DestroyMonster(arg1: new int[] {201});
            }
        }

        private class Stateendingscene_start : TriggerState {
            internal Stateendingscene_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: false);
                context.CameraSelectPath(arg1: new int[] {8000, 8001}, arg2: false);
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "endingskip_1", arg2: "exit");
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
                context.SetEffect(arg1: new int[] {5005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Stateendingscene_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendingscene_1 : TriggerState {
            internal Stateendingscene_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.AddBalloonTalk(spawnPointID: 104, msg: "$63000071_CS__63000071_MAIN__9$", duration: 2500,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 103, msg: "$63000071_CS__63000071_MAIN__10$", duration: 2500,
                    delayTick: 4000);
                context.AddBalloonTalk(spawnPointID: 104, msg: "$63000071_CS__63000071_MAIN__11$", duration: 2500,
                    delayTick: 8000);
                context.AddBalloonTalk(spawnPointID: 103, msg: "$63000071_CS__63000071_MAIN__12$", duration: 2500,
                    delayTick: 11500);
                context.AddBalloonTalk(spawnPointID: 103, msg: "$63000071_CS__63000071_MAIN__13$", duration: 2500,
                    delayTick: 15000);
                context.AddBalloonTalk(spawnPointID: 104, msg: "$63000071_CS__63000071_MAIN__14$", duration: 2500,
                    delayTick: 19000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 22000)) {
                    context.State = new Stateendingscene_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_marien");
            }
        }

        private class Stateendingscene_2 : TriggerState {
            internal Stateendingscene_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: false);
                context.AddCinematicTalk(npcID: 11004310, msg: "$63000071_CS__63000071_MAIN__15$", duration: 6000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    context.State = new Stateendingscene_3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_marien1");
            }
        }

        private class Stateendingscene_3 : TriggerState {
            internal Stateendingscene_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateendingscene_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendingscene_4 : TriggerState {
            internal Stateendingscene_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 104, msg: "$63000071_CS__63000071_MAIN__16$", duration: 3000,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointID: 104, msg: "$63000071_CS__63000071_MAIN__17$", duration: 3000,
                    delayTick: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.State = new Stateendingscene_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendingscene_5 : TriggerState {
            internal Stateendingscene_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_papa");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_marien2");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9001, arg2: new int[] {0})) {
                    context.State = new Stateendingscene_end(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendingscene_end : TriggerState {
            internal Stateendingscene_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
                context.DestroyMonster(arg1: new int[] {104});
                context.SetEffect(arg1: new int[] {5006}, arg2: true);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statefinal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendingskip_1 : TriggerState {
            internal Stateendingskip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
                context.DestroyMonster(arg1: new int[] {104});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statefinal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefinal : TriggerState {
            internal Statefinal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.VisibleMyPc(isVisible: true);
                context.SetEffect(arg1: new int[] {5006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_fin(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_fin : TriggerState {
            internal Statescene_fin(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
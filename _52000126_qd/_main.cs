using System;

namespace Maple2.Trigger._52000126_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60100210},
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.MoveUser(arg1: 52000126, arg2: 6002);
                context.SetSceneSkip(arg1: "battle_ready", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statetalk_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statetalk_01 : TriggerState {
            internal Statetalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003209, msg: "$52000126_QD__MAIN__0$", duration: 2000, align: "Left");
                context.CreateMonster(arg1: new int[] {301}, arg2: true);
                context.CreateMonster(arg1: new int[] {302}, arg2: true);
                context.CreateMonster(arg1: new int[] {303}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statetalk_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statetalk_02 : TriggerState {
            internal Statetalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Bore_A");
                context.AddCinematicTalk(npcID: 11003209, msg: "$52000126_QD__MAIN__1$", duration: 2000, align: "Left");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3003");
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_3004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002, 4003}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003214, msg: "$52000126_QD__MAIN__2$", duration: 3000, align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Bore_A");
                context.AddCinematicTalk(npcID: 11003214, msg: "$52000126_QD__MAIN__3$", duration: 3000, align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003214, msg: "$52000126_QD__MAIN__4$", duration: 4000, align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005, 4006, 4007}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003214, msg: "$52000126_QD__MAIN__5$", duration: 3000, align: "Left");
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
                context.SetOnetimeEffect(id: 20, enable: true,
                    path: @"BG/Common/Sound/Eff_Object_Explosion_Debris_01.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008}, arg2: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_3005");
                context.SetNpcEmotionLoop(arg1: 302, arg2: "Attack_Idle_A", arg3: 7000f);
                context.SetNpcEmotionLoop(arg1: 303, arg2: "Attack_Idle_A", arg3: 7000f);
                context.AddCinematicTalk(npcID: 11003213, msg: "$52000126_QD__MAIN__6$", duration: 2000, align: "Left");
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
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Attack_01_A");
                context.AddCinematicTalk(npcID: 11003214, msg: "$52000126_QD__MAIN__7$", duration: 3000, align: "Left");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statebattle_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle_ready : TriggerState {
            internal Statebattle_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statebattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle : TriggerState {
            internal Statebattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {301, 302, 303});
                context.CreateMonster(arg1: new int[] {601, 602, 603}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatebattleMsg(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatebattleMsg : TriggerState {
            internal StatebattleMsg(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000126_QD__MAIN__8$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {601, 602, 603})) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "maskbattle");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52000037_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: false, arg3: "Dead_A");
                context.SetMesh(arg1: new[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Ending_Chord_01.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SetOnetimeEffect(id: 6, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60100125}, arg3: new byte[] {1})) {
                    return new Stateready(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60100125, 60100126, 60100127, 60100128, 60100129, 60100130, 60100131, 60100132, 60100133, 60100134, 60100135}, arg3: new byte[] {2})) {
                    return new Statenpcspawn_02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60100135}, arg3: new byte[] {3})) {
                    return new Statenpcspawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSound(arg1: 7001, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statewaitng(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewaitng : TriggerState {
            internal Statewaitng(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.MoveUser(arg1: 52000037, arg2: 1);
                context.CreateMonster(arg1: new[] {604, 602}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statestartscene(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statestartscene : TriggerState {
            internal Statestartscene(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4001, 4002, 4003, 4004, 4005, 4006, 4007}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_2101");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statescene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 602, arg2: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 11003202, illustId: "Jordy_normal", msg: "$52000037_QD__MAIN__0$", duration: 3000, align: "Right");
                context.SetSceneSkip(arg1: "fadeout", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 604, arg2: "MS2PatrolData_3004");
                context.AddCinematicTalk(npcId: 11003204, msg: "$52000037_QD__MAIN__1$", duration: 2000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statescene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003202, illustId: "Jordy_normal", msg: "$52000037_QD__MAIN__2$", duration: 4000, align: "Right");
                context.SetNpcEmotionSequence(arg1: 602, arg2: "Bore_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003204, msg: "$52000037_QD__MAIN__3$", duration: 2000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statescene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 602, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003202, illustId: "Jordy_normal", msg: "$52000037_QD__MAIN__4$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statescene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 604, arg2: "Bore_C");
                context.AddCinematicTalk(npcId: 11003204, msg: "$52000037_QD__MAIN__5$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statescene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 602, arg2: "Dead_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3735)) {
                    return new Statescene_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 602, arg2: "MS2PatrolData_3003");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statescene_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_09 : TriggerState {
            internal Statescene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statescene_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_10 : TriggerState {
            internal Statescene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statescene_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_11 : TriggerState {
            internal Statescene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statescene_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_12 : TriggerState {
            internal Statescene_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4008}, arg2: false);
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statescene_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_13 : TriggerState {
            internal Statescene_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.SetOnetimeEffect(id: 6, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statescene_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_14 : TriggerState {
            internal Statescene_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4010}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statescene_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_15 : TriggerState {
            internal Statescene_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 602, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003202, illustId: "Jordy_normal", msg: "$52000037_QD__MAIN__6$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statescene_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statescene_16 : TriggerState {
            internal Statescene_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 604, arg2: "Bore_C");
                context.AddCinematicTalk(npcId: 11003204, msg: "$52000037_QD__MAIN__7$", duration: 3000, align: "Right");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statefadeout(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadeout : TriggerState {
            internal Statefadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Stateendready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateendready : TriggerState {
            internal Stateendready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {602, 604});
                context.CreateMonster(arg1: new[] {601, 603}, arg2: true);
                context.CameraReset(interpolationTime: 0f);
                context.SetSound(arg1: 7001, arg2: false);
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "nelfmissing");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class Statenpcspawn_02 : TriggerState {
            internal Statenpcspawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {601, 602, 603, 604});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statenpcspawn_02_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statenpcspawn_02_A : TriggerState {
            internal Statenpcspawn_02_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {603, 601}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class Statenpcspawn_03 : TriggerState {
            internal Statenpcspawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {601, 602, 603, 604});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52000118_qd {
    public static class _main {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100015}, arg3: new byte[] {2})) {
                    return new Statefadeout(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100015}, arg3: new byte[] {3})) {
                    return new Statefadeout_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadeout : TriggerState {
            internal Statefadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetSceneSkip(arg1: "fadeout_a", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statefadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statesuspiciousmask(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statesuspiciousmask : TriggerState {
            internal Statesuspiciousmask(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001, 4002, 4003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__0$", duration: 3000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statedooropen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statedooropen : TriggerState {
            internal Statedooropen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.CreateMonster(arg1: new[] {102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new Statejordyspawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statejordyspawn : TriggerState {
            internal Statejordyspawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__1$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new Statejordyin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statejordyin : TriggerState {
            internal Statejordyin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__3$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new Statejordyhello(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statejordyhello : TriggerState {
            internal Statejordyhello(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__4$", duration: 1000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statehuk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statehuk : TriggerState {
            internal Statehuk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Sit_Down_A", arg3: 1000f);
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__5$", duration: 1000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statesuspiciousmaskmove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statesuspiciousmaskmove : TriggerState {
            internal Statesuspiciousmaskmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new Statetalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_01 : TriggerState {
            internal Statetalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Attack_Idle_A", arg3: 10000f);
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__6$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_02 : TriggerState {
            internal Statetalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__7$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__8$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new Statetalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_03 : TriggerState {
            internal Statetalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__9$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__10$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new Statetalk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_04 : TriggerState {
            internal Statetalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__11$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statekillyou(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statekillyou : TriggerState {
            internal Statekillyou(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__12$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_05 : TriggerState {
            internal Statetalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__13$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_06 : TriggerState {
            internal Statetalk_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__14$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statecamera_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera_01 : TriggerState {
            internal Statecamera_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statecamera_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statecamera_02 : TriggerState {
            internal Statecamera_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statetalk_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_07 : TriggerState {
            internal Statetalk_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__15$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statetalk_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_08 : TriggerState {
            internal Statetalk_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__16$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__17$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new Statetalk_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_09 : TriggerState {
            internal Statetalk_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__18$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_10 : TriggerState {
            internal Statetalk_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__19$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__20$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new Statetalk_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_11 : TriggerState {
            internal Statetalk_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__21$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statetalk_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statetalk_12 : TriggerState {
            internal Statetalk_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3005");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3003");
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000118_QD__MAIN__22$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__23$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new Statefadeout_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadeout_a : TriggerState {
            internal Statefadeout_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.VisibleMyPc(isVisible: true);
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {104}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new Statefadein_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statefadein_a : TriggerState {
            internal Statefadein_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
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
                context.SetEventUI(arg1: 1, arg2: "$52000118_QD__MAIN__24$", arg3: 3000, arg4: "0");
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
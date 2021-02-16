namespace Maple2.Trigger._52000118_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100015}, arg3: new byte[] {2})) {
                    return new StateFadeout(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60100015}, arg3: new byte[] {3})) {
                    return new StateFadeout_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout : TriggerState {
            internal StateFadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.VisibleMyPc(isVisible: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.SetSceneSkip(state: new StateFadeout_a(context), arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFadein(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein : TriggerState {
            internal StateFadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSuspiciousmask(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuspiciousmask : TriggerState {
            internal StateSuspiciousmask(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001, 4002, 4003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__0$", duration: 3000, align: "center");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDooropen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDooropen : TriggerState {
            internal StateDooropen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.CreateMonster(arg1: new[] {102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateJordyspawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordyspawn : TriggerState {
            internal StateJordyspawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__1$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateJordyin(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordyin : TriggerState {
            internal StateJordyin(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__3$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateJordyhello(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateJordyhello : TriggerState {
            internal StateJordyhello(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__4$", duration: 1000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateHuk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHuk : TriggerState {
            internal StateHuk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Sit_Down_A", arg3: 1000f);
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__5$", duration: 1000, align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSuspiciousmaskmove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSuspiciousmaskmove : TriggerState {
            internal StateSuspiciousmaskmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_01 : TriggerState {
            internal StateTalk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Attack_Idle_A", arg3: 10000f);
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__6$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_02 : TriggerState {
            internal StateTalk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__7$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__8$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_03 : TriggerState {
            internal StateTalk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__9$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__10$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalk_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_04 : TriggerState {
            internal StateTalk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__11$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKillyou(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKillyou : TriggerState {
            internal StateKillyou(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__12$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_05 : TriggerState {
            internal StateTalk_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__13$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_06 : TriggerState {
            internal StateTalk_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 7001, arg2: true);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__14$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCamera_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_01 : TriggerState {
            internal StateCamera_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCamera_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_02 : TriggerState {
            internal StateCamera_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTalk_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_07 : TriggerState {
            internal StateTalk_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__15$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTalk_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_08 : TriggerState {
            internal StateTalk_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__16$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__17$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTalk_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_09 : TriggerState {
            internal StateTalk_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__18$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_10 : TriggerState {
            internal StateTalk_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__19$", duration: 3000, illustId: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcId: 11003186, msg: "$52000118_QD__MAIN__20$", duration: 3000, illustId: "Jordy_normal", align: "Left");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateTalk_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_11 : TriggerState {
            internal StateTalk_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003167, msg: "$52000118_QD__MAIN__21$", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalk_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalk_12 : TriggerState {
            internal StateTalk_12(ITriggerContext context) : base(context) { }

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
                    return new StateFadeout_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeout_a : TriggerState {
            internal StateFadeout_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.VisibleMyPc(isVisible: true);
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {104}, arg2: true);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFadein_a(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadein_a : TriggerState {
            internal StateFadein_a(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52000118_QD__MAIN__24$", arg3: 3000, arg4: "0");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
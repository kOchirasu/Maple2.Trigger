namespace Maple2.Trigger._52000130_qd {
    public static class _52000130_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new State잠시대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시대기 : TriggerState {
            internal State잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePC이동_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC이동_01 : TriggerState {
            internal StatePC이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State카일과대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일과대화_01 : TriggerState {
            internal State카일과대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카일과대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일과대화_02 : TriggerState {
            internal State카일과대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "카일이동_01", arg2: "nextState");
                context.AddCinematicTalk(npcId: 11003371, msg: "$52000130_QD__52000130_MAIN__0$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State카일과대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일과대화_03 : TriggerState {
            internal State카일과대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카일과대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일과대화_04 : TriggerState {
            internal State카일과대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000130_QD__52000130_MAIN__1$", duration: 3500, align: "right");
                context.SetPcEmotionSequence(arg1: "Talk_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State카일과대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일과대화_05 : TriggerState {
            internal State카일과대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카일과대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일과대화_06 : TriggerState {
            internal State카일과대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003371, msg: "$52000130_QD__52000130_MAIN__2$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3300)) {
                    context.State = new State카일이동_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일이동_01 : TriggerState {
            internal State카일이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카일이동_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일이동_02 : TriggerState {
            internal State카일이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State카일공격_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일공격_01 : TriggerState {
            internal State카일공격_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State카일공격_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카일공격_02 : TriggerState {
            internal State카일공격_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Emotion_Failure_A", arg2: 30000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State습격후대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State습격후대화_01 : TriggerState {
            internal State습격후대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State습격후대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State습격후대화_02 : TriggerState {
            internal State습격후대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "씬스킵_01", arg2: "exit");
                context.AddCinematicTalk(npcId: 0, msg: "$52000130_QD__52000130_MAIN__3$", duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State습격후대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State습격후대화_03 : TriggerState {
            internal State습격후대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003371, msg: "$52000130_QD__52000130_MAIN__4$", duration: 3500, align: "right");
                context.AddCinematicTalk(npcId: 11003371, msg: "$52000130_QD__52000130_MAIN__5$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State습격후대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State습격후대화_04 : TriggerState {
            internal State습격후대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000130_QD__52000130_MAIN__6$", duration: 2500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State습격후대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State습격후대화_05 : TriggerState {
            internal State습격후대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003371, msg: "$52000130_QD__52000130_MAIN__7$", duration: 3500, align: "right");
                context.AddCinematicTalk(npcId: 11003371, msg: "$52000130_QD__52000130_MAIN__8$", duration: 3000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State습격후대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State습격후대화_06 : TriggerState {
            internal State습격후대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000130_QD__52000130_MAIN__9$", duration: 4000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State습격후대화_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State습격후대화_07 : TriggerState {
            internal State습격후대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcId: 11003371, msg: "$52000130_QD__52000130_MAIN__10$", duration: 3500, align: "right");
                context.AddCinematicTalk(npcId: 11003371, msg: "$52000130_QD__52000130_MAIN__11$", duration: 2500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    context.State = new State습격후대화_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State습격후대화_08 : TriggerState {
            internal State습격후대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000130_QD__52000130_MAIN__12$", duration: 2500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State페이드아웃_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃_01 : TriggerState {
            internal State페이드아웃_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State페이드아웃_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃_02 : TriggerState {
            internal State페이드아웃_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003371, msg: "$52000130_QD__52000130_MAIN__13$", duration: 5000, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씬스킵_01 : TriggerState {
            internal State씬스킵_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000131, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
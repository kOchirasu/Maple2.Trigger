using System;

namespace Maple2.Trigger._52000117_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateready(context);

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60100015},
                    arg3: new byte[] {1})) {
                    context.State = new Statefadeout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout : TriggerState {
            internal Statefadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statefadein(context);
                    return;
                }
            }

            public override void OnExit() {
                context.MoveUser(arg1: 52000117, arg2: 6001);
            }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statejordyidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statejordyidle : TriggerState {
            internal Statejordyidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__0$", duration: 3000,
                    illustID: "Jordy_normal", align: "Left");
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__1$", duration: 3000);
                context.SetSceneSkip(arg1: "end", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Statepcmove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statepcmove : TriggerState {
            internal Statepcmove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_3002");
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__2$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__3$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Statewow(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewow : TriggerState {
            internal Statewow(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Angry_A");
                context.AddCinematicTalk(npcID: 0, msg: "$52000117_QD__MAIN__15$", duration: 2000);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Sit_Down_A", arg3: 3000f);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Sit_Down_A", arg3: 3000f);
                context.AddBalloonTalk(spawnPointID: 101, msg: "$52000117_QD__MAIN__5$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 101, msg: "$52000117_QD__MAIN__6$", duration: 3000);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
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
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__7$", duration: 3000);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetPcEmotionLoop(arg1: "Emotion_Dance_S", arg2: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statepctalk(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statepctalk : TriggerState {
            internal Statepctalk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Talk_A,Talk_B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__8$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__9$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__10$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__11$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Statescene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__12$", duration: 3000);
                context.AddCinematicTalk(npcID: 11003166, msg: "$52000117_QD__MAIN__13$", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new Statescene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_fadeout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_fadeout : TriggerState {
            internal Statescene_fadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statejordydel(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statejordydel : TriggerState {
            internal Statejordydel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_fadein(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_fadein : TriggerState {
            internal Statescene_fadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CameraReset(interpolationTime: 0.5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "jordyhello");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateendmessage(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendmessage : TriggerState {
            internal Stateendmessage(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$52000117_QD__MAIN__14$", arg3: new int[] {3000}, arg4: "0");
                context.MoveUser(arg1: 52000118, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Stateendmessage(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
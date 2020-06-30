using System;

namespace Maple2.Trigger._52010032_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {202}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003090},
                    arg3: new byte[] {1})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: false);
                context.MoveUser(arg1: 52010032, arg2: 7001);
                context.CreateMonster(arg1: new int[] {201}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State치유의식_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State치유의식_01 : TriggerState {
            internal State치유의식_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003389, msg: "$52010032_QD__MAIN__0$", duration: 3000, illustID: "0",
                    align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State치유의식_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State치유의식_02 : TriggerState {
            internal State치유의식_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002, 4003}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_3001");
                context.MoveUserPath(arg1: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcID: 11003389, msg: "$52010032_QD__MAIN__1$", duration: 3000, illustID: "0",
                    align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State치유의식_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State치유의식_03 : TriggerState {
            internal State치유의식_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_B");
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetPcEmotionSequence(arg1: "Emotion_Cry_A");
                context.AddCinematicTalk(npcID: 11003389, msg: "$52010032_QD__MAIN__2$", duration: 3000, illustID: "0",
                    align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State치유의식_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State치유의식_04 : TriggerState {
            internal State치유의식_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State치유의식_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State치유의식_05 : TriggerState {
            internal State치유의식_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003390, msg: "$52010032_QD__MAIN__3$", duration: 3000, illustID: "0",
                    align: "Left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    // context.State = new State의식종료_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State의식종료01 : TriggerState {
            internal State의식종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // context.State = new State의식종료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State의식종료02 : TriggerState {
            internal State의식종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
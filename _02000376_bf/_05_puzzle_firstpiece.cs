using System;

namespace Maple2.Trigger._02000376_bf {
    public static class _05_puzzle_firstpiece {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PickFirstPiece", value: 0);
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3110, 3111, 3112, 3113, 3114, 3115, 3116, 3117, 3118, 3119},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "PickFirstPiece", value: 1)) {
                    context.State = new StateRandomPick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick : TriggerState {
            internal StateRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_Pick : TriggerState {
            internal StatePattern01_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptA01", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern01_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_Check : TriggerState {
            internal StatePattern01_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000565)) {
                    context.State = new StatePattern01_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000565)) {
                    context.State = new StatePattern01_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_CorrectAnswer : TriggerState {
            internal StatePattern01_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3110}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern01_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_WrongAnswer : TriggerState {
            internal StatePattern01_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern01_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_Reset01 : TriggerState {
            internal StatePattern01_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern01_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_Reset02 : TriggerState {
            internal StatePattern01_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3110}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern01_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_Pick : TriggerState {
            internal StatePattern02_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3101}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptA02", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern02_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_Check : TriggerState {
            internal StatePattern02_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000566)) {
                    context.State = new StatePattern02_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000566)) {
                    context.State = new StatePattern02_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_CorrectAnswer : TriggerState {
            internal StatePattern02_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3111}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern02_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_WrongAnswer : TriggerState {
            internal StatePattern02_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern02_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_Reset01 : TriggerState {
            internal StatePattern02_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern02_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_Reset02 : TriggerState {
            internal StatePattern02_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3111}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern02_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_Pick : TriggerState {
            internal StatePattern03_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3102}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptA03", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern03_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_Check : TriggerState {
            internal StatePattern03_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000567)) {
                    context.State = new StatePattern03_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000567)) {
                    context.State = new StatePattern03_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_CorrectAnswer : TriggerState {
            internal StatePattern03_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3112}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern03_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_WrongAnswer : TriggerState {
            internal StatePattern03_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern03_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_Reset01 : TriggerState {
            internal StatePattern03_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern03_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_Reset02 : TriggerState {
            internal StatePattern03_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3112}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern03_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_Pick : TriggerState {
            internal StatePattern04_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3103}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptB01", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern04_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_Check : TriggerState {
            internal StatePattern04_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000568)) {
                    context.State = new StatePattern04_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000568)) {
                    context.State = new StatePattern04_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_CorrectAnswer : TriggerState {
            internal StatePattern04_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3113}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern04_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_WrongAnswer : TriggerState {
            internal StatePattern04_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern04_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_Reset01 : TriggerState {
            internal StatePattern04_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern04_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_Reset02 : TriggerState {
            internal StatePattern04_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3113}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern04_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_Pick : TriggerState {
            internal StatePattern05_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3104}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptB02", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern05_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_Check : TriggerState {
            internal StatePattern05_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000569)) {
                    context.State = new StatePattern05_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000569)) {
                    context.State = new StatePattern05_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_CorrectAnswer : TriggerState {
            internal StatePattern05_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3114}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern05_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_WrongAnswer : TriggerState {
            internal StatePattern05_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern05_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_Reset01 : TriggerState {
            internal StatePattern05_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern05_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_Reset02 : TriggerState {
            internal StatePattern05_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3114}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern05_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_Pick : TriggerState {
            internal StatePattern06_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3105}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptC01", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern06_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_Check : TriggerState {
            internal StatePattern06_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000570)) {
                    context.State = new StatePattern06_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000570)) {
                    context.State = new StatePattern06_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_CorrectAnswer : TriggerState {
            internal StatePattern06_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3115}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern06_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_WrongAnswer : TriggerState {
            internal StatePattern06_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern06_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_Reset01 : TriggerState {
            internal StatePattern06_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern06_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_Reset02 : TriggerState {
            internal StatePattern06_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3115}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern06_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_Pick : TriggerState {
            internal StatePattern07_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3106}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptD01", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern07_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_Check : TriggerState {
            internal StatePattern07_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000571)) {
                    context.State = new StatePattern07_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000571)) {
                    context.State = new StatePattern07_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_CorrectAnswer : TriggerState {
            internal StatePattern07_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3116}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern07_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_WrongAnswer : TriggerState {
            internal StatePattern07_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern07_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_Reset01 : TriggerState {
            internal StatePattern07_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern07_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_Reset02 : TriggerState {
            internal StatePattern07_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3116}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern07_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_Pick : TriggerState {
            internal StatePattern08_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3107}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptD02", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern08_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_Check : TriggerState {
            internal StatePattern08_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000572)) {
                    context.State = new StatePattern08_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000572)) {
                    context.State = new StatePattern08_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_CorrectAnswer : TriggerState {
            internal StatePattern08_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3117}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern08_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_WrongAnswer : TriggerState {
            internal StatePattern08_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern08_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_Reset01 : TriggerState {
            internal StatePattern08_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern08_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_Reset02 : TriggerState {
            internal StatePattern08_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3117}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern08_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_Pick : TriggerState {
            internal StatePattern09_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3108}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptE01", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern09_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_Check : TriggerState {
            internal StatePattern09_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000573)) {
                    context.State = new StatePattern09_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000573)) {
                    context.State = new StatePattern09_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_CorrectAnswer : TriggerState {
            internal StatePattern09_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3118}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern09_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_WrongAnswer : TriggerState {
            internal StatePattern09_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern09_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_Reset01 : TriggerState {
            internal StatePattern09_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern09_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_Reset02 : TriggerState {
            internal StatePattern09_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3118}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern09_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_Pick : TriggerState {
            internal StatePattern10_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3109}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 6, key: "PickSecondPieceExceptE02", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern10_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_Check : TriggerState {
            internal StatePattern10_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000574)) {
                    context.State = new StatePattern10_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIDs: new int[] {2001}, itemID: 30000574)) {
                    context.State = new StatePattern10_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_CorrectAnswer : TriggerState {
            internal StatePattern10_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 1);
                context.SetMesh(arg1: new int[] {3119}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "ResetFirstPiece", value: 1)) {
                    context.State = new StatePattern10_Reset01(context);
                    return;
                }

                if (context.UserValue(key: "LockFirstPiece", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_WrongAnswer : TriggerState {
            internal StatePattern10_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 4, key: "CorrectFirstPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern10_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_Reset01 : TriggerState {
            internal StatePattern10_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "ResetFirstPiece", value: 0);
                context.SetUserValue(key: "LockFirstPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern10_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_Reset02 : TriggerState {
            internal StatePattern10_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3119}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserValue(key: "CheckFirstPiece", value: 1)) {
                    context.State = new StatePattern10_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
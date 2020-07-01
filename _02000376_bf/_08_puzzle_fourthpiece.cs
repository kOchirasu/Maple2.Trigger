namespace Maple2.Trigger._02000376_bf {
    public static class _08_puzzle_fourthpiece {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PickFourthPieceExceptA01", value: 0);
                context.SetUserValue(key: "PickFourthPieceExceptA02", value: 0);
                context.SetUserValue(key: "PickFourthPieceExceptA03", value: 0);
                context.SetUserValue(key: "PickFourthPieceExceptB01", value: 0);
                context.SetUserValue(key: "PickFourthPieceExceptB02", value: 0);
                context.SetUserValue(key: "PickFourthPieceExceptC01", value: 0);
                context.SetUserValue(key: "PickFourthPieceExceptD01", value: 0);
                context.SetUserValue(key: "PickFourthPieceExceptD02", value: 0);
                context.SetUserValue(key: "PickFourthPieceExceptE01", value: 0);
                context.SetUserValue(key: "PickFourthPieceExceptE02", value: 0);
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
                context.SetMesh(arg1: new[] {3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PickFourthPieceExceptA01") == 1) {
                    context.State = new StateRandomPick_ExceptA01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickFourthPieceExceptA02") == 1) {
                    context.State = new StateRandomPick_ExceptA02(context);
                    return;
                }

                if (context.GetUserValue(key: "PickFourthPieceExceptA03") == 1) {
                    context.State = new StateRandomPick_ExceptA03(context);
                    return;
                }

                if (context.GetUserValue(key: "PickFourthPieceExceptB01") == 1) {
                    context.State = new StateRandomPick_ExceptB01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickFourthPieceExceptB02") == 1) {
                    context.State = new StateRandomPick_ExceptB02(context);
                    return;
                }

                if (context.GetUserValue(key: "PickFourthPieceExceptC01") == 1) {
                    context.State = new StateRandomPick_ExceptC01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickFourthPieceExceptD01") == 1) {
                    context.State = new StateRandomPick_ExceptD01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickFourthPieceExceptD02") == 1) {
                    context.State = new StateRandomPick_ExceptD02(context);
                    return;
                }

                if (context.GetUserValue(key: "PickFourthPieceExceptE01") == 1) {
                    context.State = new StateRandomPick_ExceptE01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickFourthPieceExceptE02") == 1) {
                    context.State = new StateRandomPick_ExceptE02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptA01 : TriggerState {
            internal StateRandomPick_ExceptA01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
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

        private class StateRandomPick_ExceptA02 : TriggerState {
            internal StateRandomPick_ExceptA02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
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

        private class StateRandomPick_ExceptA03 : TriggerState {
            internal StateRandomPick_ExceptA03(ITriggerContext context) : base(context) { }

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

        private class StateRandomPick_ExceptB01 : TriggerState {
            internal StateRandomPick_ExceptB01(ITriggerContext context) : base(context) { }

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

        private class StateRandomPick_ExceptB02 : TriggerState {
            internal StateRandomPick_ExceptB02(ITriggerContext context) : base(context) { }

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

        private class StateRandomPick_ExceptC01 : TriggerState {
            internal StateRandomPick_ExceptC01(ITriggerContext context) : base(context) { }

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

        private class StateRandomPick_ExceptD01 : TriggerState {
            internal StateRandomPick_ExceptD01(ITriggerContext context) : base(context) { }

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

        private class StateRandomPick_ExceptD02 : TriggerState {
            internal StateRandomPick_ExceptD02(ITriggerContext context) : base(context) { }

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

        private class StateRandomPick_ExceptE01 : TriggerState {
            internal StateRandomPick_ExceptE01(ITriggerContext context) : base(context) { }

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
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptE02 : TriggerState {
            internal StateRandomPick_ExceptE02(ITriggerContext context) : base(context) { }

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
            }

            public override void OnExit() { }
        }

        private class StatePattern01_Pick : TriggerState {
            internal StatePattern01_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3400}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000565)) {
                    context.State = new StatePattern01_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000565)) {
                    context.State = new StatePattern01_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_CorrectAnswer : TriggerState {
            internal StatePattern01_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3410}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern01_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_WrongAnswer : TriggerState {
            internal StatePattern01_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3410}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
                    context.State = new StatePattern01_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_Pick : TriggerState {
            internal StatePattern02_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3401}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000566)) {
                    context.State = new StatePattern02_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000566)) {
                    context.State = new StatePattern02_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_CorrectAnswer : TriggerState {
            internal StatePattern02_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3411}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern02_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_WrongAnswer : TriggerState {
            internal StatePattern02_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3411}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
                    context.State = new StatePattern02_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_Pick : TriggerState {
            internal StatePattern03_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3402}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000567)) {
                    context.State = new StatePattern03_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000567)) {
                    context.State = new StatePattern03_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_CorrectAnswer : TriggerState {
            internal StatePattern03_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3412}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern03_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_WrongAnswer : TriggerState {
            internal StatePattern03_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3412}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
                    context.State = new StatePattern03_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_Pick : TriggerState {
            internal StatePattern04_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3403}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000568)) {
                    context.State = new StatePattern04_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000568)) {
                    context.State = new StatePattern04_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_CorrectAnswer : TriggerState {
            internal StatePattern04_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3413}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern04_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_WrongAnswer : TriggerState {
            internal StatePattern04_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3413}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
                    context.State = new StatePattern04_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_Pick : TriggerState {
            internal StatePattern05_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3404}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000569)) {
                    context.State = new StatePattern05_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000569)) {
                    context.State = new StatePattern05_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_CorrectAnswer : TriggerState {
            internal StatePattern05_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3414}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern05_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_WrongAnswer : TriggerState {
            internal StatePattern05_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3414}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
                    context.State = new StatePattern05_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_Pick : TriggerState {
            internal StatePattern06_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3405}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000570)) {
                    context.State = new StatePattern06_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000570)) {
                    context.State = new StatePattern06_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_CorrectAnswer : TriggerState {
            internal StatePattern06_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3415}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern06_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_WrongAnswer : TriggerState {
            internal StatePattern06_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3415}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
                    context.State = new StatePattern06_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_Pick : TriggerState {
            internal StatePattern07_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3406}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000571)) {
                    context.State = new StatePattern07_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000571)) {
                    context.State = new StatePattern07_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_CorrectAnswer : TriggerState {
            internal StatePattern07_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3416}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern07_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_WrongAnswer : TriggerState {
            internal StatePattern07_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3416}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
                    context.State = new StatePattern07_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_Pick : TriggerState {
            internal StatePattern08_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3407}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000572)) {
                    context.State = new StatePattern08_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000572)) {
                    context.State = new StatePattern08_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_CorrectAnswer : TriggerState {
            internal StatePattern08_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3417}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern08_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_WrongAnswer : TriggerState {
            internal StatePattern08_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3417}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
                    context.State = new StatePattern08_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_Pick : TriggerState {
            internal StatePattern09_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3408}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000573)) {
                    context.State = new StatePattern09_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000573)) {
                    context.State = new StatePattern09_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_CorrectAnswer : TriggerState {
            internal StatePattern09_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3418}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern09_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_WrongAnswer : TriggerState {
            internal StatePattern09_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3418}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
                    context.State = new StatePattern09_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_Pick : TriggerState {
            internal StatePattern10_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3409}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000574)) {
                    context.State = new StatePattern10_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2004}, itemId: 30000574)) {
                    context.State = new StatePattern10_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_CorrectAnswer : TriggerState {
            internal StatePattern10_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 1);
                context.SetMesh(arg1: new[] {3419}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetFourthPiece") == 1) {
                    context.State = new StatePattern10_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockFourthPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_WrongAnswer : TriggerState {
            internal StatePattern10_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectFourthPiece", value: 2);
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
                context.SetUserValue(key: "CheckFourthPiece", value: 0);
                context.SetUserValue(key: "CorrectFourthPiece", value: 0);
                context.SetUserValue(key: "ResetFourthPiece", value: 0);
                context.SetUserValue(key: "LockFourthPiece", value: 0);
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
                context.SetMesh(arg1: new[] {3419}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckFourthPiece") == 1) {
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
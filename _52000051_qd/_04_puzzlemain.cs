namespace Maple2.Trigger._52000051_qd {
    public static class _04_puzzlemain {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectThirdPiece", value: 0);
                context.SetUserValue(key: "CorrectFouthPiece", value: 0);
                context.SetEffect(arg1: new[] {5002, 5003}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001023}, arg2: 0);
                context.SetUserValue(key: "PuzzleStart", value: 0);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3001, 3002, 3003, 3004, 3020}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PuzzleStart") == 1) {
                    context.State = new StateStartPuzzle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartPuzzle : TriggerState {
            internal StateStartPuzzle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 5, key: "PickFirstPiece", value: 1);
                context.SetUserValue(triggerId: 7, key: "PickThirdPiece", value: 1);
                context.SetInteractObject(arg1: new[] {10001023}, arg2: 1);
                context.SetMesh(arg1: new[] {3020}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001023}, arg2: 0)) {
                    context.State = new StateCheckAnswer01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer01 : TriggerState {
            internal StateCheckAnswer01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3020}, arg2: false, arg3: 200, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 5, key: "CheckFirstPiece", value: 1);
                context.SetUserValue(triggerId: 6, key: "CheckSecondPiece", value: 1);
                context.SetUserValue(triggerId: 7, key: "CheckThirdPiece", value: 1);
                context.SetUserValue(triggerId: 8, key: "CheckFourthPiece", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateCheckAnswer02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer02 : TriggerState {
            internal StateCheckAnswer02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "CorrectFirstPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectFouthPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectFirstPiece") == 1) {
                    context.State = new StateCheckAnswer03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer03 : TriggerState {
            internal StateCheckAnswer03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "CorrectFirstPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectFouthPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 1) {
                    context.State = new StateCheckAnswer04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer04 : TriggerState {
            internal StateCheckAnswer04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "CorrectFirstPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectFourthPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 1) {
                    context.State = new StateCheckAnswer05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer05 : TriggerState {
            internal StateCheckAnswer05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "CorrectFirstPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectFourthPiece") == 2) {
                    context.State = new StateRetry01(context);
                    return;
                }

                if (context.GetUserValue(key: "CorrectFourthPiece") == 1) {
                    context.State = new StatePuzzleSolved(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRetry01 : TriggerState {
            internal StateRetry01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$52000051_QD__04_PUZZLEMAIN__0$", arg3: 3000, arg4: "0");
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectThirdPiece", value: 0);
                context.SetUserValue(key: "CorrectFouthPiece", value: 0);
                context.SetUserValue(triggerId: 5, key: "ResetFirstPiece", value: 1);
                context.SetUserValue(triggerId: 6, key: "ResetSecondPiece", value: 1);
                context.SetUserValue(triggerId: 7, key: "ResetThirdPiece", value: 1);
                context.SetUserValue(triggerId: 8, key: "ResetFourthPiece", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRetry02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRetry02 : TriggerState {
            internal StateRetry02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001023}, arg2: 1);
                context.SetMesh(arg1: new[] {3020}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001023}, arg2: 0)) {
                    context.State = new StateCheckAnswer01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10036010);
            }
        }

        private class StatePuzzleSolved : TriggerState {
            internal StatePuzzleSolved(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 1, key: "PuzzleSolved", value: 1);
                context.SetUserValue(triggerId: 5, key: "LockFirstPiece", value: 1);
                context.SetUserValue(triggerId: 6, key: "LockSecondPiece", value: 1);
                context.SetUserValue(triggerId: 7, key: "LockThirdPiece", value: 1);
                context.SetUserValue(triggerId: 8, key: "LockFourthPiece", value: 1);
                context.SetAchievement(arg1: 9001, arg2: "trigger", arg3: "OrientPattern_Puzzle");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
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
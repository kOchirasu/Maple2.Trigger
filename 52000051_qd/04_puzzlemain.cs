namespace Maple2.Trigger._52000051_qd {
    public static class _04_puzzlemain {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectThirdPiece", value: 0);
                context.SetUserValue(key: "CorrectFouthPiece", value: 0);
                context.SetEffect(triggerIds: new []{5002, 5003}, visible: false);
                context.SetInteractObject(interactIds: new []{10001023}, state: 0);
                context.SetUserValue(key: "PuzzleStart", value: 0);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3001, 3002, 3003, 3004, 3020}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PuzzleStart") == 1) {
                    return new StateStartPuzzle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartPuzzle : TriggerState {
            internal StateStartPuzzle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 5, key: "PickFirstPiece", value: 1);
                context.SetUserValue(triggerId: 7, key: "PickThirdPiece", value: 1);
                context.SetInteractObject(interactIds: new []{10001023}, state: 1);
                context.SetMesh(triggerIds: new []{3020}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001023}, arg2: 0)) {
                    return new StateCheckAnswer01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer01 : TriggerState {
            internal StateCheckAnswer01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3020}, visible: false, arg3: 200, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 5, key: "CheckFirstPiece", value: 1);
                context.SetUserValue(triggerId: 6, key: "CheckSecondPiece", value: 1);
                context.SetUserValue(triggerId: 7, key: "CheckThirdPiece", value: 1);
                context.SetUserValue(triggerId: 8, key: "CheckFourthPiece", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateCheckAnswer02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer02 : TriggerState {
            internal StateCheckAnswer02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CorrectFirstPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectFouthPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectFirstPiece") == 1) {
                    return new StateCheckAnswer03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer03 : TriggerState {
            internal StateCheckAnswer03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CorrectFirstPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectFouthPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 1) {
                    return new StateCheckAnswer04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer04 : TriggerState {
            internal StateCheckAnswer04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CorrectFirstPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectFourthPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 1) {
                    return new StateCheckAnswer05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckAnswer05 : TriggerState {
            internal StateCheckAnswer05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CorrectFirstPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectSecondPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectThirdPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectFourthPiece") == 2) {
                    return new StateRetry01(context);
                }

                if (context.GetUserValue(key: "CorrectFourthPiece") == 1) {
                    return new StatePuzzleSolved(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRetry01 : TriggerState {
            internal StateRetry01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetEventUI(arg1: 1, script: "$52000051_QD__04_PUZZLEMAIN__0$", duration: 3000, boxId: 0);
                context.SetUserValue(key: "CorrectFirstPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectThirdPiece", value: 0);
                context.SetUserValue(key: "CorrectFouthPiece", value: 0);
                context.SetUserValue(triggerId: 5, key: "ResetFirstPiece", value: 1);
                context.SetUserValue(triggerId: 6, key: "ResetSecondPiece", value: 1);
                context.SetUserValue(triggerId: 7, key: "ResetThirdPiece", value: 1);
                context.SetUserValue(triggerId: 8, key: "ResetFourthPiece", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRetry02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRetry02 : TriggerState {
            internal StateRetry02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001023}, state: 1);
                context.SetMesh(triggerIds: new []{3020}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001023}, arg2: 0)) {
                    return new StateCheckAnswer01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10036010);
            }
        }

        private class StatePuzzleSolved : TriggerState {
            internal StatePuzzleSolved(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 1, key: "PuzzleSolved", value: 1);
                context.SetUserValue(triggerId: 5, key: "LockFirstPiece", value: 1);
                context.SetUserValue(triggerId: 6, key: "LockSecondPiece", value: 1);
                context.SetUserValue(triggerId: 7, key: "LockThirdPiece", value: 1);
                context.SetUserValue(triggerId: 8, key: "LockFourthPiece", value: 1);
                context.SetAchievement(triggerId: 9001, type: "trigger", code: "OrientPattern_Puzzle");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

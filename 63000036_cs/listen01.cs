namespace Maple2.Trigger._63000036_cs {
    public static class _listen01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001, 5002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000455}, arg3: new byte[] {1})) {
                    return new StateCameraWalk01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000455}, arg3: new byte[] {2})) {
                    return new StateCameraWalk01(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCTeleport02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk01 : TriggerState {
            internal StateCameraWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
                context.CameraSelect(arg1: 500, arg2: true);
                context.SetSceneSkip(arg1: "DialogueSkip03", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraWalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk02 : TriggerState {
            internal StateCameraWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraWalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraWalk03 : TriggerState {
            internal StateCameraWalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDialogue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001701, arg3: "$63000036_CS__LISTEN01__0$", arg4: 12);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateDialogueSkip01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip01 : TriggerState {
            internal StateDialogueSkip01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateDialogue02(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000036_CS__LISTEN01__1$", arg4: 11);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateDialogueSkip02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip02 : TriggerState {
            internal StateDialogueSkip02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StateDialogue03(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue03 : TriggerState {
            internal StateDialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000036_CS__LISTEN01__2$", arg4: 9);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateDialogueSkip03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip03 : TriggerState {
            internal StateDialogueSkip03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                return new StatePCTeleport01(context);
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport01 : TriggerState {
            internal StatePCTeleport01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCTeleport02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport02 : TriggerState {
            internal StatePCTeleport02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000062, arg2: 13);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
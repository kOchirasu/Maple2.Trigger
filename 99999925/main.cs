namespace Maple2.Trigger._99999925 {
    public static class _main {
        public class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 211, 101, 221, 222, 223, 224, 225, 226, 227, 228, 230, 231, 232, 233}, arg2: false);
                context.SetMesh(arg1: new[] {301}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 230, arg2: "MS2PatrolData0");
                context.MoveNpc(arg1: 231, arg2: "MS2PatrolData1");
                context.MoveNpc(arg1: 232, arg2: "MS2PatrolData11");
                context.MoveNpc(arg1: 233, arg2: "MS2PatrolData2");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData22");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData3");
                context.MoveNpc(arg1: 208, arg2: "MS2PatrolData4");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData5");
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 402) == 1) {
                    return new StateLoadingStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingStart : TriggerState {
            internal StateLoadingStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDialogue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 1, arg3: "$99999925__MAIN__0$", arg4: 3);
                context.SetAiExtraData(key: "BuffStart", value: 1, isModify: true);
                context.SetSkip(state: new StateDialogue01Skip(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDialogue01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue01Skip : TriggerState {
            internal StateDialogue01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraSelect(arg1: 500, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSwitchRandom(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }
        }

        private class StateSwitchRandom : TriggerState {
            internal StateSwitchRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    return new StateSwitch01(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateSwitch02(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new StateSwitch03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwitch01 : TriggerState {
            internal StateSwitch01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {403})) {
                    return new StateBrokenCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwitch02 : TriggerState {
            internal StateSwitch02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {404})) {
                    return new StateBrokenCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwitch03 : TriggerState {
            internal StateSwitch03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {405})) {
                    return new StateBrokenCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBrokenCheck : TriggerState {
            internal StateBrokenCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "BuffStart", value: 2, isModify: true);
                context.SetActor(arg1: 601, arg2: true, arg3: "Opened");
                context.SetActor(arg1: 602, arg2: true, arg3: "Opened");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {401})) {
                    return new StateBrokenWood(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBrokenWood : TriggerState {
            internal StateBrokenWood(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {411, 412}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    // return new StateEndPlay(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
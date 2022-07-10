namespace Maple2.Trigger._99999925 {
    public static class _main {
        public class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 206, 207, 211, 101, 221, 222, 223, 224, 225, 226, 227, 228, 230, 231, 232, 233}, arg2: false);
                context.SetMesh(triggerIds: new []{301}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 230, patrolName: "MS2PatrolData0");
                context.MoveNpc(spawnId: 231, patrolName: "MS2PatrolData1");
                context.MoveNpc(spawnId: 232, patrolName: "MS2PatrolData11");
                context.MoveNpc(spawnId: 233, patrolName: "MS2PatrolData2");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData22");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData3");
                context.MoveNpc(spawnId: 208, patrolName: "MS2PatrolData4");
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData5");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 1, script: "$99999925__MAIN__0$", arg4: 3);
                context.SetAiExtraData(key: "BuffStart", value: 1, isModify: true);
                context.SetSkip(state: new StateDialogue01Skip(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 500, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSwitchRandom(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateSwitchRandom : TriggerState {
            internal StateSwitchRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 33f)) {
                    return new StateSwitch01(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    return new StateSwitch02(context);
                }

                if (context.RandomCondition(rate: 33f)) {
                    return new StateSwitch03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwitch01 : TriggerState {
            internal StateSwitch01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{403})) {
                    return new StateBrokenCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwitch02 : TriggerState {
            internal StateSwitch02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{404})) {
                    return new StateBrokenCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSwitch03 : TriggerState {
            internal StateSwitch03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{405})) {
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
                context.SetActor(triggerId: 601, visible: true, initialSequence: "Opened");
                context.SetActor(triggerId: 602, visible: true, initialSequence: "Opened");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{401})) {
                    return new StateBrokenWood(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBrokenWood : TriggerState {
            internal StateBrokenWood(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{411, 412}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    // return new StateEndPlay(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

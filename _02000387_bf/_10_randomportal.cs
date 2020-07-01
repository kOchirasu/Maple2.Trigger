namespace Maple2.Trigger._02000387_bf {
    public static class _10_randomportal {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2011, 2012, 2013, 2014}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004}, arg2: false);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 14, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 22, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 23, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 24, arg2: false, arg3: false, arg4: false);
                context.SetActor(arg1: 4101, arg2: true, arg3: "ry_functobj_door_B01_off");
                context.SetActor(arg1: 4102, arg2: true, arg3: "ry_functobj_door_B01_off");
                context.SetActor(arg1: 4103, arg2: true, arg3: "ry_functobj_door_B01_off");
                context.SetActor(arg1: 4104, arg2: true, arg3: "ry_functobj_door_B01_off");
                context.SetUserValue(key: "RandomPortalOn", value: 0);
                context.SetUserValue(key: "CounterDoorPick", value: 0);
                context.SetUserValue(key: "DungeonClear", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RandomPortalOn") == 1) {
                    return new StateGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide01 : TriggerState {
            internal StateGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000387_BF__10_RANDOMPORTAL__0$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCheckMember01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckMember01 : TriggerState {
            internal StateCheckMember01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) == 1) {
                    return new StateCheckMember02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckMember02 : TriggerState {
            internal StateCheckMember02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) != 1) {
                    return new StateCheckMember01(context);
                }

                if (context.GetUserCount(boxId: 9002) == 1) {
                    return new StateCheckMember03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckMember03 : TriggerState {
            internal StateCheckMember03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) != 1) {
                    return new StateCheckMember01(context);
                }

                if (context.GetUserCount(boxId: 9002) != 1) {
                    return new StateCheckMember01(context);
                }

                if (context.GetUserCount(boxId: 9003) == 1) {
                    return new StateCheckMember04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckMember04 : TriggerState {
            internal StateCheckMember04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9001) != 1) {
                    return new StateCheckMember01(context);
                }

                if (context.GetUserCount(boxId: 9002) != 1) {
                    return new StateCheckMember01(context);
                }

                if (context.GetUserCount(boxId: 9003) != 1) {
                    return new StateCheckMember01(context);
                }

                if (context.GetUserCount(boxId: 9004) == 1) {
                    return new StateDoorActivate01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoorActivate01 : TriggerState {
            internal StateDoorActivate01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDoorActivate02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDoorActivate02 : TriggerState {
            internal StateDoorActivate02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4101, arg2: true, arg3: "ry_functobj_door_B01_on");
                context.SetActor(arg1: 4102, arg2: true, arg3: "ry_functobj_door_B01_on");
                context.SetActor(arg1: 4103, arg2: true, arg3: "ry_functobj_door_B01_on");
                context.SetActor(arg1: 4104, arg2: true, arg3: "ry_functobj_door_B01_on");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePickPortalPattern(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickPortalPattern : TriggerState {
            internal StatePickPortalPattern(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new State1stDoorPick(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State2ndDoorPick(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State3rdDoorPick(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State4rdDoorPick(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stDoorPick : TriggerState {
            internal State1stDoorPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 11, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 22, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 23, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 24, arg2: false, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGameStart00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndDoorPick : TriggerState {
            internal State2ndDoorPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 12, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 23, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 24, arg2: false, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGameStart00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdDoorPick : TriggerState {
            internal State3rdDoorPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 13, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 22, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 24, arg2: false, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGameStart00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4rdDoorPick : TriggerState {
            internal State4rdDoorPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 14, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 22, arg2: false, arg3: true, arg4: false);
                context.SetPortal(arg1: 23, arg2: false, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGameStart00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameStart00 : TriggerState {
            internal StateGameStart00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9800) == 4) {
                    return new StateGameStart01(context);
                }

                if (context.GetUserCount(boxId: 9800) < 4) {
                    return new StateGameStartDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameStartDelay01 : TriggerState {
            internal StateGameStartDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateGameStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameStart01 : TriggerState {
            internal StateGameStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 13, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 14, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 22, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 23, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 24, arg2: false, arg3: false, arg4: false);
                context.SetActor(arg1: 4101, arg2: true, arg3: "ry_functobj_door_B01_off");
                context.SetActor(arg1: 4102, arg2: true, arg3: "ry_functobj_door_B01_off");
                context.SetActor(arg1: 4103, arg2: true, arg3: "ry_functobj_door_B01_off");
                context.SetActor(arg1: 4104, arg2: true, arg3: "ry_functobj_door_B01_off");
                context.SetEffect(arg1: new[] {5001, 5002, 5003, 5004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9005) == 1) {
                    return new StateGameStart02(context);
                }

                if (context.GetUserCount(boxId: 9900) < 4) {
                    return new StateEndGame01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameStart02 : TriggerState {
            internal StateGameStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9006) == 3) {
                    return new State10secondsWait(context);
                }

                if (context.GetUserCount(boxId: 9900) < 4) {
                    return new StateEndGame01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10secondsWait : TriggerState {
            internal State10secondsWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    return new StateQuit(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCheckMemeberAgain(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckMemeberAgain : TriggerState {
            internal StateCheckMemeberAgain(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 9900) == 4) {
                    return new State10secondsWait(context);
                }

                if (context.GetUserCount(boxId: 9900) < 4) {
                    return new StateEndGame01(context);
                }

                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndGame01 : TriggerState {
            internal StateEndGame01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000387_BF__10_RANDOMPORTAL__1$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePCMoveOut01(context);
                }

                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCMoveOut01 : TriggerState {
            internal StatePCMoveOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000387, arg2: 1, arg3: 9900);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFieredNotice01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFieredNotice01 : TriggerState {
            internal StateFieredNotice01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000491, arg3: "$02000387_BF__10_RANDOMPORTAL__2$", arg4: 4);
                context.SetSkip(arg1: "FieredNotice01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFieredNotice01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFieredNotice01Skip : TriggerState {
            internal StateFieredNotice01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateFieredNotice02(context);
            }

            public override void OnExit() { }
        }

        private class StateFieredNotice02 : TriggerState {
            internal StateFieredNotice02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000491, arg3: "$02000387_BF__10_RANDOMPORTAL__3$", arg4: 4);
                context.SetSkip(arg1: "FieredNotice02Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFieredNotice02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFieredNotice02Skip : TriggerState {
            internal StateFieredNotice02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCForceToLeave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCForceToLeave : TriggerState {
            internal StatePCForceToLeave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {100});
            }
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
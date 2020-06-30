using System;

namespace Maple2.Trigger._02000387_bf {
    public static class _10_randomportal {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {2011, 2012, 2013, 2014}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
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

            public override void Execute() {
                if (context.UserValue(key: "RandomPortalOn", value: 1)) {
                    context.State = new StateGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuide01 : TriggerState {
            internal StateGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000387_BF__10_RANDOMPORTAL__0$", arg3: new int[] {3000},
                    arg4: "0");
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5003}, arg2: true);
                context.SetEffect(arg1: new int[] {5004}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCheckMember01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckMember01 : TriggerState {
            internal StateCheckMember01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9001, arg2: 1, arg3: "Equal")) {
                    context.State = new StateCheckMember02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckMember02 : TriggerState {
            internal StateCheckMember02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9001, arg2: 1, arg3: "Equal")) {
                    context.State = new StateCheckMember01(context);
                    return;
                }

                if (context.CountUsers(arg1: 9002, arg2: 1, arg3: "Equal")) {
                    context.State = new StateCheckMember03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckMember03 : TriggerState {
            internal StateCheckMember03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9001, arg2: 1, arg3: "Equal")) {
                    context.State = new StateCheckMember01(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9002, arg2: 1, arg3: "Equal")) {
                    context.State = new StateCheckMember01(context);
                    return;
                }

                if (context.CountUsers(arg1: 9003, arg2: 1, arg3: "Equal")) {
                    context.State = new StateCheckMember04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckMember04 : TriggerState {
            internal StateCheckMember04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.CountUsers(arg1: 9001, arg2: 1, arg3: "Equal")) {
                    context.State = new StateCheckMember01(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9002, arg2: 1, arg3: "Equal")) {
                    context.State = new StateCheckMember01(context);
                    return;
                }

                if (!context.CountUsers(arg1: 9003, arg2: 1, arg3: "Equal")) {
                    context.State = new StateCheckMember01(context);
                    return;
                }

                if (context.CountUsers(arg1: 9004, arg2: 1, arg3: "Equal")) {
                    context.State = new StateDoorActivate01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDoorActivate01 : TriggerState {
            internal StateDoorActivate01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateDoorActivate02(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePickPortalPattern(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickPortalPattern : TriggerState {
            internal StatePickPortalPattern(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State1stDoorPick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State2ndDoorPick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State3rdDoorPick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State4rdDoorPick(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGameStart00(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGameStart00(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGameStart00(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGameStart00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameStart00 : TriggerState {
            internal StateGameStart00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9800, arg2: 4, arg3: "Equal")) {
                    context.State = new StateGameStart01(context);
                    return;
                }

                if (context.CountUsers(arg1: 9800, arg2: 4, arg3: "Less")) {
                    context.State = new StateGameStartDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameStartDelay01 : TriggerState {
            internal StateGameStartDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGameStart01(context);
                    return;
                }
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
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5003}, arg2: false);
                context.SetEffect(arg1: new int[] {5004}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 9005, arg2: 1, arg3: "Equal")) {
                    context.State = new StateGameStart02(context);
                    return;
                }

                if (context.CountUsers(arg1: 9900, arg2: 4, arg3: "Less")) {
                    context.State = new StateEndGame01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameStart02 : TriggerState {
            internal StateGameStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9006, arg2: 3, arg3: "Equal")) {
                    context.State = new State10secondsWait(context);
                    return;
                }

                if (context.CountUsers(arg1: 9900, arg2: 4, arg3: "Less")) {
                    context.State = new StateEndGame01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10secondsWait : TriggerState {
            internal State10secondsWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "DungeonClear", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateCheckMemeberAgain(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckMemeberAgain : TriggerState {
            internal StateCheckMemeberAgain(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9900, arg2: 4, arg3: "Equal")) {
                    context.State = new State10secondsWait(context);
                    return;
                }

                if (context.CountUsers(arg1: 9900, arg2: 4, arg3: "Less")) {
                    context.State = new StateEndGame01(context);
                    return;
                }

                if (context.UserValue(key: "DungeonClear", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEndGame01 : TriggerState {
            internal StateEndGame01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000387_BF__10_RANDOMPORTAL__1$", arg3: new int[] {3000},
                    arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePCMoveOut01(context);
                    return;
                }

                if (context.UserValue(key: "DungeonClear", value: 1)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCMoveOut01 : TriggerState {
            internal StatePCMoveOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000387, arg2: 1, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFieredNotice01(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFieredNotice01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFieredNotice01Skip : TriggerState {
            internal StateFieredNotice01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFieredNotice02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFieredNotice02 : TriggerState {
            internal StateFieredNotice02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000491, arg3: "$02000387_BF__10_RANDOMPORTAL__3$", arg4: 4);
                context.SetSkip(arg1: "FieredNotice02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFieredNotice02Skip(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCForceToLeave(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCForceToLeave : TriggerState {
            internal StatePCForceToLeave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {100});
            }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
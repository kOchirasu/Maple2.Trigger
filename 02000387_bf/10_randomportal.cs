namespace Maple2.Trigger._02000387_bf {
    public static class _10_randomportal {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2011, 2012, 2013, 2014}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004}, visible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 14, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 23, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 24, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(triggerId: 4101, visible: true, initialSequence: "ry_functobj_door_B01_off");
                context.SetActor(triggerId: 4102, visible: true, initialSequence: "ry_functobj_door_B01_off");
                context.SetActor(triggerId: 4103, visible: true, initialSequence: "ry_functobj_door_B01_off");
                context.SetActor(triggerId: 4104, visible: true, initialSequence: "ry_functobj_door_B01_off");
                context.SetUserValue(key: "RandomPortalOn", value: 0);
                context.SetUserValue(key: "CounterDoorPick", value: 0);
                context.SetUserValue(key: "DungeonClear", value: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000387_BF__10_RANDOMPORTAL__0$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 4101, visible: true, initialSequence: "ry_functobj_door_B01_on");
                context.SetActor(triggerId: 4102, visible: true, initialSequence: "ry_functobj_door_B01_on");
                context.SetActor(triggerId: 4103, visible: true, initialSequence: "ry_functobj_door_B01_on");
                context.SetActor(triggerId: 4104, visible: true, initialSequence: "ry_functobj_door_B01_on");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25f)) {
                    return new State1stDoorPick(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new State2ndDoorPick(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new State3rdDoorPick(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new State4rdDoorPick(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stDoorPick : TriggerState {
            internal State1stDoorPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 23, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 24, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetPortal(portalId: 12, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 23, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 24, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetPortal(portalId: 13, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 24, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
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
                context.SetPortal(portalId: 14, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: false, enabled: true, minimapVisible: false);
                context.SetPortal(portalId: 23, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 14, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 23, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 24, visible: false, enabled: false, minimapVisible: false);
                context.SetActor(triggerId: 4101, visible: true, initialSequence: "ry_functobj_door_B01_off");
                context.SetActor(triggerId: 4102, visible: true, initialSequence: "ry_functobj_door_B01_off");
                context.SetActor(triggerId: 4103, visible: true, initialSequence: "ry_functobj_door_B01_off");
                context.SetActor(triggerId: 4104, visible: true, initialSequence: "ry_functobj_door_B01_off");
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004}, visible: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000387_BF__10_RANDOMPORTAL__1$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 02000387, portalId: 1, boxId: 9900);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11000491, script: "$02000387_BF__10_RANDOMPORTAL__2$", arg4: 4);
                context.SetSkip(state: new StateFieredNotice01Skip(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateFieredNotice02(context);
            }

            public override void OnExit() { }
        }

        private class StateFieredNotice02 : TriggerState {
            internal StateFieredNotice02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000491, script: "$02000387_BF__10_RANDOMPORTAL__3$", arg4: 4);
                context.SetSkip(state: new StateFieredNotice02Skip(context));
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{100});
            }
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

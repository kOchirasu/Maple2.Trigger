using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000380_bf {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001064}, arg2: 2);
                context.SetActor(arg1: 4001, arg2: true, arg3: "ry_functobj_door_A01_Off");
                context.SetActor(arg1: 4003, arg2: true, arg3: "ry_functobj_door_A01_On");
                context.SetActor(arg1: 4007, arg2: true, arg3: "ry_functobj_door_A01_On");
                context.SetMesh(arg1: new[] {2001, 2002, 2003, 2004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {2005, 2006, 2007, 2008}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {2010, 2011, 2012, 2020, 2021, 2022, 2023}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 13, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001, 2002, 2003, 2004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new[] {8001, 8002, 8003}, arg2: true);
                context.CreateMonster(arg1: new[] {101});
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001836, script: "$02000380_BF__MAIN__1$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__2$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 2, arg2: 11001836, script: "$02000380_BF__MAIN__3$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart_03_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03_02 : TriggerState {
            internal StateStart_03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003801, textId: 20003801, duration: 5000);
                context.SetMesh(arg1: new[] {2001, 2002, 2003, 2004}, arg2: false, arg3: 0, arg4: 10, arg5: 10f);
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__4$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStart_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_04 : TriggerState {
            internal StateStart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2202");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new[] {101})) {
                    return new StateStart_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_05 : TriggerState {
            internal StateStart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__5$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2203");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_06 : TriggerState {
            internal StateStart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__6$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_07 : TriggerState {
            internal StateStart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__7$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_08 : TriggerState {
            internal StateStart_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40009, duration: 5000);
                context.SetMesh(arg1: new[] {2010, 2011, 2012}, arg2: false, arg3: 0, arg4: 10, arg5: 10f);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    return new StatePortal_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_10 : TriggerState {
            internal StatePortal_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4001, arg2: true, arg3: "ry_functobj_door_A01_On");
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_11 : TriggerState {
            internal StatePortal_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4001, arg2: true, arg3: "ry_functobj_door_A01_On");
                context.SetPortal(portalId: 11, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_12 : TriggerState {
            internal StatePortal_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4001, arg2: true, arg3: "ry_functobj_door_A01_On");
                context.SetPortal(portalId: 12, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_09 : TriggerState {
            internal StateStart_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 1) == true) {
                    return new StateStart_09_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_09_02 : TriggerState {
            internal StateStart_09_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new StateRound_2_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {2005, 2006, 2007, 2008}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 13, visible: true, enabled: false, minimapVisible: false);
            }
        }

        private class StateRound_2_02 : TriggerState {
            internal StateRound_2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_2_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2_03 : TriggerState {
            internal StateRound_2_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound_2_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2_04 : TriggerState {
            internal StateRound_2_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2205");
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__10$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateRound_2_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2_05 : TriggerState {
            internal StateRound_2_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound_2_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2_06 : TriggerState {
            internal StateRound_2_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2207");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 705, arg2: new[] {101})) {
                    return new StateRound_2_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2_08 : TriggerState {
            internal StateRound_2_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__12$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound_2_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2_09 : TriggerState {
            internal StateRound_2_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__13$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound_2_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2_10 : TriggerState {
            internal StateRound_2_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 110, textId: 40009, duration: 5000);
                context.SetMesh(arg1: new[] {2013, 2014, 2015}, arg2: false, arg3: 0, arg4: 10, arg5: 10f);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    return new StatePortal_22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_21 : TriggerState {
            internal StatePortal_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4004, arg2: true, arg3: "ry_functobj_door_A01_On");
                context.SetPortal(portalId: 21, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_2_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal_22 : TriggerState {
            internal StatePortal_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4004, arg2: true, arg3: "ry_functobj_door_A01_On");
                context.SetPortal(portalId: 22, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRound_2_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2_11 : TriggerState {
            internal StateRound_2_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__14$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateRound_2_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_2_12 : TriggerState {
            internal StateRound_2_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 703) == 1) {
                    return new StateRound_3_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {2005, 2006, 2007, 2008}, arg2: false, arg3: 0, arg4: 0, arg5: 10f);
                context.SetPortal(portalId: 21, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 22, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 23, visible: true, enabled: false, minimapVisible: false);
            }
        }

        private class StateRound_3_02 : TriggerState {
            internal StateRound_3_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2208");
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__15$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRound_3_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_3_03 : TriggerState {
            internal StateRound_3_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2208");
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__16$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 706, arg2: new[] {101})) {
                    return new StateRound_3_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_3_04 : TriggerState {
            internal StateRound_3_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02000380_BF__MAIN__17$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003802, textId: 20003802);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {199});
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
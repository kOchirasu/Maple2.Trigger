namespace Maple2.Trigger._52000066_qd {
    public static class _chase01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 1000, arg2: false, arg3: false);
                context.SetLadder(arg1: 1001, arg2: false, arg3: false);
                context.SetLadder(arg1: 1002, arg2: false, arg3: false);
                context.SetLadder(arg1: 1003, arg2: false, arg3: false);
                context.SetLadder(arg1: 1004, arg2: false, arg3: false);
                context.SetLadder(arg1: 1005, arg2: false, arg3: false);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029}, arg2: true, arg3: 0, arg4: 0, arg5: 3f);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetBreakable(arg1: new[] {4100, 4200}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4100, 4200}, arg2: false);
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCMonologue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCMonologue01 : TriggerState {
            internal StatePCMonologue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000066_QD__CHASE01__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLodingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay02 : TriggerState {
            internal StateLodingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stCameraGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stCameraGuide01 : TriggerState {
            internal State1stCameraGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State1stCameraGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stCameraGuide02 : TriggerState {
            internal State1stCameraGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stPhaseChase01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stPhaseChase01 : TriggerState {
            internal State1stPhaseChase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: "$52000066_QD__CHASE01__1$", arg3: 3000, arg4: "0");
                context.SetLadder(arg1: 1000, arg2: true, arg3: true);
                context.SetLadder(arg1: 1001, arg2: true, arg3: true);
                context.SetLadder(arg1: 1002, arg2: true, arg3: true);
                context.SetLadder(arg1: 1003, arg2: true, arg3: true);
                context.SetLadder(arg1: 1004, arg2: true, arg3: true);
                context.SetLadder(arg1: 1005, arg2: true, arg3: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    return new State2ndCameraGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndCameraGuide01 : TriggerState {
            internal State2ndCameraGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 601, arg2: true);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_102");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State2ndCameraGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndCameraGuide02 : TriggerState {
            internal State2ndCameraGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000066, arg2: 40);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029}, arg2: false, arg3: 500, arg4: 50, arg5: 1f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State2ndCameraGuide03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndCameraGuide03 : TriggerState {
            internal State2ndCameraGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State2ndPhaseChase01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndPhaseChase01 : TriggerState {
            internal State2ndPhaseChase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000066_QD__CHASE01__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2ndPhaseChase02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State2ndPhaseChase02 : TriggerState {
            internal State2ndPhaseChase02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.SetUserValue(triggerId: 2, key: "TrapLeverOn", value: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200661, textId: 25200661, duration: 6000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9300})) {
                    return new State3rdPhaseChase01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdPhaseChase01 : TriggerState {
            internal State3rdPhaseChase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200662, textId: 25200662);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9400, 9401, 9402, 9403, 9404, 9405, 9406})) {
                    return new State3rdCameraGuide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdCameraGuide01 : TriggerState {
            internal State3rdCameraGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "TrapLeverOn", value: 2);
                context.HideGuideSummary(entityId: 25200662);
                context.SetBreakable(arg1: new[] {4100, 4200}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {4100, 4200}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State3rdCameraGuide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdCameraGuide02 : TriggerState {
            internal State3rdCameraGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 602, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State3rdCameraGuide03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveUser(arg1: 52000066, arg2: 30);
            }
        }

        private class State3rdCameraGuide03 : TriggerState {
            internal State3rdCameraGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 604, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCMonologue10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCMonologue10 : TriggerState {
            internal StatePCMonologue10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000066_QD__CHASE01__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4thTrainMove01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 604, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State4thTrainMove01 : TriggerState {
            internal State4thTrainMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {4100, 4200}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {4100, 4200}, arg2: false);
                context.SetUserValue(triggerId: 3, key: "TrainMove", value: 1);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9500, 9501, 9502})) {
                    return new StateAgentEscape01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAgentEscape01 : TriggerState {
            internal StateAgentEscape01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_103");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateAgentEscape02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAgentEscape02 : TriggerState {
            internal StateAgentEscape02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 603, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9600, arg2: new[] {103})) {
                    return new StateAgentEscape03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAgentEscape03 : TriggerState {
            internal StateAgentEscape03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new[] {300}, arg5: 6000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAgentEscape04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAgentEscape04 : TriggerState {
            internal StateAgentEscape04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {103});
                context.CameraSelect(arg1: 603, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePCMonologue20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCMonologue20 : TriggerState {
            internal StatePCMonologue20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$52000066_QD__CHASE01__4$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestEndCheck01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestEndCheck01 : TriggerState {
            internal StateQuestEndCheck01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {10001028}, arg3: new byte[] {2})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
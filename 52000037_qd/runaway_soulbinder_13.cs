namespace Maple2.Trigger._52000037_qd {
    public static class _runaway_soulbinder_13 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9400}, questIds: new []{50001411}, questStates: new byte[]{2}, jobCode: 110)) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 603, enable: true);
                context.MoveUser(mapId: 52000037, portalId: 11);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StatePC말풍선Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선Delay : TriggerState {
            internal StatePC말풍선Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.MoveUserPath(patrolName: "MS2PatrolData_PC1102A");
                    return new StatePC말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__RUNAWAY_SOULBINDER_13__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선02 : TriggerState {
            internal StatePC말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__RUNAWAY_SOULBINDER_13__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선03 : TriggerState {
            internal StatePC말풍선03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__RUNAWAY_SOULBINDER_13__2$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State말풍선Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State말풍선Delay : TriggerState {
            internal State말풍선Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.MoveUserPath(patrolName: "MS2PatrolData_PC1102B");
                    return new StatePC말풍선04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선04 : TriggerState {
            internal StatePC말풍선04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__RUNAWAY_SOULBINDER_13__3$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePC말풍선05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선05 : TriggerState {
            internal StatePC말풍선05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__RUNAWAY_SOULBINDER_13__4$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNPCSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCSpawn : TriggerState {
            internal StateNPCSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{211, 212, 213}, arg2: false);
                context.CameraSelect(triggerId: 604, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNPCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01 : TriggerState {
            internal StateNPCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001727, script: "$52000037_QD__RUNAWAY_SOULBINDER_13__5$", arg4: 2);
                context.SetSkip(state: new StateNPCScript01스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNPCScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01스킵 : TriggerState {
            internal StateNPCScript01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateNPCScript02(context);
            }

            public override void OnExit() { }
        }

        private class StateNPCScript02 : TriggerState {
            internal StateNPCScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001725, script: "$52000037_QD__RUNAWAY_SOULBINDER_13__6$", arg4: 2);
                context.SetSkip(state: new StateNPCScript02스킵(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC도주(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript02스킵 : TriggerState {
            internal StateNPCScript02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StatePC도주(context);
            }

            public override void OnExit() { }
        }

        private class StatePC도주 : TriggerState {
            internal StatePC도주(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.CameraSelect(triggerId: 605, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC1102C");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePC말풍선06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선06 : TriggerState {
            internal StatePC말풍선06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 211, patrolName: "MS2PatrolData_NPC1102");
                context.MoveNpc(spawnId: 212, patrolName: "MS2PatrolData_NPC1102");
                context.MoveNpc(spawnId: 213, patrolName: "MS2PatrolData_NPC1102");
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__RUNAWAY_SOULBINDER_13__7$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000043, portalId: 5);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

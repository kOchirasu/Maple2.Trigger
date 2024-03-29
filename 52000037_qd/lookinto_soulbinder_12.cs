namespace Maple2.Trigger._52000037_qd {
    public static class _lookinto_soulbinder_12 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: false, initialSequence: "Dead_A");
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000175}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{60100065}, questStates: new byte[]{2}, jobCode: 110)) {
                    return new StateCinematic01조건(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{60100065}, questStates: new byte[]{3}, jobCode: 110)) {
                    return new StateNPC만배치(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC만배치 : TriggerState {
            internal StateNPC만배치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000175}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic01조건 : TriggerState {
            internal StateCinematic01조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000175}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9300}, questIds: new []{60100065}, questStates: new byte[]{2}, jobCode: 110)) {
                    return new StateCinematic01시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCinematic01시작 : TriggerState {
            internal StateCinematic01시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000037, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.MoveUserPath(patrolName: "MS2PatrolData_PC1101A");
                    return new StatePC말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선01 : TriggerState {
            internal StatePC말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__LOOKINTO_SOULBINDER_12__0$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePC말풍선02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선02 : TriggerState {
            internal StatePC말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__LOOKINTO_SOULBINDER_12__1$", arg4: 3, arg5: 0);
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
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__LOOKINTO_SOULBINDER_12__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선04 : TriggerState {
            internal StatePC말풍선04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__LOOKINTO_SOULBINDER_12__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC말풍선05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선05 : TriggerState {
            internal StatePC말풍선05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__LOOKINTO_SOULBINDER_12__4$", arg4: 5, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State강제이동02조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동02조건 : TriggerState {
            internal State강제이동02조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9301}, questIds: new []{60100065}, questStates: new byte[]{2}, jobCode: 110)) {
                    return new StatePC말풍선07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC말풍선07 : TriggerState {
            internal StatePC말풍선07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000037_QD__LOOKINTO_SOULBINDER_12__5$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동02 : TriggerState {
            internal State강제이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_PC1101B");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9302}, questIds: new []{60100065}, questStates: new byte[]{2}, jobCode: 110)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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

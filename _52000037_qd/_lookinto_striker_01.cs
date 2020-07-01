namespace Maple2.Trigger._52000037_qd {
    public static class _lookinto_striker_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: false, arg3: "Dead_A");
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetInteractObject(arg1: new[] {10000175}, arg2: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {40002604}, arg3: new byte[] {3}, arg4: 100)) {
                    context.State = new StateStrikerSetting04(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {40002604}, arg3: new byte[] {2}, arg4: 100)) {
                    context.State = new StateStrikerSetting03(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {40002604}, arg3: new byte[] {1}, arg4: 100)) {
                    context.State = new StateStrikerSetting05(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60100065}, arg3: new byte[] {3}, arg4: 100)) {
                    context.State = new StateStrikerSetting02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60100065}, arg3: new byte[] {2}, arg4: 100)) {
                    context.State = new StateStrikerSetting01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStrikerSetting02 : TriggerState {
            internal StateStrikerSetting02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {202, 302, 101}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    context.State = new StateNextQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStrikerSetting05 : TriggerState {
            internal StateStrikerSetting05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000175}, arg2: 1);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {202, 302, 101}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    context.State = new StateNextQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStrikerSetting03 : TriggerState {
            internal StateStrikerSetting03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateStrikerSetting04 : TriggerState {
            internal StateStrikerSetting04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateStrikerSetting01 : TriggerState {
            internal StateStrikerSetting01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "Dead_A");
                context.CreateMonster(arg1: new[] {201, 301}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9100})) {
                    context.State = new StateSayHi01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSayHi01 : TriggerState {
            internal StateSayHi01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePCMove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCMove01 : TriggerState {
            internal StatePCMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCMove02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCMove02 : TriggerState {
            internal StatePCMove02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000037, arg2: 10, arg3: 9900);
                context.CreateMonster(arg1: new[] {401}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePatrol01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol01 : TriggerState {
            internal StatePatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePatrol02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol02 : TriggerState {
            internal StatePatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__1$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_401");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePatrol03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol03 : TriggerState {
            internal StatePatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_301");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePatrol04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrol04 : TriggerState {
            internal StatePatrol04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__2$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateComeAcrossSB01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateComeAcrossSB01 : TriggerState {
            internal StateComeAcrossSB01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateComeAcrossSB02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateComeAcrossSB02 : TriggerState {
            internal StateComeAcrossSB02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateComeAcrossSB03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateComeAcrossSB03 : TriggerState {
            internal StateComeAcrossSB03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSBRunAway01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSBRunAway01 : TriggerState {
            internal StateSBRunAway01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 401, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__14$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateSBRunAway02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSBRunAway02 : TriggerState {
            internal StateSBRunAway02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_402");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSBRunAway03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSBRunAway03 : TriggerState {
            internal StateSBRunAway03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 701, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateDialogue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__4$", arg4: 5);
                context.SetSkip(arg1: "Dialogue02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue03 : TriggerState {
            internal StateDialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {401});
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__5$", arg4: 5);
                context.SetSkip(arg1: "Dialogue04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogue04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue04 : TriggerState {
            internal StateDialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 701, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateStepInside01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStepInside01 : TriggerState {
            internal StateStepInside01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__6$", arg4: 4, arg5: 0);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_302");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateStepInside02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStepInside02 : TriggerState {
            internal StateStepInside02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__7$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFirstQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestStart01 : TriggerState {
            internal StateFirstQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000175}, arg2: 1);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {60100065}, arg3: new byte[] {3}, arg4: 100)) {
                    context.State = new StateTalkJabethNBravo01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkJabethNBravo01 : TriggerState {
            internal StateTalkJabethNBravo01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001546, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__8$", arg4: 5);
                context.SetSkip(arg1: "TalkJabethNBravo02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateTalkJabethNBravo02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkJabethNBravo02 : TriggerState {
            internal StateTalkJabethNBravo02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTalkJabethNBravo03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkJabethNBravo03 : TriggerState {
            internal StateTalkJabethNBravo03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__9$", arg4: 5);
                context.SetSkip(arg1: "TalkJabethNBravo04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateTalkJabethNBravo04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkJabethNBravo04 : TriggerState {
            internal StateTalkJabethNBravo04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPCChange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCChange01 : TriggerState {
            internal StateNPCChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201, 301});
                context.CreateMonster(arg1: new[] {202, 302}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNextQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNextQuestStart01 : TriggerState {
            internal StateNextQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__10$", arg4: 4, arg5: 0);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_203");
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_303");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNextQuestStart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNextQuestStart02 : TriggerState {
            internal StateNextQuestStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002604}, arg3: new byte[] {2}, arg4: 100)) {
                    context.State = new StateReadyToLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave01 : TriggerState {
            internal StateReadyToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001545, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__11$", arg4: 6);
                context.SetSkip(arg1: "ReadyToLeave02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateReadyToLeave02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave02 : TriggerState {
            internal StateReadyToLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToLeave03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave03 : TriggerState {
            internal StateReadyToLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_304");
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__12$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToLeave04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave04 : TriggerState {
            internal StateReadyToLeave04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_204");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToLeave05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToLeave05 : TriggerState {
            internal StateReadyToLeave05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$52000037_QD__LOOKINTO_STRIKER_01__13$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_305");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateNPCLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCLeave01 : TriggerState {
            internal StateNPCLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {302});
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_205");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateNPCLeave02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPCLeave02 : TriggerState {
            internal StateNPCLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.DestroyMonster(arg1: new[] {202});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
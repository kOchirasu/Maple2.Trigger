namespace Maple2.Trigger._63000026_cs {
    public static class _faint01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 10000, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetEffect(arg1: new[] {5100}, arg2: false);
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.SetEffect(arg1: new[] {5102}, arg2: false);
                context.SetEffect(arg1: new[] {5103}, arg2: false);
                context.SetEffect(arg1: new[] {5104}, arg2: false);
                context.SetEffect(arg1: new[] {5105}, arg2: false);
                context.SetEffect(arg1: new[] {5106}, arg2: false);
                context.SetEffect(arg1: new[] {5107}, arg2: false);
                context.SetEffect(arg1: new[] {5300}, arg2: false);
                context.SetEffect(arg1: new[] {5400}, arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: false);
                context.SetEffect(arg1: new[] {6001}, arg2: false);
                context.SetEffect(arg1: new[] {6002}, arg2: false);
                context.SetEffect(arg1: new[] {6003}, arg2: false);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8100", arg2: false);
                context.SetAgent(arg1: "8101", arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateEnter01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {90000450},
                    arg3: new byte[] {1})) {
                    context.State = new StateEnter02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter02 : TriggerState {
            internal StateEnter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10033010, textId: 10033010);
                context.SetEffect(arg1: new[] {5100}, arg2: true);
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.SetEffect(arg1: new[] {5102}, arg2: true);
                context.SetEffect(arg1: new[] {5103}, arg2: true);
                context.SetEffect(arg1: new[] {5104}, arg2: true);
                context.SetEffect(arg1: new[] {5105}, arg2: true);
                context.SetEffect(arg1: new[] {5106}, arg2: true);
                context.SetEffect(arg1: new[] {5107}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new StateOnTheBridge01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10033010);
                context.SetEffect(arg1: new[] {5100}, arg2: false);
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.SetEffect(arg1: new[] {5102}, arg2: false);
                context.SetEffect(arg1: new[] {5103}, arg2: false);
                context.SetEffect(arg1: new[] {5104}, arg2: false);
                context.SetEffect(arg1: new[] {5105}, arg2: false);
                context.SetEffect(arg1: new[] {5106}, arg2: false);
                context.SetEffect(arg1: new[] {5107}, arg2: false);
            }
        }

        private class StateOnTheBridge01 : TriggerState {
            internal StateOnTheBridge01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 500, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateOnTheBridge02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOnTheBridge02 : TriggerState {
            internal StateOnTheBridge02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000026, arg2: 10, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    context.State = new StateOnTheBridge03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOnTheBridge03 : TriggerState {
            internal StateOnTheBridge03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    context.State = new StateOnTheBridge04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateOnTheBridge04 : TriggerState {
            internal StateOnTheBridge04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new StateTinChaiComeIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiComeIn01 : TriggerState {
            internal StateTinChaiComeIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
                context.SetSound(arg1: 10000, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateTinChaiComeIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiComeIn02 : TriggerState {
            internal StateTinChaiComeIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000026_CS__FAINT01__5$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateTinChaiComeIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiComeIn03 : TriggerState {
            internal StateTinChaiComeIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTinChaiComeIn04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiComeIn04 : TriggerState {
            internal StateTinChaiComeIn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetSceneSkip(arg1: "PCTeleport03", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateTinChaiTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk01 : TriggerState {
            internal StateTinChaiTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000026_CS__FAINT01__0$", arg4: 5);
                context.SetSkip(arg1: "TinChaiTalk02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateTinChaiTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk02 : TriggerState {
            internal StateTinChaiTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTinChaiTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk03 : TriggerState {
            internal StateTinChaiTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetEffect(arg1: new[] {5400}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000026_CS__FAINT01__1$", arg4: 3);
                context.CreateMonster(arg1: new[] {900, 901, 902, 903, 904, 905, 910, 911, 912, 913, 914, 915});
                context.MoveNpc(arg1: 900, arg2: "MS2PatrolData_900");
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_901");
                context.MoveNpc(arg1: 902, arg2: "MS2PatrolData_902");
                context.MoveNpc(arg1: 903, arg2: "MS2PatrolData_903");
                context.MoveNpc(arg1: 904, arg2: "MS2PatrolData_904");
                context.MoveNpc(arg1: 905, arg2: "MS2PatrolData_905");
                context.MoveNpc(arg1: 910, arg2: "MS2PatrolData_910");
                context.MoveNpc(arg1: 911, arg2: "MS2PatrolData_911");
                context.MoveNpc(arg1: 912, arg2: "MS2PatrolData_912");
                context.MoveNpc(arg1: 913, arg2: "MS2PatrolData_913");
                context.MoveNpc(arg1: 914, arg2: "MS2PatrolData_914");
                context.MoveNpc(arg1: 915, arg2: "MS2PatrolData_915");
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDarkShadowApp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDarkShadowApp01 : TriggerState {
            internal StateDarkShadowApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDarkShadowApp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDarkShadowApp02 : TriggerState {
            internal StateDarkShadowApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.MoveUser(arg1: 63000026, arg2: 20, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateDarkShadowApp03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDarkShadowApp03 : TriggerState {
            internal StateDarkShadowApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateReadyToBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle01 : TriggerState {
            internal StateReadyToBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000026_CS__FAINT01__2$", arg4: 5);
                context.SetSkip(arg1: "ReadyToBattle02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReadyToBattle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle02 : TriggerState {
            internal StateReadyToBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelectPath(arg1: new[] {700, 701}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_102");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateReadyToBattle03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle03 : TriggerState {
            internal StateReadyToBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000026, arg2: 30, arg3: 9900);
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000026_CS__FAINT01__3$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateReadyToBattle05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle05 : TriggerState {
            internal StateReadyToBattle05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5300}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToBattle06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToBattle06 : TriggerState {
            internal StateReadyToBattle06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 30000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCFaint01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFaint01 : TriggerState {
            internal StatePCFaint01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 702, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCFaint02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFaint02 : TriggerState {
            internal StatePCFaint02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_103");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCFaint03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFaint03 : TriggerState {
            internal StatePCFaint03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000026_CS__FAINT01__4$", arg4: 5);
                context.DestroyMonster(arg1: new[] {900, 901, 902, 903, 904, 905, 910, 911, 912, 913, 914, 915});
                context.CreateMonster(arg1: new[] {920, 921, 922}, arg2: false);
                context.SetSkip(arg1: "PCFaint04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePCFaint04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFaint04 : TriggerState {
            internal StatePCFaint04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTinChaiGoToFight01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiGoToFight01 : TriggerState {
            internal StateTinChaiGoToFight01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 710, arg2: true);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_104");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTinChaiGoToFight02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiGoToFight02 : TriggerState {
            internal StateTinChaiGoToFight02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTinChaiGoToFight03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiGoToFight03 : TriggerState {
            internal StateTinChaiGoToFight03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePCTeleport01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport01 : TriggerState {
            internal StatePCTeleport01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8100", arg2: true);
                context.SetAgent(arg1: "8101", arg2: true);
                context.CameraSelectPath(arg1: new[] {720, 721}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePCTeleport02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport02 : TriggerState {
            internal StatePCTeleport02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePCTeleport03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport03 : TriggerState {
            internal StatePCTeleport03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 721, arg2: false);
                context.MoveUser(arg1: 63000027, arg2: 1, arg3: 9900);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {9900})) {
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
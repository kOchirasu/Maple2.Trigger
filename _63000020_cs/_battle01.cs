namespace Maple2.Trigger._63000020_cs {
    public static class _battle01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.CreateMonster(arg1: new[] {101, 201, 301, 401, 501}, arg2: false);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
                context.SetSkill(arg1: new[] {7000}, arg2: false);
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: false);
                context.SetEffect(arg1: new[] {6001}, arg2: false);
                context.SetEffect(arg1: new[] {7100}, arg2: false);
                context.SetEffect(arg1: new[] {7101}, arg2: false);
                context.SetEffect(arg1: new[] {7102}, arg2: false);
                context.SetEffect(arg1: new[] {7103}, arg2: false);
                context.SetEffect(arg1: new[] {7200}, arg2: false);
                context.SetEffect(arg1: new[] {7201}, arg2: false);
                context.SetEffect(arg1: new[] {7202}, arg2: false);
                context.SetEffect(arg1: new[] {7203}, arg2: false);
                context.SetEffect(arg1: new[] {7204}, arg2: false);
                context.SetEffect(arg1: new[] {7205}, arg2: false);
                context.SetEffect(arg1: new[] {7206}, arg2: false);
                context.SetEffect(arg1: new[] {7207}, arg2: false);
                context.SetEffect(arg1: new[] {7208}, arg2: false);
                context.SetEffect(arg1: new[] {7209}, arg2: false);
                context.SetEffect(arg1: new[] {7210}, arg2: false);
                context.SetEffect(arg1: new[] {7211}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9900}, arg2: 70000093, arg3: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 500, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLookAround01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLookAround02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateLookAround03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround03 : TriggerState {
            internal StateLookAround03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 511, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateLookAround04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround04 : TriggerState {
            internal StateLookAround04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 502, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateTalkKay03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay03 : TriggerState {
            internal StateTalkKay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 13000f);
                context.SetEffect(arg1: new[] {7205}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__0$", arg4: 7);
                context.SetSkip(arg1: "TalkKay04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateTalkKay04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay04 : TriggerState {
            internal StateTalkKay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7205}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTalkKay10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay10 : TriggerState {
            internal StateTalkKay10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__1$", arg4: 8);
                context.SetEffect(arg1: new[] {7206}, arg2: true);
                context.SetSkip(arg1: "TalkKay11");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateTalkKay11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay11 : TriggerState {
            internal StateTalkKay11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.SetEffect(arg1: new[] {7206}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFirstChampoin01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin01 : TriggerState {
            internal StateFirstChampoin01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateFirstChampoin02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin02 : TriggerState {
            internal StateFirstChampoin02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
                context.CreateMonster(arg1: new[] {901}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateFirstChampoin03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin03 : TriggerState {
            internal StateFirstChampoin03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_900");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__2$", arg4: 4);
                context.SetEffect(arg1: new[] {7207}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFirstChampoin04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin04 : TriggerState {
            internal StateFirstChampoin04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 901, arg2: "MS2PatrolData_901");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateFirstChampoin05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin05 : TriggerState {
            internal StateFirstChampoin05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7207}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFirstChampoin06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin06 : TriggerState {
            internal StateFirstChampoin06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000020, arg2: 2);
                context.DestroyMonster(arg1: new[] {901});
                context.CreateMonster(arg1: new[] {911}, arg2: false);
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFirstBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstBattle01 : TriggerState {
            internal StateFirstBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__3$", arg4: 5);
                context.SetEffect(arg1: new[] {7210}, arg2: true);
                context.SetSkip(arg1: "FirstBattle02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateFirstBattle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstBattle02 : TriggerState {
            internal StateFirstBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7210}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 700, arg2: false);
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFirstBattle03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstBattle03 : TriggerState {
            internal StateFirstBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10025010, textId: 10025010);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {911})) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.HideGuideSummary(entityId: 10025010);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateSecondChampoin01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin01 : TriggerState {
            internal StateSecondChampoin01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {600, 601}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateSecondChampoin02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin02 : TriggerState {
            internal StateSecondChampoin02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {902}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateSecondChampoin03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin03 : TriggerState {
            internal StateSecondChampoin03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 902, arg2: "MS2PatrolData_900");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__4$", arg4: 4);
                context.SetEffect(arg1: new[] {7208}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateSecondChampoin04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin04 : TriggerState {
            internal StateSecondChampoin04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 902, arg2: "MS2PatrolData_901");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateSecondChampoin05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin05 : TriggerState {
            internal StateSecondChampoin05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7208}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSecondChampoin06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin06 : TriggerState {
            internal StateSecondChampoin06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000020, arg2: 2);
                context.DestroyMonster(arg1: new[] {902});
                context.CreateMonster(arg1: new[] {912}, arg2: false);
                context.CameraSelect(arg1: 700, arg2: true);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSecondBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondBattle01 : TriggerState {
            internal StateSecondBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__5$", arg4: 5);
                context.SetEffect(arg1: new[] {7210}, arg2: true);
                context.SetSkip(arg1: "SecondBattle02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateSecondBattle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondBattle02 : TriggerState {
            internal StateSecondBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7210}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 700, arg2: false);
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSecondBattle03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondBattle03 : TriggerState {
            internal StateSecondBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10025020, textId: 10025020);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {912})) {
                    context.State = new StateDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.HideGuideSummary(entityId: 10025020);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateThirdChampoin01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin01 : TriggerState {
            internal StateThirdChampoin01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {600, 601}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateThirdChampoin02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin02 : TriggerState {
            internal StateThirdChampoin02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {903}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateThirdChampoin03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin03 : TriggerState {
            internal StateThirdChampoin03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 903, arg2: "MS2PatrolData_900");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__6$", arg4: 5);
                context.SetEffect(arg1: new[] {7209}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateThirdChampoin04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin04 : TriggerState {
            internal StateThirdChampoin04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 903, arg2: "MS2PatrolData_901");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateThirdChampoin05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin05 : TriggerState {
            internal StateThirdChampoin05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7209}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateThirdChampoin06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin06 : TriggerState {
            internal StateThirdChampoin06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000020, arg2: 2);
                context.DestroyMonster(arg1: new[] {903});
                context.CreateMonster(arg1: new[] {913}, arg2: false);
                context.CameraSelect(arg1: 700, arg2: true);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateThirdBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateThirdBattle01 : TriggerState {
            internal StateThirdBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetEffect(arg1: new[] {7210}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__7$", arg4: 5);
                context.SetSkip(arg1: "ThirdBattle02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateThirdBattle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateThirdBattle02 : TriggerState {
            internal StateThirdBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7210}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 700, arg2: false);
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateThirdBattle03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateThirdBattle03 : TriggerState {
            internal StateThirdBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10025030, textId: 10025030);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {913})) {
                    context.State = new StateDelay03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.HideGuideSummary(entityId: 10025030);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalkKay20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay20 : TriggerState {
            internal StateTalkKay20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 503, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateTalkKay21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay21 : TriggerState {
            internal StateTalkKay21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__8$", arg4: 9);
                context.SetEffect(arg1: new[] {7211}, arg2: true);
                context.SetSkip(arg1: "TalkKay22");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateTalkKay22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay22 : TriggerState {
            internal StateTalkKay22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000020, arg2: 6);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {7211}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCFeelDizzy01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFeelDizzy01 : TriggerState {
            internal StatePCFeelDizzy01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 703, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StatePCFeelDizzy02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFeelDizzy02 : TriggerState {
            internal StatePCFeelDizzy02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$63000020_CS__BATTLE01__9$", arg4: 4, arg5: 0);
                context.SetPcEmotionSequence(arg1: "Emotion_Disappoint_A,Emotion_Disappoint_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4200)) {
                    context.State = new StatePCFeelDizzy03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFeelDizzy03 : TriggerState {
            internal StatePCFeelDizzy03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 705, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StatePCFeelDizzy04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFeelDizzy04 : TriggerState {
            internal StatePCFeelDizzy04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 704, arg2: true);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.AddBuff(arg1: new[] {9900}, arg2: 70000094, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePCFeelOkay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFeelOkay01 : TriggerState {
            internal StatePCFeelOkay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.AddBuff(arg1: new[] {9900}, arg2: 70000096, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePCFeelOkay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFeelOkay02 : TriggerState {
            internal StatePCFeelOkay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 703, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePCFeelOkay03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFeelOkay03 : TriggerState {
            internal StatePCFeelOkay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$63000020_CS__BATTLE01__10$", arg4: 4, arg5: 0);
                context.SetPcEmotionSequence(arg1: "Bore_C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePCFeelOkay04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFeelOkay04 : TriggerState {
            internal StatePCFeelOkay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.CameraSelect(arg1: 504, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkKay23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay23 : TriggerState {
            internal StateTalkKay23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__11$", arg4: 9);
                context.SetEffect(arg1: new[] {7200}, arg2: true);
                context.SetSkip(arg1: "TalkKay24");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateTalkKay24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay24 : TriggerState {
            internal StateTalkKay24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.MoveUser(arg1: 63000020, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkKay25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay25 : TriggerState {
            internal StateTalkKay25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7200}, arg2: false);
                context.CameraSelect(arg1: 710, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkKay26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay26 : TriggerState {
            internal StateTalkKay26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__12$", arg4: 14);
                context.SetEffect(arg1: new[] {7201}, arg2: true);
                context.SetSkip(arg1: "TalkKay27");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    context.State = new StateTalkKay27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay27 : TriggerState {
            internal StateTalkKay27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {7201}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkKay28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay28 : TriggerState {
            internal StateTalkKay28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__13$", arg4: 10);
                context.SetEffect(arg1: new[] {7202}, arg2: true);
                context.SetSkip(arg1: "TalkKay29");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateTalkKay29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkKay29 : TriggerState {
            internal StateTalkKay29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7202}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateLastChampoin01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin01 : TriggerState {
            internal StateLastChampoin01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLastChampoin02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin02 : TriggerState {
            internal StateLastChampoin02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {900}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLastChampoin03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin03 : TriggerState {
            internal StateLastChampoin03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.MoveNpc(arg1: 900, arg2: "MS2PatrolData_902");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__14$", arg4: 11);
                context.SetEffect(arg1: new[] {7203}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLastChampoin04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin04 : TriggerState {
            internal StateLastChampoin04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 900, arg2: "Bore_A");
                context.SetSkip(arg1: "LastChampoin05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateLastChampoin05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin05 : TriggerState {
            internal StateLastChampoin05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 900, arg2: "MS2PatrolData_901");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLastChampoin06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin06 : TriggerState {
            internal StateLastChampoin06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7203}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLastChampoin07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin07 : TriggerState {
            internal StateLastChampoin07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000020, arg2: 2);
                context.DestroyMonster(arg1: new[] {900});
                context.CreateMonster(arg1: new[] {924}, arg2: false);
                context.CameraSelect(arg1: 700, arg2: true);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLastBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastBattle01 : TriggerState {
            internal StateLastBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001626, arg3: "$63000020_CS__BATTLE01__15$", arg4: 7);
                context.SetEffect(arg1: new[] {7204}, arg2: true);
                context.SetSkip(arg1: "LastBattle02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateLastBattle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastBattle02 : TriggerState {
            internal StateLastBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7204}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 701, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLastBattle03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastBattle03 : TriggerState {
            internal StateLastBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$63000020_CS__BATTLE01__16$", arg4: 3, arg5: 0);
                context.SetPcEmotionSequence(arg1: "Striker_Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new StateLastBattle04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastBattle04 : TriggerState {
            internal StateLastBattle04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {924});
                context.CreateMonster(arg1: new[] {910}, arg2: false);
                context.CameraSelect(arg1: 702, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkChen10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkChen10 : TriggerState {
            internal StateTalkChen10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001547, arg3: "$63000020_CS__BATTLE01__17$", arg4: 4);
                context.SetEffect(arg1: new[] {7100}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalkChen11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkChen11 : TriggerState {
            internal StateTalkChen11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7100}, arg2: false);
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateBattleStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 702, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBattleStart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleStart02 : TriggerState {
            internal StateBattleStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.ShowGuideSummary(entityId: 10025040, textId: 10025040);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateCameraAct01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraAct01 : TriggerState {
            internal StateCameraAct01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCameraAct02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraAct02 : TriggerState {
            internal StateCameraAct02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10025040);
                context.MoveUser(arg1: 63000020, arg2: 4);
                context.DestroyMonster(arg1: new[] {910});
                context.CreateMonster(arg1: new[] {920}, arg2: false);
                context.CameraSelect(arg1: 800, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCAttack01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCAttack01 : TriggerState {
            internal StatePCAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetPcEmotionSequence(arg1: "Knuckle_Attack_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    context.State = new StatePCAttack02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCAttack02 : TriggerState {
            internal StatePCAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Striker_Event_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    context.State = new StateKnockBack01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKnockBack01 : TriggerState {
            internal StateKnockBack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 920, arg2: "Attack_01_H");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateKnockBack02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKnockBack02 : TriggerState {
            internal StateKnockBack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7000}, arg2: true);
                context.CameraSelect(arg1: 801, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    context.State = new StateKnockBack03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKnockBack03 : TriggerState {
            internal StateKnockBack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateBlurAct01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlurAct01 : TriggerState {
            internal StateBlurAct01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 802, arg2: true);
                context.AddBuff(arg1: new[] {9900}, arg2: 70000094, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBlurAct02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlurAct02 : TriggerState {
            internal StateBlurAct02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 803, arg2: true);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBlurAct03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlurAct03 : TriggerState {
            internal StateBlurAct03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBlurAct04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlurAct04 : TriggerState {
            internal StateBlurAct04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9900}, arg2: 70000095, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateBlurAct05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlurAct05 : TriggerState {
            internal StateBlurAct05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 805, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    context.State = new StateBlurAct06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlurAct06 : TriggerState {
            internal StateBlurAct06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateBlurAct07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlurAct07 : TriggerState {
            internal StateBlurAct07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Emotion_Disappoint_Idle_A", arg2: 24000f);
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.AddBuff(arg1: new[] {9900}, arg2: 70000096, arg3: 1);
                context.CameraSelect(arg1: 806, arg2: true);
                context.DestroyMonster(arg1: new[] {920});
                context.CreateMonster(arg1: new[] {922}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateBlurAct08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlurAct08 : TriggerState {
            internal StateBlurAct08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 922, arg2: "MS2PatrolData_920");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkChen01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkChen01 : TriggerState {
            internal StateTalkChen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001547, arg3: "$63000020_CS__BATTLE01__18$", arg4: 5);
                context.SetEffect(arg1: new[] {7101}, arg2: true);
                context.SetSkip(arg1: "TalkChen02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateTalkChen02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkChen02 : TriggerState {
            internal StateTalkChen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7101}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTalkChen03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkChen03 : TriggerState {
            internal StateTalkChen03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001547, arg3: "$63000020_CS__BATTLE01__19$", arg4: 4);
                context.SetEffect(arg1: new[] {7103}, arg2: true);
                context.SetSkip(arg1: "TalkChen04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalkChen04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkChen04 : TriggerState {
            internal StateTalkChen04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7103}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTalkChen05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkChen05 : TriggerState {
            internal StateTalkChen05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001547, arg3: "$63000020_CS__BATTLE01__20$", arg4: 4);
                context.SetEffect(arg1: new[] {7102}, arg2: true);
                context.SetSkip(arg1: "TalkChen06");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalkChen06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkChen06 : TriggerState {
            internal StateTalkChen06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new[] {922});
                context.CreateMonster(arg1: new[] {923}, arg2: false);
                context.SetEffect(arg1: new[] {7102}, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLastAttack00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastAttack00 : TriggerState {
            internal StateLastAttack00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 923, arg2: "Attack_02_G", arg3: 2000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLastAttack01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastAttack01 : TriggerState {
            internal StateLastAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddBuff(arg1: new[] {9900}, arg2: 70000095, arg3: 1);
                context.CameraSelect(arg1: 807, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLastAttack02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastAttack02 : TriggerState {
            internal StateLastAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 808, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    context.State = new StateLastAttack03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastAttack03 : TriggerState {
            internal StateLastAttack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 923, arg2: "Attack_03_G");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StatePCFainted01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFainted01 : TriggerState {
            internal StatePCFainted01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9900}, arg2: 70000096, arg3: 1);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCFainted02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFainted02 : TriggerState {
            internal StatePCFainted02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9900}, arg2: 70000095, arg3: 1);
                context.CameraSelect(arg1: 804, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCFainted03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFainted03 : TriggerState {
            internal StatePCFainted03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePlayerDown01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown01 : TriggerState {
            internal StatePlayerDown01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePlayerDown02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown02 : TriggerState {
            internal StatePlayerDown02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9900}, arg2: 70000096, arg3: 1);
                context.MoveUser(arg1: 63000020, arg2: 5);
                context.DestroyMonster(arg1: new[] {923});
                context.CreateMonster(arg1: new[] {921}, arg2: false);
                context.CameraSelect(arg1: 810, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePlayerDown03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown03 : TriggerState {
            internal StatePlayerDown03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 16000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePlayerDown04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown04 : TriggerState {
            internal StatePlayerDown04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 921, arg2: "MS2PatrolData_921");
                context.SetEffect(arg1: new[] {6001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePlayerDown05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown05 : TriggerState {
            internal StatePlayerDown05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 811, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePlayerDown06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown06 : TriggerState {
            internal StatePlayerDown06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 812, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePlayerDown07(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {921});
            }
        }

        private class StatePlayerDown07 : TriggerState {
            internal StatePlayerDown07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 812, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMoveToNextMap01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap01 : TriggerState {
            internal StateMoveToNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 63000021, arg2: 1, arg3: 9900);
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
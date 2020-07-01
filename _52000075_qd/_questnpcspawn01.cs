namespace Maple2.Trigger._52000075_qd {
    public static class _questnpcspawn01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017}, arg2: false);
                context.CreateMonster(arg1: new[] {101, 201}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002668}, arg3: new byte[] {3})) {
                    context.State = new StateRemoveNpc01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002668}, arg3: new byte[] {2})) {
                    context.State = new StateGuardDown01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002668}, arg3: new byte[] {1})) {
                    context.State = new StateGuardDown01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002667}, arg3: new byte[] {3})) {
                    context.State = new StateGuardDown01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002667}, arg3: new byte[] {2})) {
                    context.State = new StateGuardDown01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {40002667}, arg3: new byte[] {1})) {
                    context.State = new StateNpcChange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRemoveNpc01 : TriggerState {
            internal StateRemoveNpc01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 201});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017}, arg2: true);
                context.DestroyMonster(arg1: new[] {101, 201});
                context.CreateMonster(arg1: new[] {202, 900, 901, 902}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {900, 901, 902})) {
                    context.State = new StateMobChange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobChange01 : TriggerState {
            internal StateMobChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMobChange02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobChange02 : TriggerState {
            internal StateMobChange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000075, arg2: 10);
                context.CreateMonster(arg1: new[] {301}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMobChange03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobChange03 : TriggerState {
            internal StateMobChange03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMobChange04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobChange04 : TriggerState {
            internal StateMobChange04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMobTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobTalk01 : TriggerState {
            internal StateMobTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001960, arg3: "$52000075_QD__QUESTNPCSPAWN01__0$", arg4: 4);
                context.SetSkip(arg1: "MobTalk02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateMobTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobTalk02 : TriggerState {
            internal StateMobTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMobTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobTalk03 : TriggerState {
            internal StateMobTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: false);
                context.DestroyMonster(arg1: new[] {301});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestComplete01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete01 : TriggerState {
            internal StateQuestComplete01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "abductedRamon");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateGuardDown01 : TriggerState {
            internal StateGuardDown01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 201});
                context.CreateMonster(arg1: new[] {202}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
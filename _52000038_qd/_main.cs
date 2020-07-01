namespace Maple2.Trigger._52000038_qd {
    public static class _main {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20020010);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002632}, arg3: new byte[] {3})) {
                    context.SetActor(arg1: 3001, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3002, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3003, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3004, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3005, arg2: false, arg3: "Dead_A");
                    context.State = new Statescene_c_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002632}, arg3: new byte[] {2})) {
                    context.SetActor(arg1: 3001, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3002, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3003, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3004, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3005, arg2: false, arg3: "Dead_A");
                    context.CreateMonster(arg1: new[] {131, 132}, arg2: true);
                    context.State = new Statescene_c_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002631}, arg3: new byte[] {3})) {
                    context.SetActor(arg1: 3001, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3002, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3003, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3004, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3005, arg2: false, arg3: "Dead_A");
                    context.CreateMonster(arg1: new[] {131, 132}, arg2: true);
                    context.State = new Statescene_c_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002631}, arg3: new byte[] {2})) {
                    context.SetActor(arg1: 3001, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3002, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3003, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3004, arg2: false, arg3: "Dead_A");
                    context.SetActor(arg1: 3005, arg2: false, arg3: "Dead_A");
                    context.CreateMonster(arg1: new[] {131, 132}, arg2: true);
                    context.State = new Statescene_c_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002631}, arg3: new byte[] {1})) {
                    context.CreateMonster(arg1: new[] {121, 122}, arg2: true);
                    context.State = new Statescene_b_02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002630}, arg3: new byte[] {3})) {
                    context.State = new Statescene_b_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002630}, arg3: new byte[] {2})) {
                    context.State = new Statescene_b_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002630}, arg3: new byte[] {1})) {
                    context.State = new Stateready_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready_02 : TriggerState {
            internal Stateready_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {40002630}, arg3: new byte[] {1})) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2001");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000038_QD__MAIN__0$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2002");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000038_QD__MAIN__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_03 : TriggerState {
            internal Statestart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2003");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000038_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statestart_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_04 : TriggerState {
            internal Statestart_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2004");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000038_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statestart_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_05 : TriggerState {
            internal Statestart_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statestart_05_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_05_b : TriggerState {
            internal Statestart_05_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3001, arg2: false, arg3: "Dead_A");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2005");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000038_QD__MAIN__4$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2006");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000038_QD__MAIN__5$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statestart_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_06 : TriggerState {
            internal Statestart_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202, 203, 204, 205}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statestart_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_07 : TriggerState {
            internal Statestart_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3002, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 3003, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 3004, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 3005, arg2: false, arg3: "Dead_A");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2007");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000038_QD__MAIN__6$", arg4: 2, arg5: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_2008");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000038_QD__MAIN__7$", arg4: 2, arg5: 4);
                context.ShowGuideSummary(entityId: 40010, textId: 40010);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203, 204, 205})) {
                    context.DestroyMonster(arg1: new[] {101, 102});
                    context.HideGuideSummary(entityId: 40010);
                    context.State = new Statescene_b_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_b_01 : TriggerState {
            internal Statescene_b_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "beyondroid1");
                context.CreateMonster(arg1: new[] {111, 112}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002631}, arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new[] {111, 112});
                    context.CreateMonster(arg1: new[] {121, 122}, arg2: true);
                    context.State = new Statescene_b_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_b_02 : TriggerState {
            internal Statescene_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 121, arg2: "MS2PatrolData_2009");
                context.SetConversation(arg1: 1, arg2: 121, arg3: "$52000038_QD__MAIN__8$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new Statescene_b_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_b_03 : TriggerState {
            internal Statescene_b_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 122, arg2: "MS2PatrolData_2010");
                context.SetConversation(arg1: 1, arg2: 122, arg3: "$52000038_QD__MAIN__9$", arg4: 2, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new Statescene_b_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_b_04 : TriggerState {
            internal Statescene_b_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103}, arg2: true);
                context.ShowGuideSummary(entityId: 20020010, textId: 20020010);
                context.SetConversation(arg1: 1, arg2: 121, arg3: "$52000038_QD__MAIN__10$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {40002631}, arg3: new byte[] {2})) {
                    context.DestroyMonster(arg1: new[] {121, 122});
                    context.CreateMonster(arg1: new[] {131, 132}, arg2: true);
                    context.HideGuideSummary(entityId: 20020010);
                    context.State = new Statescene_c_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_c_01 : TriggerState {
            internal Statescene_c_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
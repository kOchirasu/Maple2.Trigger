namespace Maple2.Trigger._02000294_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: true);
                context.DestroyMonster(arg1: new[] {3001});
                context.DestroyMonster(arg1: new[] {3002});
                context.DestroyMonster(arg1: new[] {3003});
                context.DestroyMonster(arg1: new[] {3004});
                context.DestroyMonster(arg1: new[] {3005});
                context.DestroyMonster(arg1: new[] {3006});
                context.DestroyMonster(arg1: new[] {3007});
                context.DestroyMonster(arg1: new[] {3008});
                context.DestroyMonster(arg1: new[] {3009});
                context.DestroyMonster(arg1: new[] {3010});
                context.DestroyMonster(arg1: new[] {3011});
                context.DestroyMonster(arg1: new[] {3012});
                context.DestroyMonster(arg1: new[] {3013});
                context.DestroyMonster(arg1: new[] {3014});
                context.DestroyMonster(arg1: new[] {3015});
                context.DestroyMonster(arg1: new[] {3016});
                context.DestroyMonster(arg1: new[] {3017});
                context.DestroyMonster(arg1: new[] {3100});
                context.DestroyMonster(arg1: new[] {3101});
                context.DestroyMonster(arg1: new[] {3102});
                context.DestroyMonster(arg1: new[] {3103});
                context.DestroyMonster(arg1: new[] {3104});
                context.DestroyMonster(arg1: new[] {10000});
                context.SetAgent(arg1: "133", arg2: false);
                context.SetAgent(arg1: "134", arg2: false);
                context.SetAgent(arg1: "135", arg2: false);
                context.SetAgent(arg1: "136", arg2: false);
                context.SetAgent(arg1: "137", arg2: false);
                context.SetAgent(arg1: "138", arg2: false);
                context.SetAgent(arg1: "139", arg2: false);
                context.SetAgent(arg1: "140", arg2: false);
                context.SetAgent(arg1: "141", arg2: false);
                context.SetAgent(arg1: "142", arg2: false);
                context.SetAgent(arg1: "143", arg2: false);
                context.SetAgent(arg1: "144", arg2: false);
                context.SetAgent(arg1: "145", arg2: false);
                context.SetAgent(arg1: "146", arg2: false);
                context.SetAgent(arg1: "147", arg2: false);
                context.SetAgent(arg1: "148", arg2: false);
                context.SetAgent(arg1: "149", arg2: false);
                context.SetAgent(arg1: "150", arg2: false);
                context.SetAgent(arg1: "151", arg2: false);
                context.SetAgent(arg1: "152", arg2: false);
                context.SetAgent(arg1: "153", arg2: false);
                context.SetAgent(arg1: "154", arg2: false);
                context.SetAgent(arg1: "155", arg2: false);
                context.SetAgent(arg1: "156", arg2: false);
                context.SetAgent(arg1: "157", arg2: false);
                context.SetActor(arg1: 900, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {101, 102}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121,
                        122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        25000, 25001, 25002, 25003, 25004, 25005, 25006, 25007, 25008, 25009, 25010, 25011, 25012,
                        25013, 25014, 25015, 25016, 25017
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {300}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDungeonStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {10000}, arg2: false);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSkip(arg1: "GateOpen01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNpcMonologue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue01 : TriggerState {
            internal StateNpcMonologue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 10000, arg2: "MS2PatrolData_10000");
                context.SetConversation(arg1: 1, arg2: 10000, arg3: "$02000294_BF__MAIN__0$", arg4: 2, arg5: 0);
                context.SetSkip(arg1: "GateOpen01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateNpcMonologue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue02 : TriggerState {
            internal StateNpcMonologue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 10000, arg2: "MS2PatrolData_10001");
                context.SetConversation(arg1: 1, arg2: 10000, arg3: "$02000294_BF__MAIN__1$", arg4: 2, arg5: 0);
                context.SetSkip(arg1: "GateOpen01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGateOpen01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGateOpen01 : TriggerState {
            internal StateGateOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetActor(arg1: 900, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {300}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGateOpen02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGateOpen02 : TriggerState {
            internal StateGateOpen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 10000, arg2: "MS2PatrolData_10002");
                context.SetConversation(arg1: 1, arg2: 10000, arg3: "$02000294_BF__MAIN__2$", arg4: 3, arg5: 0);
                context.SetActor(arg1: 900, arg2: false, arg3: "Opened");
                context.SetMesh(arg1: new[] {301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314},
                    arg2: false, arg3: 1000, arg4: 500, arg5: 5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBattle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle01 : TriggerState {
            internal StateBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002941, textId: 20002941);
                context.CreateMonster(arg1: new[] {3001}, arg2: false);
                context.CreateMonster(arg1: new[] {3002}, arg2: false);
                context.CreateMonster(arg1: new[] {3003}, arg2: false);
                context.CreateMonster(arg1: new[] {3004}, arg2: false);
                context.CreateMonster(arg1: new[] {3005}, arg2: false);
                context.CreateMonster(arg1: new[] {3006}, arg2: false);
                context.CreateMonster(arg1: new[] {3007}, arg2: false);
                context.CreateMonster(arg1: new[] {3008}, arg2: false);
                context.CreateMonster(arg1: new[] {3009}, arg2: false);
                context.CreateMonster(arg1: new[] {3010}, arg2: false);
                context.CreateMonster(arg1: new[] {3011}, arg2: false);
                context.CreateMonster(arg1: new[] {3012}, arg2: false);
                context.CreateMonster(arg1: new[] {3013}, arg2: false);
                context.CreateMonster(arg1: new[] {3014}, arg2: false);
                context.CreateMonster(arg1: new[] {3015}, arg2: false);
                context.CreateMonster(arg1: new[] {3016}, arg2: false);
                context.CreateMonster(arg1: new[] {3017}, arg2: false);
                context.CreateMonster(arg1: new[] {3100}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateBattle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle02 : TriggerState {
            internal StateBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999992, key: "Battle_01", value: 1);
                context.CreateMonster(arg1: new[] {3101}, arg2: true);
                context.CreateMonster(arg1: new[] {3102}, arg2: true);
                context.CreateMonster(arg1: new[] {3103}, arg2: true);
                context.CreateMonster(arg1: new[] {3104}, arg2: true);
                context.HideGuideSummary(entityId: 20002941);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {3100})) {
                    context.State = new StateBattle03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattle03 : TriggerState {
            internal StateBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "133", arg2: true);
                context.SetAgent(arg1: "134", arg2: true);
                context.SetAgent(arg1: "135", arg2: true);
                context.SetAgent(arg1: "136", arg2: true);
                context.SetAgent(arg1: "137", arg2: true);
                context.SetAgent(arg1: "138", arg2: true);
                context.SetAgent(arg1: "139", arg2: true);
                context.SetAgent(arg1: "140", arg2: true);
                context.SetAgent(arg1: "141", arg2: true);
                context.SetAgent(arg1: "142", arg2: true);
                context.SetAgent(arg1: "143", arg2: true);
                context.SetAgent(arg1: "144", arg2: true);
                context.SetAgent(arg1: "145", arg2: true);
                context.SetAgent(arg1: "146", arg2: true);
                context.SetAgent(arg1: "147", arg2: true);
                context.SetAgent(arg1: "148", arg2: true);
                context.SetAgent(arg1: "149", arg2: true);
                context.SetAgent(arg1: "150", arg2: true);
                context.SetAgent(arg1: "151", arg2: true);
                context.SetAgent(arg1: "152", arg2: true);
                context.SetAgent(arg1: "153", arg2: true);
                context.SetAgent(arg1: "154", arg2: true);
                context.SetAgent(arg1: "155", arg2: true);
                context.SetAgent(arg1: "156", arg2: true);
                context.SetAgent(arg1: "157", arg2: true);
                context.DestroyMonster(arg1: new[] {3001});
                context.DestroyMonster(arg1: new[] {3002});
                context.DestroyMonster(arg1: new[] {3003});
                context.DestroyMonster(arg1: new[] {3004});
                context.DestroyMonster(arg1: new[] {3005});
                context.DestroyMonster(arg1: new[] {3006});
                context.DestroyMonster(arg1: new[] {3007});
                context.DestroyMonster(arg1: new[] {3008});
                context.DestroyMonster(arg1: new[] {3009});
                context.DestroyMonster(arg1: new[] {3010});
                context.DestroyMonster(arg1: new[] {3011});
                context.DestroyMonster(arg1: new[] {3012});
                context.DestroyMonster(arg1: new[] {3013});
                context.DestroyMonster(arg1: new[] {3014});
                context.DestroyMonster(arg1: new[] {3015});
                context.DestroyMonster(arg1: new[] {3016});
                context.DestroyMonster(arg1: new[] {3017});
                context.DestroyMonster(arg1: new[] {3018});
                context.DestroyMonster(arg1: new[] {3101});
                context.DestroyMonster(arg1: new[] {3102});
                context.DestroyMonster(arg1: new[] {3103});
                context.DestroyMonster(arg1: new[] {3104});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBattleEnd01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd01 : TriggerState {
            internal StateBattleEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "137", arg2: false);
                context.SetAgent(arg1: "138", arg2: false);
                context.SetAgent(arg1: "152", arg2: false);
                context.SetAgent(arg1: "153", arg2: false);
                context.MoveNpc(arg1: 10000, arg2: "MS2PatrolData_10003");
                context.SetConversation(arg1: 1, arg2: 10000, arg3: "$02000294_BF__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBattleEnd02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd02 : TriggerState {
            internal StateBattleEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 10000, arg3: "$02000294_BF__MAIN__4$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBattleEnd03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd03 : TriggerState {
            internal StateBattleEnd03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 10000, arg2: "MS2PatrolData_10004");
                context.SetConversation(arg1: 1, arg2: 10000, arg3: "$02000294_BF__MAIN__5$", arg4: 3, arg5: 0);
                context.SetMesh(arg1: new[] {101, 102}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBattleEnd04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd04 : TriggerState {
            internal StateBattleEnd04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002942, textId: 20002942);
                context.SetConversation(arg1: 1, arg2: 10000, arg3: "$02000294_BF__MAIN__6$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002942);
                context.DestroyMonster(arg1: new[] {3001});
                context.DestroyMonster(arg1: new[] {3002});
                context.DestroyMonster(arg1: new[] {3003});
                context.DestroyMonster(arg1: new[] {3004});
                context.DestroyMonster(arg1: new[] {3005});
                context.DestroyMonster(arg1: new[] {3006});
                context.DestroyMonster(arg1: new[] {3007});
                context.DestroyMonster(arg1: new[] {3008});
                context.DestroyMonster(arg1: new[] {3009});
                context.DestroyMonster(arg1: new[] {3010});
                context.DestroyMonster(arg1: new[] {3011});
                context.DestroyMonster(arg1: new[] {3012});
                context.DestroyMonster(arg1: new[] {3013});
                context.DestroyMonster(arg1: new[] {3014});
                context.DestroyMonster(arg1: new[] {3015});
                context.DestroyMonster(arg1: new[] {3016});
                context.DestroyMonster(arg1: new[] {3017});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
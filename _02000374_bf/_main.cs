namespace Maple2.Trigger._02000374_bf {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: false, arg3: "Closed_A");
                context.SetEventUI(arg1: 0, arg2: "0,3");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {6001}, arg2: false);
                context.SetMesh(arg1: new[] {6002}, arg2: true);
                context.SetEffect(arg1: new[] {7999, 7001, 7002, 7003, 7999, 7998, 7801, 7802, 7803}, arg2: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 700) == 1) {
                    return new StateReady_Idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle : TriggerState {
            internal StateReady_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateReady_Idle_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle_02 : TriggerState {
            internal StateReady_Idle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 100, textId: 40012);
                context.SetTimer(arg1: "10", arg2: 10, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 100);
            }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.PlaySystemSoundInBox(arg2: "System_Dark_Intro_Chord_01");
                context.SetProductionUI(arg1: 3, arg2: "$02000374_BF__MAIN__25$");
                context.SetTimer(arg1: "5", arg2: 5, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "1,3");
                context.SetEffect(arg1: new[] {7998}, arg2: true);
                context.SetMesh(arg1: new[] {6002}, arg2: false);
                context.SetActor(arg1: 4001, arg2: true, arg3: "Opened_A");
                context.SetPortal(arg1: 1, arg2: false, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State2Round(context);
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    return new State1Round_Talk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk : TriggerState {
            internal State1Round_Talk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__0$", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State2Round(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new State1Round_Talk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk_01 : TriggerState {
            internal State1Round_Talk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {110}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State2Round(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new State1Round_Talk_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk_02 : TriggerState {
            internal State1Round_Talk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__1$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__1$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State2Round(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    return new State1Round_Talk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk_03 : TriggerState {
            internal State1Round_Talk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__2$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State1Round_Talk_04(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State2Round(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk_04 : TriggerState {
            internal State1Round_Talk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State2Round(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round : TriggerState {
            internal State2Round(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__3$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2Round_Talk_00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Talk_00 : TriggerState {
            internal State2Round_Talk_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__26$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__27$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2Round_Talk_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Talk_01 : TriggerState {
            internal State2Round_Talk_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "2,3");
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetEffect(arg1: new[] {7801, 7802}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__28$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__29$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetSkill(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013}, arg2: true);
                    return new State2Round_Talk_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 8001, arg2: false);
                context.SetEffect(arg1: new[] {7001, 7002, 7003}, arg2: true);
            }
        }

        private class State2Round_Talk_02 : TriggerState {
            internal State2Round_Talk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2003");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__5$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__5$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State2Round_Talk_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Talk_03 : TriggerState {
            internal State2Round_Talk_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__6$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__6$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2Round_Spawn_Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_Random : TriggerState {
            internal State2Round_Spawn_Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 33f)) {
                    return new State2Round_Spawn_A(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new State2Round_Spawn_B(context);
                }

                if (context.RandomCondition(arg1: 33f)) {
                    return new State2Round_Spawn_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A : TriggerState {
            internal State2Round_Spawn_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__7$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__7$", arg4: 3, arg5: 0);
                context.SetUserValue(triggerId: 2037402, key: "2Round_A", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 85000)) {
                    return new State2Round_Spawn_A_02_Ready(context);
                }

                if (context.GetUserValue(key: "2Round_A") == 1) {
                    return new State2Round_Spawn_A_02_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B : TriggerState {
            internal State2Round_Spawn_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2004");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__8$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__8$", arg4: 3, arg5: 0);
                context.SetUserValue(triggerId: 2037403, key: "2Round_B", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 85000)) {
                    return new State2Round_Spawn_B_02_Ready(context);
                }

                if (context.GetUserValue(key: "2Round_B") == 1) {
                    return new State2Round_Spawn_B_02_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C : TriggerState {
            internal State2Round_Spawn_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2005");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__9$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__9$", arg4: 3, arg5: 0);
                context.SetUserValue(triggerId: 2037404, key: "2Round_C", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 85000)) {
                    return new State2Round_Spawn_C_02_Ready(context);
                }

                if (context.GetUserValue(key: "2Round_C") == 1) {
                    return new State2Round_Spawn_C_02_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_02_Ready : TriggerState {
            internal State2Round_Spawn_A_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__10$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__10$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2Round_Spawn_A_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_02_Ready : TriggerState {
            internal State2Round_Spawn_B_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__13$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__13$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2Round_Spawn_B_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_02_Ready : TriggerState {
            internal State2Round_Spawn_C_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__16$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__16$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2Round_Spawn_C_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_02 : TriggerState {
            internal State2Round_Spawn_A_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    return new State2Round_Spawn_A_B_02(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new State2Round_Spawn_A_C_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_B_02 : TriggerState {
            internal State2Round_Spawn_A_B_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2037403, key: "2Round_B", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    return new State2Round_Spawn_A_B_C(context);
                }

                if (context.GetUserValue(key: "2Round_B") == 1) {
                    return new State2Round_Spawn_A_B_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_C_02 : TriggerState {
            internal State2Round_Spawn_A_C_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2037404, key: "2Round_C", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    return new State2Round_Spawn_A_C_B(context);
                }

                if (context.GetUserValue(key: "2Round_C") == 1) {
                    return new State2Round_Spawn_A_C_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_B_C : TriggerState {
            internal State2Round_Spawn_A_B_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__11$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__11$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037404, key: "2Round_C", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State2Round_End_Condition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A_C_B : TriggerState {
            internal State2Round_Spawn_A_C_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__12$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__12$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037403, key: "2Round_B", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State2Round_End_Condition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_02 : TriggerState {
            internal State2Round_Spawn_B_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    return new State2Round_Spawn_B_A_02(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new State2Round_Spawn_B_C_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_A_02 : TriggerState {
            internal State2Round_Spawn_B_A_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2037402, key: "2Round_A", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    return new State2Round_Spawn_B_A_C(context);
                }

                if (context.GetUserValue(key: "2Round_A") == 1) {
                    return new State2Round_Spawn_B_A_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_C_02 : TriggerState {
            internal State2Round_Spawn_B_C_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2037404, key: "2Round_C", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    return new State2Round_Spawn_B_C_A(context);
                }

                if (context.GetUserValue(key: "2Round_C") == 1) {
                    return new State2Round_Spawn_B_C_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_A_C : TriggerState {
            internal State2Round_Spawn_B_A_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__14$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__14$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037404, key: "2Round_C", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State2Round_End_Condition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_B_C_A : TriggerState {
            internal State2Round_Spawn_B_C_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__15$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__15$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037402, key: "2Round_A", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State2Round_End_Condition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_02 : TriggerState {
            internal State2Round_Spawn_C_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    return new State2Round_Spawn_C_A_02(context);
                }

                if (context.RandomCondition(arg1: 50f)) {
                    return new State2Round_Spawn_C_B_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_A_02 : TriggerState {
            internal State2Round_Spawn_C_A_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2037402, key: "2Round_A", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    return new State2Round_Spawn_C_A_B(context);
                }

                if (context.GetUserValue(key: "2Round_A") == 1) {
                    return new State2Round_Spawn_C_A_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_B_02 : TriggerState {
            internal State2Round_Spawn_C_B_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2037403, key: "2Round_B", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 135000)) {
                    return new State2Round_Spawn_C_B_A(context);
                }

                if (context.GetUserValue(key: "2Round_B") == 1) {
                    return new State2Round_Spawn_C_B_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_A_B : TriggerState {
            internal State2Round_Spawn_C_A_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__18$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__18$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037403, key: "2Round_B", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State2Round_End_Condition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_C_B_A : TriggerState {
            internal State2Round_Spawn_C_B_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__17$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__17$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037402, key: "2Round_A", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State2Round_End_Condition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_End_Condition : TriggerState {
            internal State2Round_End_Condition(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102, 103, 104})) {
                    return new State3Round_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Round_Ready : TriggerState {
            internal State3Round_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3Round_Talk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk01 : TriggerState {
            internal State3Round_Talk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__19$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__19$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3Round_Talk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk02 : TriggerState {
            internal State3Round_Talk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "3,3");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__20$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__20$", arg4: 2, arg5: 0);
                context.SetUserValue(triggerId: 2037405, key: "3Round_Effect", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3Round_Talk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk03 : TriggerState {
            internal State3Round_Talk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__21$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__21$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new[] {7206}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State3Round_Talk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk04 : TriggerState {
            internal State3Round_Talk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {199}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 199, arg3: "$02000374_BF__MAIN__30$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3Round_Talk05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk05 : TriggerState {
            internal State3Round_Talk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {199});
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__31$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__32$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3Round_Talk06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk06 : TriggerState {
            internal State3Round_Talk06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__22$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__22$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new[] {7205}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2300)) {
                    return new State3Round_Talk07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Round_Talk07 : TriggerState {
            internal State3Round_Talk07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__23$", arg4: 2, arg5: 0);
                context.CreateMonster(arg1: new[] {105}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {105})) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000374, arg2: 6);
                context.SetActor(arg1: 4002, arg2: true, arg3: "Opened_A");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_2999");
                context.SetEventUI(arg1: 7, arg2: "$02000374_BF__MAIN__33$", arg3: 3000, arg4: "0");
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__24$", arg4: 2, arg5: 1);
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

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: true, arg3: "Closed_A");
                context.SetEventUI(arg1: 1, arg2: "$02000374_BF__MAIN__34$", arg3: 3000);
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000374_BF__MAIN__35$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new[] {4102}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_02 : TriggerState {
            internal StateEnd_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4002, arg2: false, arg3: "Closed_A");
                context.DestroyMonster(arg1: new[] {110});
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
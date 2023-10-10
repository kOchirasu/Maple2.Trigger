namespace Maple2.Trigger._61000009_me {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4002, visible: false, initialSequence: "Closed_A");
                context.SetEventUI(arg1: 0, script: "0,3");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{6001}, visible: false);
                context.SetMesh(triggerIds: new []{6002}, visible: true);
                context.SetEffect(triggerIds: new []{7999, 7001, 7002, 7003, 7999, 7998, 7801, 7802, 7803}, visible: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateReady_Idle_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle_02 : TriggerState {
            internal StateReady_Idle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.SetTimer(timerId: "30", seconds: 30, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new StateStart_02(context);
                }

                if (context.GetUserCount(boxId: 700) == 10) {
                    return new StateStart_02(context);
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
                context.SetCinematicUI(type: 1);
                context.PlaySystemSoundInBox(sound: "System_Dark_Intro_Chord_01");
                context.SetCinematicUI(type: 3, script: "$02000374_BF__MAIN__25$");
                context.SetTimer(timerId: "5", seconds: 5, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 700, type: "trigger", code: "dailyquest_start");
                context.SetUserValue(triggerId: 2037406, key: "timer", value: 1);
                context.SetEventUI(arg1: 0, script: "1,3");
                context.SetEffect(triggerIds: new []{7998}, visible: true);
                context.SetMesh(triggerIds: new []{6002}, visible: false);
                context.SetActor(triggerId: 4001, visible: true, initialSequence: "Opened_A");
                context.SetPortal(portalId: 1, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State2Round(context);
                }

                if (context.UserDetected(boxIds: new []{701})) {
                    return new State1Round_Talk(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk : TriggerState {
            internal State1Round_Talk(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__0$", duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
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
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__1$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__1$", arg4: 3, arg5: 0);
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__2$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State1Round_Talk_04(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State2Round(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1Round_Talk_04 : TriggerState {
            internal State1Round_Talk_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State2Round(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round : TriggerState {
            internal State2Round(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__3$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__26$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__27$", arg4: 3, arg5: 0);
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 0, script: "2,3");
                context.CameraSelect(triggerId: 8001, enabled: true);
                context.SetEffect(triggerIds: new []{7801, 7802}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__28$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__29$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetSkill(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013}, enabled: true);
                    return new State2Round_Talk_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 8001, enabled: false);
                context.SetEffect(triggerIds: new []{7001, 7002, 7003}, visible: true);
            }
        }

        private class State2Round_Talk_02 : TriggerState {
            internal State2Round_Talk_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2003");
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__5$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__5$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__6$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__6$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 33)) {
                    return new State2Round_Spawn_A(context);
                }

                if (context.RandomCondition(rate: 33)) {
                    return new State2Round_Spawn_B(context);
                }

                if (context.RandomCondition(rate: 33)) {
                    return new State2Round_Spawn_C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2Round_Spawn_A : TriggerState {
            internal State2Round_Spawn_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__7$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__7$", arg4: 3, arg5: 0);
                context.SetUserValue(triggerId: 2037402, key: "2Round_A", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2004");
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__8$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__8$", arg4: 3, arg5: 0);
                context.SetUserValue(triggerId: 2037403, key: "2Round_B", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2005");
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__9$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__9$", arg4: 3, arg5: 0);
                context.SetUserValue(triggerId: 2037404, key: "2Round_C", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__10$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__10$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__13$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__13$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__16$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__16$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new State2Round_Spawn_A_B_02(context);
                }

                if (context.RandomCondition(rate: 50)) {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__11$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__11$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037404, key: "2Round_C", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__12$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__12$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037403, key: "2Round_B", value: 1);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new State2Round_Spawn_B_A_02(context);
                }

                if (context.RandomCondition(rate: 50)) {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__14$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__14$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037404, key: "2Round_C", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__15$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__15$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037402, key: "2Round_A", value: 1);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50)) {
                    return new State2Round_Spawn_C_A_02(context);
                }

                if (context.RandomCondition(rate: 50)) {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__18$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__18$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037403, key: "2Round_B", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__17$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__17$", arg4: 3, arg5: 1);
                context.SetUserValue(triggerId: 2037402, key: "2Round_A", value: 1);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{102, 103, 104})) {
                    return new State3Round_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3Round_Ready : TriggerState {
            internal State3Round_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__19$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__19$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 0, script: "3,3");
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__20$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__20$", arg4: 2, arg5: 0);
                context.SetUserValue(triggerId: 2037405, key: "3Round_Effect", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__21$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__21$", arg4: 2, arg5: 0);
                context.SetEffect(triggerIds: new []{7206}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{199}, arg2: false);
                context.SetConversation(type: 1, spawnId: 199, script: "$02000374_BF__MAIN__30$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{199});
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__31$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__32$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__22$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__22$", arg4: 2, arg5: 0);
                context.SetEffect(triggerIds: new []{7205}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__23$", arg4: 2, arg5: 0);
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{105})) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 61000009, portalId: 6);
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Opened_A");
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2999");
                context.SetEventUI(arg1: 7, script: "$02000374_BF__MAIN__33$", duration: 3000, boxId: 0);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__24$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Closed_A");
                context.SetEventUI(arg1: 1, script: "$02000374_BF__MAIN__34$", duration: 3000);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000374_BF__MAIN__35$", arg4: 2, arg5: 0);
                context.SetEffect(triggerIds: new []{4102}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 4002, visible: false, initialSequence: "Closed_A");
                context.DestroyMonster(spawnIds: new []{110});
                context.SetPortal(portalId: 3, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

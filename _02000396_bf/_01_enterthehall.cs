namespace Maple2.Trigger._02000396_bf {
    public static class _01_enterthehall {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5004}, arg2: false);
                context.SetActor(arg1: 4004, arg2: true, arg3: "Closed");
                context.SetLadder(arg1: 511, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 512, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new[] {101, 102});
                context.DestroyMonster(arg1: new[] {901, 902, 903});
                context.SetAgent(arg1: "8006,8007,8008,8009", arg2: true);
                context.SetUserValue(key: "MobClear", value: 0);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
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
                    context.State = new StateBlackeyeApp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlackeyeApp01 : TriggerState {
            internal StateBlackeyeApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBlackeyeApp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlackeyeApp02 : TriggerState {
            internal StateBlackeyeApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000396_BF__01_ENTERTHEHALL__0$", arg4: 3,
                    arg5: 1);
                context.SetSkip(arg1: "BlackeyeApp02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateBlackeyeApp02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlackeyeApp02Skip : TriggerState {
            internal StateBlackeyeApp02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointId: 101);
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateBlackeyeApp03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlackeyeApp03 : TriggerState {
            internal StateBlackeyeApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000396_BF__01_ENTERTHEHALL__1$", arg4: 3,
                    arg5: 0);
                context.SetSkip(arg1: "BlackeyeApp03Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBlackeyeApp03Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlackeyeApp03Skip : TriggerState {
            internal StateBlackeyeApp03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointId: 101);
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEnemyApp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyApp01 : TriggerState {
            internal StateEnemyApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetUserValue(triggerId: 2, key: "MobSpawn", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEnemyApp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyApp02 : TriggerState {
            internal StateEnemyApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {901, 902, 903}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 901, arg3: "$02000396_BF__01_ENTERTHEHALL__2$", arg4: 2,
                    arg5: 1);
                context.SetConversation(arg1: 1, arg2: 902, arg3: "$02000396_BF__01_ENTERTHEHALL__3$", arg4: 2,
                    arg5: 1);
                context.SetConversation(arg1: 1, arg2: 903, arg3: "$02000396_BF__01_ENTERTHEHALL__4$", arg4: 2,
                    arg5: 1);
                context.SetSkip(arg1: "EnemyApp03Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateEnemyApp03Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyApp03Skip : TriggerState {
            internal StateEnemyApp03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointId: 901);
                context.RemoveBalloonTalk(spawnPointId: 902);
                context.RemoveBalloonTalk(spawnPointId: 903);
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEnemyApp03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyApp03 : TriggerState {
            internal StateEnemyApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_104");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBlackeyeAction01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlackeyeAction01 : TriggerState {
            internal StateBlackeyeAction01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000396_BF__01_ENTERTHEHALL__5$", arg4: 5);
                context.SetSkip(arg1: "BlackeyeAction01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateBlackeyeAction01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlackeyeAction01Skip : TriggerState {
            internal StateBlackeyeAction01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBlackeyeAction02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlackeyeAction02 : TriggerState {
            internal StateBlackeyeAction02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000396_BF__01_ENTERTHEHALL__6$", arg4: 3,
                    arg5: 1);
                context.SetLadder(arg1: 511, arg2: true, arg3: true, arg4: 1);
                context.SetLadder(arg1: 512, arg2: true, arg3: true, arg4: 1);
                context.SetUserValue(triggerId: 2, key: "MobAttack", value: 1);
                context.SetUserValue(triggerId: 10, key: "TrapOn", value: 1);
                context.SetUserValue(triggerId: 11, key: "TrapOn", value: 1);
                context.SetUserValue(triggerId: 12, key: "TrapOn", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateBlackeyeAction03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlackeyeAction03 : TriggerState {
            internal StateBlackeyeAction03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039601, textId: 20039601, duration: 3000);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "MobClear") == 1) {
                    context.State = new StateMoveToUpstairs01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToUpstairs01 : TriggerState {
            internal StateMoveToUpstairs01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8006,8007,8008,8009", arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_102");
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.SetActor(arg1: 4004, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {3007}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 3, key: "EnableLadder", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateMoveToUpstairs02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToUpstairs02 : TriggerState {
            internal StateMoveToUpstairs02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000006, arg3: "$02000396_BF__01_ENTERTHEHALL__7$", arg4: 5);
                context.SetSkip(arg1: "MoveToUpstairs02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateMoveToUpstairs02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToUpstairs02Skip : TriggerState {
            internal StateMoveToUpstairs02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039602, textId: 20039602, duration: 3000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    context.State = new StateFindWayOut01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFindWayOut01 : TriggerState {
            internal StateFindWayOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_103");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: "$02000396_BF__01_ENTERTHEHALL__8$", arg3: 4000,
                    arg4: "0");
                context.SetUserValue(triggerId: 4, key: "SearchStart", value: 1);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9100, arg2: new[] {102})) {
                    context.State = new StateNpcMonologueRandom(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologueRandom : TriggerState {
            internal StateNpcMonologueRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNpcMonologue01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNpcMonologue02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNpcMonologue03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNpcMonologue04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue01 : TriggerState {
            internal StateNpcMonologue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000396_BF__01_ENTERTHEHALL__9$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateNpcMonologueRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "FindWay") == 1) {
                    context.State = new StateNpcLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue02 : TriggerState {
            internal StateNpcMonologue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000396_BF__01_ENTERTHEHALL__10$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateNpcMonologueRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "FindWay") == 1) {
                    context.State = new StateNpcLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue03 : TriggerState {
            internal StateNpcMonologue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000396_BF__01_ENTERTHEHALL__11$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateNpcMonologueRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "FindWay") == 1) {
                    context.State = new StateNpcLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue04 : TriggerState {
            internal StateNpcMonologue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000396_BF__01_ENTERTHEHALL__12$", arg4: 3,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateNpcMonologueRandom(context);
                    return;
                }

                if (context.GetUserValue(key: "FindWay") == 1) {
                    context.State = new StateNpcLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcLeave01 : TriggerState {
            internal StateNpcLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointId: 102);
                context.DestroyMonster(arg1: new[] {102});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
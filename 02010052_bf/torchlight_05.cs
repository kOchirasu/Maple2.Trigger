namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_05 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7542}, visible: false);
                context.SetMesh(triggerIds: new []{6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6081, 6082}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{7005}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 708) == 1) {
                    return new StateFreeze(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFreeze : TriggerState {
            internal StateFreeze(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7542}, visible: true);
                context.SetConversation(type: 1, spawnId: 994, script: "$02010052_BF__TORCHLIGHT_05__0$", arg4: 3);
                context.SetMesh(triggerIds: new []{6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6081, 6082}, visible: true, arg3: 80, arg4: 100, arg5: 8f);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateIdle_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle_02 : TriggerState {
            internal StateIdle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{105})) {
                    return new StateBurn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state : TriggerState {
            internal StateBurn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7505}, visible: true);
                context.SetMesh(triggerIds: new []{6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6081, 6082}, visible: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetMesh(triggerIds: new []{600001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02010052_BF__TORCHLIGHT_05__1$", duration: 3000);
                context.SetEffect(triggerIds: new []{7005}, visible: true);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSpawn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_state : TriggerState {
            internal StateSpawn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 205, textId: 20105202);
                context.SetConversation(type: 1, spawnId: 994, script: "$02010052_BF__TORCHLIGHT_05__2$", arg4: 3);
                context.MoveNpc(spawnId: 994, patrolName: "MS2PatrolData_1007");
                context.CreateMonster(spawnIds: new []{510, 511, 512, 513, 514, 515}, arg2: true);
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateBlock_spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_spawn : TriggerState {
            internal StateBlock_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090}, visible: true, arg3: 80, arg4: 500, arg5: 8f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

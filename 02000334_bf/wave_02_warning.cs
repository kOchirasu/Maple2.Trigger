namespace Maple2.Trigger._02000334_bf {
    public static class _wave_02_warning {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90099, spawnIds: new []{151})) {
                    return new State1차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State돌격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌격 : TriggerState {
            internal State돌격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{98001}, visible: true);
                context.SetConversation(type: 1, spawnId: 190, script: "$02000334_BF__WAVE__2$", arg4: 3);
                context.MoveNpc(spawnId: 190, patrolName: "MS2PatrolData_3501");
                context.CreateMonster(spawnIds: new []{991, 993, 994}, arg2: true);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateCamera_복구(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_복구 : TriggerState {
            internal StateCamera_복구(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{98006}, visible: true);
                context.AddBuff(boxIds: new []{90001}, skillId: 70000068, level: 1);
                context.MoveNpc(spawnId: 199, patrolName: "MS2PatrolData_3502");
                context.SetConversation(type: 1, spawnId: 199, script: "$02000334_BF__WAVE__3$", arg4: 3);
                context.CameraSelectPath(pathIds: new []{8017}, returnView: false);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new State돌격2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌격2 : TriggerState {
            internal State돌격2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{98001}, visible: true);
                context.MoveNpc(spawnId: 190, patrolName: "MS2PatrolData_3501");
                context.SetConversation(type: 1, spawnId: 190, script: "$02000334_BF__WAVE__4$", arg4: 3);
                context.CreateMonster(spawnIds: new []{992, 995}, arg2: true);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateCamera_복구2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera_복구2 : TriggerState {
            internal StateCamera_복구2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{98006}, visible: true);
                context.AddBuff(boxIds: new []{90001}, skillId: 70000068, level: 1);
                context.MoveNpc(spawnId: 199, patrolName: "MS2PatrolData_3502");
                context.SetConversation(type: 1, spawnId: 199, script: "$02000334_BF__WAVE__5$", arg4: 3);
                context.CameraSelectPath(pathIds: new []{8017}, returnView: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

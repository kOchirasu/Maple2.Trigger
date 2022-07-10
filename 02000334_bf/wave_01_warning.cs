namespace Maple2.Trigger._02000334_bf {
    public static class _wave_01_warning {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90099, spawnIds: new []{150})) {
                    return new State1차타이머(context);
                }

                if (context.MonsterDead(spawnIds: new []{999})) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
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
                context.MoveNpc(spawnId: 190, patrolName: "MS2PatrolData_3501");
                context.SetConversation(type: 1, spawnId: 190, script: "$02000334_BF__WAVE__0$", arg4: 3);
                context.CreateMonster(spawnIds: new []{991, 992, 993}, arg2: true);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateCamera복구(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera복구 : TriggerState {
            internal StateCamera복구(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{98006}, visible: true);
                context.MoveNpc(spawnId: 199, patrolName: "MS2PatrolData_3502");
                context.AddBuff(boxIds: new []{90001}, skillId: 70000068, level: 1);
                context.SetConversation(type: 1, spawnId: 199, script: "$02000334_BF__WAVE__1$", arg4: 3);
                context.CameraSelectPath(pathIds: new []{8017}, returnView: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

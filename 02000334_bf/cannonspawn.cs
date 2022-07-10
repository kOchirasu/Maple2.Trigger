namespace Maple2.Trigger._02000334_bf {
    public static class _cannonspawn {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CannonSpawn") == 1) {
                    return new StateCannonSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCannonSpawn : TriggerState {
            internal StateCannonSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 190, script: "$02000334_BF__WAVE__12$", arg4: 3, arg5: 1);
                context.SetConversation(type: 1, spawnId: 199, script: "$02000334_BF__MAIN__12$", arg4: 3, arg5: 3);
                context.SetTimer(timerId: "3", seconds: 3, display: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateCannonSpawn_start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCannonSpawn_start : TriggerState {
            internal StateCannonSpawn_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9999131, key: "cannon_01", value: 1);
                context.SetUserValue(triggerId: 9999132, key: "cannon_02", value: 1);
                context.SetUserValue(triggerId: 9999133, key: "cannon_03", value: 1);
                context.CreateMonster(spawnIds: new []{301, 302, 303}, arg2: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 102, textId: 20000020);
                context.SetEffect(triggerIds: new []{90021}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{190})) {
                    return new StateClear(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 102);
            }
        }

        private class StateClear : TriggerState {
            internal StateClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

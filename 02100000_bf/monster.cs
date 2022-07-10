namespace Maple2.Trigger._02100000_bf {
    public static class _monster {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetMesh(triggerIds: new []{80001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{9500001, 9500002, 9500003, 9500004, 9500005, 9500006, 9500007, 9500008, 9500009, 9500010, 9600001, 9600002, 9600003, 9600004, 9600005, 9600006, 9600007, 9600008, 9600009, 9600010, 9600011, 9600012, 9600013, 9600014}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return new StateUserDetection(context);
            }

            public override void OnExit() { }
        }

        private class StateUserDetection : TriggerState {
            internal StateUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: true);
                context.SetPortal(portalId: 19, visible: false, enabled: false, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{80001, 800011, 81001}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterDead_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead_1 : TriggerState {
            internal StateMonsterDead_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{80001})) {
                    return new StateMonsterSpawn_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_2 : TriggerState {
            internal StateMonsterSpawn_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{80002, 800021, 810021}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterDead_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead_2 : TriggerState {
            internal StateMonsterDead_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{80002, 800021, 800011})) {
                    return new StateMonsterSpawn_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_3 : TriggerState {
            internal StateMonsterSpawn_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{81001, 81002, 810021});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9500001, 9500002, 9500003, 9500004, 9500005, 9500006, 9500007, 9500008, 9500009, 9500010}, visible: true, arg3: 0, arg4: 90, arg5: 1f);
                context.SetMesh(triggerIds: new []{9600001, 9600002, 9600003, 9600004, 9600005, 9600006, 9600007, 9600008, 9600009, 9600010, 9600011, 9600012, 9600013, 9600014}, visible: true, arg3: 0, arg4: 90, arg5: 1f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State길Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State길Creation : TriggerState {
            internal State길Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{80001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

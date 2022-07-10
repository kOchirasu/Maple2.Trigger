namespace Maple2.Trigger._02020061_bf {
    public static class _boss_object1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(spawnIds: new []{711, 721});
                context.SetInteractObject(interactIds: new []{12000094}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 1) {
                    return new StateLever1_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever1_체크 : TriggerState {
            internal StateLever1_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{721}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{711})) {
                    return new StateLever1_발동(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever1_발동 : TriggerState {
            internal StateLever1_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetInteractObject(interactIds: new []{12000094}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000094}, arg2: 0)) {
                    return new StateLever1_안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever1_안내 : TriggerState {
            internal StateLever1_안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLever1_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever1_재활성 : TriggerState {
            internal StateLever1_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000094}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000094}, arg2: 0)) {
                    return new StateLever1_재활성_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever1_재활성_Wait : TriggerState {
            internal StateLever1_재활성_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossObjectStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.MonsterDead(spawnIds: new []{921, 922, 923, 924, 925, 926})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateLever1_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetUserValue(triggerId: 99990023, key: "MonsterSpawn", value: 0);
                context.DestroyMonster(spawnIds: new []{711, 721});
                context.SetInteractObject(interactIds: new []{12000094}, state: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

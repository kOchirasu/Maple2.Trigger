namespace Maple2.Trigger._02020062_bf {
    public static class _object3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5201}, visible: false);
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 0);
                context.SetInteractObject(interactIds: new []{12000109}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 1) {
                    return new StateLever3_Guide메시지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_Guide메시지 : TriggerState {
            internal StateLever3_Guide메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{723}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.UserDetected(boxIds: new []{9013})) {
                    context.SetEventUI(arg1: 1, script: "$02020062_BF__OBJECT3__0$", duration: 5000, boxId: 9013);
                    return new StateLever3_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_체크 : TriggerState {
            internal StateLever3_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{713})) {
                    return new StateLever3_발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_발동 : TriggerState {
            internal StateLever3_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5201}, visible: true);
                context.SetInteractObject(interactIds: new []{12000109}, state: 1);
                context.SetEventUI(arg1: 1, script: "$02020062_BF__OBJECT3__1$", duration: 5000, boxId: 9013);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{701})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000109}, arg2: 0)) {
                    return new StateLever3_MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_MonsterSpawn : TriggerState {
            internal StateLever3_MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{701})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    return new StateLever3_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_재활성 : TriggerState {
            internal StateLever3_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000109}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2 && context.MonsterDead(spawnIds: new []{701})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000109}, arg2: 0)) {
                    return new StateLever3_재활성_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever3_재활성_Wait : TriggerState {
            internal StateLever3_재활성_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 2 && context.MonsterDead(spawnIds: new []{701})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    return new StateLever3_재활성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5201}, visible: false);
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 2);
                context.DestroyMonster(spawnIds: new []{723}, arg2: false);
                context.SetInteractObject(interactIds: new []{12000109}, state: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

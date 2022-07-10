namespace Maple2.Trigger._02020061_bf {
    public static class _object1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 0);
                context.SetInteractObject(interactIds: new []{12000084}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 1) {
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
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{711})) {
                    return new StateLever1_발동(context);
                }

                if (context.UserDetected(boxIds: new []{9011})) {
                    return new StateLever1_안내MassiveEvent(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever1_안내MassiveEvent : TriggerState {
            internal StateLever1_안내MassiveEvent(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020061_BF__OBJECT1__0$", duration: 5000, boxId: 9011);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{711})) {
                    return new StateLever1_발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever1_발동 : TriggerState {
            internal StateLever1_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetInteractObject(interactIds: new []{12000084}, state: 1);
                context.SetEventUI(arg1: 1, script: "$02020061_BF__OBJECT1__1$", duration: 5000, boxId: 9011);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{701})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000084}, arg2: 0)) {
                    return new StateLever1_MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLever1_MonsterSpawn : TriggerState {
            internal StateLever1_MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{701})) {
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
                context.SetInteractObject(interactIds: new []{12000084}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{701})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{12000084}, arg2: 0)) {
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
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{701})) {
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
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 2);
                context.DestroyMonster(spawnIds: new []{721}, arg2: false);
                context.SetInteractObject(interactIds: new []{12000084}, state: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

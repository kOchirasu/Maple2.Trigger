namespace Maple2.Trigger._80000015_bonus {
    public static class _train_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3100}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3701, 3702, 3703}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{121})) {
                    return new State아이템체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이템체크 : TriggerState {
            internal State아이템체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "itemSpawn") == 1) {
                    return new StateCreation(context);
                }

                if (context.WaitTick(waitTick: 200)) {
                    context.CreateItem(spawnIds: new []{9020, 9021, 9022, 9023, 9024, 9025}, arg5: 15);
                    context.SetUserValue(key: "itemSpawn", value: 1);
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1200}, arg2: false);
                context.SetMesh(triggerIds: new []{3100}, visible: false, arg3: 500, arg4: 0, arg5: 0f);
                context.AddBuff(boxIds: new []{1200}, skillId: 60170051, level: 1, arg4: true, arg5: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State삼(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State삼 : TriggerState {
            internal State삼(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3703}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이 : TriggerState {
            internal State이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3703}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3702}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State일(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State일 : TriggerState {
            internal State일(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3702}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3701}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State출발(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State출발 : TriggerState {
            internal State출발(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3701}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 1200, patrolName: "MS2PatrolData1200A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 122, spawnIds: new []{1200})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.DestroyMonster(spawnIds: new []{1200});
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

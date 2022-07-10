namespace Maple2.Trigger._80000015_bonus {
    public static class _train_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3200, 3210}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3704, 3705, 3706}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{123})) {
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
                    context.CreateItem(spawnIds: new []{9026, 9027, 9028, 9029, 9030, 9031}, arg5: 15);
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
                context.CreateMonster(spawnIds: new []{1201}, arg2: false);
                context.SetMesh(triggerIds: new []{3200}, visible: false, arg3: 500, arg4: 0, arg5: 0f);
                context.AddBuff(boxIds: new []{1201}, skillId: 60170051, level: 1, arg4: true, arg5: true);
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
                context.SetMesh(triggerIds: new []{3706}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{3706}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3705}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{3705}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3704}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{3704}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(spawnId: 1201, patrolName: "MS2PatrolData1201A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 124, spawnIds: new []{1201})) {
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
                    context.DestroyMonster(spawnIds: new []{1201});
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

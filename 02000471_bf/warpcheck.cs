namespace Maple2.Trigger._02000471_bf {
    public static class _warpcheck {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040318, key: "InteractClear", value: 0);
                context.SetUserValue(triggerId: 2040323, key: "Warp", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Boss") == 1) {
                    return new StateWarp_condition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_condition : TriggerState {
            internal StateWarp_condition(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnId: 1999) <= 0.70f) {
                    return new StateWarp_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_1st : TriggerState {
            internal StateWarp_1st(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002106, 10002107}, state: 1);
                context.SetMesh(triggerIds: new []{1207, 1208}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02000471_BF__WARPCHECK__0$", duration: 5000, boxId: 0);
                context.AddBuff(boxIds: new []{720}, skillId: 70002061, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWarp_go(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002106}, arg2: 0)) {
                    return new StateWarp_cancel(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002107}, arg2: 0)) {
                    return new StateWarp_cancel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_cancel : TriggerState {
            internal StateWarp_cancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002106, 10002107}, state: 0);
                context.SetMesh(triggerIds: new []{1207, 1208}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02000471_BF__WARPCHECK__1$", duration: 5000, boxId: 0);
                context.AddBuff(boxIds: new []{720}, skillId: 70002062, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnId: 1999) <= 0.30f) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_go : TriggerState {
            internal StateWarp_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002106, 10002107}, state: 0);
                context.SetMesh(triggerIds: new []{1207, 1208}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 2040323, key: "Warp", value: 1);
                context.AddBuff(boxIds: new []{720}, skillId: 70002062, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnId: 1999) <= 0.30f) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_2nd : TriggerState {
            internal StateWarp_2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002106, 10002107}, state: 1);
                context.SetMesh(triggerIds: new []{1207, 1208}, visible: true, arg3: 0, arg4: 0, arg5: 10f);
                context.SetEventUI(arg1: 1, script: "$02000471_BF__WARPCHECK__0$", duration: 5000, boxId: 0);
                context.AddBuff(boxIds: new []{720}, skillId: 70002061, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWarp_go2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002106}, arg2: 0)) {
                    return new StateWarp2_cancel(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002107}, arg2: 0)) {
                    return new StateWarp2_cancel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp2_cancel : TriggerState {
            internal StateWarp2_cancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002106, 10002107}, state: 0);
                context.SetMesh(triggerIds: new []{1207, 1208}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02000471_BF__WARPCHECK__1$", duration: 5000, boxId: 0);
                context.AddBuff(boxIds: new []{720}, skillId: 70002062, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateEnd(context);
                }

                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateWarp_go2 : TriggerState {
            internal StateWarp_go2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002106, 10002107}, state: 0);
                context.SetMesh(triggerIds: new []{1207, 1208}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 2040323, key: "Warp", value: 2);
                context.AddBuff(boxIds: new []{720}, skillId: 70002062, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1999})) {
                    return new StateEnd(context);
                }

                return new StateEnd(context);
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

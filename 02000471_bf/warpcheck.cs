namespace Maple2.Trigger._02000471_bf {
    public static class _warpcheck {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040318, key: "InteractClear", value: 0);
                context.SetUserValue(triggerId: 2040323, key: "Warp", value: 0);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnPointId: 1999) <= 0.70f) {
                    return new StateWarp_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_1st : TriggerState {
            internal StateWarp_1st(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 1);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02000471_BF__WARPCHECK__0$", arg3: 5000, arg4: "0");
                context.AddBuff(arg1: new[] {720}, arg2: 70002061, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWarp_go(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002106}, arg2: 0)) {
                    return new StateWarp_cancel(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002107}, arg2: 0)) {
                    return new StateWarp_cancel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_cancel : TriggerState {
            internal StateWarp_cancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 0);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02000471_BF__WARPCHECK__1$", arg3: 5000, arg4: "0");
                context.AddBuff(arg1: new[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnPointId: 1999) <= 0.30f) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_go : TriggerState {
            internal StateWarp_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 0);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 2040323, key: "Warp", value: 1);
                context.AddBuff(arg1: new[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnPointId: 1999) <= 0.30f) {
                    return new StateWarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp_2nd : TriggerState {
            internal StateWarp_2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 1);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: true, arg3: 0, arg4: 0, arg5: 10f);
                context.SetEventUI(arg1: 1, script: "$02000471_BF__WARPCHECK__0$", arg3: 5000, arg4: "0");
                context.AddBuff(arg1: new[] {720}, arg2: 70002061, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWarp_go2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002106}, arg2: 0)) {
                    return new StateWarp2_cancel(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002107}, arg2: 0)) {
                    return new StateWarp2_cancel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWarp2_cancel : TriggerState {
            internal StateWarp2_cancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 0);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02000471_BF__WARPCHECK__1$", arg3: 5000, arg4: "0");
                context.AddBuff(arg1: new[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new StateEnd(context);
                }

                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateWarp_go2 : TriggerState {
            internal StateWarp_go2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 0);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 2040323, key: "Warp", value: 2);
                context.AddBuff(arg1: new[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new StateEnd(context);
                }

                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
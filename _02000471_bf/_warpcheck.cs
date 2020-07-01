namespace Maple2.Trigger._02000471_bf {
    public static class _warpcheck {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040318, key: "InteractClear", value: 0);
                context.SetUserValue(triggerId: 2040323, key: "Warp", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Boss") == 1) {
                    return new Statewarp_condition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewarp_condition : TriggerState {
            internal Statewarp_condition(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new Stateend(context);
                }

                if (context.GetNpcHpRate(spawnPointId: 1999) <= 0.70f) {
                    return new Statewarp_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewarp_1st : TriggerState {
            internal Statewarp_1st(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 1);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARPCHECK__0$", arg3: 5000, arg4: "0");
                context.AddBuff(arg1: new[] {720}, arg2: 70002061, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new Stateend(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new Statewarp_go(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002106}, arg2: 0)) {
                    return new Statewarp_cancel(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002107}, arg2: 0)) {
                    return new Statewarp_cancel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewarp_cancel : TriggerState {
            internal Statewarp_cancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 0);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARPCHECK__1$", arg3: 5000, arg4: "0");
                context.AddBuff(arg1: new[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new Stateend(context);
                }

                if (context.GetNpcHpRate(spawnPointId: 1999) <= 0.30f) {
                    return new Statewarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewarp_go : TriggerState {
            internal Statewarp_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 0);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 2040323, key: "Warp", value: 1);
                context.AddBuff(arg1: new[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new Stateend(context);
                }

                if (context.GetNpcHpRate(spawnPointId: 1999) <= 0.30f) {
                    return new Statewarp_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewarp_2nd : TriggerState {
            internal Statewarp_2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 1);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: true, arg3: 0, arg4: 0, arg5: 10f);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARPCHECK__0$", arg3: 5000, arg4: "0");
                context.AddBuff(arg1: new[] {720}, arg2: 70002061, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new Stateend(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new Statewarp_go2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002106}, arg2: 0)) {
                    return new Statewarp2_cancel(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002107}, arg2: 0)) {
                    return new Statewarp2_cancel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewarp2_cancel : TriggerState {
            internal Statewarp2_cancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 0);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARPCHECK__1$", arg3: 5000, arg4: "0");
                context.AddBuff(arg1: new[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new Stateend(context);
                }

                return new Stateend(context);
            }

            public override void OnExit() { }
        }

        private class Statewarp_go2 : TriggerState {
            internal Statewarp_go2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002106, 10002107}, arg2: 0);
                context.SetMesh(arg1: new[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 2040323, key: "Warp", value: 2);
                context.AddBuff(arg1: new[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1999})) {
                    return new Stateend(context);
                }

                return new Stateend(context);
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
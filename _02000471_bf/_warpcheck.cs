using System;

namespace Maple2.Trigger._02000471_bf {
    public static class _warpcheck {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2040318, key: "InteractClear", value: 0);
                context.SetUserValue(triggerID: 2040323, key: "Warp", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Boss", value: 1)) {
                    context.State = new Statewarp_condition(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_condition : TriggerState {
            internal Statewarp_condition(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1999})) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.CheckNpcHp(compare: "lowerEqual", value: 70, spawnPointId: 1999, isRelative: "true")) {
                    context.State = new Statewarp_1st(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_1st : TriggerState {
            internal Statewarp_1st(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002106}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10002107}, arg2: 1);
                context.SetMesh(arg1: new int[] {1207, 1208}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARPCHECK__0$", arg3: new int[] {5000}, arg4: "0");
                context.AddBuff(arg1: new int[] {720}, arg2: 70002061, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1999})) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new Statewarp_go(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002106}, arg2: 0)) {
                    context.State = new Statewarp_cancel(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002107}, arg2: 0)) {
                    context.State = new Statewarp_cancel(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_cancel : TriggerState {
            internal Statewarp_cancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002106}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002107}, arg2: 0);
                context.SetMesh(arg1: new int[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARPCHECK__1$", arg3: new int[] {5000}, arg4: "0");
                context.AddBuff(arg1: new int[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1999})) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.CheckNpcHp(compare: "lowerEqual", value: 30, spawnPointId: 1999, isRelative: "true")) {
                    context.State = new Statewarp_2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_go : TriggerState {
            internal Statewarp_go(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002106}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002107}, arg2: 0);
                context.SetMesh(arg1: new int[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 2040323, key: "Warp", value: 1);
                context.AddBuff(arg1: new int[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1999})) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.CheckNpcHp(compare: "lowerEqual", value: 30, spawnPointId: 1999, isRelative: "true")) {
                    context.State = new Statewarp_2nd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_2nd : TriggerState {
            internal Statewarp_2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002106}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10002107}, arg2: 1);
                context.SetMesh(arg1: new int[] {1207, 1208}, arg2: true, arg3: 0, arg4: 0, arg5: 10f);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARPCHECK__0$", arg3: new int[] {5000}, arg4: "0");
                context.AddBuff(arg1: new int[] {720}, arg2: 70002061, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1999})) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new Statewarp_go2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002106}, arg2: 0)) {
                    context.State = new Statewarp2_cancel(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10002107}, arg2: 0)) {
                    context.State = new Statewarp2_cancel(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp2_cancel : TriggerState {
            internal Statewarp2_cancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002106}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002107}, arg2: 0);
                context.SetMesh(arg1: new int[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__WARPCHECK__1$", arg3: new int[] {5000}, arg4: "0");
                context.AddBuff(arg1: new int[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1999})) {
                    context.State = new Stateend(context);
                    return;
                }

                if (true) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewarp_go2 : TriggerState {
            internal Statewarp_go2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10002106}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10002107}, arg2: 0);
                context.SetMesh(arg1: new int[] {1207, 1208}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 2040323, key: "Warp", value: 2);
                context.AddBuff(arg1: new int[] {720}, arg2: 70002062, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1999})) {
                    context.State = new Stateend(context);
                    return;
                }

                if (true) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}